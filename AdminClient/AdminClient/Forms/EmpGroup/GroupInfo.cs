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
    public partial class GroupInfo : AdminClient.BaseForm.EmpFormTemp
    {
        List<GroupFormConnVO> GroupFormConn = null;
        List<GroupInfoVO> Group = null;
        List<FormInfoVO> Form = null;
        int no = int.MaxValue;
        bool enabled = false;

        public GroupInfo()
        {
            InitializeComponent();
        }

        private void GroupInfo_Load(object sender, EventArgs e)
        {
            DgvSet();
            TextBoxSet();
            GroupFormConnSelectAll();
            GroupInfoSelectAll();
            Fromsreference();

        }

        #region private 메서드
        #region dgv설정
        private void DgvSet()
        {
            dgv_GroupMenu.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_GroupMenu, "폼이름", "Form_Name", 130);
            CommonUtil.AddGridTextColumn(dgv_GroupMenu, "메뉴이름", "Form_Menu");
            dgv_Group.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹번호", "Grp_No", 90);
            CommonUtil.AddGridTextColumn(dgv_Group, "그룹이름", "Grp_Name", 150);
            dgv_MenuInfo.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_MenuInfo, "폼이름", "Form_Name", 130);
            CommonUtil.AddGridTextColumn(dgv_MenuInfo, "메뉴이름", "Form_Menu", 120);
        }
        #endregion

        #region 텍스트 박스 이벤트 셋
        private void TextBoxSet()
        {
            txtNo.KeyPress += UtilEvent.tbx_Trim;
            txtName.KeyPress += UtilEvent.tbx_Trim;
            txtNo.KeyPress += UtilEvent.TextBoxIsDigit;
            //txtName.KeyPress += UtilEvent.isHangul_KeyPress;
        }
        #endregion

        #region 권한 연결 구조 조회
        private void GroupFormConnSelectAll()
        {
            GroupFormConnService service = new GroupFormConnService();
            GroupFormConn = service.GetAllGroupFormConnVO();
        }
        #endregion

        #region 권한 그룹 조회
        private void GroupInfoSelectAll()
        {
            GroupInfoService service = new GroupInfoService();
            Group = service.AllGroupInfoVO();
            dgv_Group.DataSource = Group;
        }
        #endregion

        #region 폼 목록 가져옴
        private void Fromsreference()
        {
            FormInfoService infoService = new FormInfoService();
            Form = infoService.GetAllList();
            dgv_MenuInfo.DataSource = Form;
            if (no != int.MaxValue)
                SetAuthority(no);
        }
        #endregion

        #region 선택한 그룹에 따른 폼과 할당된 폼 확인
        private void SetAuthority(int GroupID)
        {
            var List = (from item in GroupFormConn
                        where item.Group_No == GroupID
                        select item).ToList(); //선택한 권한 그룹폼만 가져옴

            // fromVO를 복사
            var temp = Form.ToList();

            //삭제해야할 From저장장소
            List<FormInfoVO> Deleteds = new List<FormInfoVO>();

            //권한 그룹에 있는 폼들을 가져옴
            Form.ForEach((from) =>
            {
                List.ForEach((item) =>
                {
                    if (from.Form_Name == item.Form_Name)
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
            dgv_MenuInfo.DataSource = temp;
            //해당 그룹 권한 폼 가져옴
            dgv_GroupMenu.DataSource = Deleteds;
        }
        #endregion

        #region 정렬
        private void OderByGroupVo()
        {
            if (Group.Count < 2)
                return;
            Group = Group.OrderBy(x => x.Grp_No).ToList();
            //Group.Sort();
        }
        #endregion

        #endregion

        #region 이벤트
        #region 버튼이벤트
        #region 그룹 추가 버튼 이벤트 
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfoService service = new GroupInfoService();
            if (service.InserGroupInfo(GroupNo, txtName.Text)) //추가가되면
            {
                Group.Add(new GroupInfoVO                     //List에추가
                {
                    Grp_No = GroupNo,
                    Grp_Name = txtName.Text
                });
                OderByGroupVo();                              //정렬
                dgv_Group.DataSource = null;
                dgv_Group.DataSource = Group;
            }
        }
        #endregion


        #region 그룹 삭제 버튼
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfoService service = new GroupInfoService();
            if (service.DeleteGroupInfo(GroupNo))   //삭제가 되면
            {
                var temp = Group.Find(x => x.Grp_No == GroupNo);
                Group.Remove(temp);   //삭제
                OderByGroupVo();        //정렬
                dgv_Group.DataSource = null;
                dgv_Group.DataSource = Group;
            }
        }
        #endregion

        #region 그룹 수정
        private void btn_Upadte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            int GroupNo = Convert.ToInt32(txtNo.Text);
            GroupInfoService service = new GroupInfoService();
            if (service.UpdateGroupInfo(GroupNo, txtName.Text)) //변경이 되면
            {
                GroupInfoVO temp = Group.Find(x => x.Grp_No == GroupNo);
                //Group.Remove(temp);           //일단 삭제
                temp.Grp_Name = txtName.Text;  //그룹명을 변경
                //Group.Add(temp);              //추가
                OderByGroupVo();                //정렬
                dgv_Group.DataSource = null;
                dgv_Group.DataSource = Group;
            }
        }
        #endregion

        #region 폼 재조회
        private void button3_Click(object sender, EventArgs e)
        {
            Fromsreference();
        }
        #endregion

        #region 권한 할당
        private void btn_MenuAdd_Click(object sender, EventArgs e)
        {
            if (dgv_MenuInfo.SelectedRows != null || dgv_MenuInfo.SelectedRows[0].Index != -1)
            {
                int index = dgv_MenuInfo.SelectedRows[0].Index;
                GroupFormConnService service = new GroupFormConnService();
                if (service.InsertGroupFormConn(no, dgv_MenuInfo["Form_Name", index].Value.ToString())) //추가가 되면
                {
                    GroupFormConn.Add(new GroupFormConnVO //리스트에 추가
                    {
                        Group_No = no,
                        Form_Name = dgv_MenuInfo["Form_Name", index].Value.ToString()
                    });
                    SetAuthority(no); //재 조회
                }
            }
        }
        #endregion

        #region 권한 삭제
        private void btn_MenuDelete_Click(object sender, EventArgs e)
        {
            if (dgv_GroupMenu.SelectedRows != null || dgv_GroupMenu.SelectedRows[0].Index != -1)
            {
                int index = dgv_GroupMenu.SelectedRows[0].Index;
                GroupFormConnService service = new GroupFormConnService();
                if (service.DeleteGroupFormConn(no, dgv_GroupMenu["Form_Name", index].Value.ToString())) //삭제가되면
                {
                    GroupFormConnVO temp = GroupFormConn.Find(x => x.Form_Name == dgv_GroupMenu["Form_Name", index].Value.ToString()
                                                                   && x.Group_No == no);
                    GroupFormConn.Remove(temp); //삭제
                    SetAuthority(no);           //재 조회
                }
            }
        }

        #endregion
        #endregion

        #region dgv 더블 클릭이벤트

        #region 그룹 dgv 더블클릭이벤트
        private void dgv_Group_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            no = Convert.ToInt32(dgv_Group["Grp_No", e.RowIndex].Value);
            SetAuthority(no);
            txtNo.Text = dgv_Group["Grp_No", e.RowIndex].Value.ToString();
            txtName.Text = dgv_Group["Grp_Name", e.RowIndex].Value.ToString();
            if (!enabled)   //한번도 누른적없으면
            {
                enabled = true;
                btn_MenuAdd.Enabled = btn_Delete.Enabled = btn_Upadte.Enabled = btn_MenuDelete.Enabled = enabled; //버튼을 선택할수 있게함
            }
        }
        #endregion

        #endregion
        #endregion
    }
}
