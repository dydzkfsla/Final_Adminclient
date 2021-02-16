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
    public partial class EmpInfoPopUp : AdminClient.BaseForm.EmpFormTemp
    {

        public List<EmployeesTeamVO> Employees = null;
        List<TeamInfoVO> Team = null;
        //List<EmpTeamConnVO>   EmpTeamConn = null;

        public EmpInfoPopUp()
        {
            InitializeComponent();
        }

        public EmpInfoPopUp(List<TeamInfoVO> team) : this()
        {
            Team = team;
            btn_AllUpdate.Enabled = false;
            btn_AllDelete.Enabled = false;
        }

        public EmpInfoPopUp(List<TeamInfoVO> team,  List<EmployeesTeamVO> employees) : this(team)
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

            btn_AllUpdate.Enabled = true;
            btn_AllDelete.Enabled = true;
        }


        private void EmpPopUp_Load(object sender, EventArgs e)
        {
            lbl_Title.Text = "팀정보관리";
            dgv_EmpGroup.SetGridColumn();
            dgv_Group.SetGridColumn();

            CommonUtil.AddGridTextColumn(dgv_Group, "팀코드", "Team_Code", 100);
            CommonUtil.AddGridTextColumn(dgv_Group, "팀이름", "Team_Name", 100);
            CommonUtil.AddGridTextColumn(dgv_EmpGroup, "팀코드", "Team_Code",100);
            CommonUtil.AddGridTextColumn(dgv_EmpGroup, "팀이름", "Team_Name", 100);

            CommonUtil.SetInitGridView(dgv_AddrSearch);
            CommonUtil.AddGridTextColumn(dgv_AddrSearch, "주소", "jibunAddr", 600);
            CommonUtil.AddGridTextColumn(dgv_AddrSearch, "주소", "zipNo", 100);
            SetAuthority();
            TextBoxEventAdd();
        }

        #region 선택한 그룹에 따른 폼과 할당된 폼 확인
        private void SetAuthority()
        {
            if (Employees == null)
                return;

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

        #region 텍스트 박스 입력 제한
        private void TextBoxEventAdd()
        {
            txt_EmpCode.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txt_EmpName.KeyPress += UtilEvent.isHangul_KeyPress;
            txt_empPassworad.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txt_Number.KeyPress += UtilEvent.TextBoxIsDigit;
            txt_Post.KeyPress += UtilEvent.TextBoxIsDigit;
        }
        #endregion

        #region 주소검색
        private void btn_SerchAddress_Click(object sender, EventArgs e)
        {
            SearchAddr();
        }
        #endregion

        #region 주소검색 API
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
        #endregion

        #region 텍스트 박스 입력 확인 
        private bool ChkTextBox()
        {
            bool ChkTextBox = true;
            CommonUtil.ControlAction<GroupBox, TextBox>(groupBox1, (x) =>
            {
                if (x.Name.Contains("Code") )
                {
                    if (x.Text.Length != 7)
                        ChkTextBox = false;
                }

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
        #endregion

        #region DGV ADD 이벤트
        private void dgv_AddrSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txt_Post.Text = dgv_AddrSearch["zipNo", e.RowIndex].Value.ToString();
            txt_Address.Text = dgv_AddrSearch["jibunAddr", e.RowIndex].Value.ToString();
        }
        #endregion

        #region 권한추가 
        private void btn_add_Click(object sender, EventArgs e)
        {
            //선택한것이 없으면
            if (dgv_Group.SelectedRows.Count == 0)
                return;

            int RowIndex = dgv_Group.SelectedRows[0].Index;
            if (RowIndex < 0)
                return;
            EmployeesTeamVO temp = UtileHelper.GetCopyObj<EmployeesTeamVO>(Employees[0]); //딥복사
            temp.Team_Code = dgv_Group["Team_Code", RowIndex].Value.ToString();  //딥복사
            Employees.Add(temp);
            SetAuthority();
        }
        #endregion

        #region 권한삭제
        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if (dgv_EmpGroup.SelectedRows.Count == 0)
                return;
            if(Employees.Count == 1) //모든권한이 빠지면
            {
                EmployeesTeamVO temp = UtileHelper.GetCopyObj<EmployeesTeamVO>(Employees[0]); //딥복사
                temp.Team_Code = null;
                Employees.Add(temp);
            }

            int RowIndex = dgv_EmpGroup.SelectedRows[0].Index;
            if (RowIndex < 0)
                return;
            string Team_Code = dgv_EmpGroup["Team_Code", RowIndex].Value.ToString();
            Employees = Employees.Where(x => x.Team_Code != Team_Code).ToList();
            SetAuthority();
        }
        #endregion

        #region  추가(Insert)
        private void btn_Alladd_Click(object sender, EventArgs e)
        {
            if (!ChkTextBox())
                return;

            List<string> team = new List<string>();

            EmployeesVO employees = new EmployeesVO
            {
                Emp_Code = txt_EmpCode.Text,
                Emp_Email = txt_EmpEmail.Text,
                Emp_Name = txt_EmpName.Text,
                Emp_PostCode = int.Parse(txt_Post.Text),
                Emp_Pwd = txt_empPassworad.Text,
                Emp_Addr = txt_Address.Text,
                Emp_AddrDetail = txt_AddressDetail.Text,
                Emp_HireDate = dtp_HireDate.Value,
                Emp_Addbutton = false,
                Emp_Updatebutton = false,
                Emp_Deletebutton = false
            };
            if (dtp_RetireDate.Enabled)
                employees.Emp_RetireDate = dtp_RetireDate.Value;
            else
                employees.Emp_RetireDate = new DateTime(9998,12,30);

            if (!string.IsNullOrWhiteSpace(txt_Number.Text))
                employees.Emp_Phone = txt_Number.Text;
            else
                employees.Emp_Phone = null;
            //팀 권한 추가 
            Employees.ForEach( x =>     
            {
                if (x.Team_Code != null) {
                    team.Add(x.Team_Code);
                }
            });



            EmployeesService service = new EmployeesService();
            if(service.SP_InsertEmployees(employees, team))  //성공하면
            {
                this.DialogResult = DialogResult.Yes;
                Employees.Clear();
                team.ForEach(x => {
                    Employees.Add(
                        new EmployeesTeamVO
                        {
                            Emp_Code = txt_EmpCode.Text,
                            Emp_Email = txt_EmpEmail.Text,
                            Emp_Name = txt_EmpName.Text,
                            Emp_PostCode = int.Parse(txt_Post.Text),
                            Emp_Pwd = txt_empPassworad.Text,
                            Emp_Addr = txt_Address.Text,
                            Emp_AddrDetail = txt_AddressDetail.Text,
                            Emp_HireDate = dtp_HireDate.Value,
                            Emp_RetireDate = dtp_RetireDate.Enabled ? dtp_RetireDate.Value : new DateTime(9998, 12, 30),
                            Emp_Phone = string.IsNullOrWhiteSpace(txt_Number.Text) ? null : txt_Number.Text,
                            Team_Code = x
                        });
                });
                
                this.Close();
            }
            else
            {
                MessageBox.Show("추가실패");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        #region  체크박스 체크 상태
        private void chk_cheal_CheckedChanged(object sender, EventArgs e)
        {
            dtp_RetireDate.Enabled = chk_cheal.Checked;
        }
        #endregion

        #region 수정
        private void btn_AllUpdate_Click(object sender, EventArgs e)
        {
            if (!ChkTextBox())
                return;

            List<string> team = new List<string>();

            EmployeesVO employees = new EmployeesVO
            {
                Emp_Code = Employees[0].Emp_Code,
                Emp_Email = txt_EmpEmail.Text,
                Emp_Name = txt_EmpName.Text,
                Emp_PostCode = int.Parse(txt_Post.Text),
                Emp_Pwd = txt_empPassworad.Text,
                Emp_Addr = txt_Address.Text,
                Emp_AddrDetail = txt_AddressDetail.Text,
                Emp_HireDate = dtp_HireDate.Value,
            };
            if (dtp_RetireDate.Enabled)
                employees.Emp_RetireDate = dtp_RetireDate.Value;
            else
                employees.Emp_RetireDate = new DateTime(9998, 12, 30);

            if (!string.IsNullOrWhiteSpace(txt_Number.Text))
                employees.Emp_Phone = txt_Number.Text;
            else
                employees.Emp_Phone = null;

            Employees.ForEach(x =>
            {
                if (x.Team_Code != null)
                {
                    team.Add(x.Team_Code);
                }
            });



            EmployeesService service = new EmployeesService();
            if (service.UpdateEmployees(employees, team))
            {
                this.DialogResult = DialogResult.OK;
                Employees.Clear();
                team.ForEach(x => {
                    Employees.Add(
                        new EmployeesTeamVO
                        {
                            Emp_Code = txt_EmpCode.Text,
                            Emp_Email = txt_EmpEmail.Text,
                            Emp_Name = txt_EmpName.Text,
                            Emp_PostCode = int.Parse(txt_Post.Text),
                            Emp_Pwd = txt_empPassworad.Text,
                            Emp_Addr = txt_Address.Text,
                            Emp_AddrDetail = txt_AddressDetail.Text,
                            Emp_HireDate = dtp_HireDate.Value,
                            Emp_RetireDate = dtp_RetireDate.Enabled ? dtp_RetireDate.Value : new DateTime(9998, 12, 30),
                            Emp_Phone = string.IsNullOrWhiteSpace(txt_Number.Text) ? null : txt_Number.Text,
                            Team_Code = x
                        });
                });

                this.Close();
            }
            else
            {
                MessageBox.Show("추가실패");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        #region 삭제
        private void btn_AllDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("삭제", "삭제하시겠습니까?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EmployeesService service = new EmployeesService();
                if (service.DeleteAllEmp(Employees[0].Emp_Code))
                {
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
        #endregion
    }
}
