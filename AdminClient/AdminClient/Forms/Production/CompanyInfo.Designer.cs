namespace AdminClient.Forms
{
    partial class CompanyInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Auto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CEO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblblblbl = new System.Windows.Forms.Label();
            this.btn_ProdAdd = new System.Windows.Forms.Button();
            this.txt_Prod_Code = new System.Windows.Forms.TextBox();
            this.txt_Prod_Name = new System.Windows.Forms.TextBox();
            this.txt_Prod_SafetyStock = new System.Windows.Forms.TextBox();
            this.txt_Prod_MinCount = new System.Windows.Forms.TextBox();
            this.dgv_CompList = new AdminClient.CustomDataGridView();
            this.schCtrl = new AdminClient.SearchControl();
            this.sortCtrl = new AdminClient.SortControl();
            this.txt_Prod_Unit = new System.Windows.Forms.TextBox();
            this.btn_ProdUpdate = new System.Windows.Forms.Button();
            this.txt_totCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Prod_WhCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Prod_UnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_AllInfo = new System.Windows.Forms.Panel();
            this.cbo_itemState = new System.Windows.Forms.ComboBox();
            this.dgv_detail = new AdminClient.CustomDataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompList)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_AllInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label15);
            this.splitContainer3.Panel1.Controls.Add(this.dgv_detail);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pnl_AllInfo);
            this.splitContainer3.Panel2.Controls.Add(this.btn_ProdUpdate);
            this.splitContainer3.Panel2.Controls.Add(this.btn_ProdAdd);
            this.splitContainer3.Size = new System.Drawing.Size(1222, 469);
            this.splitContainer3.SplitterDistance = 999;
            this.splitContainer3.SplitterWidth = 8;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.dgv_CompList);
            this.splitContainer2.Size = new System.Drawing.Size(1222, 857);
            this.splitContainer2.SplitterDistance = 382;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1439, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1536, 9);
            this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Type);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_CEO);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_Code);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Size = new System.Drawing.Size(1638, 64);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
            this.panel1.Controls.SetChildIndex(this.label9, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Name, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.txt_CEO, 0);
            this.panel1.Controls.SetChildIndex(this.label11, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Type, 0);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.cbo_Type);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Controls.Add(this.label3);
            this.gb_Sherch.Controls.Add(this.cbo_Auto);
            this.gb_Sherch.Size = new System.Drawing.Size(348, 211);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Auto, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Type, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Location = new System.Drawing.Point(12, 217);
            this.gb_detail.Size = new System.Drawing.Size(348, 462);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(144, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1650, 860);
            this.splitContainer1.SplitterDistance = 398;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 387);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 860);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(269, 18);
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1633, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1744, 7);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "출하 자동여부";
            // 
            // cbo_Auto
            // 
            this.cbo_Auto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Auto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Auto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Auto.FormattingEnabled = true;
            this.cbo_Auto.Location = new System.Drawing.Point(9, 68);
            this.cbo_Auto.Name = "cbo_Auto";
            this.cbo_Auto.Size = new System.Drawing.Size(234, 25);
            this.cbo_Auto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "사용유무";
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(9, 116);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(234, 25);
            this.cbo_State.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "업종";
            // 
            // cbo_Type
            // 
            this.cbo_Type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(9, 164);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(234, 25);
            this.cbo_Type.TabIndex = 13;
            // 
            // txt_Code
            // 
            this.txt_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Code.Location = new System.Drawing.Point(433, 21);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(145, 25);
            this.txt_Code.TabIndex = 7;
            this.txt_Code.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "업체코드";
            this.label8.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Location = new System.Drawing.Point(670, 21);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 25);
            this.txt_Name.TabIndex = 9;
            this.txt_Name.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(611, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "업체명";
            this.label9.Visible = false;
            // 
            // txt_CEO
            // 
            this.txt_CEO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CEO.Location = new System.Drawing.Point(912, 21);
            this.txt_CEO.Name = "txt_CEO";
            this.txt_CEO.Size = new System.Drawing.Size(145, 25);
            this.txt_CEO.TabIndex = 11;
            this.txt_CEO.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(853, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "대표명";
            this.label10.Visible = false;
            // 
            // txt_Type
            // 
            this.txt_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Type.Location = new System.Drawing.Point(1142, 21);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(145, 25);
            this.txt_Type.TabIndex = 13;
            this.txt_Type.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1098, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "업종";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(6, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "품목코드";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "품목이름";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(8, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "단위";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(6, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "창고";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(8, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "안전재고량";
            // 
            // lblblblbl
            // 
            this.lblblblbl.AutoSize = true;
            this.lblblblbl.Location = new System.Drawing.Point(21, 222);
            this.lblblblbl.Name = "lblblblbl";
            this.lblblblbl.Size = new System.Drawing.Size(78, 17);
            this.lblblblbl.TabIndex = 6;
            this.lblblblbl.Text = "최소주문량";
            // 
            // btn_ProdAdd
            // 
            this.btn_ProdAdd.Location = new System.Drawing.Point(101, 10);
            this.btn_ProdAdd.Name = "btn_ProdAdd";
            this.btn_ProdAdd.Size = new System.Drawing.Size(72, 39);
            this.btn_ProdAdd.TabIndex = 7;
            this.btn_ProdAdd.Text = "추가";
            this.btn_ProdAdd.UseVisualStyleBackColor = true;
            this.btn_ProdAdd.Click += new System.EventHandler(this.btn_ProdAdd_Click);
            // 
            // txt_Prod_Code
            // 
            this.txt_Prod_Code.Location = new System.Drawing.Point(88, 8);
            this.txt_Prod_Code.Name = "txt_Prod_Code";
            this.txt_Prod_Code.Size = new System.Drawing.Size(196, 25);
            this.txt_Prod_Code.TabIndex = 8;
            // 
            // txt_Prod_Name
            // 
            this.txt_Prod_Name.Location = new System.Drawing.Point(88, 41);
            this.txt_Prod_Name.Name = "txt_Prod_Name";
            this.txt_Prod_Name.Size = new System.Drawing.Size(196, 25);
            this.txt_Prod_Name.TabIndex = 9;
            // 
            // txt_Prod_SafetyStock
            // 
            this.txt_Prod_SafetyStock.Location = new System.Drawing.Point(87, 173);
            this.txt_Prod_SafetyStock.Name = "txt_Prod_SafetyStock";
            this.txt_Prod_SafetyStock.Size = new System.Drawing.Size(197, 25);
            this.txt_Prod_SafetyStock.TabIndex = 13;
            // 
            // txt_Prod_MinCount
            // 
            this.txt_Prod_MinCount.Location = new System.Drawing.Point(100, 218);
            this.txt_Prod_MinCount.Name = "txt_Prod_MinCount";
            this.txt_Prod_MinCount.Size = new System.Drawing.Size(197, 25);
            this.txt_Prod_MinCount.TabIndex = 14;
            // 
            // dgv_CompList
            // 
            this.dgv_CompList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CompList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CompList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CompList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CompList.GridColor = System.Drawing.Color.Black;
            this.dgv_CompList.IsChkVisible = true;
            this.dgv_CompList.IsEditVisible = true;
            this.dgv_CompList.Location = new System.Drawing.Point(0, 25);
            this.dgv_CompList.Name = "dgv_CompList";
            this.dgv_CompList.RowTemplate.Height = 23;
            this.dgv_CompList.Size = new System.Drawing.Size(1222, 357);
            this.dgv_CompList.TabIndex = 0;
            this.dgv_CompList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CompList_CellClick);
            this.dgv_CompList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CompList_CellContentClick);
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(11, 24);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(333, 81);
            this.schCtrl.TabIndex = 32;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(11, 113);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 33;
            // 
            // txt_Prod_Unit
            // 
            this.txt_Prod_Unit.Location = new System.Drawing.Point(88, 74);
            this.txt_Prod_Unit.Name = "txt_Prod_Unit";
            this.txt_Prod_Unit.Size = new System.Drawing.Size(196, 25);
            this.txt_Prod_Unit.TabIndex = 19;
            // 
            // btn_ProdUpdate
            // 
            this.btn_ProdUpdate.Location = new System.Drawing.Point(196, 10);
            this.btn_ProdUpdate.Name = "btn_ProdUpdate";
            this.btn_ProdUpdate.Size = new System.Drawing.Size(72, 39);
            this.btn_ProdUpdate.TabIndex = 20;
            this.btn_ProdUpdate.Text = "수정";
            this.btn_ProdUpdate.UseVisualStyleBackColor = true;
            this.btn_ProdUpdate.Click += new System.EventHandler(this.btn_ProdUpdate_Click);
            // 
            // txt_totCount
            // 
            this.txt_totCount.Location = new System.Drawing.Point(88, 107);
            this.txt_totCount.Name = "txt_totCount";
            this.txt_totCount.Size = new System.Drawing.Size(196, 25);
            this.txt_totCount.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "현재고량";
            // 
            // txt_Prod_WhCode
            // 
            this.txt_Prod_WhCode.Location = new System.Drawing.Point(87, 140);
            this.txt_Prod_WhCode.Name = "txt_Prod_WhCode";
            this.txt_Prod_WhCode.Size = new System.Drawing.Size(196, 25);
            this.txt_Prod_WhCode.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "단위당가격";
            // 
            // txt_Prod_UnitPrice
            // 
            this.txt_Prod_UnitPrice.Location = new System.Drawing.Point(100, 251);
            this.txt_Prod_UnitPrice.Name = "txt_Prod_UnitPrice";
            this.txt_Prod_UnitPrice.Size = new System.Drawing.Size(197, 25);
            this.txt_Prod_UnitPrice.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "단종여부";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Prod_WhCode);
            this.panel2.Controls.Add(this.txt_totCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Prod_Unit);
            this.panel2.Controls.Add(this.txt_Prod_SafetyStock);
            this.panel2.Controls.Add(this.txt_Prod_Name);
            this.panel2.Controls.Add(this.txt_Prod_Code);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 207);
            this.panel2.TabIndex = 28;
            // 
            // pnl_AllInfo
            // 
            this.pnl_AllInfo.Controls.Add(this.panel2);
            this.pnl_AllInfo.Controls.Add(this.label6);
            this.pnl_AllInfo.Controls.Add(this.txt_Prod_UnitPrice);
            this.pnl_AllInfo.Controls.Add(this.cbo_itemState);
            this.pnl_AllInfo.Controls.Add(this.label5);
            this.pnl_AllInfo.Controls.Add(this.txt_Prod_MinCount);
            this.pnl_AllInfo.Controls.Add(this.lblblblbl);
            this.pnl_AllInfo.Location = new System.Drawing.Point(17, 62);
            this.pnl_AllInfo.Name = "pnl_AllInfo";
            this.pnl_AllInfo.Size = new System.Drawing.Size(318, 320);
            this.pnl_AllInfo.TabIndex = 30;
            // 
            // cbo_itemState
            // 
            this.cbo_itemState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_itemState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_itemState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_itemState.FormattingEnabled = true;
            this.cbo_itemState.Location = new System.Drawing.Point(99, 285);
            this.cbo_itemState.Name = "cbo_itemState";
            this.cbo_itemState.Size = new System.Drawing.Size(196, 25);
            this.cbo_itemState.TabIndex = 15;
            // 
            // dgv_detail
            // 
            this.dgv_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detail.BackgroundColor = System.Drawing.Color.White;
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detail.GridColor = System.Drawing.Color.Black;
            this.dgv_detail.IsChkVisible = false;
            this.dgv_detail.IsEditVisible = false;
            this.dgv_detail.Location = new System.Drawing.Point(3, 26);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowTemplate.Height = 23;
            this.dgv_detail.Size = new System.Drawing.Size(984, 440);
            this.dgv_detail.TabIndex = 0;
            this.dgv_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detail_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "업체 목록";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "업체별 취급품목";
            // 
            // CompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "CompanyInfo";
            this.Load += new System.EventHandler(this.CompanyInfo_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_AllInfo.ResumeLayout(false);
            this.pnl_AllInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Auto;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CEO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Prod_MinCount;
        private System.Windows.Forms.TextBox txt_Prod_SafetyStock;
        private System.Windows.Forms.TextBox txt_Prod_Name;
        private System.Windows.Forms.TextBox txt_Prod_Code;
        private System.Windows.Forms.Button btn_ProdAdd;
        private System.Windows.Forms.Label lblblblbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CustomDataGridView dgv_CompList;
        private SearchControl schCtrl;
        private SortControl sortCtrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Prod_UnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Prod_WhCode;
        private System.Windows.Forms.TextBox txt_totCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ProdUpdate;
        private System.Windows.Forms.TextBox txt_Prod_Unit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_AllInfo;
        private System.Windows.Forms.ComboBox cbo_itemState;
        private CustomDataGridView dgv_detail;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label7;
	}
}
