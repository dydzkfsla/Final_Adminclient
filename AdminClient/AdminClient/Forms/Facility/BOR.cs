using AdminClient.PopUp;
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

namespace AdminClient.Forms
{
    public partial class BOR : AdminClient.BaseForm.EmpFormNoSerchTemp
    {
        List<ComboBORVO> comblist;
        List<BORVO> borlist = null;

        public BOR()
        {
            InitializeComponent();
        }

        private void BOR_Load(object sender, EventArgs e)
        {
            BORService service = new BORService();
            comblist = service.GetComboBindingList();

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

            cbo_state.Items.Add("Y");
            cbo_state.Items.Add("N");
            cbo_state.SelectedIndex = 0;

            dgv_BOR.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_BOR, "BOR코드", "BOR_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "물품코드", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "물품명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "공정코드", "Pcs_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "공정명", "Pcs_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "설비코드", "Fac_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "설비명", "FacGrp_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "소요시간", "Tact_Time");
            CommonUtil.AddGridTextColumn(dgv_BOR, "BOR순서", "BOR_Priority");
            CommonUtil.AddGridTextColumn(dgv_BOR, "선행일", "BOR_DelayTime");
            CommonUtil.AddGridTextColumn(dgv_BOR, "사용유무", "BOR_State");

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BORPopUp pop = new BORPopUp();
            pop.Comblist = comblist;
            pop.StartPosition = FormStartPosition.CenterParent;

            if(pop.ShowDialog() == DialogResult.OK)
            {
                BORVO vo = pop.VO;

                if(borlist == null)
                {
                    borlist = new List<BORVO>();
                    borlist.Add(vo);
                }
                else
                    borlist.Add(vo);


                dgv_BOR.DataSource = null;
                dgv_BOR.DataSource = borlist;

                MessageBox.Show("BOR 정보를 추가하였습니다.");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BORVO vo = new BORVO
            {
                Pcs_Code = cbo_Pcs.SelectedValue.ToString(),
                Fac_Code = cbo_Fac.SelectedValue.ToString(),
                Prod_Code = txt_Prod.Text,
                BOR_State = cbo_state.Text
            };

            BORService service = new BORService();

            borlist = service.GetBORList(vo);
        }

        private void dgv_BOR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if(e.RowIndex > -1)
                {
                    BORVO vo = null;

                    int code = Convert.ToInt32(dgv_BOR["BOR_Code", e.RowIndex].Value);

                    borlist.ForEach((bor) =>
                    {
                        if (bor.BOR_Code == code)
                            vo = bor;
                    });

                    BORPopUp pop = new BORPopUp();
                    pop.VO = vo;

                    DialogResult dr = pop.ShowDialog();

                    if(dr == DialogResult.OK)
                    {
                        vo = pop.VO;

                        borlist.Add(vo);

                        dgv_BOR.DataSource = null;
                        dgv_BOR.DataSource = borlist;

                        MessageBox.Show("BOR정보를 추가하였습니다.");

                    }else if(dr == DialogResult.None)
                    {
                        borlist.ForEach((bor) =>
                        {
                            if (bor.BOR_Code == vo.BOR_Code)
                                vo = bor;
                        });

                        borlist.Remove(vo);

                        dgv_BOR.DataSource = null;
                        dgv_BOR.DataSource = borlist;

                        MessageBox.Show("BOR정보를 비활성화 하였습니다.");

                    }

                }
            }
        }
    }
}
