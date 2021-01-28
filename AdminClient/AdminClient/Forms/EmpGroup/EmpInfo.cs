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
    public partial class EmpInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        List<TeamInfoVO> Team = null;

        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {
            DgvColumSet();
            DataLoad();
            DataSet();
            dtp_RetireDateTo.Value =  dtp_HireDateTo.Value = DateTime.Now;
            dtp_HireDateFrom.Value = dtp_RetireDateFrom.Value = DateTime.Now.AddDays(-180);      
        }


        #region dgv 셋
        private void DgvColumSet()
        {
            dgv_Emp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 코드", "Emp_Code");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 이름", "Emp_Name");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 입사일", "Emp_HireDate",150 , Format: "yyyy-MM-dd");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 퇴사일", "Emp_RetireDate",150, Format: "yyyy-MM-dd");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 연락처", "Emp_Phone",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 이메일", "Emp_Email",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 우편번호", "Emp_PostCode",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 주소상세", "Emp_AddrDetail",150);
        }
        #endregion

        #region DataLoad
        public void DataLoad()
        {
            TeamInfoService service = new TeamInfoService();
            Team = service.AllTeamInfoVO();
        }
        #endregion

        #region DataSet
        public void DataSet()
        {
            cbo_Temp.DisplayMember = "Team_Name";
            cbo_Temp.ValueMember = "Team_Code";
            var temp = Team.ToList();
            temp.Insert(0,new TeamInfoVO { Team_Name = "선택", Team_Code = "" });
            cbo_Temp.DataSource = temp;
        }
        #endregion

        #region chk 이벤트

        private void chk_HireDate_CheckedChanged(object sender, EventArgs e)
        {
            gb_HireDate.Enabled = ((CheckBox)sender).Checked;
        }

        private void chk_RetireDate_CheckedChanged(object sender, EventArgs e)
        {
            gb_RetireDate.Enabled = ((CheckBox)sender).Checked;
        }

        #endregion



        private void btn_search_Click(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            string Team_Code = null, HireDateFrom = null, HireDateTo = null
               , RetireDateFrom = null, RetireDateTo = null;
            int LimitCount = 0;
            if (chk_limit.Checked)
                LimitCount = Convert.ToInt32(nu_limit.Value);
            if(chk_HireDate.Checked)
            {
                HireDateFrom = dtp_HireDateFrom.Value.ToString("yyyy-MM-dd");
                HireDateTo = dtp_RetireDateTo.Value.ToString("yyyy-MM-dd");
            }
            if (chk_RetireDate.Checked)
            {
                RetireDateFrom = dtp_RetireDateFrom.Value.ToString("yyyy-MM-dd");
                RetireDateTo = dtp_RetireDateTo.Value.ToString("yyyy-MM-dd");
            }
            if(cbo_Temp.SelectedIndex > 0)
            {
                Team_Code = cbo_Temp.SelectedValue.ToString();
            }

            var List = service.SerchSelectEmployees(LimitCount, Team_Code, HireDateFrom,HireDateTo, RetireDateFrom, RetireDateTo);
            dgv_Emp.DataSource = List;
        }
    }
}
