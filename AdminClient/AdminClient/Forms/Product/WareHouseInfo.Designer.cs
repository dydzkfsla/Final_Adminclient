namespace AdminClient.Forms
{
	partial class WareHouseInfo
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
			if(disposing && (components != null))
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.schCtrl = new AdminClient.SearchControl();
			this.schCtrlDetail = new AdminClient.SearchControl();
			this.dgv_WhList = new AdminClient.CustomDataGridView();
			this.dgv_WhDetailList = new AdminClient.CustomDataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_Type = new System.Windows.Forms.ComboBox();
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.sortCtrl = new AdminClient.SortControl();
			this.txt_State = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_Type = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.sortCtrlDetail = new AdminClient.SortControl();
			this.gb_detailItem = new System.Windows.Forms.GroupBox();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_WhList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_WhDetailList)).BeginInit();
			this.gb_detailItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer3
			// 
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.dgv_WhDetailList);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.gb_detailItem);
			this.splitContainer3.Size = new System.Drawing.Size(1238, 452);
			this.splitContainer3.SplitterDistance = 1196;
			// 
			// splitContainer2
			// 
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dgv_WhList);
			this.splitContainer2.Size = new System.Drawing.Size(1238, 860);
			this.splitContainer2.SplitterDistance = 402;
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
			this.panel1.Controls.Add(this.txt_State);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txt_Type);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txt_Code);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Size = new System.Drawing.Size(1636, 64);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
			this.panel1.Controls.SetChildIndex(this.label12, 0);
			this.panel1.Controls.SetChildIndex(this.txt_Type, 0);
			this.panel1.Controls.SetChildIndex(this.label10, 0);
			this.panel1.Controls.SetChildIndex(this.txt_State, 0);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(159, 43);
			this.lbl_Title.Text = "창고관리";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_State);
			this.gb_Sherch.Controls.Add(this.cbo_Type);
			this.gb_Sherch.Controls.Add(this.label2);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 186);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Type, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortCtrl);
			this.gb_detail.Controls.Add(this.schCtrl);
			this.gb_detail.Size = new System.Drawing.Size(348, 274);
			// 
			// nu_limit
			// 
			this.nu_limit.Location = new System.Drawing.Point(120, 17);
			// 
			// chk_limit
			// 
			this.chk_limit.Location = new System.Drawing.Point(24, 18);
			this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Size = new System.Drawing.Size(1654, 860);
			this.splitContainer1.SplitterDistance = 379;
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
			this.btn_search.Location = new System.Drawing.Point(269, 17);
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
			// schCtrl
			// 
			this.schCtrl.BackColor = System.Drawing.Color.Transparent;
			this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.schCtrl.Location = new System.Drawing.Point(8, 34);
			this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.schCtrl.Name = "schCtrl";
			this.schCtrl.Size = new System.Drawing.Size(325, 77);
			this.schCtrl.TabIndex = 0;
			// 
			// schCtrlDetail
			// 
			this.schCtrlDetail.BackColor = System.Drawing.Color.Transparent;
			this.schCtrlDetail.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.schCtrlDetail.Location = new System.Drawing.Point(7, 25);
			this.schCtrlDetail.Margin = new System.Windows.Forms.Padding(4);
			this.schCtrlDetail.Name = "schCtrlDetail";
			this.schCtrlDetail.Size = new System.Drawing.Size(325, 77);
			this.schCtrlDetail.TabIndex = 0;
			// 
			// dgv_WhList
			// 
			this.dgv_WhList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_WhList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_WhList.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_WhList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_WhList.GridColor = System.Drawing.Color.Black;
			this.dgv_WhList.IsChkVisible = true;
			this.dgv_WhList.IsEditVisible = true;
			this.dgv_WhList.Location = new System.Drawing.Point(0, 0);
			this.dgv_WhList.Name = "dgv_WhList";
			this.dgv_WhList.RowTemplate.Height = 23;
			this.dgv_WhList.Size = new System.Drawing.Size(1238, 402);
			this.dgv_WhList.TabIndex = 0;
			this.dgv_WhList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WhList_CellClick);
			this.dgv_WhList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WhList_CellContentClick);
			// 
			// dgv_WhDetailList
			// 
			this.dgv_WhDetailList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_WhDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_WhDetailList.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_WhDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_WhDetailList.GridColor = System.Drawing.Color.Black;
			this.dgv_WhDetailList.IsChkVisible = false;
			this.dgv_WhDetailList.IsEditVisible = false;
			this.dgv_WhDetailList.Location = new System.Drawing.Point(0, 0);
			this.dgv_WhDetailList.Name = "dgv_WhDetailList";
			this.dgv_WhDetailList.RowTemplate.Height = 23;
			this.dgv_WhDetailList.Size = new System.Drawing.Size(1196, 452);
			this.dgv_WhDetailList.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "창고종류";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "사용상태";
			// 
			// cbo_Type
			// 
			this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Type.FormattingEnabled = true;
			this.cbo_Type.Location = new System.Drawing.Point(89, 59);
			this.cbo_Type.Name = "cbo_Type";
			this.cbo_Type.Size = new System.Drawing.Size(158, 25);
			this.cbo_Type.TabIndex = 5;
			// 
			// cbo_State
			// 
			this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(91, 102);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(156, 25);
			this.cbo_State.TabIndex = 6;
			// 
			// sortCtrl
			// 
			this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
			this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortCtrl.Location = new System.Drawing.Point(8, 114);
			this.sortCtrl.Margin = new System.Windows.Forms.Padding(17, 33, 17, 33);
			this.sortCtrl.Name = "sortCtrl";
			this.sortCtrl.Size = new System.Drawing.Size(330, 74);
			this.sortCtrl.TabIndex = 1;
			// 
			// txt_State
			// 
			this.txt_State.Location = new System.Drawing.Point(1036, 21);
			this.txt_State.Name = "txt_State";
			this.txt_State.Size = new System.Drawing.Size(145, 25);
			this.txt_State.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(977, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 17);
			this.label10.TabIndex = 26;
			this.label10.Text = "상태";
			// 
			// txt_Type
			// 
			this.txt_Type.Location = new System.Drawing.Point(794, 21);
			this.txt_Type.Name = "txt_Type";
			this.txt_Type.Size = new System.Drawing.Size(145, 25);
			this.txt_Type.TabIndex = 25;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(720, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(68, 17);
			this.label12.TabIndex = 24;
			this.label12.Text = "창고종류";
			// 
			// txt_Code
			// 
			this.txt_Code.Location = new System.Drawing.Point(557, 21);
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.Size = new System.Drawing.Size(145, 25);
			this.txt_Code.TabIndex = 23;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(492, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 17);
			this.label13.TabIndex = 22;
			this.label13.Text = "창고코드";
			// 
			// sortCtrlDetail
			// 
			this.sortCtrlDetail.BackColor = System.Drawing.Color.Transparent;
			this.sortCtrlDetail.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortCtrlDetail.Location = new System.Drawing.Point(5, 122);
			this.sortCtrlDetail.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
			this.sortCtrlDetail.Name = "sortCtrlDetail";
			this.sortCtrlDetail.Size = new System.Drawing.Size(350, 110);
			this.sortCtrlDetail.TabIndex = 1;
			// 
			// gb_detailItem
			// 
			this.gb_detailItem.Controls.Add(this.schCtrlDetail);
			this.gb_detailItem.Controls.Add(this.sortCtrlDetail);
			this.gb_detailItem.Location = new System.Drawing.Point(10, 12);
			this.gb_detailItem.Name = "gb_detailItem";
			this.gb_detailItem.Size = new System.Drawing.Size(337, 246);
			this.gb_detailItem.TabIndex = 2;
			this.gb_detailItem.TabStop = false;
			this.gb_detailItem.Text = "디테일 세부검색";
			// 
			// WareHouseInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "WareHouseInfo";
			this.Load += new System.EventHandler(this.WareHouseInfo_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_WhList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_WhDetailList)).EndInit();
			this.gb_detailItem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private SearchControl schCtrlDetail;
        private SearchControl schCtrl;
        private CustomDataGridView dgv_WhDetailList;
        private CustomDataGridView dgv_WhList;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SortControl sortCtrl;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label13;
        private SortControl sortCtrlDetail;
        private System.Windows.Forms.GroupBox gb_detailItem;
    }
}
