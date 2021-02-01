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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("즐겨찾기 목록");
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
            this.lbl_Date = new System.Windows.Forms.Label();
            this.날짜 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tabForms = new AdminClient.ucTabControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1940, 25);
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
            this.테스트1ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
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
            this.테스트2ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.테스트2ToolStripMenuItem.Text = "물품확인";
            // 
            // 테스트3ToolStripMenuItem
            // 
            this.테스트3ToolStripMenuItem.Name = "테스트3ToolStripMenuItem";
            this.테스트3ToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.테스트3ToolStripMenuItem.Text = "고객사";
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.즐겨찾기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Date);
            this.panel1.Controls.Add(this.날짜);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1016);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 284);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(50, 17);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "label1";
            // 
            // 날짜
            // 
            this.날짜.AutoSize = true;
            this.날짜.Location = new System.Drawing.Point(3, 258);
            this.날짜.Name = "날짜";
            this.날짜.Size = new System.Drawing.Size(36, 17);
            this.날짜.TabIndex = 10;
            this.날짜.Text = "시간";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminClient.Properties.Resources.cowboy_2028626_1280;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(235, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 1016);
            this.panel5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.Location = new System.Drawing.Point(0, 610);
            this.treeView.Margin = new System.Windows.Forms.Padding(0);
            this.treeView.Name = "treeView";
            treeNode2.Name = "노드0";
            treeNode2.Text = "즐겨찾기 목록";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView.Size = new System.Drawing.Size(234, 405);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabForms.Location = new System.Drawing.Point(275, 25);
            this.tabForms.Margin = new System.Windows.Forms.Padding(4);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1665, 30);
            this.tabForms.TabIndex = 6;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1041);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_FormClosing);
            this.Load += new System.EventHandler(this.MDI_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDI_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private ucTabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label 날짜;
        private System.Windows.Forms.Timer timerTime;
    }
}