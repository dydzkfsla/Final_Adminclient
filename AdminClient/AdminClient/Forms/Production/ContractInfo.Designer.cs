
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_ContractList = new AdminClient.CustomDataGridView();
            this.btn_CreateProductionAdd = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btn_CreateProductionAdd);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.btn_CreateProductionAdd, 0);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(159, 43);
            this.lbl_Title.Text = "수주관리";
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
            this.gb_Sherch.Size = new System.Drawing.Size(348, 225);
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
            this.gb_detail.Controls.Add(this.sortControl1);
            this.gb_detail.Controls.Add(this.searchControl1);
            this.gb_detail.Location = new System.Drawing.Point(11, 240);
            this.gb_detail.Size = new System.Drawing.Size(348, 202);
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
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(265, 17);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.sortControl1.Location = new System.Drawing.Point(6, 107);
            this.sortControl1.Margin = new System.Windows.Forms.Padding(4);
            this.sortControl1.Name = "sortControl1";
            this.sortControl1.Size = new System.Drawing.Size(325, 75);
            this.sortControl1.TabIndex = 1;
            // 
            // cbo_ContractFinish
            // 
            this.cbo_ContractFinish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_ContractFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ContractFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_ContractFinish.FormattingEnabled = true;
            this.cbo_ContractFinish.Location = new System.Drawing.Point(129, 69);
            this.cbo_ContractFinish.Name = "cbo_ContractFinish";
            this.cbo_ContractFinish.Size = new System.Drawing.Size(83, 25);
            this.cbo_ContractFinish.TabIndex = 14;
            // 
            // cbo_ContractConfirm
            // 
            this.cbo_ContractConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_ContractConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ContractConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // dgv_ContractList
            // 
            this.dgv_ContractList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ContractList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ContractList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ContractList.GridColor = System.Drawing.Color.Black;
            this.dgv_ContractList.IsChkVisible = false;
            this.dgv_ContractList.IsEditVisible = true;
            this.dgv_ContractList.Location = new System.Drawing.Point(36, 0);
            this.dgv_ContractList.Name = "dgv_ContractList";
            this.dgv_ContractList.RowTemplate.Height = 23;
            this.dgv_ContractList.Size = new System.Drawing.Size(1246, 841);
            this.dgv_ContractList.TabIndex = 3;
            this.dgv_ContractList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ContractList_CellContentClick);
            // 
            // btn_CreateProductionAdd
            // 
            this.btn_CreateProductionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateProductionAdd.BackColor = System.Drawing.Color.White;
            this.btn_CreateProductionAdd.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CreateProductionAdd.Image = global::AdminClient.Properties.Resources.Edit_32x32;
            this.btn_CreateProductionAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateProductionAdd.Location = new System.Drawing.Point(1386, 9);
            this.btn_CreateProductionAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CreateProductionAdd.Name = "btn_CreateProductionAdd";
            this.btn_CreateProductionAdd.Size = new System.Drawing.Size(82, 47);
            this.btn_CreateProductionAdd.TabIndex = 17;
            this.btn_CreateProductionAdd.Text = "생산계획\r\n생성";
            this.btn_CreateProductionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateProductionAdd.UseVisualStyleBackColor = false;
            this.btn_CreateProductionAdd.Click += new System.EventHandler(this.btn_CreateProduction_Click);
            // 
            // cbo_Destination
            // 
            this.cbo_Destination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Destination.FormattingEnabled = true;
            this.cbo_Destination.Location = new System.Drawing.Point(169, 187);
            this.cbo_Destination.Name = "cbo_Destination";
            this.cbo_Destination.Size = new System.Drawing.Size(151, 25);
            this.cbo_Destination.TabIndex = 37;
            // 
            // cbo_CompName
            // 
            this.cbo_CompName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_CompName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CompName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContractList)).EndInit();
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
		private CustomDataGridView dgv_ContractList;
		protected System.Windows.Forms.Button btn_CreateProductionAdd;
		private System.Windows.Forms.ComboBox cbo_Destination;
		private System.Windows.Forms.ComboBox cbo_CompName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}