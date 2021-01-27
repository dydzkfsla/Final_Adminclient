namespace AdminClient.Forms
{
    partial class TempInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Temp = new AdminClient.CustomDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_addGroup = new AdminClient.CustomDataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Group = new AdminClient.CustomDataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GroupDelete = new System.Windows.Forms.Button();
            this.btn_GroupAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Upadte = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChief = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_Temp);
            this.pnl_Main.Controls.Add(this.groupBox1);
            this.pnl_Main.Controls.Add(this.btn_GroupDelete);
            this.pnl_Main.Controls.Add(this.btn_GroupAdd);
            this.pnl_Main.Controls.Add(this.dgv_Group);
            this.pnl_Main.Controls.Add(this.btn_Delete);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.btn_Upadte);
            this.pnl_Main.Controls.Add(this.btn_Add);
            this.pnl_Main.Controls.Add(this.dgv_addGroup);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Size = new System.Drawing.Size(1279, 687);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1253, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1301, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "팀이름";
            // 
            // dgv_Temp
            // 
            this.dgv_Temp.AllowUserToAddRows = false;
            this.dgv_Temp.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Temp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Temp.GridColor = System.Drawing.Color.Black;
            this.dgv_Temp.IsChkVisible = false;
            this.dgv_Temp.IsEditVisible = false;
            this.dgv_Temp.Location = new System.Drawing.Point(6, 39);
            this.dgv_Temp.Name = "dgv_Temp";
            this.dgv_Temp.RowHeadersVisible = false;
            this.dgv_Temp.RowTemplate.Height = 23;
            this.dgv_Temp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Temp.Size = new System.Drawing.Size(352, 283);
            this.dgv_Temp.TabIndex = 1;
            this.dgv_Temp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Temp_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dgv_addGroup
            // 
            this.dgv_addGroup.AllowUserToAddRows = false;
            this.dgv_addGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgv_addGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_addGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_addGroup.GridColor = System.Drawing.Color.Black;
            this.dgv_addGroup.IsChkVisible = false;
            this.dgv_addGroup.IsEditVisible = false;
            this.dgv_addGroup.Location = new System.Drawing.Point(364, 39);
            this.dgv_addGroup.Name = "dgv_addGroup";
            this.dgv_addGroup.RowHeadersVisible = false;
            this.dgv_addGroup.RowTemplate.Height = 23;
            this.dgv_addGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_addGroup.Size = new System.Drawing.Size(443, 283);
            this.dgv_addGroup.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "No";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = false;
            this.dataGridViewCheckBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "등록 그룹목록";
            // 
            // dgv_Group
            // 
            this.dgv_Group.AllowUserToAddRows = false;
            this.dgv_Group.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Group.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Group.GridColor = System.Drawing.Color.Black;
            this.dgv_Group.IsChkVisible = false;
            this.dgv_Group.IsEditVisible = false;
            this.dgv_Group.Location = new System.Drawing.Point(885, 39);
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.RowHeadersVisible = false;
            this.dgv_Group.RowTemplate.Height = 23;
            this.dgv_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Group.Size = new System.Drawing.Size(370, 283);
            this.dgv_Group.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "No";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.NullValue = false;
            this.dataGridViewCheckBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCheckBoxColumn5.HeaderText = "";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Visible = false;
            this.dataGridViewCheckBoxColumn5.Width = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "No";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.NullValue = false;
            this.dataGridViewCheckBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewCheckBoxColumn3.HeaderText = "";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Visible = false;
            this.dataGridViewCheckBoxColumn3.Width = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "그룹목록";
            // 
            // btn_GroupDelete
            // 
            this.btn_GroupDelete.BackColor = System.Drawing.Color.White;
            this.btn_GroupDelete.Enabled = false;
            this.btn_GroupDelete.Location = new System.Drawing.Point(813, 156);
            this.btn_GroupDelete.Name = "btn_GroupDelete";
            this.btn_GroupDelete.Size = new System.Drawing.Size(64, 38);
            this.btn_GroupDelete.TabIndex = 11;
            this.btn_GroupDelete.Text = ">>";
            this.btn_GroupDelete.UseVisualStyleBackColor = false;
            this.btn_GroupDelete.Click += new System.EventHandler(this.btn_GroupDelete_Click);
            // 
            // btn_GroupAdd
            // 
            this.btn_GroupAdd.BackColor = System.Drawing.Color.White;
            this.btn_GroupAdd.Enabled = false;
            this.btn_GroupAdd.Location = new System.Drawing.Point(813, 58);
            this.btn_GroupAdd.Name = "btn_GroupAdd";
            this.btn_GroupAdd.Size = new System.Drawing.Size(64, 38);
            this.btn_GroupAdd.TabIndex = 10;
            this.btn_GroupAdd.Text = "<<";
            this.btn_GroupAdd.UseVisualStyleBackColor = false;
            this.btn_GroupAdd.Click += new System.EventHandler(this.btn_GroupAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtChief);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 306);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 69);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(75, 33);
            this.txtCode.MaxLength = 7;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(218, 25);
            this.txtCode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "팀명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(346, 477);
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
            this.btn_Upadte.Location = new System.Drawing.Point(346, 429);
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
            this.btn_Add.Location = new System.Drawing.Point(346, 379);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 43);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "담당자";
            // 
            // txtChief
            // 
            this.txtChief.Location = new System.Drawing.Point(75, 106);
            this.txtChief.MaxLength = 7;
            this.txtChief.Name = "txtChief";
            this.txtChief.Size = new System.Drawing.Size(218, 25);
            this.txtChief.TabIndex = 8;
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(75, 137);
            this.txtPart.MaxLength = 300;
            this.txtPart.Multiline = true;
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(218, 163);
            this.txtPart.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Part";
            // 
            // TempInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1289, 745);
            this.Name = "TempInfo";
            this.Load += new System.EventHandler(this.TempInfo_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_addGroup;
        private System.Windows.Forms.Label label2;
        private CustomDataGridView dgv_Temp;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GroupDelete;
        private System.Windows.Forms.Button btn_GroupAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Upadte;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChief;
        private System.Windows.Forms.Label label6;
    }
}
