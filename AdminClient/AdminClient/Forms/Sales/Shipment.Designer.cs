
namespace AdminClient.Forms
{
	partial class Shipment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp_DueDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtp_DueDateFrom = new System.Windows.Forms.DateTimePicker();
			this.cbo_CompName = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dgv_ShipList = new AdminClient.CustomDataGridView();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
			this.cbo_ContractFinish = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_ShipList)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1461, 9);
			this.btn_add.Text = "출하\r\n처리";
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1379, 9);
			this.btn_Xls.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(7, 6);
			this.panel1.Size = new System.Drawing.Size(1555, 69);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(169, 43);
			this.lbl_Title.Text = "제품 출하";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1565, 748);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_ContractFinish);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Controls.Add(this.cbo_CompName);
			this.gb_Sherch.Controls.Add(this.label8);
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Location = new System.Drawing.Point(5, 2);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 232);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label8, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_CompName, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_ContractFinish, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Location = new System.Drawing.Point(5, 238);
			this.gb_detail.Size = new System.Drawing.Size(349, 210);
			// 
			// chk_limit
			// 
			this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(7, 80);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgv_ShipList);
			this.splitContainer1.Size = new System.Drawing.Size(1565, 667);
			this.splitContainer1.SplitterDistance = 362;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 290);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 667);
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(252, 18);
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(1544, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(1655, 7);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtp_DueDateTo);
			this.groupBox1.Controls.Add(this.dtp_DueDateFrom);
			this.groupBox1.Location = new System.Drawing.Point(5, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 64);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "납기일";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(121, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "~";
			// 
			// dtp_DueDateTo
			// 
			this.dtp_DueDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DueDateTo.Location = new System.Drawing.Point(145, 24);
			this.dtp_DueDateTo.Name = "dtp_DueDateTo";
			this.dtp_DueDateTo.Size = new System.Drawing.Size(108, 25);
			this.dtp_DueDateTo.TabIndex = 4;
			// 
			// dtp_DueDateFrom
			// 
			this.dtp_DueDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DueDateFrom.Location = new System.Drawing.Point(7, 24);
			this.dtp_DueDateFrom.Name = "dtp_DueDateFrom";
			this.dtp_DueDateFrom.Size = new System.Drawing.Size(108, 25);
			this.dtp_DueDateFrom.TabIndex = 3;
			// 
			// cbo_CompName
			// 
			this.cbo_CompName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_CompName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_CompName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_CompName.FormattingEnabled = true;
			this.cbo_CompName.Location = new System.Drawing.Point(12, 62);
			this.cbo_CompName.Name = "cbo_CompName";
			this.cbo_CompName.Size = new System.Drawing.Size(189, 25);
			this.cbo_CompName.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "고객사";
			// 
			// dgv_ShipList
			// 
			this.dgv_ShipList.AllowUserToAddRows = false;
			this.dgv_ShipList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_ShipList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ShipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ShipList.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_ShipList.GridColor = System.Drawing.Color.Black;
			this.dgv_ShipList.IsChkVisible = false;
			this.dgv_ShipList.IsEditVisible = false;
			this.dgv_ShipList.Location = new System.Drawing.Point(36, 3);
			this.dgv_ShipList.Name = "dgv_ShipList";
			this.dgv_ShipList.RowHeadersVisible = false;
			this.dgv_ShipList.RowTemplate.Height = 23;
			this.dgv_ShipList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_ShipList.Size = new System.Drawing.Size(1155, 661);
			this.dgv_ShipList.TabIndex = 4;
			// 
			// searchControl1
			// 
			this.searchControl1.BackColor = System.Drawing.Color.Transparent;
			this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchControl1.Location = new System.Drawing.Point(6, 24);
			this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
			this.searchControl1.Name = "searchControl1";
			this.searchControl1.Size = new System.Drawing.Size(320, 75);
			this.searchControl1.TabIndex = 0;
			// 
			// sortControl1
			// 
			this.sortControl1.BackColor = System.Drawing.Color.Transparent;
			this.sortControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortControl1.Location = new System.Drawing.Point(11, 107);
			this.sortControl1.Margin = new System.Windows.Forms.Padding(4);
			this.sortControl1.Name = "sortControl1";
			this.sortControl1.Size = new System.Drawing.Size(321, 69);
			this.sortControl1.TabIndex = 1;
			// 
			// cbo_ContractFinish
			// 
			this.cbo_ContractFinish.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_ContractFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_ContractFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_ContractFinish.FormattingEnabled = true;
			this.cbo_ContractFinish.Location = new System.Drawing.Point(12, 110);
			this.cbo_ContractFinish.Name = "cbo_ContractFinish";
			this.cbo_ContractFinish.Size = new System.Drawing.Size(108, 25);
			this.cbo_ContractFinish.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 21;
			this.label1.Text = "출하완료여부";
			// 
			// Shipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1576, 848);
			this.Name = "Shipment";
			this.Text = "Shipment";
			this.Load += new System.EventHandler(this.Shipment_Load);
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ShipList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp_DueDateTo;
		private System.Windows.Forms.DateTimePicker dtp_DueDateFrom;
		private System.Windows.Forms.ComboBox cbo_CompName;
		private System.Windows.Forms.Label label8;
		private CustomDataGridView dgv_ShipList;
		private SortControl sortControl1;
		private SearchControl searchControl1;
		private System.Windows.Forms.ComboBox cbo_ContractFinish;
		private System.Windows.Forms.Label label1;
	}
}