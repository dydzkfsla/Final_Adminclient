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
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dgv_ProdList = new AdminClient.CustomDataGridView();
			this.txt_Wh = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_Cate = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.schCtrl = new AdminClient.SearchControl();
			this.sortCtrl = new AdminClient.SortControl();
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
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_Wh);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txt_Cate);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txt_Name);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txt_Code);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
			this.panel1.Controls.SetChildIndex(this.label12, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Name, 0);
			this.panel1.Controls.SetChildIndex(this.label10, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Cate, 0);
			this.panel1.Controls.SetChildIndex(this.label11, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Wh, 0);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_State);
			this.gb_Sherch.Controls.Add(this.label4);
			this.gb_Sherch.Controls.Add(this.cbo_Unit);
			this.gb_Sherch.Controls.Add(this.label2);
			this.gb_Sherch.Controls.Add(this.cbo_Category);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 213);
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
			this.gb_detail.Controls.Add(this.label7);
			this.gb_detail.Location = new System.Drawing.Point(12, 228);
			this.gb_detail.Size = new System.Drawing.Size(348, 231);
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
			this.splitContainer1.SplitterDistance = 395;
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(260, 17);
			this.btn_search.Click += new System.EventHandler(this.button1_Click);
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
			// cbo_State
			// 
			this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(12, 165);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(225, 25);
			this.cbo_State.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "단종여부";
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
			this.dgv_ProdList.IsEditVisible = true;
			this.dgv_ProdList.Location = new System.Drawing.Point(33, 3);
			this.dgv_ProdList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.dgv_ProdList.Name = "dgv_ProdList";
			this.dgv_ProdList.RowHeadersVisible = false;
			this.dgv_ProdList.RowTemplate.Height = 23;
			this.dgv_ProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_ProdList.Size = new System.Drawing.Size(1216, 838);
			this.dgv_ProdList.TabIndex = 3;
			this.dgv_ProdList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProdList_CellClick);
			this.dgv_ProdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProdList_CellContentClick);
			// 
			// txt_Wh
			// 
			this.txt_Wh.Location = new System.Drawing.Point(1113, 21);
			this.txt_Wh.Name = "txt_Wh";
			this.txt_Wh.Size = new System.Drawing.Size(145, 25);
			this.txt_Wh.TabIndex = 21;
			this.txt_Wh.Visible = false;
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
			this.label11.Visible = false;
			// 
			// txt_Cate
			// 
			this.txt_Cate.Location = new System.Drawing.Point(883, 21);
			this.txt_Cate.Name = "txt_Cate";
			this.txt_Cate.Size = new System.Drawing.Size(145, 25);
			this.txt_Cate.TabIndex = 19;
			this.txt_Cate.Visible = false;
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
			this.label10.Visible = false;
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(641, 21);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(145, 25);
			this.txt_Name.TabIndex = 17;
			this.txt_Name.Visible = false;
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
			this.label12.Text = "품목이름";
			this.label12.Visible = false;
			// 
			// txt_Code
			// 
			this.txt_Code.Location = new System.Drawing.Point(404, 21);
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.Size = new System.Drawing.Size(145, 25);
			this.txt_Code.TabIndex = 15;
			this.txt_Code.Visible = false;
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
			this.label13.Text = "품목코드";
			this.label13.Visible = false;
			// 
			// schCtrl
			// 
			this.schCtrl.BackColor = System.Drawing.Color.Transparent;
			this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.schCtrl.Location = new System.Drawing.Point(8, 48);
			this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.schCtrl.Name = "schCtrl";
			this.schCtrl.Size = new System.Drawing.Size(325, 69);
			this.schCtrl.TabIndex = 47;
			// 
			// sortCtrl
			// 
			this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
			this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortCtrl.Location = new System.Drawing.Point(8, 125);
			this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.sortCtrl.Name = "sortCtrl";
			this.sortCtrl.Size = new System.Drawing.Size(325, 69);
			this.sortCtrl.TabIndex = 48;
			// 
			// ProductInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(1665, 1025);
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
        private System.Windows.Forms.ComboBox cbo_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private CustomDataGridView dgv_ProdList;
        private System.Windows.Forms.TextBox txt_Wh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Cate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label13;
        private SearchControl schCtrl;
        private SortControl sortCtrl;
    }
}
