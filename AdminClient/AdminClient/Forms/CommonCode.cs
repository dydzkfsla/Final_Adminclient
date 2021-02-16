using AdminClient.PopUp;
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
            splitContainer1.SplitterDistance = 370;
            #region 초기셋팅
            gb_detail.Enabled = nu_limit.Enabled = false;
            
            txt_Code.KeyPress += NoneKeyPress;
            txt_Name.KeyPress += NoneKeyPress;
            txt_Cate.KeyPress += NoneKeyPress;
            txt_Pcode.KeyPress += NoneKeyPress;

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

        private void NoneKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chk_limit_CheckedChanged(object sender, EventArgs e)
        {
            nu_limit.Enabled = chk_limit.Checked;

            if (!chk_limit.Checked)
            {
                nu_limit.Value = 0;
            }
        }

        private void dgv_CommList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if(e.RowIndex > -1)
                {
                    PopUp.CommandCode pop = new PopUp.CommandCode();
                    pop.ThisMode = PopUp.CommandCode.Mode.Old;
                    CommonVO vo = new CommonVO
                    {
                        Common_Code = txt_Code.Text, 
                        Common_Name = txt_Name.Text, 
                        Common_Category = txt_Cate.Text, 
                        Common_Pcode = txt_Pcode.Text
                    };

                    pop.VO = vo;

                    DialogResult dr = pop.ShowDialog();

                    if(dr == DialogResult.OK)
                    {
                        vo = pop.VO;

                        commList.ForEach((comm) =>
                        {
                            if(comm.Common_Code == vo.Common_Code)
                            {
                                comm.Common_Name = vo.Common_Name;
                                comm.Common_Category = vo.Common_Category;
                                comm.Common_Pcode = vo.Common_Pcode;
                            }
                        });

                        dgv_CommList.DataSource = null;
                        dgv_CommList.DataSource = commList;

                        MessageBox.Show("수정이 완료되었습니다");
                    }
                    else if(dr == DialogResult.None)
                    {
                        vo = pop.VO;

                        commList.ForEach((comm) =>
                        {
                            if (comm.Common_Code == vo.Common_Code)
                                vo = comm;
                        });

                        commList.Remove(vo);

                        CommonUtil.ControlAction<Panel, TextBox>(panel1, (txt) => { txt.Text = ""; });

                        dgv_CommList.DataSource = null;
                        dgv_CommList.DataSource = commList;

                        MessageBox.Show("삭제가 완료되었습니다.");

                    }

                }
            }
        }

        private void dgv_CommList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txt_Code.Text = dgv_CommList["Common_Code", e.RowIndex].Value.ToString();
                txt_Cate.Text = dgv_CommList["Common_Category", e.RowIndex].Value.ToString();
                txt_Name.Text = dgv_CommList["Common_Name", e.RowIndex].Value.ToString();

                if(dgv_CommList["Common_Pcode", e.RowIndex].Value != null)
                    txt_Pcode.Text = dgv_CommList["Common_Pcode", e.RowIndex].Value.ToString();
            }
        }

        private void btm_searchClick(object sender, EventArgs e)
        {
            string limit = null, category = null;


            if (chk_limit.Checked)
                limit = nu_limit.Value.ToString();

            if (cbo_catagory.SelectedIndex > 0)
                category = cbo_catagory.SelectedValue.ToString();

            CommonService service = new CommonService();
            commList = service.GetCommonList(limit, category);

            dgv_CommList.DataSource = commList;

            if(commList.Count > 0)
            {
                gb_detail.Enabled = true;
                schCtrl.Getdata(dgv_CommList);
                sortCtrl.Getdata(dgv_CommList);
            }
        }


        #region 상단 파란패널

        private void btn_add_Click(object sender, EventArgs e) // 추가버튼
        {
            PopUp.CommandCode pop = new PopUp.CommandCode();
            pop.ThisMode = PopUp.CommandCode.Mode.New;
            pop.StartPosition = FormStartPosition.CenterParent;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                CommonVO vo = pop.VO;

                if (commList == null)
                {
                    commList = new List<CommonVO>();
                    commList.Add(vo);
                }
                else
                    commList.Add(vo);

                MessageBox.Show("공통코드를 추가하였습니다.");

            }
        }


        #endregion

        
    }
}
