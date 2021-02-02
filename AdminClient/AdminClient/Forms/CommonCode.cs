using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class CommandCode : AdminClient.BaseForm.FormSerchListTemp
    {
        List<ComboCommonVO> cbolist;
        List<CommonVO> commList;
        public CommandCode()
        {
            InitializeComponent();
        }

        private void CommandCode_Load(object sender, EventArgs e)
        {
            #region 초기셋팅
            nu_limit.Enabled = false;

            dgv_CommList.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_CommList, "코드", "Common_Code", 150);
            CommonUtil.AddGridTextColumn(dgv_CommList, "이름", "Common_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_CommList, "카테고리", "Common_Category", 150);
            CommonUtil.AddGridTextColumn(dgv_CommList, "부모코드", "Common_Pcode", 150);

            #endregion

            CommonService service = new CommonService();
            cbolist = service.GetComboBindingList();

            cbolist.Insert(0, new ComboCommonVO { Common_Category = null, Common_Name = "전체" });

            cbo_catagory.DataSource = cbolist;
            cbo_catagory.ValueMember = "Common_Category";
            cbo_catagory.DisplayMember = "Common_Name";

        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;
        }

        private void button1_Click(object sender, EventArgs e) // btn_Search
        {
            string limit = null, category = null;


            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_catagory.SelectedIndex > 0)
                category = cbo_catagory.SelectedValue.ToString();

            CommonService service = new CommonService();
            commList = service.GetCommonList(limit, category);

            dgv_CommList.DataSource = commList;

            searchControl1.Getdata(dgv_CommList);

        }

        private void dgv_CommList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_Code.Enabled = false;

                txt_Code.Text = dgv_CommList["Common_Code", e.RowIndex].Value.ToString();
                txt_Cate.Text = dgv_CommList["Common_Category", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_CommList["Common_Name", e.RowIndex].Value.ToString();
                txt_Pcode.Text = dgv_CommList["Common_Pcode", e.RowIndex].Value.ToString();

            }
        }


        #region 상단 파란패널
        private void btn_Clear_Click(object sender, EventArgs e) // 초기화버튼
        {
            txt_Code.Enabled = true;
            txt_Code.Text = txt_Cate.Text = txt_Name.Text = txt_Pcode.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e) // 수정버튼
        {
            if(txt_Code.Enabled)
            {
                MessageBox.Show("목록중 선택해주세요");
                return;
            }

            //유효성검사
            if(txt_Cate.Text.Length < 1 || txt_Name.Text.Length < 1)
            {
                MessageBox.Show("이름과 카테고리는 필수입력입니다.");
                return;
            }

            string cate, pcode = string.Empty, name, code;

            cate = txt_Cate.Text;
            name = txt_Name.Text;

            if (txt_Pcode.Text.Length > 0)
                pcode = txt_Pcode.Text;

            code = txt_Code.Text;

            CommonService service = new CommonService();
            bool result = service.UpdateCommon(code, cate, name, pcode);

            if(result)
            {
                MessageBox.Show("수정완료했습니다.");

                foreach(CommonVO vo in commList)
                {
                    if(vo.Common_Code == code)
                    {
                        vo.Common_Name = name;
                        vo.Common_Category = cate;
                        vo.Common_Pcode = pcode;
                    }
                }

                dgv_CommList.DataSource = null;
                dgv_CommList.DataSource = commList;

            }
            else
                MessageBox.Show("수정중 오류가 발생했습니다.");
        }

        private void btn_add_Click(object sender, EventArgs e) // 추가버튼
        {
            if (txt_Code.Enabled)
            {
                if (txt_Cate.Text.Length < 1 || txt_Name.Text.Length < 1 || txt_Code.Text.Length < 1)
                {
                    MessageBox.Show("코드와 이름, 카테고리는 필수입력입니다.");
                    return;
                }

                CommonVO vo = new CommonVO
                {
                    Common_Code = txt_Code.Text,
                    Common_Category = txt_Cate.Text,
                    Common_Name = txt_Name.Text,
                    Common_Pcode = null
                };

                if (txt_Pcode.Text.Length > 0)
                    vo.Common_Pcode = txt_Pcode.Text;

                CommonService service = new CommonService();
                bool result = service.CommonAdd(vo);

                if (result)
                {
                    MessageBox.Show("추가에 성공하였습니다.");

                    commList.Add(vo);
                    dgv_CommList.DataSource = null;
                    dgv_CommList.DataSource = commList;

                }
                else
                    MessageBox.Show("추가중 오류가 발생했습니다.");
            }
            else
            {
                if (MessageBox.Show("선택한 목록이 있을 경우 등록작업을 실행할 수 없습니다. 등록모드로 변경하시겠습니까?", "확인메세지", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txt_Code.Enabled = true;
                    txt_Code.Text = "";
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) // 삭제버튼
        {
            if (!txt_Code.Enabled)
            {
                string code = txt_Code.Text;

                CommonService service = new CommonService();
                bool result = service.CommonDelete(code);

                if (result)
                {
                    MessageBox.Show("삭제에 성공했습니다.");
                    CommonVO vo = null;
                    commList.ForEach(item =>
                    {
                        if (item.Common_Code == code)
                        {
                            vo = item;
                        }
                    });

                    if(vo != null)
                        commList.Remove(vo);

                    dgv_CommList.DataSource = null;
                    dgv_CommList.DataSource = commList;

                }
                else
                    MessageBox.Show("삭제중 오류가 발생했습니다.");

            }
            else
                MessageBox.Show("삭제할 정보를 목록에서 선택해 주세요");
        }
        #endregion


    }
}
