using AdminClient.Serch;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class BORPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { New, Old }  // New : 등록모드(등록버튼만 활성화), Old : 수정모드(수정, 삭제버튼만 활성화)
        Mode mode;

        List<ComboBORVO> comblist;
        BORVO vo;

        public Mode ThisMode { get; set; }
        public List<ComboBORVO> Comblist { set { comblist = value; } }
        public BORVO VO{ get { return vo; } set { vo = value; } }

        public BORPopUp()
        {
            InitializeComponent();
        }

        private void BORPopUp_Load(object sender, EventArgs e)
        {
            lbl_Code.Visible = false;
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;

            txt_Prod.KeyPress += NoneKeyPress;
            txt_Delay.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_Priority.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_Tact.KeyPress += UtilEvent.TextBoxIsDigit;

            if (comblist.Count > 0)
            {
                var faclist = (from fac in comblist
                               where string.IsNullOrEmpty(fac.Pcs_Code)
                               select fac).ToList();

                cbo_Fac.DisplayMember = "FacGrp_Name";
                cbo_Fac.ValueMember = "FacGrp_Code";
                cbo_Fac.DataSource = faclist;

                var pcslist = (from pcs in comblist
                               where string.IsNullOrEmpty(pcs.FacGrp_Code)
                               select pcs).ToList();

                cbo_Pcs.DisplayMember = "Pcs_Name";
                cbo_Pcs.ValueMember = "Pcs_Code";
                cbo_Pcs.DataSource = pcslist;
            }

            if(mode == Mode.Old)
            {
                btn_Add.Enabled = btn_prodSearch.Enabled = false;

                lbl_Code.Text = vo.BOR_Code.ToString();

                txt_Prod.Text = vo.Prod_Name;
                txt_Prod.Tag = vo.Prod_Code;

                for(int i = 0; i< cbo_Fac.Items.Count; i++)
                {
                    cbo_Fac.SelectedIndex = i;
                    if (cbo_Fac.SelectedValue.ToString() == vo.Fac_Code)
                        break;
                }

                for(int i = 0; i<cbo_Pcs.Items.Count; i++)
                {
                    cbo_Pcs.SelectedIndex = i;
                    if (cbo_Pcs.SelectedValue.ToString() == vo.Pcs_Code)
                        break;
                }

                if (vo.BOR_State == "Y")
                    cbo_State.SelectedIndex = 0;
                else
                    cbo_State.SelectedIndex = 1;

                txt_Delay.Text = vo.BOR_DelayTime.ToString();
                txt_Priority.Text = vo.BOR_Priority.ToString();
                txt_Tact.Text = vo.Tact_Time.ToString();
                txt_Note.Text = vo.BOR_Note;

            }
            else
            {
                btn_Update.Enabled = btn_Delete.Enabled = false;
            }

        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_prodSearch_Click(object sender, EventArgs e)
        {
            ProductSearch sch = new ProductSearch();
            sch.StartPosition = FormStartPosition.CenterParent;

            ProductVO vo = null;

            if(sch.ShowDialog() == DialogResult.OK)
            {
                vo = sch.AddList[0];
            }

            if(vo != null)
            {
                txt_Prod.Text = vo.Prod_Name;
                txt_Prod.Tag = vo.Prod_Code;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CommonUtil.ControlAction<Panel, TextBox>(pnl_BORInfo, (txt) =>
            {
                if(txt.Text.Trim().Length < 1)
                {
                    MessageBox.Show("주황색 표시는 필수 입력 사항입니다.");
                    return;
                }
            });

            vo = new BORVO
            {
                Prod_Code = txt_Prod.Text,
                Fac_Code = cbo_Fac.SelectedValue.ToString(),
                Pcs_Code = cbo_Pcs.SelectedValue.ToString(),
                Tact_Time = int.Parse(txt_Tact.Text),
                BOR_Priority = int.Parse(txt_Priority.Text),
                BOR_DelayTime = int.Parse(txt_Delay.Text),
                BOR_State = cbo_State.Text,
                BOR_Note = txt_Note.Text
            };

            BORService service = new BORService();
            int code = service.AddBOR(vo);

            if(code > 0)
            {
                vo.BOR_Code = code;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
            else
                MessageBox.Show("BOR정보 추가중 오류가 발생했습니다.");


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CommonUtil.ControlAction<Panel, TextBox>(pnl_BORInfo, (txt) =>
            {
                if (txt.Text.Trim().Length < 1)
                {
                    MessageBox.Show("주황색 표시는 필수 입력 사항입니다.");
                    return;
                }
            });

            vo = new BORVO
            {
                BOR_Code = int.Parse(lbl_Code.Text), 
                Prod_Code = txt_Prod.Text,
                Fac_Code = cbo_Fac.SelectedValue.ToString(),
                Pcs_Code = cbo_Pcs.SelectedValue.ToString(),
                Tact_Time = int.Parse(txt_Tact.Text),
                BOR_Priority = int.Parse(txt_Priority.Text),
                BOR_DelayTime = int.Parse(txt_Delay.Text),
                BOR_State = cbo_State.Text,
                BOR_Note = txt_Note.Text
            };

            BORService service = new BORService();
            bool result = service.UpdateBOR(vo);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("BOR수정중 오류가 발생했습니다.");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BORService service = new BORService();
            bool result = service.DeleteBOR(int.Parse(lbl_Code.Text));

            if(result)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
            else
                MessageBox.Show("BOR비활성화중 오류가 발생했습니다.");
        }
    }
}
