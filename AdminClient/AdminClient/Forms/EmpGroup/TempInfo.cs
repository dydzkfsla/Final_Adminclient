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
        List<View_FormConnGroupVO> FormConnGroup = null;
        List<TeamForFormVO> TeamForForms = null;
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
            GetData();
            TeamGroupConnSelectAll();
            TeamInfoSelectAll();
            Groupference();
        }

        #region private 메서드
        #region dgv설정
        private void DgvSet()
        {
            dgv_Temp.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Temp, "팀코드", "Team_Code", 90);
            CommonUtil.AddGridTextColumn(dgv_Temp, "팀이름", "Team_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_Temp, "그룹번호", "Team_Chief", 130, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Temp, "그룹이름", "Team_Part", 120, visibility: false);
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

        public void GetData()
        {
            ViewService service = new ViewService();
            FormConnGroup = service.View_FormConnGroup();

            TeamForFormServer Tservice = new TeamForFormServer();
            TeamForForms = Tservice.GetAllTeamForForm();
        }

        #region 그룹 목록 가져옴
        private void Groupference()
        {
            GroupInfoService infoService = new GroupInfoService();
            Group = infoService.AllGroupInfoVO();
            if (code != string.Empty)
                SetAuthority(code);
            Group.ForEach(x =>
            {
                var menu = FormConnGroup.FindAll(y => y.Grp_No == x.Grp_No);
                treeView1.Nodes.Add(x.Grp_No.ToString(), x.Grp_Name.ToString());
                foreach (var item in menu)
                {
                    TreeNode tree = new TreeNode()
                    {
                        Name = item.Form_Name,
                        Text = item.Form_Menu
                    };
                    treeView1.Nodes[x.Grp_No.ToString()].Nodes.Add(tree);

                    tree.Nodes.Add("Form_Select", "Select");
                    tree.Nodes.Add("Form_Insert", "Insert");
                    tree.Nodes.Add("Form_Update", "Update");
                    tree.Nodes.Add("Form_Delete", "Delete");
                }
            });
            treeView1.ExpandAll();
        }
        #endregion

        private void NodeCheckedfalse(TreeNodeCollection nodes)
        {
            foreach(TreeNode node in nodes)
            {
                node.Checked = false;
                if(nodes.Count > 0)
                {
                    NodeCheckedfalse(node.Nodes);
                }
            }
        }


        #region 선택한 팀에따른 그룹과 할당된 그룹 확인
        private void SetAuthority(string code)
        {

            var List = (from item in TeamGroupConn
                        where item.Team_Code == code
                        select item).ToList(); //선택한 권한 그룹폼만 가져옴

            //복사
            var temp = Group.ToList();



            NodeCheckedfalse(treeView1.Nodes);

            List.ForEach(x =>
            {
                TreeNode node = treeView1.Nodes[x.Grp_No.ToString()];
                if (node == null)
                    return;
                node.Checked = true;

                foreach(TreeNode item in node.Nodes)
                {
                    var vo = TeamForForms.Find(y => y.Team_Code == code && y.Form_Name == item.Name);
                    if (vo != null)
                    {
                        item.Nodes["Form_Delete"].Checked = vo.Form_Delete;
                        item.Nodes["Form_Insert"].Checked = vo.Form_Insert;
                        item.Nodes["Form_Select"].Checked = vo.Form_Select;
                        item.Nodes["Form_Update"].Checked = vo.Form_Update;
                    }
                    else
                    {
                        item.Nodes["Form_Delete"].Checked = false;
                        item.Nodes["Form_Insert"].Checked = false;
                        item.Nodes["Form_Select"].Checked = false;
                        item.Nodes["Form_Update"].Checked = false;
                    }

                    if (item.Nodes["Form_Delete"].Checked == true &&
                        item.Nodes["Form_Insert"].Checked == true &&
                        item.Nodes["Form_Select"].Checked == true &&
                        item.Nodes["Form_Update"].Checked == true)
                    {
                        item.Checked = true;
                    }
                    else
                    {
                        item.Checked = false;
                    }

                }
            });

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
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (code == string.Empty)
                return;

            if (e.Node.Level == 0)
            {
                TeamAddGroup(e.Node.Name, e.Node.Checked);
            }
            if (e.Node.Level == 1)
            {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        TeamAddMenu(code, e.Node.Name, node.Name, e.Node.Checked);
                        node.Checked = e.Node.Checked;
                    }
            }
            if (e.Node.Level == 2)
            {
                TeamAddMenu(code, e.Node.Parent.Name, e.Node.Name, e.Node.Checked);
            }
            SetAuthority(code);
        }

        private void TeamAddMenu(string TeamCode, string Form_Name, string UpdateColum, bool Chcked )
        {
            TeamForFormServer Server = new TeamForFormServer();
            if(Server.UpdateTeamForForm(TeamCode, Form_Name, Chcked, UpdateColum))
            {
                var item = TeamForForms.Find(x => x.Team_Code == TeamCode && x.Form_Name == Form_Name);
                if(item == null)
                {
                    item = new TeamForFormVO
                    {

                        Team_Code = TeamCode,
                        Form_Name = Form_Name,
                        Form_Delete = false,
                        Form_Insert = false,
                        Form_Select = false,
                        Form_Update = false
                    };
                    TeamForForms.Add(item);
                }

                Type type = item.GetType();
                type.GetProperty(UpdateColum).SetValue(item, Chcked);
            }
        }

        private void TeamAddGroup(string GroupNo, bool Checked)
        {
            if (Checked)
            {
                int index = Convert.ToInt32(GroupNo);
                if (TeamGroupConn.FindAll(x => x.Grp_No == index && x.Team_Code == code).Count != 0) //이미 추가가 되어있으면
                    return;

                TeamGroupConnService service = new TeamGroupConnService();
                if (service.InsertTeamGroupConn(code, index)) //추가가 되면
                {
                    TeamGroupConn.Add(new TeamGroupConnVO //리스트에 추가
                    {
                        Team_Code = code,
                        Grp_No = index
                    });
                    SetAuthority(code); //재 조회
                }
            }
            else
            {
                int index = Convert.ToInt32(GroupNo);
                if (TeamGroupConn.FindAll(x => x.Grp_No == index && x.Team_Code == code).Count == 0) //이미 항목이 없으면
                    return;
                TeamGroupConnService service = new TeamGroupConnService();
                if (service.DeleteTeamGroupConn(code, index)) //삭제가되면
                {
                    TeamGroupConnVO temp = TeamGroupConn.Find(x => x.Grp_No == index
                                                                   && x.Team_Code == code);
                    TeamGroupConn.Remove(temp); //삭제
                    SetAuthority(code);           //재 조회
                }
            }
        }
    }
}
