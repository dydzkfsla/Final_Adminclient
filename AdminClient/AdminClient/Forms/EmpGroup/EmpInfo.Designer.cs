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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Emp = new AdminClient.CustomDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1175, 23);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1258, 23);
            // 
            // btn_Update
            // 
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker6);
            this.panel1.Controls.Add(this.dateTimePicker5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Size = new System.Drawing.Size(1348, 91);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.textBox2, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.textBox3, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            this.panel1.Controls.SetChildIndex(this.label9, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimePicker5, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimePicker6, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.textBox4, 0);
            this.panel1.Controls.SetChildIndex(this.label11, 0);
            this.panel1.Controls.SetChildIndex(this.textBox5, 0);
            this.panel1.Controls.SetChildIndex(this.label13, 0);
            this.panel1.Controls.SetChildIndex(this.textBox7, 0);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1366, 768);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.checkBox1);
            this.gb_Sherch.Controls.Add(this.label3);
            this.gb_Sherch.Controls.Add(this.comboBox1);
            this.gb_Sherch.Controls.Add(this.groupBox2);
            this.gb_Sherch.Controls.Add(this.groupBox1);
            this.gb_Sherch.Size = new System.Drawing.Size(365, 251);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.groupBox2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.comboBox1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.comboBox5);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.button3);
            this.gb_detail.Controls.Add(this.button2);
            this.gb_detail.Controls.Add(this.rd_descending);
            this.gb_detail.Controls.Add(this.rd_ascending);
            this.gb_detail.Controls.Add(this.comboBox3);
            this.gb_detail.Controls.Add(this.comboBox2);
            this.gb_detail.Controls.Add(this.comboBox4);
            this.gb_detail.Controls.Add(this.textBox1);
            this.gb_detail.Controls.Add(this.label4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1366, 647);
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
            this.btn_search.Location = new System.Drawing.Point(286, 17);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1345, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1456, 7);
            // 
            // dgv_Emp
            // 
            this.dgv_Emp.AllowUserToAddRows = false;
            this.dgv_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Emp.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Emp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Emp.GridColor = System.Drawing.Color.Black;
            this.dgv_Emp.IsChkVisible = false;
            this.dgv_Emp.Location = new System.Drawing.Point(33, 0);
            this.dgv_Emp.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dgv_Emp.Name = "dgv_Emp";
            this.dgv_Emp.RowHeadersVisible = false;
            this.dgv_Emp.RowTemplate.Height = 23;
            this.dgv_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Emp.Size = new System.Drawing.Size(946, 647);
            this.dgv_Emp.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "직원코드";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "직원이름";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입사일";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "퇴사일";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "우편번호";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "주소";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "상세주소";
            this.Column7.Name = "Column7";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(8, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입사일";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Location = new System.Drawing.Point(8, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "퇴사일";
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(139, 24);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(106, 25);
            this.dateTimePicker4.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "소속 그룹";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::AdminClient.Properties.Resources.BelowAverage_32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(276, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "조건\r\n적용";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(276, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 64);
            this.button2.TabIndex = 19;
            this.button2.Text = "정렬";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(113, 190);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(106, 21);
            this.rd_descending.TabIndex = 18;
            this.rd_descending.TabStop = true;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Location = new System.Drawing.Point(15, 190);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(98, 21);
            this.rd_ascending.TabIndex = 17;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(8, 229);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(211, 25);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 25);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(5, 43);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(214, 25);
            this.comboBox4.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 25);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "검색조건";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "소속 그룹";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(5, 153);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(214, 25);
            this.comboBox5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(154, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "직원이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(154, 57);
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
            this.label8.Location = new System.Drawing.Point(385, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "입사일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(385, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "퇴사일";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(435, 16);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(124, 25);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker6.Location = new System.Drawing.Point(435, 54);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(124, 25);
            this.dateTimePicker6.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(660, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 25);
            this.textBox4.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(595, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "이메일";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(660, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 25);
            this.textBox5.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(580, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "우편번호";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(898, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 25);
            this.textBox7.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(824, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "전화번호";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(268, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // EmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1377, 868);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_Emp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
