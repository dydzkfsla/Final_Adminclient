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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_EmpName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Emp_code = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Btn_Select = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Btn_add = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Btn_Update = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Btn_Delete = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabForms = new AdminClient.ucTabControl();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem,
            this.즐겨찾기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1940, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.즐겨찾기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Down);
            this.panel1.Controls.Add(this.btn_Up);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 999);
            this.panel1.TabIndex = 5;
            // 
            // btn_Down
            // 
            this.btn_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Down.Location = new System.Drawing.Point(0, 934);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(235, 45);
            this.btn_Down.TabIndex = 17;
            this.btn_Down.Text = "∨\r\n∨";
            this.btn_Down.UseVisualStyleBackColor = false;
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Up.Location = new System.Drawing.Point(0, 0);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(235, 45);
            this.btn_Up.TabIndex = 16;
            this.btn_Up.Text = "∧\r\n∧";
            this.btn_Up.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(235, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 999);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTime,
            this.toolStripSeparator4,
            this.toolStripLabel_EmpName,
            this.toolStripSeparator5,
            this.toolStripLabel_Emp_code,
            this.toolStripSeparator6,
            this.toolStripLabel_Btn_Select,
            this.toolStripSeparator1,
            this.toolStripLabel_Btn_add,
            this.toolStripSeparator2,
            this.toolStripLabel_Btn_Update,
            this.toolStripSeparator3,
            this.toolStripLabel_Btn_Delete});
            this.toolStrip1.Location = new System.Drawing.Point(275, 1016);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1665, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelTime
            // 
            this.toolStripLabelTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelTime.Name = "toolStripLabelTime";
            this.toolStripLabelTime.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabelTime.Text = "toolStripLabel1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_EmpName
            // 
            this.toolStripLabel_EmpName.Name = "toolStripLabel_EmpName";
            this.toolStripLabel_EmpName.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel_EmpName.Text = "toolStripLabel1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Emp_code
            // 
            this.toolStripLabel_Emp_code.Name = "toolStripLabel_Emp_code";
            this.toolStripLabel_Emp_code.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel_Emp_code.Text = "toolStripLabel1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Btn_Select
            // 
            this.toolStripLabel_Btn_Select.Name = "toolStripLabel_Btn_Select";
            this.toolStripLabel_Btn_Select.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel_Btn_Select.Text = "조회권한 : Y";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Btn_add
            // 
            this.toolStripLabel_Btn_add.Name = "toolStripLabel_Btn_add";
            this.toolStripLabel_Btn_add.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel_Btn_add.Text = "추가권한 : Y";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Btn_Update
            // 
            this.toolStripLabel_Btn_Update.Name = "toolStripLabel_Btn_Update";
            this.toolStripLabel_Btn_Update.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel_Btn_Update.Text = "수정권한 : Y";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Btn_Delete
            // 
            this.toolStripLabel_Btn_Delete.Name = "toolStripLabel_Btn_Delete";
            this.toolStripLabel_Btn_Delete.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel_Btn_Delete.Text = "삭제권한 : Y";
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabForms.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabForms.Location = new System.Drawing.Point(275, 42);
            this.tabForms.Margin = new System.Windows.Forms.Padding(4);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1665, 30);
            this.tabForms.TabIndex = 6;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            this.tabForms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabForms_MouseDown);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1041);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_FormClosing);
            this.Load += new System.EventHandler(this.MDI_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDI_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private ucTabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTime;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_EmpName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Btn_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Btn_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Btn_Delete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Emp_code;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Btn_Select;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
    }
}