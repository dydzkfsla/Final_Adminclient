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
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("메뉴관리");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("그룹관리");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("직원관리");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("직원메뉴", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("물품확인");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("고객사");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("폼 로드 목록", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테스트1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테스트2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.테스트3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테스트1ToolStripMenuItem,
            this.테스트2ToolStripMenuItem,
            this.테스트3ToolStripMenuItem});
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
            // 테스트2ToolStripMenuItem
            // 
            this.테스트2ToolStripMenuItem.Name = "테스트2ToolStripMenuItem";
            this.테스트2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.테스트2ToolStripMenuItem.Text = "물품확인";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 686);
            this.panel1.TabIndex = 5;
            // 
            // 테스트3ToolStripMenuItem
            // 
            this.테스트3ToolStripMenuItem.Name = "테스트3ToolStripMenuItem";
            this.테스트3ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.테스트3ToolStripMenuItem.Text = "고객사";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            treeNode36.Name = "노드4";
            treeNode36.Text = "메뉴관리";
            treeNode37.Name = "노드6";
            treeNode37.Text = "그룹관리";
            treeNode38.Name = "노드7";
            treeNode38.Text = "직원관리";
            treeNode39.Name = "노드1";
            treeNode39.Text = "직원메뉴";
            treeNode40.Name = "노드2";
            treeNode40.Text = "물품확인";
            treeNode41.Name = "노드3";
            treeNode41.Text = "고객사";
            treeNode42.Name = "노드0";
            treeNode42.Text = "폼 로드 목록";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.treeView1.Size = new System.Drawing.Size(183, 224);
            this.treeView1.TabIndex = 0;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "∧\r\n∧";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 10;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 653);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "∨ \r\n∨ ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 58);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 58);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 58);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "메뉴관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "그룹관리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "직원관리";
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
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            // 
            // 그룹관리ToolStripMenuItem
            // 
            this.그룹관리ToolStripMenuItem.Name = "그룹관리ToolStripMenuItem";
            this.그룹관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.그룹관리ToolStripMenuItem.Text = "그룹관리";
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.직원관리ToolStripMenuItem.Text = "직원관리";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
    }
}