using AdminClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms.LogIn
{
    public partial class Login : AdminClient.BaseForm.FormTemp
    {
        public Login()
        {
            InitializeComponent();
        }

		private void Login_Load(object sender, EventArgs e)
		{
            //txt 입력제한
            txt_EmpID.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txt_EmpPwd.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;

            txt_EmpID.KeyPress += UtilEvent.tbx_Trim;
            txt_EmpPwd.KeyPress += UtilEvent.tbx_Trim;
        }

		private void btn_Login_Click(object sender, EventArgs e)
		{
            EmployeeService service = new EmployeeService();
            Global.Global.employees = service.EmpLogin(txt_EmpID.Text, txt_EmpPwd.Text);
            if (Global.Global.employees == null)
			{
                MessageBox.Show("로그인 실패");
                return;
			}
			else
			{
                MessageBox.Show($"{Global.Global.employees.Emp_Name}님이 로그인 하셨습니다.");
                FormInfoService Formservice = new FormInfoService();
                this.OpenCreateForm<MDI.MDI>(() => { return new MDI.MDI(); });
                this.Hide();
            }
		}
	}
}
