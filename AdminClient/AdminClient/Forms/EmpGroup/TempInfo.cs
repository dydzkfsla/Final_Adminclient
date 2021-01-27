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
    public partial class TempInfo : AdminClient.BaseForm.EmpFormTemp
    {
        List<TeamGroupConnVO> TeamGroupConn = null;
        List<TeamInfoVO> Team = null;
        List<GroupInfoVO> Group = null;
        string code = string.Empty;
        bool enabled = false;
        public TempInfo()
        {
            InitializeComponent();

        }

        private void TempInfo_Load(object sender, EventArgs e)
        {
            DgvSet();
            TextBoxSet();
            TeamGroupConnSelectAll();
            TeamInfoSelectAll();
            Groupference();
        }

        #region private 메서드
        #region dgv설정
        private void DgvSet()
        {   
            dgv_addGroup.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_addGroup, "그룹번호", "Grp_No", 130);
            CommonUtil.AddGridTextColumn(dgv_addGroup, "그룹이름", "Grp_Name", 120);
            dgv_Temp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Temp, "팀코드", "Team_Code", 90);
            CommonUtil.AddGridTextColumn(dgv_Temp, "팀이름", "Team_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_Temp, "그룹번호", "Team_Chief", 130, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Temp, "그룹이름", "Team_Part", 120, visibility: false);
            dgv_Group.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹번호", "Grp_No", 130);
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹이름", "Grp_Name", 120);
        }
        #endregion

        #region 텍스트 박스 이벤트 셋
        private void TextBoxSet()
        {
            txtCode.KeyPress += UtilEvent.tbx_Trim;
            txtName.KeyPress += UtilEvent.tbx_Trim;
            txtCode.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
            txtName.KeyPress += UtilEvent.tbx_Trim;
            txtChief.KeyPress += UtilEvent.isAlphaAndDigit_KeyPress;
        }
        #endregion

        #region 권한 연결 구조 조회
        private void TeamGroupConnSelectAll()
        {
            TeamGroupConnService service = new TeamGroupConnService();
            TeamGroupConn = service.GetAllTeamGroupConnVO();
        }
        #endregion

        #region 권한 팀 조회
        private void TeamInfoSelectAll()
        {
            TeamInfoService service = new TeamInfoService();
            Team = service.AllTeamInfoVO();
            dgv_Temp.DataSource = Team;
        }
        #endregion

        #region 그룹 목록 가져옴
        private void Groupference()
        {
            GroupInfoService infoService = new GroupInfoService();
            Group = infoService.AllGroupInfoVO();
            dgv_Group.DataSource = Group;
            if (code != string.Empty)
                SetAuthority(code);
        }
        #endregion

        #region 선택한 팀에따른 그룹과 할당된 그룹 확인
        private void SetAuthority(string code)
        {

            var List = (from item in TeamGroupConn
                        where item.Team_Code == code
                        select item).ToList(); //선택한 권한 그룹폼만 가져옴

            //복사
            var temp = Group.ToList();

            //삭제해야할 그룹저장장소
            List<GroupInfoVO> Deleteds = new List<GroupInfoVO>();

            //권한 그룹에 있는 폼들을 가져옴
            Group.ForEach((from) =>
            {
                List.ForEach((item) =>
                {
                    if (from.Grp_No == item.Grp_No)
                    {
                        Deleteds.Add(from);
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
            dgv_addGroup.DataSource = Deleteds;
        }
        #endregion

        #region 정렬
        private void OderByGroupVo()
        {
            if (Team.Count < 2)
                return;
            Team = Team.OrderBy(x => x.Team_Code).ToList();
            //Group.Sort();
        }
        #endregion

        #endregion


        #region 이벤트
        #region 버튼이벤트
        #region 팀 추가 버튼 이벤트 
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) || txtCode.Text.Length != 7 || string.IsNullOrEmpty(txtName.Text))
                return;
            TeamInfoService service = new TeamInfoService();
            if (service.InserTeamInfo(txtCode.Text, txtName.Text, txtChief.Text, txtPart.Text)) //추가가되면
            {
                Team.Add(new TeamInfoVO                     //List에추가
                {
                    Team_Code = txtCode.Text,
                    Team_Name = txtName.Text,
                    Team_Chief = string.IsNullOrWhiteSpace(txtChief.Text) ? null : txtChief.Text,
                    Team_Part = string.IsNullOrWhiteSpace(txtPart.Text) ? null : txtChief.Text
                });
                OderByGroupVo();                              //정렬
                dgv_Temp.DataSource = null;
                dgv_Temp.DataSource = Team;
            }
        }
        #endregion

        #region 팀 수정 버튼 이벤트 
        private void btn_Upadte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) || txtCode.Text.Length != 7 || string.IsNullOrEmpty(txtName.Text))
                return;
            TeamInfoService service = new TeamInfoService();
            if (service.UpdateTeamInfo(txtCode.Text, txtName.Text, txtChief.Text, txtPart.Text)) //추가가되면
            {
                TeamInfoVO temp = Team.Find(x => x.Team_Code == code);


                temp.Team_Code = txtCode.Text;
                temp.Team_Name = txtName.Text;
                temp.Team_Chief = string.IsNullOrWhiteSpace(txtChief.Text) ? null : txtChief.Text;
                temp.Team_Part = string.IsNullOrWhiteSpace(txtPart.Text) ? null : txtChief.Text;
                OderByGroupVo();                              //정렬
                dgv_Temp.DataSource = null;
                dgv_Temp.DataSource = Team;
            }
        }
        #endregion

        #region 팀 삭제 버튼 이벤트 
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
                return;
            TeamInfoService service = new TeamInfoService();
            if (service.DeleteTeamInfo(txtCode.Text))   //삭제가 되면
            {
                var temp = Team.Find(x => x.Team_Code == txtCode.Text);
                Team.Remove(temp);   //삭제
                OderByGroupVo();        //정렬
                dgv_Temp.DataSource = null;
                dgv_Temp.DataSource = Team;
                TeamGroupConnService teamGroupConnService = new TeamGroupConnService();
                teamGroupConnService.DeleteFromTeamConn(txtCode.Text);
                var list = TeamGroupConn.Where(x => x.Team_Code == txtCode.Text).ToList();
                list.ForEach(x => TeamGroupConn.Remove(x));

            }
        }
        #endregion

        private void btn_GroupAdd_Click(object sender, EventArgs e)
        {
            if (dgv_Group.SelectedRows != null || dgv_Group.SelectedRows[0].Index != -1)
            {
                int index = dgv_Group.SelectedRows[0].Index;
                TeamGroupConnService service = new TeamGroupConnService();
                if (service.InsertTeamGroupConn(code, Convert.ToInt32(dgv_Group["Grp_No", index].Value))) //추가가 되면
                {
                    TeamGroupConn.Add(new TeamGroupConnVO //리스트에 추가
                    {
                        Team_Code = code,
                        Grp_No = Convert.ToInt32(dgv_Group["Grp_No", index].Value)
                    });
                    SetAuthority(code); //재 조회
                }
            }
        }

        private void btn_GroupDelete_Click(object sender, EventArgs e)
        {
            if (dgv_Group.SelectedRows != null || dgv_Group.SelectedRows[0].Index != -1)
            {
                int index = dgv_addGroup.SelectedRows[0].Index;
                TeamGroupConnService service = new TeamGroupConnService();
                if (service.DeleteTeamGroupConn(code,Convert.ToInt32(dgv_addGroup["Grp_No", index].Value))) //삭제가되면
                {
                    TeamGroupConnVO temp = TeamGroupConn.Find(x => x.Grp_No == Convert.ToInt32(dgv_addGroup["Grp_No", index].Value)
                                                                   && x.Team_Code == code);
                    TeamGroupConn.Remove(temp); //삭제
                    SetAuthority(code);           //재 조회
                }
            }
        }
        #endregion

        #endregion

        private void dgv_Temp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            code = dgv_Temp["Team_Code", e.RowIndex].Value.ToString();
            SetAuthority(code);


            txtCode.Text = code;
            txtName.Text = dgv_Temp["Team_Name", e.RowIndex].Value.ToString();
            txtChief.Text = dgv_Temp["Team_Chief", e.RowIndex].Value == null ? string.Empty : dgv_Temp["Team_Chief", e.RowIndex].Value.ToString();
            txtPart.Text = dgv_Temp["Team_Part", e.RowIndex].Value == null ? string.Empty : dgv_Temp["Team_Part", e.RowIndex].Value.ToString();
            if (!enabled)   //한번도 누른적없으면
            {
                enabled = true;
                btn_GroupAdd.Enabled = btn_Delete.Enabled = btn_Upadte.Enabled = btn_GroupDelete.Enabled = enabled; //버튼을 선택할수 있게함
            }
        }
    }
}
