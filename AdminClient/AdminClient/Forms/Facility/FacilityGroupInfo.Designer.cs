namespace AdminClient.Forms
{
	partial class FacilityGroupInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
			this.txt_FgrpName = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txt_FgrpCode = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbo_Enable = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_DetailEnable = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_FacGrpList = new AdminClient.CustomDataGridView();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacGrpList)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1387, 9);
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1470, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_FgrpName);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.txt_FgrpCode);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Location = new System.Drawing.Point(7, 6);
			this.panel1.Size = new System.Drawing.Size(1555, 69);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.txt_FgrpCode, 0);
			this.panel1.Controls.SetChildIndex(this.label14, 0);
			this.panel1.Controls.SetChildIndex(this.txt_FgrpName, 0);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(124, 43);
			this.lbl_Title.Text = "설비군";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1565, 689);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_Enable);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(343, 118);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Enable, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.cbo_DetailEnable);
			this.gb_detail.Controls.Add(this.label2);
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Location = new System.Drawing.Point(11, 124);
			this.gb_detail.Size = new System.Drawing.Size(352, 400);
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
			this.splitContainer1.Panel2.Controls.Add(this.dgv_FacGrpList);
			this.splitContainer1.Size = new System.Drawing.Size(1565, 608);
			this.splitContainer1.SplitterDistance = 365;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 261);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 608);
			// 
			// button1
			// 
			this.btn_search.Location = new System.Drawing.Point(254, 17);
			this.btn_search.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(1544, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(1655, 7);
			// 
			// searchControl1
			// 
			this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchControl1.Location = new System.Drawing.Point(6, 24);
			this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
			this.searchControl1.Name = "searchControl1";
			this.searchControl1.Size = new System.Drawing.Size(325, 77);
			this.searchControl1.TabIndex = 3;
			// 
			// sortControl1
			// 
			this.sortControl1.Location = new System.Drawing.Point(12, 161);
			this.sortControl1.Margin = new System.Windows.Forms.Padding(28, 67, 28, 67);
			this.sortControl1.Name = "sortControl1";
			this.sortControl1.Size = new System.Drawing.Size(316, 103);
			this.sortControl1.TabIndex = 4;
			// 
			// txt_FgrpName
			// 
			this.txt_FgrpName.Location = new System.Drawing.Point(817, 21);
			this.txt_FgrpName.Name = "txt_FgrpName";
			this.txt_FgrpName.Size = new System.Drawing.Size(121, 25);
			this.txt_FgrpName.TabIndex = 58;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(743, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(68, 17);
			this.label14.TabIndex = 57;
			this.label14.Text = "설비군명";
			// 
			// txt_FgrpCode
			// 
			this.txt_FgrpCode.Location = new System.Drawing.Point(596, 21);
			this.txt_FgrpCode.Name = "txt_FgrpCode";
			this.txt_FgrpCode.Size = new System.Drawing.Size(121, 25);
			this.txt_FgrpCode.TabIndex = 56;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(507, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(83, 17);
			this.label13.TabIndex = 55;
			this.label13.Text = "설비군코드";
			// 
			// cbo_Enable
			// 
			this.cbo_Enable.FormattingEnabled = true;
			this.cbo_Enable.Location = new System.Drawing.Point(12, 74);
			this.cbo_Enable.Name = "cbo_Enable";
			this.cbo_Enable.Size = new System.Drawing.Size(189, 25);
			this.cbo_Enable.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "설비 사용 유무";
			// 
			// cbo_DetailEnable
			// 
			this.cbo_DetailEnable.FormattingEnabled = true;
			this.cbo_DetailEnable.Location = new System.Drawing.Point(12, 119);
			this.cbo_DetailEnable.Name = "cbo_DetailEnable";
			this.cbo_DetailEnable.Size = new System.Drawing.Size(189, 25);
			this.cbo_DetailEnable.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "설비 사용 유무";
			// 
			// dgv_FacGrpList
			// 
			this.dgv_FacGrpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_FacGrpList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_FacGrpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_FacGrpList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_FacGrpList.GridColor = System.Drawing.Color.Black;
			this.dgv_FacGrpList.IsChkVisible = true;
			this.dgv_FacGrpList.IsEditVisible = true;
			this.dgv_FacGrpList.Location = new System.Drawing.Point(36, 3);
			this.dgv_FacGrpList.Name = "dgv_FacGrpList";
			this.dgv_FacGrpList.RowTemplate.Height = 23;
			this.dgv_FacGrpList.Size = new System.Drawing.Size(1157, 602);
			this.dgv_FacGrpList.TabIndex = 3;
			this.dgv_FacGrpList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacGrpList_CellClick);
			this.dgv_FacGrpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacGrpList_CellContentClick);
			// 
			// FacilityGroupInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(1576, 789);
			this.Name = "FacilityGroupInfo";
			this.Load += new System.EventHandler(this.FacilityGroupInfo_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacGrpList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SortControl sortControl1;
		private SearchControl searchControl1;
		private System.Windows.Forms.TextBox txt_FgrpName;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_FgrpCode;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbo_Enable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbo_DetailEnable;
		private System.Windows.Forms.Label label2;
		private CustomDataGridView dgv_FacGrpList;
	}
}
