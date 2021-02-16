namespace AdminClient.PopUp
{
    partial class OrderInfoPopUp
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_Order = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt_OrderCode = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_check = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_Set = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_ProdName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_OrderCnt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_WHcode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_In = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_Out = new System.Windows.Forms.Button();
			this.dgv_AddList = new AdminClient.CustomDataGridView();
			this.dgv_Prod = new AdminClient.CustomDataGridView();
			this.dgv_Comp = new AdminClient.CustomDataGridView();
			this.txt_Note = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pnl_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Comp)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_Main
			// 
			this.pnl_Main.Controls.Add(this.txt_Note);
			this.pnl_Main.Controls.Add(this.label13);
			this.pnl_Main.Controls.Add(this.label14);
			this.pnl_Main.Controls.Add(this.btn_Out);
			this.pnl_Main.Controls.Add(this.label7);
			this.pnl_Main.Controls.Add(this.btn_In);
			this.pnl_Main.Controls.Add(this.label6);
			this.pnl_Main.Controls.Add(this.dgv_AddList);
			this.pnl_Main.Controls.Add(this.label16);
			this.pnl_Main.Controls.Add(this.label15);
			this.pnl_Main.Controls.Add(this.dgv_Prod);
			this.pnl_Main.Controls.Add(this.dgv_Comp);
			this.pnl_Main.Controls.Add(this.txt_WHcode);
			this.pnl_Main.Controls.Add(this.label11);
			this.pnl_Main.Controls.Add(this.txt_OrderCnt);
			this.pnl_Main.Controls.Add(this.label12);
			this.pnl_Main.Controls.Add(this.label2);
			this.pnl_Main.Controls.Add(this.label9);
			this.pnl_Main.Controls.Add(this.btn_Order);
			this.pnl_Main.Controls.Add(this.label8);
			this.pnl_Main.Controls.Add(this.txt_ProdName);
			this.pnl_Main.Controls.Add(this.label10);
			this.pnl_Main.Controls.Add(this.panel1);
			this.pnl_Main.Controls.Add(this.txt_check);
			this.pnl_Main.Controls.Add(this.label1);
			this.pnl_Main.Controls.Add(this.label4);
			this.pnl_Main.Controls.Add(this.btn_Set);
			this.pnl_Main.Size = new System.Drawing.Size(1269, 512);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(185, 43);
			this.lbl_Title.Text = "FormBase";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(1243, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(1291, 7);
			// 
			// btn_Order
			// 
			this.btn_Order.Location = new System.Drawing.Point(345, 447);
			this.btn_Order.Name = "btn_Order";
			this.btn_Order.Size = new System.Drawing.Size(393, 53);
			this.btn_Order.TabIndex = 65;
			this.btn_Order.Text = "발주";
			this.btn_Order.UseVisualStyleBackColor = true;
			this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtp_DueDate);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.txt_OrderCode);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(871, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(347, 90);
			this.panel1.TabIndex = 62;
			// 
			// dtp_DueDate
			// 
			this.dtp_DueDate.Location = new System.Drawing.Point(122, 43);
			this.dtp_DueDate.Name = "dtp_DueDate";
			this.dtp_DueDate.Size = new System.Drawing.Size(188, 25);
			this.dtp_DueDate.TabIndex = 60;
			this.dtp_DueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(4, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 17);
			this.label5.TabIndex = 35;
			this.label5.Text = "◆";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.White;
			this.label19.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label19.Location = new System.Drawing.Point(3, 5);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 17);
			this.label19.TabIndex = 33;
			this.label19.Text = "◆";
			// 
			// txt_OrderCode
			// 
			this.txt_OrderCode.Location = new System.Drawing.Point(122, 2);
			this.txt_OrderCode.Name = "txt_OrderCode";
			this.txt_OrderCode.Size = new System.Drawing.Size(188, 25);
			this.txt_OrderCode.TabIndex = 31;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label20.Location = new System.Drawing.Point(26, 5);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 17);
			this.label20.TabIndex = 30;
			this.label20.Text = "주문번호";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(26, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "납기일";
			// 
			// txt_check
			// 
			this.txt_check.Location = new System.Drawing.Point(878, 239);
			this.txt_check.Multiline = true;
			this.txt_check.Name = "txt_check";
			this.txt_check.Size = new System.Drawing.Size(304, 112);
			this.txt_check.TabIndex = 55;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(898, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 54;
			this.label1.Text = "검사항목";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(875, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 17);
			this.label4.TabIndex = 53;
			this.label4.Text = "◆";
			// 
			// btn_Set
			// 
			this.btn_Set.Location = new System.Drawing.Point(1194, 149);
			this.btn_Set.Name = "btn_Set";
			this.btn_Set.Size = new System.Drawing.Size(67, 25);
			this.btn_Set.TabIndex = 64;
			this.btn_Set.Text = "적용";
			this.btn_Set.UseVisualStyleBackColor = true;
			this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(875, 116);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 17);
			this.label9.TabIndex = 63;
			this.label9.Text = "◆";
			// 
			// txt_ProdName
			// 
			this.txt_ProdName.Location = new System.Drawing.Point(994, 112);
			this.txt_ProdName.Name = "txt_ProdName";
			this.txt_ProdName.Size = new System.Drawing.Size(188, 25);
			this.txt_ProdName.TabIndex = 62;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(898, 116);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 17);
			this.label10.TabIndex = 61;
			this.label10.Text = "물품이름";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(875, 153);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 17);
			this.label11.TabIndex = 68;
			this.label11.Text = "◆";
			// 
			// txt_OrderCnt
			// 
			this.txt_OrderCnt.Location = new System.Drawing.Point(994, 149);
			this.txt_OrderCnt.Name = "txt_OrderCnt";
			this.txt_OrderCnt.Size = new System.Drawing.Size(188, 25);
			this.txt_OrderCnt.TabIndex = 67;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label12.Location = new System.Drawing.Point(898, 153);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(68, 17);
			this.label12.TabIndex = 66;
			this.label12.Text = "주문갯수";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(17, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 17);
			this.label15.TabIndex = 74;
			this.label15.Text = "회사목록";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(269, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 17);
			this.label16.TabIndex = 75;
			this.label16.Text = "품목목록";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(875, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 40;
			this.label8.Text = "◆";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(898, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 41;
			this.label2.Text = "창고";
			// 
			// txt_WHcode
			// 
			this.txt_WHcode.Location = new System.Drawing.Point(994, 186);
			this.txt_WHcode.Name = "txt_WHcode";
			this.txt_WHcode.Size = new System.Drawing.Size(188, 25);
			this.txt_WHcode.TabIndex = 52;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(599, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 77;
			this.label6.Text = "발주목록";
			// 
			// btn_In
			// 
			this.btn_In.Location = new System.Drawing.Point(516, 133);
			this.btn_In.Name = "btn_In";
			this.btn_In.Size = new System.Drawing.Size(74, 53);
			this.btn_In.TabIndex = 78;
			this.btn_In.Text = "추가";
			this.btn_In.UseVisualStyleBackColor = true;
			this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.Color.Crimson;
			this.label7.Location = new System.Drawing.Point(37, 447);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 79;
			this.label7.Text = "주문갯수";
			// 
			// btn_Out
			// 
			this.btn_Out.Location = new System.Drawing.Point(516, 224);
			this.btn_Out.Name = "btn_Out";
			this.btn_Out.Size = new System.Drawing.Size(74, 53);
			this.btn_Out.TabIndex = 80;
			this.btn_Out.Text = "제거";
			this.btn_Out.UseVisualStyleBackColor = true;
			this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
			// 
			// dgv_AddList
			// 
			this.dgv_AddList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_AddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_AddList.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_AddList.GridColor = System.Drawing.Color.Black;
			this.dgv_AddList.IsChkVisible = true;
			this.dgv_AddList.IsEditVisible = false;
			this.dgv_AddList.Location = new System.Drawing.Point(602, 46);
			this.dgv_AddList.Name = "dgv_AddList";
			this.dgv_AddList.RowTemplate.Height = 23;
			this.dgv_AddList.Size = new System.Drawing.Size(234, 365);
			this.dgv_AddList.TabIndex = 76;
			this.dgv_AddList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AddList_CellClick);
			// 
			// dgv_Prod
			// 
			this.dgv_Prod.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Prod.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Prod.GridColor = System.Drawing.Color.Black;
			this.dgv_Prod.IsChkVisible = true;
			this.dgv_Prod.IsEditVisible = false;
			this.dgv_Prod.Location = new System.Drawing.Point(272, 46);
			this.dgv_Prod.Name = "dgv_Prod";
			this.dgv_Prod.RowTemplate.Height = 23;
			this.dgv_Prod.Size = new System.Drawing.Size(234, 365);
			this.dgv_Prod.TabIndex = 73;
			// 
			// dgv_Comp
			// 
			this.dgv_Comp.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Comp.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_Comp.GridColor = System.Drawing.Color.Black;
			this.dgv_Comp.IsChkVisible = false;
			this.dgv_Comp.IsEditVisible = false;
			this.dgv_Comp.Location = new System.Drawing.Point(20, 46);
			this.dgv_Comp.Name = "dgv_Comp";
			this.dgv_Comp.RowTemplate.Height = 23;
			this.dgv_Comp.Size = new System.Drawing.Size(234, 365);
			this.dgv_Comp.TabIndex = 72;
			this.dgv_Comp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Comp_CellClick);
			// 
			// txt_Note
			// 
			this.txt_Note.Location = new System.Drawing.Point(878, 384);
			this.txt_Note.Multiline = true;
			this.txt_Note.Name = "txt_Note";
			this.txt_Note.Size = new System.Drawing.Size(304, 112);
			this.txt_Note.TabIndex = 83;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(898, 364);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 17);
			this.label13.TabIndex = 82;
			this.label13.Text = "메모";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(875, 364);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(23, 17);
			this.label14.TabIndex = 81;
			this.label14.Text = "◆";
			// 
			// OrderPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(1279, 570);
			this.Name = "OrderPopUp";
			this.Load += new System.EventHandler(this.OrderPopUp_Load);
			this.pnl_Main.ResumeLayout(false);
			this.pnl_Main.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Comp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_OrderCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_OrderCnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private CustomDataGridView dgv_Prod;
        private CustomDataGridView dgv_Comp;
        private System.Windows.Forms.TextBox txt_WHcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Label label6;
        private CustomDataGridView dgv_AddList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
