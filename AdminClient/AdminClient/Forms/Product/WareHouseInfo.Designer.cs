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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchControl1 = new AdminClient.SearchControl();
            this.searchControl2 = new AdminClient.SearchControl();
            this.dgv_WhList = new AdminClient.CustomDataGridView();
            this.dgv_WhDetailList = new AdminClient.CustomDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.cbo_State = new System.Windows.Forms.ComboBox();
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
            this.splitContainer3.Panel2.Controls.Add(this.searchControl2);
            this.splitContainer3.Size = new System.Drawing.Size(880, 366);
            this.splitContainer3.SplitterDistance = 531;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_WhList);
            this.splitContainer2.SplitterDistance = 327;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(159, 43);
            this.lbl_Title.Text = "창고관리";
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Controls.Add(this.cbo_Type);
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Size = new System.Drawing.Size(333, 186);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.button1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Type, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.searchControl1);
            this.gb_detail.Size = new System.Drawing.Size(337, 471);
            // 
            // nu_limit
            // 
            this.nu_limit.Location = new System.Drawing.Point(120, 17);
            // 
            // chk_limit
            // 
            this.chk_limit.Location = new System.Drawing.Point(24, 18);
            // 
            // splitContainer1
            // 
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 17);
            // 
            // searchControl1
            // 
            this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchControl1.Location = new System.Drawing.Point(8, 24);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(325, 77);
            this.searchControl1.TabIndex = 0;
            // 
            // searchControl2
            // 
            this.searchControl2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchControl2.Location = new System.Drawing.Point(14, 16);
            this.searchControl2.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Size = new System.Drawing.Size(325, 77);
            this.searchControl2.TabIndex = 0;
            // 
            // dgv_WhList
            // 
            this.dgv_WhList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_WhList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_WhList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_WhList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_WhList.GridColor = System.Drawing.Color.Black;
            this.dgv_WhList.IsChkVisible = false;
            this.dgv_WhList.IsEditVisible = false;
            this.dgv_WhList.Location = new System.Drawing.Point(0, 0);
            this.dgv_WhList.Name = "dgv_WhList";
            this.dgv_WhList.RowTemplate.Height = 23;
            this.dgv_WhList.Size = new System.Drawing.Size(880, 327);
            this.dgv_WhList.TabIndex = 0;
            // 
            // dgv_WhDetailList
            // 
            this.dgv_WhDetailList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_WhDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_WhDetailList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_WhDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_WhDetailList.GridColor = System.Drawing.Color.Black;
            this.dgv_WhDetailList.IsChkVisible = false;
            this.dgv_WhDetailList.IsEditVisible = false;
            this.dgv_WhDetailList.Location = new System.Drawing.Point(0, 0);
            this.dgv_WhDetailList.Name = "dgv_WhDetailList";
            this.dgv_WhDetailList.RowTemplate.Height = 23;
            this.dgv_WhDetailList.Size = new System.Drawing.Size(531, 366);
            this.dgv_WhDetailList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "창고종류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "사용상태";
            // 
            // cbo_Type
            // 
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(89, 100);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(158, 25);
            this.cbo_Type.TabIndex = 5;
            // 
            // cbo_State
            // 
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(91, 143);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(156, 25);
            this.cbo_State.TabIndex = 6;
            // 
            // WareHouseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1278, 864);
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
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private SearchControl searchControl2;
        private SearchControl searchControl1;
        private CustomDataGridView dgv_WhDetailList;
        private CustomDataGridView dgv_WhList;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
