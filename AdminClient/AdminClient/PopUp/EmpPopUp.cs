using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminClientVO;
using AdminClientDAC;
using System.Linq;
using AdminClient.Service;
using System.Configuration;
using System.Net;
using System.Xml;

namespace AdminClient.PopUp
{
    public partial class EmpPopUp : AdminClient.BaseForm.EmpFormTemp
    {

        List<EmployeesTeamVO> Employees = null;
        List<TeamInfoVO>      Team = null;
        //List<EmpTeamConnVO>   EmpTeamConn = null;

        public EmpPopUp()
        {
            InitializeComponent();
        }

        public EmpPopUp(List<TeamInfoVO> team) : this()
        {
            Team = team;
        }

        public EmpPopUp(List<TeamInfoVO> team,  List<EmployeesTeamVO> employees) : this(team)
        {
            Team = team;
            Employees = employees;

            txt_EmpCode.Text = Employees[0].Emp_Code;
            txt_EmpName.Text = Employees[0].Emp_Name;
            txt_EmpEmail.Text = Employees[0].Emp_Email;
            txt_Post.Text = Employees[0].Emp_PostCode.ToString();
            txt_Address.Text = Employees[0].Emp_Addr;
            txt_AddressDetail.Text = Employees[0].Emp_AddrDetail;
            txt_Number.Text = Employees[0].Emp_Phone;
            txt_empPassworad.Text = Employees[0].Emp_Pwd;
            dtp_RetireDate.Value = Employees[0].Emp_RetireDate;
            dtp_HireDate.Value = Employees[0].Emp_HireDate;
        }


        private void EmpPopUp_Load(object sender, EventArgs e)
        {
            dgv_EmpGroup.SetGridColumn();
            dgv_Group.SetGridColumn();

            CommonUtil.AddGridTextColumn(dgv_Group, "팀코드", "Team_Code", 100);
            CommonUtil.AddGridTextColumn(dgv_Group, "팀이름", "Team_Name", 100);
            CommonUtil.AddGridTextColumn(dgv_EmpGroup, "팀코드", "Team_Code",100);
            CommonUtil.AddGridTextColumn(dgv_EmpGroup, "팀이름", "Team_Name", 100);

            CommonUtil.SetInitGridView(dgv_AddrSearch);
            CommonUtil.AddGridTextColumn(dgv_AddrSearch, "주소", "jibunAddr", 600);
            CommonUtil.AddGridTextColumn(dgv_AddrSearch, "주소", "zipNo", 100);

            //if (Employees != null) {
            //    EmpTeamConnService service = new EmpTeamConnService();
            //    EmpTeamConn = service.GetEmpTeamConnVO(Employees[0].Emp_Code);
            //}
            SetAuthority();
            TextBoxEventAdd();
        }

        #region 선택한 그룹에 따른 폼과 할당된 폼 확인
        private void SetAuthority()
        {
            var List = (from item in Employees
                        select new EmpTeamConnVO { Team_Code = item.Team_Code, Emp_Code = item .Emp_Code}).ToList(); //선택한 권한 그룹폼만 가져옴

            // fromVO를 복사
            var temp = Team.ToList();

            //삭제해야할 From저장장소
            List<TeamInfoVO> Deleteds = new List<TeamInfoVO>();

            //권한 그룹에 있는 폼들을 가져옴
            Team.ForEach((Team) =>
            {
                List.ForEach((item) =>
                {
                    if (Team.Team_Code == item.Team_Code)
                    {
                        Deleteds.Add(Team);
                    }
                });
            });

            //권한그룹에 있는 폼을 삭제
            Deleteds.ForEach((item) =>
            {
                temp.Remove(item);
            });

            //삭제함으로써 해당 권한그룹에 할당안된 폼만 가져와 바인딩
            dgv_Group.DataSource = temp;
            //해당 그룹 권한 폼 가져옴
            dgv_EmpGroup.DataSource = Deleteds;
        }
        #endregion

        private void TextBoxEventAdd()
        {
            txt_EmpCode.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txt_EmpName.KeyPress += UtilEvent.isHangul_KeyPress;
            txt_empPassworad.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txt_Number.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_Post.KeyPress += UtilEvent.TextBoxIsDigit;
        }

        private void btn_SerchAddress_Click(object sender, EventArgs e)
        {
            SearchAddr();
        }

        private void SearchAddr()
        {
            UtilEvent.TextBoxIsNotNull(txt_Address, "주소를 입력해주세요.");

            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = ConfigurationManager.AppSettings["RoadAPIKey"].ToString();

            string apiUrl = $"{url}?confmKey={apiKey}" +
                $"&currentPage=1&countPerPage=1000&keyword={txt_Address.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);

            if (ds.Tables.Count > 1)
                dgv_AddrSearch.DataSource = ds.Tables[1];
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
        }

        private bool ChkTextBox()
        {
            bool ChkTextBox = true;
            CommonUtil.ControlAction<GroupBox, TextBox>(groupBox1, (x) =>
            {
                if (string.IsNullOrWhiteSpace(x.Text.Trim()))
                {
                    ChkTextBox = false;
                }
            });

            CommonUtil.ControlAction<Panel, TextBox>(panel1, (x) =>
            {
                if (string.IsNullOrWhiteSpace(x.Text.Trim()))
                {
                    ChkTextBox = false;
                }
            });
            return ChkTextBox;
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_AddrSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txt_Post.Text = dgv_AddrSearch["zipNo", e.RowIndex].Value.ToString();
            txt_Address.Text = dgv_AddrSearch["jibunAddr", e.RowIndex].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //선택한것이 없으면
            if (dgv_Group.SelectedRows.Count == 0)
                return;

            int RowIndex = dgv_Group.SelectedRows[0].Index;
            if (RowIndex < 0)
                return;
            EmployeesTeamVO temp = UtileHelper.GetCopyObj<EmployeesTeamVO>(Employees[0]);
            temp.Team_Code = dgv_Group["Team_Code", RowIndex].Value.ToString();
            Employees.Add(temp);
            SetAuthority();
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if (dgv_Group.SelectedRows.Count == 0)
                return;

            int RowIndex = dgv_Group.SelectedRows[0].Index;
            if (RowIndex < 0)
                return;
            string Team_Code = dgv_Group["Team_Code", RowIndex].Value.ToString();
            Employees = Employees.Where(x => x.Team_Code != Team_Code).ToList();
            SetAuthority();
        }

        private void btn_Alladd_Click(object sender, EventArgs e)
        {
            if (!ChkTextBox())
                return;
        }

        private void chk_cheal_CheckedChanged(object sender, EventArgs e)
        {
            dtp_RetireDate.Enabled = chk_cheal.Checked;
        }

        private void btn_AllUpdate_Click(object sender, EventArgs e)
        {
            if (!ChkTextBox())
                return;


        }
    }
}
