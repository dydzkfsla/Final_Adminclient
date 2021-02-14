namespace AdminClient.Serch
{
    partial class ProductSearch
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
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Unit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_ProdList = new AdminClient.CustomDataGridView();
            this.dgv_AddList = new AdminClient.CustomDataGridView();
            this.schCtrl = new AdminClient.SearchControl();
            this.sortCtrl = new AdminClient.SortControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_ProdList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_AddList);
            this.splitContainer2.Size = new System.Drawing.Size(903, 686);
            this.splitContainer2.SplitterDistance = 361;
            this.splitContainer2.SplitterWidth = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1163, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1246, 9);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1331, 64);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(169, 43);
            this.lbl_Title.Text = "물품 추가";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Main.Size = new System.Drawing.Size(1349, 767);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Controls.Add(this.label4);
            this.gb_Sherch.Controls.Add(this.cbo_Unit);
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.cbo_Category);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Size = new System.Drawing.Size(356, 260);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Category, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Unit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label4, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Controls.Add(this.comboBox6);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.comboBox8);
            this.gb_detail.Controls.Add(this.label6);
            this.gb_detail.Controls.Add(this.comboBox10);
            this.gb_detail.Controls.Add(this.label8);
            this.gb_detail.Controls.Add(this.comboBox11);
            this.gb_detail.Controls.Add(this.label9);
            this.gb_detail.Location = new System.Drawing.Point(11, 266);
            this.gb_detail.Size = new System.Drawing.Size(356, 418);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1349, 686);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.SplitterWidth = 6;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 300);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 686);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(257, 18);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1327, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1438, 7);
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(12, 174);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(225, 25);
            this.cbo_State.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "단종여부";
            // 
            // cbo_Unit
            // 
            this.cbo_Unit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Unit.FormattingEnabled = true;
            this.cbo_Unit.Location = new System.Drawing.Point(12, 120);
            this.cbo_Unit.Name = "cbo_Unit";
            this.cbo_Unit.Size = new System.Drawing.Size(225, 25);
            this.cbo_Unit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "단위";
            // 
            // cbo_Category
            // 
            this.cbo_Category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(12, 72);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(225, 25);
            this.cbo_Category.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "카테고리";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(23, 372);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(225, 25);
            this.comboBox6.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "단종여부";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(23, 324);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(225, 25);
            this.comboBox8.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "검사여부";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(23, 276);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(225, 25);
            this.comboBox10.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "단위";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(23, 228);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(225, 25);
            this.comboBox11.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 47;
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
            this.dgv_ProdList.IsChkVisible = true;
            this.dgv_ProdList.IsEditVisible = false;
            this.dgv_ProdList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ProdList.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_ProdList.Name = "dgv_ProdList";
            this.dgv_ProdList.RowHeadersVisible = false;
            this.dgv_ProdList.RowTemplate.Height = 23;
            this.dgv_ProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdList.Size = new System.Drawing.Size(902, 315);
            this.dgv_ProdList.TabIndex = 1;
            // 
            // dgv_AddList
            // 
            this.dgv_AddList.AllowUserToAddRows = false;
            this.dgv_AddList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AddList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AddList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AddList.GridColor = System.Drawing.Color.Black;
            this.dgv_AddList.IsChkVisible = true;
            this.dgv_AddList.IsEditVisible = false;
            this.dgv_AddList.Location = new System.Drawing.Point(0, 0);
            this.dgv_AddList.Name = "dgv_AddList";
            this.dgv_AddList.RowHeadersVisible = false;
            this.dgv_AddList.RowTemplate.Height = 23;
            this.dgv_AddList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AddList.Size = new System.Drawing.Size(903, 319);
            this.dgv_AddList.TabIndex = 2;
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(12, 34);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(320, 75);
            this.schCtrl.TabIndex = 55;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(12, 117);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 56;
            // 
            // ProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1359, 866);
            this.Name = "ProductSearch";
            this.Load += new System.EventHandler(this.ProductSearch_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_ProdList;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label9;
        private CustomDataGridView dgv_AddList;
        private SortControl sortCtrl;
        private SearchControl schCtrl;
    }
}
