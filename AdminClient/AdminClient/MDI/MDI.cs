using AdminClient.Forms;
using AdminClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminClientVO;

namespace AdminClient.MDI
{
    public partial class MDI : Form
    {
        List<View_EmpFormVO> Forms = new List<View_EmpFormVO>();
        List<View_FavoritesVO> Favorites = new List<View_FavoritesVO>();
        public MDI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lbl_Date.Text = DateTime.Now.ToString("G");
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("G");
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            ViewService service = new ViewService();        //권한에 따른 폼들가져옴
            Forms = service.View_EmpForm(Global.Global.employees.Emp_Code);
            if (Forms == null)
                return;
            var items = (from pa in Forms
                         group pa by pa.Grp_Name into data
                         select new { Grp_Name = data.Key, vo = data }).ToList();

            foreach (var item in items)
            {
                menuStrip1.Items.Add(new ToolStripMenuItem { Name = item.Grp_Name, Text = item.Grp_Name });
                foreach (var vo in item.vo)
                {
                    ((ToolStripMenuItem)menuStrip1.Items[item.Grp_Name]).DropDownItems.Add(vo.Form_Menu, null, (sende, evnt) =>
                    {
                        Type type = Type.GetType("AdminClient.Forms." + vo.Form_Name);
                        Form instance = Activator.CreateInstance(type) as Form;
                        instance.Name = vo.Form_Name + vo.Grp_Name;
                        this.OpenCreateForm(instance, type, true);
                        instance.Text = vo.Form_Menu;
                    });
                }
            }

            //즐겨찾기 항목 가져옴
            Favorites = service.View_Favorites(Global.Global.employees.Emp_Code);
            if (Favorites == null)
                return;
            var favor = (from pa in Favorites
                        group pa by pa.Grp_Name into data
                        select new { Grp_Name = data.Key, vo = data }).ToList();

            foreach (var item in favor)
            {
                treeView.Nodes[0].Nodes.Add(new TreeNode { Name = item.Grp_Name, Text = item.Grp_Name });
                foreach (var vo in item.vo)
                {
                    treeView.Nodes[0].Nodes[item.Grp_Name].Nodes.Add(new TreeNode
                    {
                        Name = vo.Form_Name,
                        Text = vo.Form_Menu,
                        Tag = vo.Form_Menu+"|"+vo.Form_Name
                    });
                }
            }
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void MDI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.Dock = DockStyle.Fill; //폼이 표시될때 최대크기

            TabPage tp = new TabPage { Name = ActiveMdiChild.Name, Text = this.ActiveMdiChild.Text + "      " };
            //탭하나 생성
            foreach (TabPage tab in tabForms.TabPages)
            {
                if (tab.Name == tp.Name)// 해당탭이 있으면 실행   ##Constans 사용불가
                {
                    tabForms.SelectedTab = tab;             //해당탭선택
                    int Select = tabForms.SelectedIndex;    //선택한 탭 인덱스 가져옴
                    //해당 탭의 마우스 버튼 이벤트를 일으킴
                    tabForms_MouseDown(tabForms, new MouseEventArgs(MouseButtons.Left, 1, tabForms.GetTabRect(Select).X + 2, tabForms.GetTabRect(Select).Y + 2, 1));
                    return;
                }
            }
            tp.Tag = this.ActiveMdiChild;   //탭에  Active폼 테그로상속
            tabForms.TabPages.Add(tp);      //탭추가
            tabForms.SelectedTab = tp;      //탭선택

            this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            this.ActiveMdiChild.Tag = tp;
        }

        #region 탭추가
        /// <summary>
        /// 해당 탭의 닫기 이미지를 눌렀을경우실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabForms_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabForms.TabPages.Count; i++)
            {
                var tabRect = tabForms.GetTabRect(i); //탭의 사각형범위 
                //tabRect.Inflate(-2, -2);
                var closeImage = Properties.Resources.close_grey; //이미지가져옴
                var imageRect = new Rectangle(                    //해당이미지의 위치값 가져옴
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))             //만약 닫기이미지위치에 마우스가있으면
                {
                    this.ActiveMdiChild.Close();                //해당 표시 창 닫음
                    //tabForms.TabPages.RemoveAt(i);                    
                    break;
                }
            }
        }
        #endregion

        #region 자식폼 닫음
        /// <summary>
        /// 폼닫을때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();//폼이 닫히면 해당 폼을 상속한 탭 메모리해재(삭제)
        }
        #endregion

        #region 탭선택
        /// <summary>
        /// 탭을 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab != null && tabForms.SelectedTab.Tag != null)
            {
                (tabForms.SelectedTab.Tag as Form).Activate(); //해당 탭 Acticate
            }
        }
        #endregion

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Tag != null)
            {
                string[] vs = e.Node.Tag.ToString().Split('|'); //vo.Form_Menu+"|"+ vo.Form_Name
                Type type = Type.GetType("AdminClient.Forms." + vs[1]);
                Form instance = Activator.CreateInstance(type) as Form;
                instance.Name = vs[1];
                instance.Text = vs[0];
                this.OpenCreateForm(instance, type, true);
            }
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                return;
            FavoritesService service = new FavoritesService();
            if(service.InserFavorites(Global.Global.employees.Emp_Code, this.ActiveMdiChild.GetType().Name))
            {
                var item = Forms.Find(x => x.Form_Name == this.ActiveMdiChild.GetType().Name);

                //해당 그룹 노드가 없으면
                if (!treeView.Nodes[0].Nodes.ContainsKey(item.Grp_Name))
                {
                    treeView.Nodes[0].Nodes.Add(new TreeNode { Name = item.Grp_Name, Text = item.Grp_Name });
                }
                //노드추가
                treeView.Nodes[0].Nodes[item.Grp_Name].Nodes.Add(new TreeNode
                {
                    Name = item.Form_Name,
                    Text = item.Form_Menu,
                    Tag = item.Form_Menu + "|" + item.Form_Name
                });
            }
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                return;
            FavoritesService service = new FavoritesService();
            
            if (service.DeleteFavorites(Global.Global.employees.Emp_Code, this.ActiveMdiChild.GetType().Name))
            {
                var item = Forms.Find(x => x.Form_Name == this.ActiveMdiChild.GetType().Name);
                //노드 삭제
                treeView.Nodes[0].Nodes[item.Grp_Name].Nodes[item.Form_Name].Remove();
                //그룹 노드에 자식이 없으면
                if(treeView.Nodes[0].Nodes[item.Grp_Name].Nodes.Count == 0)
                { 
                    //그룹 노드삭제
                    treeView.Nodes[0].Nodes[item.Grp_Name].Remove();
                }
            }
        }
    }
}
