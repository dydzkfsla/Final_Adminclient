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
    public partial class EmpInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        List<TeamInfoVO> Team = null;
        List<EmployeesTeamVO> EmpTeam = null;

        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {
            DgvColumSet();
            DataLoad();
            DataSet();
            TextBoxEventSet();
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

        #region 텍스트 박스 이벤트
        public void TextBoxEventSet()
        {
            txt_EmpName.KeyPress += UtilEvent.Handled_KeyPress;
            txt_Email.KeyPress += UtilEvent.Handled_KeyPress;
            txt_Phone.KeyPress += UtilEvent.Handled_KeyPress;
            txt_PostCode.KeyPress += UtilEvent.Handled_KeyPress;
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

        #region  검색이벤트
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

            //입력된 값들 전달
            EmpTeam = service.SerchSelectEmployees(LimitCount, Team_Code, HireDateFrom,HireDateTo, RetireDateFrom, RetireDateTo);

            //검색된 값이 있으면
            if(EmpTeam != null && EmpTeam.Count > 0)
            {
                var temp = EmpTeam.GroupBy(x => x.Emp_Code).ToList();
                List<EmployeesTeamVO> Emp = new List<EmployeesTeamVO>();
                temp.ForEach(item => Emp.Add(item.First()));
                dgv_Emp.DataSource = Emp;

                searchControl.Getdata(dgv_Emp);
                sortControl.Getdata(dgv_Emp);
                gb_detail.Enabled = true;
            }
        }
        #endregion

        #region 셀 더블 클릭
        private void dgv_Emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txt_EmpName.Text = dgv_Emp["Emp_Name", e.RowIndex].Value.ToString();
            txt_Email.Text = dgv_Emp["Emp_Email", e.RowIndex].Value.ToString();
            txt_Phone.Text = dgv_Emp["Emp_Name", e.RowIndex].Value.ToString();
            txt_PostCode.Text = dgv_Emp["Emp_Phone", e.RowIndex].Value.ToString();
            dtp_HireDate.Value = Convert.ToDateTime(dgv_Emp["Emp_HireDate", e.RowIndex].Value);
        }
        #endregion

        private void dgv_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Emp.Columns[e.ColumnIndex].Name == "Edit")
            {
                string EmpCode = dgv_Emp["Emp_Code", e.RowIndex].Value.ToString();
                EmpPopUp empPop = new EmpPopUp(Team, EmpTeam.Where(x => x.Emp_Code == EmpCode).ToList());
                DialogResult result = empPop.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    var temp = (List<EmployeesTeamVO>)dgv_Emp.DataSource;
                    EmpTeam.AddRange(empPop.Employees);
                    temp.Add(empPop.Employees.First());
                    dgv_Emp.DataSource = null;
                    dgv_Emp.DataSource = temp;
                }
                else if(result == DialogResult.No)
                {
                    var temp = (List<EmployeesTeamVO>)dgv_Emp.DataSource;
                    EmpTeam.RemoveAll(x => x.Emp_Code == EmpCode);
                    temp.RemoveAll(x => x.Emp_Code == EmpCode);
                    dgv_Emp.DataSource = null;
                    dgv_Emp.DataSource = temp;
                }
                else if (result == DialogResult.OK)
                {
                    var temp = (List<EmployeesTeamVO>)dgv_Emp.DataSource;
                    EmpTeam.RemoveAll(x => x.Emp_Code == empPop.Employees[0].Emp_Code);
                    temp.RemoveAll(x => x.Emp_Code == empPop.Employees[0].Emp_Code);
                    EmpTeam.AddRange(empPop.Employees);
                    temp.Add(empPop.Employees.First());
                    dgv_Emp.DataSource = null;
                    dgv_Emp.DataSource = temp;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            EmpPopUp empPop = new EmpPopUp(Team);
            DialogResult result = empPop.ShowDialog();
            if (result == DialogResult.Yes)
            {
                var temp = (List<EmployeesTeamVO>)dgv_Emp.DataSource;
                EmpTeam.AddRange(empPop.Employees);
                temp.Add(empPop.Employees.First());
                dgv_Emp.DataSource = null;
                dgv_Emp.DataSource = temp;
            }
        }
    }
}
