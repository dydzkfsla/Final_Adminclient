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
    public partial class WareHouseInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { New, Old }  // New : 등록모드(등록버튼만 활성화), Old : 수정모드(수정, 삭제버튼만 활성화)
        Mode mode;

        List<ComboWhVO> typeList;
        WareHouseVO vo = null;
        string userID = Global.Global.employees.Emp_Code;

        public Mode ThisMode { set { mode = value; } }

        public WareHouseVO VO { get { return vo; } set { vo = value; } }
        public List<ComboWhVO> CombList { set { typeList = value; } }

        public WareHouseInfoPopUp()
        {
            InitializeComponent();
        }

        private void WareHousePopUp_Load(object sender, EventArgs e)
        {
            txt_Code.KeyPress += NoneKeyPress;

            cbo_State.Items.Add("Y");
            cbo_State.Items.Add("N");
            cbo_State.SelectedIndex = 0;

            cbo_Type.DataSource = typeList;
            cbo_Type.ValueMember = "Common_Code";
            cbo_Type.DisplayMember = "Common_Name";

            if (mode == Mode.New)
            {
                lbl_Title.Text = "신규창고 등록";
                btn_Update.Enabled = btn_Delete.Enabled = false;
            }
            else
            {
                lbl_Title.Text = "기존창고 정보 수정";
                btn_Add.Enabled = false;
            }
            
            txt_Code.Text = "자동추가";

            #region old모드일경우
            if (vo != null)
            {
                txt_Code.Text = vo.WH_Code;

                int index = 0;

                foreach (var idx in cbo_State.Items)
                {
                    if (idx.ToString() == vo.WH_State)
                        break;

                    index += 1;
                }

                cbo_State.SelectedIndex = index;

                for (int i = 0; i < cbo_Type.Items.Count - 1; i++)
                {
                    cbo_Type.SelectedIndex = i;
                    if (cbo_Type.SelectedValue.ToString() == vo.WH_Type)
                        break;
                }

            }
            #endregion
        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim().Length < 1)
            {
                MessageBox.Show("창고 이름을 입력해주세요");
                return;
            }

            if (cbo_Type.SelectedIndex < 1)
            {
                MessageBox.Show("창고 타입을 선택해주세요");
                return;
            }

            vo = new WareHouseVO 
            {
                WH_Code = txt_Code.Text, 
                WH_Type = cbo_Type.SelectedValue.ToString(), 
                WH_Name = txt_Name.Text, 
                Common_Name = cbo_Type.Text, 
                WH_State = cbo_State.SelectedItem.ToString()
            };

            WareHouseService service = new WareHouseService();
            bool result = service.UpdateWareHouse(vo);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("수정중 오류가 발생했습니다.");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text.Trim().Length < 1)
            {
                MessageBox.Show("창고 이름을 입력해주세요");
                return;
            }

            if (cbo_Type.SelectedIndex < 1)
            {
                MessageBox.Show("창고 타입을 선택해주세요");
                return;
            }

            vo = new WareHouseVO
            {
                WH_Type = cbo_Type.SelectedValue.ToString(),
                WH_Name = txt_Name.Text,
                WH_State = cbo_State.SelectedItem.ToString(),
                Common_Name = cbo_Type.Text
            };

            WareHouseService service = new WareHouseService();
            string code = service.AddWareHouse(vo);

            if(code.Length > 0)
            {
                vo.WH_Code = code;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("추가중 오류가 발생했습니다.");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            WareHouseService service = new WareHouseService();
            bool result = service.DeleteWareHouse(txt_Code.Text);
            

            if(result)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
            else
                MessageBox.Show("비활성화 작업중 오류가 발생했습니다.");

        }
    }
}
