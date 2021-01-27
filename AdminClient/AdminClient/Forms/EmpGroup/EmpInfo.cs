using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class EmpInfo : AdminClient.BaseForm.FormSerchListTemp
    {
        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {
            DgvColumSet();
        }


        #region dgv 셋
        private void DgvColumSet()
        {
            dgv_Emp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 코드", "Emp_Code");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 이름", "Emp_Name");
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 입사일", "Emp_HireDate",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 퇴사일", "Emp_RetireDate",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 연락처", "Emp_Phone",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 이메일", "Emp_Email",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 우편번호", "Emp_PostCode",150);
            CommonUtil.AddGridTextColumn(dgv_Emp, "직원 주소상세", "Emp_AddrDetail",150);
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

    }
}
