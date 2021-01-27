namespace AdminClient.Forms
{
    partial class GroupInfo
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_MenuAdd = new System.Windows.Forms.Button();
            this.btn_MenuDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Upadte = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Group = new AdminClient.CustomDataGridView();
            this.dgv_GroupMenu = new AdminClient.CustomDataGridView();
            this.dgv_MenuInfo = new AdminClient.CustomDataGridView();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_MenuInfo);
            this.pnl_Main.Controls.Add(this.dgv_GroupMenu);
            this.pnl_Main.Controls.Add(this.dgv_Group);
            this.pnl_Main.Controls.Add(this.groupBox1);
            this.pnl_Main.Controls.Add(this.button3);
            this.pnl_Main.Controls.Add(this.btn_MenuDelete);
            this.pnl_Main.Controls.Add(this.btn_MenuAdd);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Size = new System.Drawing.Size(1179, 640);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(169, 43);
            this.lbl_Title.Text = "메뉴 그룹";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1153, 9);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1263, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "등록 메뉴목록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "메뉴목록";
            // 
            // btn_MenuAdd
            // 
            this.btn_MenuAdd.BackColor = System.Drawing.Color.White;
            this.btn_MenuAdd.Enabled = false;
            this.btn_MenuAdd.Location = new System.Drawing.Point(687, 37);
            this.btn_MenuAdd.Name = "btn_MenuAdd";
            this.btn_MenuAdd.Size = new System.Drawing.Size(64, 38);
            this.btn_MenuAdd.TabIndex = 6;
            this.btn_MenuAdd.Text = "<<";
            this.btn_MenuAdd.UseVisualStyleBackColor = false;
            this.btn_MenuAdd.Click += new System.EventHandler(this.btn_MenuAdd_Click);
            // 
            // btn_MenuDelete
            // 
            this.btn_MenuDelete.BackColor = System.Drawing.Color.White;
            this.btn_MenuDelete.Enabled = false;
            this.btn_MenuDelete.Location = new System.Drawing.Point(687, 150);
            this.btn_MenuDelete.Name = "btn_MenuDelete";
            this.btn_MenuDelete.Size = new System.Drawing.Size(64, 38);
            this.btn_MenuDelete.TabIndex = 7;
            this.btn_MenuDelete.Text = ">>";
            this.btn_MenuDelete.UseVisualStyleBackColor = false;
            this.btn_MenuDelete.Click += new System.EventHandler(this.btn_MenuDelete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(687, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "폼목록\r\n  조회";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Upadte);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Location = new System.Drawing.Point(19, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 219);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 80);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(79, 44);
            this.txtNo.MaxLength = 8;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(218, 25);
            this.txtNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "그룹명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "no";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(429, 142);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 43);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Upadte
            // 
            this.btn_Upadte.BackColor = System.Drawing.Color.White;
            this.btn_Upadte.Enabled = false;
            this.btn_Upadte.Location = new System.Drawing.Point(429, 93);
            this.btn_Upadte.Name = "btn_Upadte";
            this.btn_Upadte.Size = new System.Drawing.Size(93, 43);
            this.btn_Upadte.TabIndex = 1;
            this.btn_Upadte.Text = "수정";
            this.btn_Upadte.UseVisualStyleBackColor = false;
            this.btn_Upadte.Click += new System.EventHandler(this.btn_Upadte_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(429, 44);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 43);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Group
            // 
            this.dgv_Group.AllowUserToAddRows = false;
            this.dgv_Group.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Group.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Group.GridColor = System.Drawing.Color.Black;
            this.dgv_Group.IsChkVisible = false;
            this.dgv_Group.IsEditVisible = false;
            this.dgv_Group.Location = new System.Drawing.Point(19, 32);
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.RowHeadersVisible = false;
            this.dgv_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Group.Size = new System.Drawing.Size(267, 303);
            this.dgv_Group.TabIndex = 10;
            this.dgv_Group.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Group_CellDoubleClick);
            // 
            // dgv_GroupMenu
            // 
            this.dgv_GroupMenu.AllowUserToAddRows = false;
            this.dgv_GroupMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GroupMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GroupMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_GroupMenu.GridColor = System.Drawing.Color.Black;
            this.dgv_GroupMenu.IsChkVisible = false;
            this.dgv_GroupMenu.IsEditVisible = false;
            this.dgv_GroupMenu.Location = new System.Drawing.Point(308, 32);
            this.dgv_GroupMenu.Name = "dgv_GroupMenu";
            this.dgv_GroupMenu.RowHeadersVisible = false;
            this.dgv_GroupMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GroupMenu.Size = new System.Drawing.Size(373, 303);
            this.dgv_GroupMenu.TabIndex = 11;
            // 
            // dgv_MenuInfo
            // 
            this.dgv_MenuInfo.AllowUserToAddRows = false;
            this.dgv_MenuInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MenuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MenuInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MenuInfo.GridColor = System.Drawing.Color.Black;
            this.dgv_MenuInfo.IsChkVisible = false;
            this.dgv_MenuInfo.IsEditVisible = false;
            this.dgv_MenuInfo.Location = new System.Drawing.Point(769, 37);
            this.dgv_MenuInfo.Name = "dgv_MenuInfo";
            this.dgv_MenuInfo.RowHeadersVisible = false;
            this.dgv_MenuInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MenuInfo.Size = new System.Drawing.Size(396, 303);
            this.dgv_MenuInfo.TabIndex = 12;
            // 
            // GroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1190, 697);
            this.Name = "GroupInfo";
            this.Load += new System.EventHandler(this.GroupInfo_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Upadte;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_MenuDelete;
        private System.Windows.Forms.Button btn_MenuAdd;
        private CustomDataGridView dgv_MenuInfo;
        private CustomDataGridView dgv_GroupMenu;
        private CustomDataGridView dgv_Group;
    }
}
