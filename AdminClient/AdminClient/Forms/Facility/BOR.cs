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
        List<BORVO> borlist = null;
        List<CombBORVO> cboList;

        public BOR()
        {
            InitializeComponent();
        }

        private void BOR_Load(object sender, EventArgs e)
        {
            BORService service = new BORService();
            cboList = service.GetCboBindingList();

            //var faclist = (from fac in comblist
            //               where string.IsNullOrEmpty(fac.Pcs_Code)
            //               select fac).ToList();

            //cbo_Fac.DisplayMember = "FacGrp_Name";
            //cbo_Fac.ValueMember = "FacGrp_Code";
            //cbo_Fac.DataSource = faclist;

            //var pcslist = (from pcs in comblist
            //               where string.IsNullOrEmpty(pcs.FacGrp_Code)
            //               select pcs).ToList();

            //cbo_Pcs.DisplayMember = "Pcs_Name"; 
            //cbo_Pcs.ValueMember = "Pcs_Code";
            //cbo_Pcs.DataSource = pcslist;


            if (cboList.Count > 0)
            {
                var faclist = (from fac in cboList
                               where string.IsNullOrEmpty(fac.Pcs_Code)
                               select fac).ToList();

                faclist.Insert(0, new CombBORVO { Fac_Code = "0", Fac_Name = "전체" });

                cbo_Fac.DisplayMember = "Fac_Name";
                cbo_Fac.ValueMember = "Fac_Code";
                cbo_Fac.DataSource = faclist;

                var pcslist = (from pcs in cboList
                               where string.IsNullOrEmpty(pcs.Fac_Code)
                               select pcs).ToList();

                pcslist.Insert(0, new CombBORVO { Pcs_Code = "0", Pcs_Name = "전체" });

                cbo_Pcs.DisplayMember = "Pcs_Name";
                cbo_Pcs.ValueMember = "Pcs_Code";
                cbo_Pcs.DataSource = pcslist;

            }


            cbo_state.Items.Add("Y");
            cbo_state.Items.Add("N");
            cbo_state.SelectedIndex = 0;

            dgv_BOR.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_BOR, "BOR코드", "BOR_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "품목코드", "Prod_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "품목명", "Prod_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "공정코드", "Pcs_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "공정명", "Pcs_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "설비코드", "Fac_Code");
            CommonUtil.AddGridTextColumn(dgv_BOR, "설비명", "Fac_Name");
            CommonUtil.AddGridTextColumn(dgv_BOR, "소요시간", "Tact_Time");
            CommonUtil.AddGridTextColumn(dgv_BOR, "BOR순서", "BOR_Priority");
            CommonUtil.AddGridTextColumn(dgv_BOR, "선행일", "BOR_DelayTime");
            CommonUtil.AddGridTextColumn(dgv_BOR, "사용유무", "BOR_State");

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BORPopUp pop = new BORPopUp();
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
            //if(txt_Prod.Text.Trim().Length < 1)
            //{
            //    MessageBox.Show("물품 코드를 입력해주세요");
            //    return;
            //}

            string fac, pcs, prod;
            fac = pcs = prod = string.Empty;

            if (txt_Prod.Text.Trim().Length > 0)
                prod = txt_Prod.Text.Trim();

            if (cbo_Fac.SelectedIndex > 0)
                fac = cbo_Fac.SelectedValue.ToString();

            if (cbo_Pcs.SelectedIndex > 0)
                pcs = cbo_Pcs.SelectedValue.ToString();

            BORVO vo = new BORVO
            {
                Pcs_Code = pcs,
                Fac_Code = fac,
                Prod_Code = prod,
                BOR_State = cbo_state.Text
            };

            BORService service = new BORService();

            borlist = service.GetBORList(vo);

            dgv_BOR.DataSource = borlist;
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
                    pop.ThisMode = BORPopUp.Mode.Old;

                    DialogResult dr = pop.ShowDialog();

                    if(dr == DialogResult.OK)
                    {
                        vo = pop.VO;

                        borlist.ForEach((bor) =>
                        {
                            if (bor.BOR_Code == vo.BOR_Code)
                                bor = vo;
                        });

                        dgv_BOR.DataSource = null;
                        dgv_BOR.DataSource = borlist;

                        MessageBox.Show("BOR정보를 추가하였습니다.");

                    }else if(dr == DialogResult.None)
                    {
                        borlist.ForEach((bor) =>
                        {
                            if (bor.BOR_Code == vo.BOR_Code)
                                bor.BOR_State = "N";
                        });

                        dgv_BOR.DataSource = null;
                        dgv_BOR.DataSource = borlist;

                        MessageBox.Show("BOR정보를 비활성화 하였습니다.");

                    }

                }
            }
        }
    }
}
