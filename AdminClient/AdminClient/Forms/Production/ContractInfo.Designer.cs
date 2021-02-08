
namespace AdminClient.Forms
{
	partial class ContractInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
			this.cbo_ContractFinish = new System.Windows.Forms.ComboBox();
			this.cbo_ContractConfirm = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_DueDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtp_DueDateFrom = new System.Windows.Forms.DateTimePicker();
			this.cbo_DeDestination = new System.Windows.Forms.ComboBox();
			this.cbo_DeCompName = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbo_ContDFinish = new System.Windows.Forms.ComboBox();
			this.cbo_ContDConfirm = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dgv_ContractList = new AdminClient.CustomDataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtp_DeDueDateTo = new System.Windows.Forms.DateTimePicker();
			this.dtp_DeDueDateFrom = new System.Windows.Forms.DateTimePicker();
			this.cbo_Destination = new System.Windows.Forms.ComboBox();
			this.cbo_CompName = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_ContractList)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1468, 9);
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(12, 9);
			this.panel1.Size = new System.Drawing.Size(1636, 64);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.button2, 0);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(159, 43);
			this.lbl_Title.Text = "수주관리";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_Destination);
			this.gb_Sherch.Controls.Add(this.cbo_CompName);
			this.gb_Sherch.Controls.Add(this.label5);
			this.gb_Sherch.Controls.Add(this.label6);
			this.gb_Sherch.Controls.Add(this.cbo_ContractFinish);
			this.gb_Sherch.Controls.Add(this.cbo_ContractConfirm);
			this.gb_Sherch.Controls.Add(this.label3);
			this.gb_Sherch.Controls.Add(this.label2);
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Location = new System.Drawing.Point(12, 11);
			this.gb_Sherch.Size = new System.Drawing.Size(344, 225);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_ContractConfirm, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_ContractFinish, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label6, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label5, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_CompName, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Destination, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.groupBox2);
			this.gb_detail.Controls.Add(this.cbo_DeDestination);
			this.gb_detail.Controls.Add(this.cbo_DeCompName);
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.label7);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Controls.Add(this.label8);
			this.gb_detail.Controls.Add(this.label11);
			this.gb_detail.Controls.Add(this.label10);
			this.gb_detail.Controls.Add(this.cbo_ContDFinish);
			this.gb_detail.Controls.Add(this.cbo_ContDConfirm);
			this.gb_detail.Location = new System.Drawing.Point(11, 240);
			this.gb_detail.Size = new System.Drawing.Size(344, 355);
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
			this.splitContainer1.Panel2.Controls.Add(this.dgv_ContractList);
			this.splitContainer1.Size = new System.Drawing.Size(1654, 844);
			this.splitContainer1.SplitterDistance = 365;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 379);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 844);
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(265, 17);
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
			// searchControl1
			// 
			this.searchControl1.BackColor = System.Drawing.Color.Transparent;
			this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchControl1.Location = new System.Drawing.Point(6, 24);
			this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
			this.searchControl1.Name = "searchControl1";
			this.searchControl1.Size = new System.Drawing.Size(325, 75);
			this.searchControl1.TabIndex = 0;
			// 
			// sortControl1
			// 
			this.sortControl1.BackColor = System.Drawing.Color.Transparent;
			this.sortControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortControl1.Location = new System.Drawing.Point(11, 273);
			this.sortControl1.Margin = new System.Windows.Forms.Padding(4);
			this.sortControl1.Name = "sortControl1";
			this.sortControl1.Size = new System.Drawing.Size(325, 75);
			this.sortControl1.TabIndex = 1;
			// 
			// cbo_ContractFinish
			// 
			this.cbo_ContractFinish.FormattingEnabled = true;
			this.cbo_ContractFinish.Location = new System.Drawing.Point(129, 69);
			this.cbo_ContractFinish.Name = "cbo_ContractFinish";
			this.cbo_ContractFinish.Size = new System.Drawing.Size(83, 25);
			this.cbo_ContractFinish.TabIndex = 14;
			// 
			// cbo_ContractConfirm
			// 
			this.cbo_ContractConfirm.FormattingEnabled = true;
			this.cbo_ContractConfirm.Location = new System.Drawing.Point(12, 69);
			this.cbo_ContractConfirm.Name = "cbo_ContractConfirm";
			this.cbo_ContractConfirm.Size = new System.Drawing.Size(83, 25);
			this.cbo_ContractConfirm.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(126, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "수주 완료여부";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "수주 확정여부";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtp_DueDateTo);
			this.groupBox1.Controls.Add(this.dtp_DueDateFrom);
			this.groupBox1.Location = new System.Drawing.Point(5, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 64);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "납기일";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(126, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "~";
			// 
			// dtp_DueDateTo
			// 
			this.dtp_DueDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DueDateTo.Location = new System.Drawing.Point(145, 24);
			this.dtp_DueDateTo.Name = "dtp_DueDateTo";
			this.dtp_DueDateTo.Size = new System.Drawing.Size(119, 25);
			this.dtp_DueDateTo.TabIndex = 4;
			// 
			// dtp_DueDateFrom
			// 
			this.dtp_DueDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DueDateFrom.Location = new System.Drawing.Point(7, 24);
			this.dtp_DueDateFrom.Name = "dtp_DueDateFrom";
			this.dtp_DueDateFrom.Size = new System.Drawing.Size(119, 25);
			this.dtp_DueDateFrom.TabIndex = 3;
			// 
			// cbo_DeDestination
			// 
			this.cbo_DeDestination.FormattingEnabled = true;
			this.cbo_DeDestination.Location = new System.Drawing.Point(170, 241);
			this.cbo_DeDestination.Name = "cbo_DeDestination";
			this.cbo_DeDestination.Size = new System.Drawing.Size(151, 25);
			this.cbo_DeDestination.TabIndex = 33;
			// 
			// cbo_DeCompName
			// 
			this.cbo_DeCompName.FormattingEnabled = true;
			this.cbo_DeCompName.Location = new System.Drawing.Point(12, 241);
			this.cbo_DeCompName.Name = "cbo_DeCompName";
			this.cbo_DeCompName.Size = new System.Drawing.Size(151, 25);
			this.cbo_DeCompName.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(167, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 17);
			this.label7.TabIndex = 31;
			this.label7.Text = "도착지";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 221);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 17);
			this.label8.TabIndex = 30;
			this.label8.Text = "고객사";
			// 
			// cbo_ContDFinish
			// 
			this.cbo_ContDFinish.FormattingEnabled = true;
			this.cbo_ContDFinish.Location = new System.Drawing.Point(129, 123);
			this.cbo_ContDFinish.Name = "cbo_ContDFinish";
			this.cbo_ContDFinish.Size = new System.Drawing.Size(83, 25);
			this.cbo_ContDFinish.TabIndex = 27;
			// 
			// cbo_ContDConfirm
			// 
			this.cbo_ContDConfirm.FormattingEnabled = true;
			this.cbo_ContDConfirm.Location = new System.Drawing.Point(12, 123);
			this.cbo_ContDConfirm.Name = "cbo_ContDConfirm";
			this.cbo_ContDConfirm.Size = new System.Drawing.Size(83, 25);
			this.cbo_ContDConfirm.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(126, 103);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 17);
			this.label10.TabIndex = 25;
			this.label10.Text = "수주 완료여부";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 103);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 17);
			this.label11.TabIndex = 23;
			this.label11.Text = "수주 확정여부";
			// 
			// dgv_ContractList
			// 
			this.dgv_ContractList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ContractList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_ContractList.GridColor = System.Drawing.Color.Black;
			this.dgv_ContractList.IsChkVisible = false;
			this.dgv_ContractList.IsEditVisible = false;
			this.dgv_ContractList.Location = new System.Drawing.Point(36, 0);
			this.dgv_ContractList.Name = "dgv_ContractList";
			this.dgv_ContractList.RowTemplate.Height = 23;
			this.dgv_ContractList.Size = new System.Drawing.Size(1246, 841);
			this.dgv_ContractList.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button2.Image = global::AdminClient.Properties.Resources.Edit_32x32;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(1386, 9);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 47);
			this.button2.TabIndex = 17;
			this.button2.Text = "생산계획\r\n생성";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.dtp_DeDueDateTo);
			this.groupBox2.Controls.Add(this.dtp_DeDueDateFrom);
			this.groupBox2.Location = new System.Drawing.Point(6, 154);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(297, 64);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "납기일";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(126, 29);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(18, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "~";
			// 
			// dtp_DeDueDateTo
			// 
			this.dtp_DeDueDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DeDueDateTo.Location = new System.Drawing.Point(145, 24);
			this.dtp_DeDueDateTo.Name = "dtp_DeDueDateTo";
			this.dtp_DeDueDateTo.Size = new System.Drawing.Size(119, 25);
			this.dtp_DeDueDateTo.TabIndex = 4;
			// 
			// dtp_DeDueDateFrom
			// 
			this.dtp_DeDueDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_DeDueDateFrom.Location = new System.Drawing.Point(7, 24);
			this.dtp_DeDueDateFrom.Name = "dtp_DeDueDateFrom";
			this.dtp_DeDueDateFrom.Size = new System.Drawing.Size(119, 25);
			this.dtp_DeDueDateFrom.TabIndex = 3;
			// 
			// cbo_Destination
			// 
			this.cbo_Destination.FormattingEnabled = true;
			this.cbo_Destination.Location = new System.Drawing.Point(169, 187);
			this.cbo_Destination.Name = "cbo_Destination";
			this.cbo_Destination.Size = new System.Drawing.Size(151, 25);
			this.cbo_Destination.TabIndex = 37;
			// 
			// cbo_CompName
			// 
			this.cbo_CompName.FormattingEnabled = true;
			this.cbo_CompName.Location = new System.Drawing.Point(12, 187);
			this.cbo_CompName.Name = "cbo_CompName";
			this.cbo_CompName.Size = new System.Drawing.Size(151, 25);
			this.cbo_CompName.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(166, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 17);
			this.label5.TabIndex = 35;
			this.label5.Text = "도착지";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 17);
			this.label6.TabIndex = 34;
			this.label6.Text = "고객사";
			// 
			// ContractInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "ContractInfo";
			this.Text = "ContractInfo";
			this.Load += new System.EventHandler(this.ContractInfo_Load);
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ContractList)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SearchControl searchControl1;
		private SortControl sortControl1;
		private System.Windows.Forms.ComboBox cbo_ContractFinish;
		private System.Windows.Forms.ComboBox cbo_ContractConfirm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_DueDateTo;
		private System.Windows.Forms.DateTimePicker dtp_DueDateFrom;
		private System.Windows.Forms.ComboBox cbo_DeDestination;
		private System.Windows.Forms.ComboBox cbo_DeCompName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbo_ContDFinish;
		private System.Windows.Forms.ComboBox cbo_ContDConfirm;
		private CustomDataGridView dgv_ContractList;
		protected System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtp_DeDueDateTo;
		private System.Windows.Forms.DateTimePicker dtp_DeDueDateFrom;
		private System.Windows.Forms.ComboBox cbo_Destination;
		private System.Windows.Forms.ComboBox cbo_CompName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}