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
    public partial class CommandCode : AdminClient.BaseForm.EmpFormTemp
    {
        CommonVO vo;

        public enum Mode { New, Old } 
        Mode mode;

        public Mode ThisMode { set { mode = value; } }
        public CommonVO VO { get { return vo; } set { vo = value; } }

        public CommandCode()
        {
            InitializeComponent();
        }
        private void CommonPopUp_Load(object sender, EventArgs e)
        {
            
            if (mode == Mode.New)
            {
                btn_Update.Enabled = btn_Delete.Enabled = false;
                lbl_Title.Text = "공통코드등록";
            }
            else
            {
                lbl_Title.Text = "공통코드수정";
                txt_Code.KeyPress += NoneKeyPress;
                txt_Code.Text = vo.Common_Code;
                txt_Name.Text = vo.Common_Name;
                txt_Category.Text = vo.Common_Category;
                if (vo.Common_Pcode != null)
                    txt_Pcode.Text = vo.Common_Pcode;

                btn_add.Enabled = false;

            }
        }

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CommonUtil.ControlAction<Panel, TextBox>(pnl_common, (txt) =>
            {
                if (txt.Text.Trim().Length < 0)
                {
                    MessageBox.Show("주황색은 필수 입력 사항입니다.");
                    return;
                }
            });


            vo = new CommonVO
            {
                Common_Code = txt_Code.Text,
                Common_Name = txt_Name.Text,
                Common_Category = txt_Category.Text,
                Common_Pcode = txt_Pcode.Text
            };

            CommonService service = new CommonService();
            bool result = service.CommonAdd(vo);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("공통코드 주가중 오류가 발생했습니다.");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CommonUtil.ControlAction<Panel, TextBox>(pnl_common, (txt) =>
            {
                if (txt.Text.Trim().Length < 0)
                {
                    MessageBox.Show("주황색은 필수 입력 사항입니다.");
                    return;
                }
            });

            vo.Common_Code = txt_Code.Text;
            vo.Common_Name = txt_Name.Text;
            vo.Common_Category = txt_Category.Text;
            vo.Common_Pcode = txt_Pcode.Text;

            CommonService service = new CommonService();
            bool result = service.UpdateCommon(vo);

            if(result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
            else
                MessageBox.Show("공통코드 수정중 오류가 발생했습니다.");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말 삭제하시겠습니까?", "확인메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CommonService service = new CommonService();
                bool result = service.CommonDelete(txt_Code.Text);

                if(result)
                {
                    this.DialogResult = DialogResult.None;
                    this.Close();
                }
                else
                    MessageBox.Show("공통코드 삭제중 오류가 발생했습니다.");

            }

        }
    }
}
