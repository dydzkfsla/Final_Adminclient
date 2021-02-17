using AdminClient.Serch;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class BOMPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { New, Old }
        public enum FRmode { Forward, Reverse}
        Mode mode;
        FRmode frmode;
        ReverseBOM rvo;
        ForwardBOM fvo;
        BOMVO vo;

        public BOMVO VO { get { return vo; } }
        public ForwardBOM FVO { get { return fvo; } set { fvo = value; } }
        public ReverseBOM RVO { get { return rvo; } set { rvo = value; } }
        public Mode ThisMode { set { mode = value; } }
        public FRmode ThisFR { set { frmode = value; } }


        ProductVO prodinfo = null;

        public BOMPopUp()
        {
            InitializeComponent();
        }

        private void btn_ProdSearch_Click(object sender, EventArgs e)
        {
            ProductSearch frm = new ProductSearch();
            frm.ThisMode = ProductSearch.Mode.One;
            if(frm.ShowDialog() == DialogResult.OK)
                prodinfo = frm.AddList[0];

            if(prodinfo != null)
            {
                txt_ProdName.Text = prodinfo.Prod_Name;
                txt_ProdName.Tag = prodinfo.Prod_Code;

                BOMService service = new BOMService();
                List<UpLevelList> upItemList = service.GetUpLevelItemList(prodinfo);

                if(upItemList.Count < 1)
                    upItemList.Add(new UpLevelList { Prod_Code = "*", Prod_Name = "*" });

                cbo_ProdP.DisplayMember = "Prod_Name";
                cbo_ProdP.ValueMember = "Prod_Code";
                cbo_ProdP.DataSource = upItemList;
                cbo_ProdP.Enabled = true;

                //변경필요
                if (prodinfo.Prod_Unit == "ea")
                    txt_Count.KeyPress += UtilEvent.TextBoxIsDigit;
                else
                    txt_Count.KeyPress += UtilEvent.TextBoxIsDigitAndOneDot;
            }


        }

        private void BOMPopUp_Load(object sender, EventArgs e)
        {
            
            lbl_code.Visible = false;
            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;
            cbo_AutoDecreaseState.Items.Add("Y");
            cbo_AutoDecreaseState.Items.Add("N");
            cbo_AutoDecreaseState.SelectedIndex = 0;

            if (mode == Mode.New)  // 신규BOM추가
            {
                lbl_Title.Text = "BOM등록";
                btn_UpItemSch.Enabled = false;
                btn_Update.Enabled = btn_Delete.Enabled = false;

                cbo_ProdP.Enabled = false;
                txt_ProdName.KeyPress += NoneKeyPress;
                dtp_End.Value = DateTime.Now.AddDays(1);
            }
            else
            {
                lbl_Title.Text = "BOM수정";
                btn_UpItemSch.Enabled = true;
                btn_Add.Enabled = false;

                if (frmode == FRmode.Forward)  // 정전개
                {
                    lbl_code.Text = fvo.BOM_Code.ToString();
                    txt_ProdName.Text = fvo.childName;
                    txt_ProdName.Tag = fvo.Prod_Code;
                    txt_Count.Text = fvo.BOM_Count.ToString();
                    txt_Note.Text = fvo.BOM_Note;

                    cbo_ProdP.Items.Add(fvo.parentName);
                    cbo_ProdP.Tag = fvo.BOM_P_ProdCode;
                    cbo_ProdP.SelectedIndex = 0;

                    if (fvo.BOM_State == "Y")
                        cbo_State.SelectedIndex = 0;
                    else
                        cbo_State.SelectedIndex = 1;

                    if (fvo.BOM_AutoDecrease == "Y")
                        cbo_AutoDecreaseState.SelectedIndex = 0;
                    else
                        cbo_AutoDecreaseState.SelectedIndex = 1;
                }
                else
                {
                    lbl_code.Text = rvo.BOM_Code.ToString();
                    txt_ProdName.Text = rvo.childName;
                    txt_ProdName.Tag = rvo.childCode;

                    txt_Count.Text = rvo.BOM_Count.ToString();

                    cbo_ProdP.Items.Add(rvo.parentName);
                    cbo_ProdP.Tag = rvo.parentCode;
                    cbo_ProdP.SelectedIndex = 0;

                    if (rvo.BOM_State == "Y")
                        cbo_State.SelectedIndex = 0;
                    else
                        cbo_State.SelectedIndex = 1;

                    if (rvo.BOM_AutoDecrease == "Y")
                        cbo_AutoDecreaseState.SelectedIndex = 0;
                    else
                        cbo_AutoDecreaseState.SelectedIndex = 1;

                }

            }
        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_Start.Value >= dtp_End.Value)
            {
                dtp_Start.Value = dtp_End.Value.AddDays(-1);
            }
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_End.Value <= dtp_Start.Value)
            {
                dtp_End.Value = dtp_Start.Value.AddDays(1);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_ProdName.Text.Trim().Length < 1)
            {
                MessageBox.Show("물품을 선택해주세요");
                return;
            }

            if (txt_Count.Text.Trim().Length < 1)
            {
                MessageBox.Show("소요량을 입력해주세요");
                return;
            }

            vo = new BOMVO
            {
                BOM_ProdCode = txt_ProdName.Tag.ToString(),
                BOM_Count = decimal.Parse(txt_Count.Text),
                BOM_P_ProdCode = cbo_ProdP.SelectedValue.ToString(),
                BOM_StartDate = dtp_Start.Value,
                BOM_EndDate = dtp_End.Value,
                BOM_State = cbo_State.Text,
                BOM_AutoDecrease = cbo_AutoDecreaseState.Text,
                BOM_Note = txt_Note.Text
            };

            BOMService service = new BOMService();
            vo.BOM_Code = service.AddBOM(vo);


            if(vo.BOM_Code > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("BOM입력중 오류가 발생했습니다.");


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ProdName.Text.Trim().Length < 1)
            {
                MessageBox.Show("물품을 선택해주세요");
                return;
            }

            if(txt_Count.Text.Trim().Length < 1)
            {
                MessageBox.Show("소요량을 입력해주세요");
                return;
            }

            vo = new BOMVO
            {
                BOM_Code = int.Parse(lbl_code.Text), 
                BOM_ProdCode = txt_ProdName.Tag.ToString(),
                BOM_Count = decimal.Parse(txt_Count.Text),
                BOM_StartDate = dtp_Start.Value, 
                BOM_EndDate = dtp_End.Value, 
                BOM_State = cbo_State.Text, 
                BOM_AutoDecrease = cbo_State.Text
            };

            if (txt_Note.Text.Trim().Length > 0)
                vo.BOM_Note = txt_Note.Text;

            if (cbo_ProdP.Tag != null)
                vo.BOM_P_ProdCode = cbo_ProdP.Tag.ToString();
            else
                vo.BOM_P_ProdCode = cbo_ProdP.SelectedValue.ToString();

            BOMService service = new BOMService();
            bool result = service.UpdateBOM(vo);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("BOM수정 작업중 오류가 발생했습니다.");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BOMService service = new BOMService();
            bool result = service.DeleteBOM(int.Parse(lbl_code.Text));

            if(result)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
            else
                MessageBox.Show("BOM정보를 삭제했습니다.");
        }

        private void btn_UpItemSch_Click(object sender, EventArgs e)
        {
            cbo_ProdP.Tag = null;

            BOMService service = new BOMService();
            ProductVO vo = new ProductVO
            {
                Prod_Code = txt_ProdName.Tag.ToString(),
                Prod_Category = "Prod" + txt_ProdName.Tag.ToString().Substring(0, 3)
            };

            List<UpLevelList> upItemList = service.GetUpLevelItemList(vo);

            if (upItemList.Count < 1)
                upItemList.Add(new UpLevelList { Prod_Code = "*", Prod_Name = "*" });

            cbo_ProdP.DisplayMember = "Prod_Name";
            cbo_ProdP.ValueMember = "Prod_Code";
            cbo_ProdP.DataSource = upItemList;
            cbo_ProdP.Enabled = true;

        }
    }
}
