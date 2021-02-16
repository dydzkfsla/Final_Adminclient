namespace AdminClient.Forms
{
	partial class StockInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_Stock = new AdminClient.CustomDataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_Type = new System.Windows.Forms.ComboBox();
			this.cbo_Unit = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.schCtrl = new AdminClient.SearchControl();
			this.sortCtrl = new AdminClient.SortControl();
			this.pnl_Main.SuspendLayout();
			this.gb_Sherch.SuspendLayout();
			this.gb_detail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(124, 43);
			this.lbl_Title.Text = "재고량";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_Unit);
			this.gb_Sherch.Controls.Add(this.label2);
			this.gb_Sherch.Controls.Add(this.cbo_Type);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 162);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Type, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Unit, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortCtrl);
			this.gb_detail.Controls.Add(this.schCtrl);
			this.gb_detail.Location = new System.Drawing.Point(3, 168);
			this.gb_detail.Size = new System.Drawing.Size(348, 204);
			// 
			// nu_limit
			// 
			this.nu_limit.Size = new System.Drawing.Size(155, 25);
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
			this.splitContainer1.Panel2.Controls.Add(this.dgv_Stock);
			this.splitContainer1.Size = new System.Drawing.Size(1654, 925);
			this.splitContainer1.SplitterDistance = 457;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 419);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 925);
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
			// dgv_Stock
			// 
			this.dgv_Stock.AllowUserToAddRows = false;
			this.dgv_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Stock.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Stock.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Stock.GridColor = System.Drawing.Color.Black;
			this.dgv_Stock.IsChkVisible = true;
			this.dgv_Stock.IsEditVisible = false;
			this.dgv_Stock.Location = new System.Drawing.Point(36, 3);
			this.dgv_Stock.Name = "dgv_Stock";
			this.dgv_Stock.RowHeadersVisible = false;
			this.dgv_Stock.RowTemplate.Height = 23;
			this.dgv_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Stock.Size = new System.Drawing.Size(1154, 919);
			this.dgv_Stock.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "품목타입";
			// 
			// cbo_Type
			// 
			this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Type.FormattingEnabled = true;
			this.cbo_Type.Location = new System.Drawing.Point(12, 70);
			this.cbo_Type.Name = "cbo_Type";
			this.cbo_Type.Size = new System.Drawing.Size(241, 25);
			this.cbo_Type.TabIndex = 4;
			// 
			// cbo_Unit
			// 
			this.cbo_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Unit.FormattingEnabled = true;
			this.cbo_Unit.Location = new System.Drawing.Point(12, 117);
			this.cbo_Unit.Name = "cbo_Unit";
			this.cbo_Unit.Size = new System.Drawing.Size(241, 25);
			this.cbo_Unit.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "단위";
			// 
			// schCtrl
			// 
			this.schCtrl.BackColor = System.Drawing.Color.Transparent;
			this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.schCtrl.Location = new System.Drawing.Point(9, 24);
			this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.schCtrl.Name = "schCtrl";
			this.schCtrl.Size = new System.Drawing.Size(325, 77);
			this.schCtrl.TabIndex = 47;
			// 
			// sortCtrl
			// 
			this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
			this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortCtrl.Location = new System.Drawing.Point(15, 113);
			this.sortCtrl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.sortCtrl.Name = "sortCtrl";
			this.sortCtrl.Size = new System.Drawing.Size(319, 71);
			this.sortCtrl.TabIndex = 48;
			// 
			// StockInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "StockInfo";
			this.Load += new System.EventHandler(this.StockInfo_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_Stock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ComboBox cbo_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_Stock;
        private SearchControl schCtrl;
        private SortControl sortCtrl;
    }
}
