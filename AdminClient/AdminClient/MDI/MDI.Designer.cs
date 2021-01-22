namespace AdminClient.MDI
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("메뉴관리");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("그룹관리");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("직원관리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("직원메뉴", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("물품확인");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("고객사");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("즐겨찾기 목록", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테스트1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테스트2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테스트3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ucTabControl1 = new AdminClient.ucTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.ucTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테스트1ToolStripMenuItem,
            this.테스트2ToolStripMenuItem,
            this.테스트3ToolStripMenuItem,
            this.즐겨찾기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 테스트1ToolStripMenuItem
            // 
            this.테스트1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴관리ToolStripMenuItem,
            this.그룹관리ToolStripMenuItem,
            this.직원관리ToolStripMenuItem});
            this.테스트1ToolStripMenuItem.Name = "테스트1ToolStripMenuItem";
            this.테스트1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.테스트1ToolStripMenuItem.Text = "직원메뉴";
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            // 
            // 그룹관리ToolStripMenuItem
            // 
            this.그룹관리ToolStripMenuItem.Name = "그룹관리ToolStripMenuItem";
            this.그룹관리ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.그룹관리ToolStripMenuItem.Text = "그룹관리";
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // 테스트2ToolStripMenuItem
            // 
            this.테스트2ToolStripMenuItem.Name = "테스트2ToolStripMenuItem";
            this.테스트2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.테스트2ToolStripMenuItem.Text = "물품확인";
            // 
            // 테스트3ToolStripMenuItem
            // 
            this.테스트3ToolStripMenuItem.Name = "테스트3ToolStripMenuItem";
            this.테스트3ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.테스트3ToolStripMenuItem.Text = "고객사";
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.즐겨찾기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 686);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminClient.Properties.Resources.cowboy_2028626_1280;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(182, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 686);
            this.panel5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(0, 179);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드4";
            treeNode1.Text = "메뉴관리";
            treeNode2.Name = "노드6";
            treeNode2.Text = "그룹관리";
            treeNode3.Name = "노드7";
            treeNode3.Text = "직원관리";
            treeNode4.Name = "노드1";
            treeNode4.Text = "직원메뉴";
            treeNode5.Name = "노드2";
            treeNode5.Text = "물품확인";
            treeNode6.Name = "노드3";
            treeNode6.Text = "고객사";
            treeNode7.Name = "노드0";
            treeNode7.Text = "즐겨찾기 목록";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(183, 187);
            this.treeView1.TabIndex = 0;
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.Controls.Add(this.tabPage1);
            this.ucTabControl1.Controls.Add(this.tabPage2);
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ucTabControl1.Location = new System.Drawing.Point(213, 24);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(740, 20);
            this.ucTabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 710);
            this.Controls.Add(this.ucTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ucTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 테스트1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 테스트2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 테스트3ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private ucTabControl ucTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}