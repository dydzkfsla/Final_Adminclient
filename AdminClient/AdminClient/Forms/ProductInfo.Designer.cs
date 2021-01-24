namespace AdminClient.Forms
{
    partial class ProductInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.cbo_Unit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_ProdList = new AdminClient.CustomDataGridView();
            this.txt_Wh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Cate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1358, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1441, 9);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(1276, 9);
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.txt_Wh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_Cate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_Code);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Size = new System.Drawing.Size(1526, 64);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Update, 0);
            this.panel1.Controls.SetChildIndex(this.label13, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
            this.panel1.Controls.SetChildIndex(this.label12, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Name, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Cate, 0);
            this.panel1.Controls.SetChildIndex(this.label11, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Wh, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Clear, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Delete, 0);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1544, 756);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Controls.Add(this.label4);
            this.gb_Sherch.Controls.Add(this.comboBox3);
            this.gb_Sherch.Controls.Add(this.label3);
            this.gb_Sherch.Controls.Add(this.cbo_Unit);
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.cbo_Category);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Size = new System.Drawing.Size(376, 242);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.button1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Category, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Unit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.comboBox3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label4, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.comboBox6);
            this.gb_detail.Controls.Add(this.rd_descending);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.rd_ascending);
            this.gb_detail.Controls.Add(this.comboBox8);
            this.gb_detail.Controls.Add(this.comboBox9);
            this.gb_detail.Controls.Add(this.label6);
            this.gb_detail.Controls.Add(this.button2);
            this.gb_detail.Controls.Add(this.comboBox10);
            this.gb_detail.Controls.Add(this.button3);
            this.gb_detail.Controls.Add(this.label8);
            this.gb_detail.Controls.Add(this.comboBox5);
            this.gb_detail.Controls.Add(this.comboBox11);
            this.gb_detail.Controls.Add(this.comboBox7);
            this.gb_detail.Controls.Add(this.label9);
            this.gb_detail.Controls.Add(this.textBox1);
            this.gb_detail.Controls.Add(this.label7);
            this.gb_detail.Location = new System.Drawing.Point(11, 248);
            this.gb_detail.Size = new System.Drawing.Size(397, 425);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(138, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ProdList);
            this.splitContainer1.Size = new System.Drawing.Size(1544, 675);
            this.splitContainer1.SplitterDistance = 427;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 294);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 675);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 18);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1523, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1634, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "카테고리";
            // 
            // cbo_Category
            // 
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(12, 61);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(225, 25);
            this.cbo_Category.TabIndex = 4;
            // 
            // cbo_Unit
            // 
            this.cbo_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Unit.FormattingEnabled = true;
            this.cbo_Unit.Location = new System.Drawing.Point(12, 109);
            this.cbo_Unit.Name = "cbo_Unit";
            this.cbo_Unit.Size = new System.Drawing.Size(225, 25);
            this.cbo_Unit.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "단위";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 157);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 25);
            this.comboBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "검사여부";
            // 
            // cbo_State
            // 
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(12, 205);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(225, 25);
            this.cbo_State.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "단종여부";
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(112, 353);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(106, 21);
            this.rd_descending.TabIndex = 46;
            this.rd_descending.TabStop = true;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Location = new System.Drawing.Point(8, 353);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(98, 21);
            this.rd_ascending.TabIndex = 45;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(8, 380);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(225, 25);
            this.comboBox9.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(287, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 64);
            this.button2.TabIndex = 43;
            this.button2.Text = "정렬";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::AdminClient.Properties.Resources.BelowAverage_32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(292, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 56);
            this.button3.TabIndex = 42;
            this.button3.Text = "조건\r\n적용";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(8, 81);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(125, 25);
            this.comboBox5.TabIndex = 41;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(8, 50);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(225, 25);
            this.comboBox7.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 25);
            this.textBox1.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "검색조건";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(8, 304);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(225, 25);
            this.comboBox6.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "단종여부";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(8, 256);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(225, 25);
            this.comboBox8.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "검사여부";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(8, 208);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(225, 25);
            this.comboBox10.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "단위";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(8, 160);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(225, 25);
            this.comboBox11.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "카테고리";
            // 
            // dgv_ProdList
            // 
            this.dgv_ProdList.AllowUserToAddRows = false;
            this.dgv_ProdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProdList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProdList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProdList.GridColor = System.Drawing.Color.Black;
            this.dgv_ProdList.IsChkVisible = false;
            this.dgv_ProdList.Location = new System.Drawing.Point(33, 0);
            this.dgv_ProdList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dgv_ProdList.Name = "dgv_ProdList";
            this.dgv_ProdList.RowHeadersVisible = false;
            this.dgv_ProdList.RowTemplate.Height = 23;
            this.dgv_ProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdList.Size = new System.Drawing.Size(1079, 675);
            this.dgv_ProdList.TabIndex = 3;
            this.dgv_ProdList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProdList_CellClick);
            // 
            // txt_Wh
            // 
            this.txt_Wh.Location = new System.Drawing.Point(1113, 21);
            this.txt_Wh.Name = "txt_Wh";
            this.txt_Wh.Size = new System.Drawing.Size(145, 25);
            this.txt_Wh.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1069, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "창고";
            // 
            // txt_Cate
            // 
            this.txt_Cate.Location = new System.Drawing.Point(883, 21);
            this.txt_Cate.Name = "txt_Cate";
            this.txt_Cate.Size = new System.Drawing.Size(145, 25);
            this.txt_Cate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(824, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "구분";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(641, 21);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 25);
            this.txt_Name.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(567, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "물품이름";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(404, 21);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(145, 25);
            this.txt_Code.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(339, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "물품코드";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(149, 24);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "초기화";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(38, 29);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1555, 856);
            this.Name = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label9;
        private CustomDataGridView dgv_ProdList;
        private System.Windows.Forms.TextBox txt_Wh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Cate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
    }
}
