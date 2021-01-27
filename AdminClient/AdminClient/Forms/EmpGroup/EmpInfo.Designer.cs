namespace AdminClient.Forms
{
    partial class EmpInfo
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
            this.dgv_Emp = new AdminClient.CustomDataGridView();
            this.dtp_HireDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_HireDateTo = new System.Windows.Forms.DateTimePicker();
            this.gb_HireDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_RetireDate = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_RetireDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_RetireDateFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sortControl1 = new AdminClient.SortControl();
            this.searchControl1 = new AdminClient.SearchControl();
            this.chk_HireDate = new System.Windows.Forms.CheckBox();
            this.chk_RetireDate = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).BeginInit();
            this.gb_HireDate.SuspendLayout();
            this.gb_RetireDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1518, 23);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1601, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Size = new System.Drawing.Size(1691, 91);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.textBox2, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.textBox3, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimePicker5, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.textBox4, 0);
            this.panel1.Controls.SetChildIndex(this.label11, 0);
            this.panel1.Controls.SetChildIndex(this.textBox5, 0);
            this.panel1.Controls.SetChildIndex(this.label13, 0);
            this.panel1.Controls.SetChildIndex(this.textBox7, 0);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1709, 768);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.chk_RetireDate);
            this.gb_Sherch.Controls.Add(this.chk_HireDate);
            this.gb_Sherch.Controls.Add(this.label3);
            this.gb_Sherch.Controls.Add(this.comboBox1);
            this.gb_Sherch.Controls.Add(this.gb_RetireDate);
            this.gb_Sherch.Controls.Add(this.gb_HireDate);
            this.gb_Sherch.Size = new System.Drawing.Size(365, 251);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.button1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.gb_HireDate, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.gb_RetireDate, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.comboBox1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_HireDate, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_RetireDate, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.searchControl1);
            this.gb_detail.Controls.Add(this.sortControl1);
            this.gb_detail.Controls.Add(this.comboBox5);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Enabled = false;
            this.gb_detail.Location = new System.Drawing.Point(11, 257);
            this.gb_detail.Size = new System.Drawing.Size(365, 270);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 121);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Emp);
            this.splitContainer1.Size = new System.Drawing.Size(1709, 647);
            this.splitContainer1.SplitterDistance = 383;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 280);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 647);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 17);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1688, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1799, 7);
            // 
            // dgv_Emp
            // 
            this.dgv_Emp.AllowUserToAddRows = false;
            this.dgv_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Emp.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Emp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Emp.GridColor = System.Drawing.Color.Black;
            this.dgv_Emp.IsChkVisible = true;
            this.dgv_Emp.IsEditVisible = true;
            this.dgv_Emp.Location = new System.Drawing.Point(33, 0);
            this.dgv_Emp.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dgv_Emp.Name = "dgv_Emp";
            this.dgv_Emp.RowHeadersVisible = false;
            this.dgv_Emp.RowTemplate.Height = 23;
            this.dgv_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Emp.Size = new System.Drawing.Size(1289, 647);
            this.dgv_Emp.TabIndex = 3;
            // 
            // dtp_HireDateFrom
            // 
            this.dtp_HireDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HireDateFrom.Location = new System.Drawing.Point(3, 23);
            this.dtp_HireDateFrom.Name = "dtp_HireDateFrom";
            this.dtp_HireDateFrom.Size = new System.Drawing.Size(106, 25);
            this.dtp_HireDateFrom.TabIndex = 3;
            // 
            // dtp_HireDateTo
            // 
            this.dtp_HireDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HireDateTo.Location = new System.Drawing.Point(139, 24);
            this.dtp_HireDateTo.Name = "dtp_HireDateTo";
            this.dtp_HireDateTo.Size = new System.Drawing.Size(106, 25);
            this.dtp_HireDateTo.TabIndex = 4;
            // 
            // gb_HireDate
            // 
            this.gb_HireDate.Controls.Add(this.label1);
            this.gb_HireDate.Controls.Add(this.dtp_HireDateTo);
            this.gb_HireDate.Controls.Add(this.dtp_HireDateFrom);
            this.gb_HireDate.Enabled = false;
            this.gb_HireDate.Location = new System.Drawing.Point(8, 97);
            this.gb_HireDate.Name = "gb_HireDate";
            this.gb_HireDate.Size = new System.Drawing.Size(255, 64);
            this.gb_HireDate.TabIndex = 5;
            this.gb_HireDate.TabStop = false;
            this.gb_HireDate.Text = "입사일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "~";
            // 
            // gb_RetireDate
            // 
            this.gb_RetireDate.Controls.Add(this.label2);
            this.gb_RetireDate.Controls.Add(this.dtp_RetireDateTo);
            this.gb_RetireDate.Controls.Add(this.dtp_RetireDateFrom);
            this.gb_RetireDate.Enabled = false;
            this.gb_RetireDate.Location = new System.Drawing.Point(8, 167);
            this.gb_RetireDate.Name = "gb_RetireDate";
            this.gb_RetireDate.Size = new System.Drawing.Size(255, 64);
            this.gb_RetireDate.TabIndex = 6;
            this.gb_RetireDate.TabStop = false;
            this.gb_RetireDate.Text = "퇴사일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // dtp_RetireDateTo
            // 
            this.dtp_RetireDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_RetireDateTo.Location = new System.Drawing.Point(139, 24);
            this.dtp_RetireDateTo.Name = "dtp_RetireDateTo";
            this.dtp_RetireDateTo.Size = new System.Drawing.Size(106, 25);
            this.dtp_RetireDateTo.TabIndex = 4;
            // 
            // dtp_RetireDateFrom
            // 
            this.dtp_RetireDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_RetireDateFrom.Location = new System.Drawing.Point(3, 23);
            this.dtp_RetireDateFrom.Name = "dtp_RetireDateFrom";
            this.dtp_RetireDateFrom.Size = new System.Drawing.Size(106, 25);
            this.dtp_RetireDateFrom.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "소속 팀";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "소속 팀";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(11, 120);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(214, 25);
            this.comboBox5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "직원이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "소속그룹";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(270, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "입사일";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(351, 19);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(143, 25);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(591, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 25);
            this.textBox4.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(526, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "이메일";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(351, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 25);
            this.textBox5.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(271, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "우편번호";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(591, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 25);
            this.textBox7.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(517, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "전화번호";
            // 
            // sortControl1
            // 
            this.sortControl1.BackColor = System.Drawing.Color.Transparent;
            this.sortControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortControl1.Location = new System.Drawing.Point(8, 164);
            this.sortControl1.Margin = new System.Windows.Forms.Padding(4);
            this.sortControl1.Name = "sortControl1";
            this.sortControl1.Size = new System.Drawing.Size(327, 71);
            this.sortControl1.TabIndex = 23;
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.Color.Transparent;
            this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchControl1.Location = new System.Drawing.Point(10, 24);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(325, 77);
            this.searchControl1.TabIndex = 24;
            // 
            // chk_HireDate
            // 
            this.chk_HireDate.AutoSize = true;
            this.chk_HireDate.Location = new System.Drawing.Point(62, 100);
            this.chk_HireDate.Name = "chk_HireDate";
            this.chk_HireDate.Size = new System.Drawing.Size(15, 14);
            this.chk_HireDate.TabIndex = 9;
            this.chk_HireDate.UseVisualStyleBackColor = true;
            this.chk_HireDate.CheckedChanged += new System.EventHandler(this.chk_HireDate_CheckedChanged);
            // 
            // chk_RetireDate
            // 
            this.chk_RetireDate.AutoSize = true;
            this.chk_RetireDate.Location = new System.Drawing.Point(62, 170);
            this.chk_RetireDate.Name = "chk_RetireDate";
            this.chk_RetireDate.Size = new System.Drawing.Size(15, 14);
            this.chk_RetireDate.TabIndex = 10;
            this.chk_RetireDate.UseVisualStyleBackColor = true;
            this.chk_RetireDate.CheckedChanged += new System.EventHandler(this.chk_RetireDate_CheckedChanged);
            // 
            // EmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1720, 868);
            this.Name = "EmpInfo";
            this.Load += new System.EventHandler(this.EmpInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.gb_Sherch.ResumeLayout(false);
            this.gb_Sherch.PerformLayout();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp)).EndInit();
            this.gb_HireDate.ResumeLayout(false);
            this.gb_HireDate.PerformLayout();
            this.gb_RetireDate.ResumeLayout(false);
            this.gb_RetireDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_Emp;
        private System.Windows.Forms.DateTimePicker dtp_HireDateTo;
        private System.Windows.Forms.DateTimePicker dtp_HireDateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gb_RetireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_RetireDateTo;
        private System.Windows.Forms.DateTimePicker dtp_RetireDateFrom;
        private System.Windows.Forms.GroupBox gb_HireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label8;
        private SearchControl searchControl1;
        private SortControl sortControl1;
        private System.Windows.Forms.CheckBox chk_RetireDate;
        private System.Windows.Forms.CheckBox chk_HireDate;
    }
}
