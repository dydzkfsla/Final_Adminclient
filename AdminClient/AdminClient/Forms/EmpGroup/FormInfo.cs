using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
    public partial class FormInfo : AdminClient.BaseForm.EmpFormTemp
    {
        List<string> typeList = new List<string>();
        public FormInfo()
        {
            InitializeComponent();
            dgvdeleted.SetGridColumn();
            dgvNonSelectForm.SetGridColumn();
            dgvSelectForm.SetGridColumn();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            txt_formName.Enabled = false;
            typeList = new List<string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetExportedTypes())  //모든 타입가져옴
            {
                if (t.Namespace == "AdminClient.Forms") //해당 네임스페이스만
                {
                    if (Activator.CreateInstance(t) is Form) //폼인 클래스만
                    {
                        typeList.Add(t.Name);
                    }
                }
            }

            txt_ManuName.KeyPress += UtilEvent.tbx_Trim;
            //txt_ManuName.KeyPress += UtilEvent.isHangul_KeyPress;

            DgvSet();
            Inited(); //초기상태
        }

        private void DgvSet()
        {
            CommonUtil.SetInitGridView(dgvSelectForm);
            CommonUtil.AddGridTextColumn(dgvSelectForm, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvSelectForm, "메뉴이름", "Form_Menu");
            CommonUtil.SetInitGridView(dgvNonSelectForm);
            CommonUtil.AddGridTextColumn(dgvNonSelectForm, "폼이름", "Form_Name", 150);
            CommonUtil.SetInitGridView(dgvdeleted);
            CommonUtil.AddGridTextColumn(dgvdeleted, "폼이름", "Form_Name", 150);
            CommonUtil.AddGridTextColumn(dgvdeleted, "메뉴이름", "Form_Menu", visibility: false);
        }

        private void Inited()
        {
            DgvDatSourceLoad();
            btn_add.Enabled = false;
            btn_Update.Enabled = false;
            btn_delete.Enabled = false;
            txt_formName.Text = string.Empty;
            txt_ManuName.Text = string.Empty;
        }

        private void DgvDatSourceLoad()
        {
            //네임스페이스의 모든 폼이름 목록을 복사
            var AllFroms = (from item in typeList
                            select item).ToList();

            FormInfoService service = new FormInfoService();
            var list = service.GetAllList(); //db에서 모든 폼을 가져옴

            //네임스페이스에 해당 가져온 목록이 있으면 삭제 즉 아직 등록안됨 폼만 가져옴
            list.ForEach((item) =>
            {
                AllFroms.Remove(item.Form_Name);
            });

            //db의 목록을 복사해옴
            var templist = (from item in list
                            select item).ToList();

            //삭제해야할 항목 저장공간 할당
            List<FormInfoVO> remove = new List<FormInfoVO>();

            //삭제해야할 항목 확인
            templist.ForEach((item) =>
            {
                typeList.ForEach((type) => {
                    if (item.Form_Name == type) //네임스페이스에 있는 항목 저장
                    {
                        remove.Add(item);
                    }
                });
            });

            //삭제할것을  삭제하여 네임스페이스에 없는데 할당된 폼
            //이미 삭제된 폼을 찾음
            remove.ForEach((index) =>
            {
                templist.Remove(index);
            });

            var items = (from item in AllFroms
                         select new { Form_Name = item }).ToList();

            dgvSelectForm.DataSource = list;     //바인딩된 폼
            dgvNonSelectForm.DataSource = items; //할당안된폼
            dgvdeleted.DataSource = templist;    //할당인 되있지만 네임스페이스에 없는폼
        }

        private void dgvSelectForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            btn_add.Enabled = false;
            btn_Update.Enabled = true;
            btn_delete.Enabled = true;

            txt_formName.Text = dgvSelectForm["Form_Name", e.RowIndex].Value.ToString();
            txt_ManuName.Text = dgvSelectForm["Form_Menu", e.RowIndex].Value.ToString();
        }

        private void dgvNonSelectForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_Update.Enabled = false;

            txt_formName.Text = dgvNonSelectForm["Form_Name", e.RowIndex].Value.ToString();
            txt_ManuName.Text = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormInfoService service = new FormInfoService();
            if (string.IsNullOrEmpty(txt_ManuName.Text))
                return;
            if (service.InsertFormInfo(txt_formName.Text, txt_ManuName.Text))
            {
                Inited();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            FormInfoService service = new FormInfoService();
            if (service.DeleteFormInfo(txt_formName.Text))
            {
                Inited();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ManuName.Text))
                return;
            FormInfoService service = new FormInfoService();
            if (service.UpdateFormInfo(txt_formName.Text, txt_ManuName.Text))
            {
                Inited();
            }
        }
    }
}
