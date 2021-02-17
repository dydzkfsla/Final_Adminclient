namespace AdminClient.Forms
{
    partial class OrderInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_3Month = new System.Windows.Forms.RadioButton();
            this.rb_1Month = new System.Windows.Forms.RadioButton();
            this.rb_OneWeek = new System.Windows.Forms.RadioButton();
            this.rb_Today = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dgv_Odlist = new AdminClient.CustomDataGridView();
            this.dgv_oddList = new AdminClient.CustomDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ProdCode = new System.Windows.Forms.TextBox();
            this.txt_OrderCnt = new System.Windows.Forms.TextBox();
            this.txt_RqCnt = new System.Windows.Forms.TextBox();
            this.txt_CqCnt = new System.Windows.Forms.TextBox();
            this.btn_ProdDelete = new System.Windows.Forms.Button();
            this.btn_ProdUpdate = new System.Windows.Forms.Button();
            this.schCtrl = new AdminClient.SearchControl();
            this.sortCtrl = new AdminClient.SortControl();
            this.epv_dtpvalue = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_odMenu = new System.Windows.Forms.GroupBox();
            this.btn_OdMenu = new System.Windows.Forms.Button();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lbl_unit3 = new System.Windows.Forms.Label();
            this.lbl_unit2 = new System.Windows.Forms.Label();
            this.lbl_unit1 = new System.Windows.Forms.Label();
            this.btn_ProdIN = new System.Windows.Forms.Button();
            this.btn_ProdAdd = new System.Windows.Forms.Button();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.txt_OdCode = new System.Windows.Forms.TextBox();
            this.lblblblb = new System.Windows.Forms.Label();
            this.gb_ProdInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Odlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oddList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_dtpvalue)).BeginInit();
            this.gb_odMenu.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.gb_ProdInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgv_oddList);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gb_odMenu);
            this.splitContainer3.Panel2.Controls.Add(this.gb_ProdInfo);
            this.splitContainer3.Size = new System.Drawing.Size(1244, 548);
            this.splitContainer3.SplitterDistance = 883;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_Odlist);
            this.splitContainer2.Size = new System.Drawing.Size(1244, 857);
            this.splitContainer2.SplitterDistance = 303;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1468, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
            this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_OdCode);
            this.panel1.Controls.Add(this.lblblblb);
            this.panel1.Size = new System.Drawing.Size(1636, 64);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.lblblblb, 0);
            this.panel1.Controls.SetChildIndex(this.txt_OdCode, 0);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Controls.Add(this.groupBox1);
            this.gb_Sherch.Size = new System.Drawing.Size(348, 208);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Location = new System.Drawing.Point(11, 224);
            this.gb_detail.Size = new System.Drawing.Size(348, 194);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(134, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1654, 860);
            this.splitContainer1.SplitterDistance = 373;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 476);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 860);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(257, 17);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1633, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1744, 7);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_3Month);
            this.groupBox1.Controls.Add(this.rb_1Month);
            this.groupBox1.Controls.Add(this.rb_OneWeek);
            this.groupBox1.Controls.Add(this.rb_Today);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "납기일";
            // 
            // rb_3Month
            // 
            this.rb_3Month.AutoSize = true;
            this.rb_3Month.Location = new System.Drawing.Point(226, 63);
            this.rb_3Month.Name = "rb_3Month";
            this.rb_3Month.Size = new System.Drawing.Size(49, 21);
            this.rb_3Month.TabIndex = 9;
            this.rb_3Month.TabStop = true;
            this.rb_3Month.Text = "3달";
            this.rb_3Month.UseVisualStyleBackColor = true;
            this.rb_3Month.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_1Month
            // 
            this.rb_1Month.AutoSize = true;
            this.rb_1Month.Location = new System.Drawing.Point(160, 63);
            this.rb_1Month.Name = "rb_1Month";
            this.rb_1Month.Size = new System.Drawing.Size(49, 21);
            this.rb_1Month.TabIndex = 8;
            this.rb_1Month.TabStop = true;
            this.rb_1Month.Text = "1달";
            this.rb_1Month.UseVisualStyleBackColor = true;
            this.rb_1Month.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_OneWeek
            // 
            this.rb_OneWeek.AutoSize = true;
            this.rb_OneWeek.Location = new System.Drawing.Point(87, 63);
            this.rb_OneWeek.Name = "rb_OneWeek";
            this.rb_OneWeek.Size = new System.Drawing.Size(49, 21);
            this.rb_OneWeek.TabIndex = 7;
            this.rb_OneWeek.TabStop = true;
            this.rb_OneWeek.Text = "1주";
            this.rb_OneWeek.UseVisualStyleBackColor = true;
            this.rb_OneWeek.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_Today
            // 
            this.rb_Today.AutoSize = true;
            this.rb_Today.Location = new System.Drawing.Point(14, 63);
            this.rb_Today.Name = "rb_Today";
            this.rb_Today.Size = new System.Drawing.Size(54, 21);
            this.rb_Today.TabIndex = 6;
            this.rb_Today.TabStop = true;
            this.rb_Today.Text = "당일";
            this.rb_Today.UseVisualStyleBackColor = true;
            this.rb_Today.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(160, 24);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(108, 25);
            this.dtp_end.TabIndex = 4;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(22, 24);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(108, 25);
            this.dtp_start.TabIndex = 3;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dgv_Odlist
            // 
            this.dgv_Odlist.AllowUserToAddRows = false;
            this.dgv_Odlist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Odlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Odlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Odlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Odlist.GridColor = System.Drawing.Color.Black;
            this.dgv_Odlist.IsChkVisible = false;
            this.dgv_Odlist.IsEditVisible = false;
            this.dgv_Odlist.Location = new System.Drawing.Point(0, 0);
            this.dgv_Odlist.Name = "dgv_Odlist";
            this.dgv_Odlist.RowHeadersVisible = false;
            this.dgv_Odlist.RowTemplate.Height = 23;
            this.dgv_Odlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Odlist.Size = new System.Drawing.Size(1244, 303);
            this.dgv_Odlist.TabIndex = 0;
            this.dgv_Odlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Odlist_CellClick);
            this.dgv_Odlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Odlist_CellContentClick);
            // 
            // dgv_oddList
            // 
            this.dgv_oddList.AllowUserToAddRows = false;
            this.dgv_oddList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_oddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_oddList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_oddList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_oddList.GridColor = System.Drawing.Color.Black;
            this.dgv_oddList.IsChkVisible = false;
            this.dgv_oddList.IsEditVisible = false;
            this.dgv_oddList.Location = new System.Drawing.Point(0, 0);
            this.dgv_oddList.Name = "dgv_oddList";
            this.dgv_oddList.RowHeadersVisible = false;
            this.dgv_oddList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_oddList.Size = new System.Drawing.Size(883, 548);
            this.dgv_oddList.TabIndex = 0;
            this.dgv_oddList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_oddList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "주문수량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "입고수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "취소수량";
            // 
            // txt_ProdCode
            // 
            this.txt_ProdCode.Location = new System.Drawing.Point(70, 5);
            this.txt_ProdCode.Name = "txt_ProdCode";
            this.txt_ProdCode.Size = new System.Drawing.Size(176, 25);
            this.txt_ProdCode.TabIndex = 4;
            // 
            // txt_OrderCnt
            // 
            this.txt_OrderCnt.Location = new System.Drawing.Point(70, 36);
            this.txt_OrderCnt.Name = "txt_OrderCnt";
            this.txt_OrderCnt.Size = new System.Drawing.Size(176, 25);
            this.txt_OrderCnt.TabIndex = 5;
            // 
            // txt_RqCnt
            // 
            this.txt_RqCnt.Location = new System.Drawing.Point(70, 67);
            this.txt_RqCnt.Name = "txt_RqCnt";
            this.txt_RqCnt.Size = new System.Drawing.Size(176, 25);
            this.txt_RqCnt.TabIndex = 6;
            // 
            // txt_CqCnt
            // 
            this.txt_CqCnt.Location = new System.Drawing.Point(70, 98);
            this.txt_CqCnt.Name = "txt_CqCnt";
            this.txt_CqCnt.Size = new System.Drawing.Size(176, 25);
            this.txt_CqCnt.TabIndex = 7;
            // 
            // btn_ProdDelete
            // 
            this.btn_ProdDelete.Location = new System.Drawing.Point(3, 181);
            this.btn_ProdDelete.Name = "btn_ProdDelete";
            this.btn_ProdDelete.Size = new System.Drawing.Size(292, 39);
            this.btn_ProdDelete.TabIndex = 16;
            this.btn_ProdDelete.Text = "삭제";
            this.btn_ProdDelete.UseVisualStyleBackColor = true;
            this.btn_ProdDelete.Click += new System.EventHandler(this.btn_ProdDelete_Click);
            // 
            // btn_ProdUpdate
            // 
            this.btn_ProdUpdate.Location = new System.Drawing.Point(3, 233);
            this.btn_ProdUpdate.Name = "btn_ProdUpdate";
            this.btn_ProdUpdate.Size = new System.Drawing.Size(292, 39);
            this.btn_ProdUpdate.TabIndex = 15;
            this.btn_ProdUpdate.UseVisualStyleBackColor = true;
            this.btn_ProdUpdate.Click += new System.EventHandler(this.btn_ProdUpdate_Click);
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(6, 24);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(320, 75);
            this.schCtrl.TabIndex = 0;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(6, 107);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 1;
            // 
            // epv_dtpvalue
            // 
            this.epv_dtpvalue.ContainerControl = this;
            // 
            // gb_odMenu
            // 
            this.gb_odMenu.Controls.Add(this.btn_OdMenu);
            this.gb_odMenu.Location = new System.Drawing.Point(12, 371);
            this.gb_odMenu.Name = "gb_odMenu";
            this.gb_odMenu.Size = new System.Drawing.Size(312, 96);
            this.gb_odMenu.TabIndex = 2;
            this.gb_odMenu.TabStop = false;
            this.gb_odMenu.Text = "OrderMenu";
            // 
            // btn_OdMenu
            // 
            this.btn_OdMenu.Location = new System.Drawing.Point(8, 34);
            this.btn_OdMenu.Name = "btn_OdMenu";
            this.btn_OdMenu.Size = new System.Drawing.Size(292, 46);
            this.btn_OdMenu.TabIndex = 0;
            this.btn_OdMenu.UseVisualStyleBackColor = true;
            this.btn_OdMenu.Click += new System.EventHandler(this.btn_OdMenu_Click);
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.lbl_unit3);
            this.pnl_Info.Controls.Add(this.lbl_unit2);
            this.pnl_Info.Controls.Add(this.lbl_unit1);
            this.pnl_Info.Controls.Add(this.btn_ProdIN);
            this.pnl_Info.Controls.Add(this.btn_ProdDelete);
            this.pnl_Info.Controls.Add(this.btn_ProdUpdate);
            this.pnl_Info.Controls.Add(this.btn_ProdAdd);
            this.pnl_Info.Controls.Add(this.txt_CqCnt);
            this.pnl_Info.Controls.Add(this.txt_RqCnt);
            this.pnl_Info.Controls.Add(this.txt_OrderCnt);
            this.pnl_Info.Controls.Add(this.txt_ProdCode);
            this.pnl_Info.Controls.Add(this.label8);
            this.pnl_Info.Controls.Add(this.label7);
            this.pnl_Info.Controls.Add(this.label6);
            this.pnl_Info.Controls.Add(this.label1);
            this.pnl_Info.Location = new System.Drawing.Point(6, 24);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(303, 328);
            this.pnl_Info.TabIndex = 17;
            // 
            // lbl_unit3
            // 
            this.lbl_unit3.AutoSize = true;
            this.lbl_unit3.Location = new System.Drawing.Point(251, 106);
            this.lbl_unit3.Name = "lbl_unit3";
            this.lbl_unit3.Size = new System.Drawing.Size(0, 17);
            this.lbl_unit3.TabIndex = 20;
            // 
            // lbl_unit2
            // 
            this.lbl_unit2.AutoSize = true;
            this.lbl_unit2.Location = new System.Drawing.Point(251, 75);
            this.lbl_unit2.Name = "lbl_unit2";
            this.lbl_unit2.Size = new System.Drawing.Size(0, 17);
            this.lbl_unit2.TabIndex = 19;
            // 
            // lbl_unit1
            // 
            this.lbl_unit1.AutoSize = true;
            this.lbl_unit1.Location = new System.Drawing.Point(251, 44);
            this.lbl_unit1.Name = "lbl_unit1";
            this.lbl_unit1.Size = new System.Drawing.Size(0, 17);
            this.lbl_unit1.TabIndex = 18;
            // 
            // btn_ProdIN
            // 
            this.btn_ProdIN.Location = new System.Drawing.Point(3, 285);
            this.btn_ProdIN.Name = "btn_ProdIN";
            this.btn_ProdIN.Size = new System.Drawing.Size(292, 39);
            this.btn_ProdIN.TabIndex = 17;
            this.btn_ProdIN.Text = "부분입고";
            this.btn_ProdIN.UseVisualStyleBackColor = true;
            this.btn_ProdIN.Click += new System.EventHandler(this.btn_ProdIN_Click);
            // 
            // btn_ProdAdd
            // 
            this.btn_ProdAdd.Location = new System.Drawing.Point(3, 129);
            this.btn_ProdAdd.Name = "btn_ProdAdd";
            this.btn_ProdAdd.Size = new System.Drawing.Size(292, 39);
            this.btn_ProdAdd.TabIndex = 14;
            this.btn_ProdAdd.Text = "물품추가";
            this.btn_ProdAdd.UseVisualStyleBackColor = true;
            this.btn_ProdAdd.Click += new System.EventHandler(this.btn_ProdAdd_Click);
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(12, 56);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(225, 25);
            this.cbo_State.TabIndex = 8;
            // 
            // txt_OdCode
            // 
            this.txt_OdCode.Location = new System.Drawing.Point(302, 21);
            this.txt_OdCode.Name = "txt_OdCode";
            this.txt_OdCode.Size = new System.Drawing.Size(192, 25);
            this.txt_OdCode.TabIndex = 20;
            this.txt_OdCode.Visible = false;
            // 
            // lblblblb
            // 
            this.lblblblb.AutoSize = true;
            this.lblblblb.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblblblb.ForeColor = System.Drawing.Color.White;
            this.lblblblb.Location = new System.Drawing.Point(228, 25);
            this.lblblblb.Name = "lblblblb";
            this.lblblblb.Size = new System.Drawing.Size(68, 17);
            this.lblblblb.TabIndex = 19;
            this.lblblblb.Text = "발주번호";
            this.lblblblb.Visible = false;
            // 
            // gb_ProdInfo
            // 
            this.gb_ProdInfo.Controls.Add(this.pnl_Info);
            this.gb_ProdInfo.Location = new System.Drawing.Point(12, 7);
            this.gb_ProdInfo.Name = "gb_ProdInfo";
            this.gb_ProdInfo.Size = new System.Drawing.Size(312, 358);
            this.gb_ProdInfo.TabIndex = 21;
            this.gb_ProdInfo.TabStop = false;
            this.gb_ProdInfo.Text = "ProductMenu";
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.gb_Sherch.ResumeLayout(false);
            this.gb_Sherch.PerformLayout();
            this.gb_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Odlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oddList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_dtpvalue)).EndInit();
            this.gb_odMenu.ResumeLayout(false);
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.gb_ProdInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private CustomDataGridView dgv_oddList;
        private System.Windows.Forms.TextBox txt_CqCnt;
        private System.Windows.Forms.TextBox txt_RqCnt;
        private System.Windows.Forms.TextBox txt_OrderCnt;
        private System.Windows.Forms.TextBox txt_ProdCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_Odlist;
        private System.Windows.Forms.Button btn_ProdDelete;
        private System.Windows.Forms.Button btn_ProdUpdate;
        private SortControl sortCtrl;
        private SearchControl schCtrl;
        private System.Windows.Forms.RadioButton rb_3Month;
        private System.Windows.Forms.RadioButton rb_1Month;
        private System.Windows.Forms.RadioButton rb_OneWeek;
        private System.Windows.Forms.RadioButton rb_Today;
        private System.Windows.Forms.ErrorProvider epv_dtpvalue;
        private System.Windows.Forms.GroupBox gb_odMenu;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Button btn_OdMenu;
        private System.Windows.Forms.Button btn_ProdAdd;
        private System.Windows.Forms.TextBox txt_OdCode;
        private System.Windows.Forms.Label lblblblb;
        private System.Windows.Forms.Button btn_ProdIN;
        private System.Windows.Forms.Label lbl_unit3;
        private System.Windows.Forms.Label lbl_unit2;
        private System.Windows.Forms.Label lbl_unit1;
        private System.Windows.Forms.GroupBox gb_ProdInfo;
    }
}
