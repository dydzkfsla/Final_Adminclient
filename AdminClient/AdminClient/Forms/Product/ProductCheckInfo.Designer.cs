namespace AdminClient.Forms
{
	partial class ProductCheckInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customDataGridView1 = new AdminClient.CustomDataGridView();
            this.searchControl = new AdminClient.SearchControl();
            this.sortControl = new AdminClient.SortControl();
            this.dgv_Check = new AdminClient.CustomDataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Check)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(15, 28);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Location = new System.Drawing.Point(0, 73);
            this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Size = new System.Drawing.Size(348, 98);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sortControl);
            this.gb_detail.Controls.Add(this.searchControl);
            this.gb_detail.Enabled = false;
            this.gb_detail.Location = new System.Drawing.Point(12, 113);
            this.gb_detail.Size = new System.Drawing.Size(348, 211);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(159, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged_1);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Check);
            this.splitContainer1.Panel2.Controls.Add(this.customDataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1654, 860);
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 386);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 860);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(263, 17);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView1.GridColor = System.Drawing.Color.Black;
            this.customDataGridView1.IsChkVisible = false;
            this.customDataGridView1.IsEditVisible = false;
            this.customDataGridView1.Location = new System.Drawing.Point(36, 2);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.RowTemplate.Height = 23;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(1248, 936);
            this.customDataGridView1.TabIndex = 3;
            // 
            // searchControl
            // 
            this.searchControl.BackColor = System.Drawing.Color.Transparent;
            this.searchControl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchControl.Location = new System.Drawing.Point(11, 33);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(326, 75);
            this.searchControl.TabIndex = 0;
            // 
            // sortControl
            // 
            this.sortControl.BackColor = System.Drawing.Color.Transparent;
            this.sortControl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortControl.Location = new System.Drawing.Point(12, 116);
            this.sortControl.Margin = new System.Windows.Forms.Padding(4);
            this.sortControl.Name = "sortControl";
            this.sortControl.Size = new System.Drawing.Size(325, 69);
            this.sortControl.TabIndex = 1;
            // 
            // dgv_Check
            // 
            this.dgv_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Check.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Check.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Check.GridColor = System.Drawing.Color.Black;
            this.dgv_Check.IsChkVisible = false;
            this.dgv_Check.IsEditVisible = true;
            this.dgv_Check.Location = new System.Drawing.Point(36, 3);
            this.dgv_Check.Name = "dgv_Check";
            this.dgv_Check.RowTemplate.Height = 23;
            this.dgv_Check.Size = new System.Drawing.Size(1246, 854);
            this.dgv_Check.TabIndex = 4;
            this.dgv_Check.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Check_CellContentClick);
            // 
            // ProductCheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "ProductCheckInfo";
            this.Load += new System.EventHandler(this.ProductCheckInfo_Load);
            this.panel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private CustomDataGridView customDataGridView1;
        private SortControl sortControl;
        private SearchControl searchControl;
        private CustomDataGridView dgv_Check;
    }
}
