
namespace AdminClient.Forms
{
	partial class FacilityInfo_NEW
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cbo_OutSourcing = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_Enable = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
			this.dgv_FacGrpList = new AdminClient.CustomDataGridView();
			this.dgv_FacList = new AdminClient.CustomDataGridView();
			this.btn_AddFacGrp = new System.Windows.Forms.Button();
			this.cbo_Fgrp = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacGrpList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacList)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer2
			// 
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label3);
			this.splitContainer2.Panel1.Controls.Add(this.dgv_FacGrpList);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label4);
			this.splitContainer2.Panel2.Controls.Add(this.dgv_FacList);
			this.splitContainer2.Size = new System.Drawing.Size(1249, 860);
			this.splitContainer2.SplitterDistance = 379;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1468, 9);
			this.btn_add.Text = "설비\r\n등록";
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_AddFacGrp);
			this.panel1.Size = new System.Drawing.Size(1636, 64);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.btn_AddFacGrp, 0);
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.label7);
			this.gb_Sherch.Controls.Add(this.cbo_Fgrp);
			this.gb_Sherch.Controls.Add(this.cbo_OutSourcing);
			this.gb_Sherch.Controls.Add(this.label2);
			this.gb_Sherch.Controls.Add(this.cbo_Enable);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 206);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Enable, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_OutSourcing, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_Fgrp, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label7, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Location = new System.Drawing.Point(12, 212);
			this.gb_detail.Size = new System.Drawing.Size(347, 193);
			// 
			// chk_limit
			// 
			this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Size = new System.Drawing.Size(1654, 860);
			this.splitContainer1.SplitterDistance = 368;
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
			this.btn_search.Location = new System.Drawing.Point(254, 17);
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
			// cbo_OutSourcing
			// 
			this.cbo_OutSourcing.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_OutSourcing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_OutSourcing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_OutSourcing.FormattingEnabled = true;
			this.cbo_OutSourcing.Location = new System.Drawing.Point(12, 169);
			this.cbo_OutSourcing.Name = "cbo_OutSourcing";
			this.cbo_OutSourcing.Size = new System.Drawing.Size(233, 25);
			this.cbo_OutSourcing.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "외주 여부";
			// 
			// cbo_Enable
			// 
			this.cbo_Enable.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_Enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_Enable.FormattingEnabled = true;
			this.cbo_Enable.Location = new System.Drawing.Point(12, 121);
			this.cbo_Enable.Name = "cbo_Enable";
			this.cbo_Enable.Size = new System.Drawing.Size(233, 25);
			this.cbo_Enable.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "설비 사용 유무";
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
			this.sortControl1.Location = new System.Drawing.Point(12, 107);
			this.sortControl1.Margin = new System.Windows.Forms.Padding(4);
			this.sortControl1.Name = "sortControl1";
			this.sortControl1.Size = new System.Drawing.Size(325, 69);
			this.sortControl1.TabIndex = 15;
			// 
			// dgv_FacGrpList
			// 
			this.dgv_FacGrpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_FacGrpList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_FacGrpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_FacGrpList.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_FacGrpList.GridColor = System.Drawing.Color.Black;
			this.dgv_FacGrpList.IsChkVisible = false;
			this.dgv_FacGrpList.IsEditVisible = true;
			this.dgv_FacGrpList.Location = new System.Drawing.Point(0, 25);
			this.dgv_FacGrpList.Name = "dgv_FacGrpList";
			this.dgv_FacGrpList.RowTemplate.Height = 23;
			this.dgv_FacGrpList.Size = new System.Drawing.Size(1246, 354);
			this.dgv_FacGrpList.TabIndex = 0;
			this.dgv_FacGrpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacGrpList_CellContentClick);
			this.dgv_FacGrpList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacGrpList_CellDoubleClick);
			// 
			// dgv_FacList
			// 
			this.dgv_FacList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_FacList.BackgroundColor = System.Drawing.Color.White;
			this.dgv_FacList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_FacList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_FacList.GridColor = System.Drawing.Color.Black;
			this.dgv_FacList.IsChkVisible = false;
			this.dgv_FacList.IsEditVisible = true;
			this.dgv_FacList.Location = new System.Drawing.Point(1, 26);
			this.dgv_FacList.Name = "dgv_FacList";
			this.dgv_FacList.RowTemplate.Height = 23;
			this.dgv_FacList.Size = new System.Drawing.Size(1245, 443);
			this.dgv_FacList.TabIndex = 0;
			this.dgv_FacList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacList_CellContentClick);
			// 
			// btn_AddFacGrp
			// 
			this.btn_AddFacGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddFacGrp.BackColor = System.Drawing.Color.White;
			this.btn_AddFacGrp.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_AddFacGrp.Image = global::AdminClient.Properties.Resources.EditName_32x32;
			this.btn_AddFacGrp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_AddFacGrp.Location = new System.Drawing.Point(1386, 9);
			this.btn_AddFacGrp.Margin = new System.Windows.Forms.Padding(0);
			this.btn_AddFacGrp.Name = "btn_AddFacGrp";
			this.btn_AddFacGrp.Size = new System.Drawing.Size(82, 47);
			this.btn_AddFacGrp.TabIndex = 61;
			this.btn_AddFacGrp.Text = "설비군\r\n 등록";
			this.btn_AddFacGrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_AddFacGrp.UseVisualStyleBackColor = false;
			this.btn_AddFacGrp.Click += new System.EventHandler(this.btn_FacGrpAdd_Click);
			// 
			// cbo_Fgrp
			// 
			this.cbo_Fgrp.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_Fgrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Fgrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_Fgrp.FormattingEnabled = true;
			this.cbo_Fgrp.Location = new System.Drawing.Point(12, 73);
			this.cbo_Fgrp.Name = "cbo_Fgrp";
			this.cbo_Fgrp.Size = new System.Drawing.Size(233, 25);
			this.cbo_Fgrp.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "설비군";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "설비군 목록";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "설비 목록";
			// 
			// FacilityInfo_NEW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "FacilityInfo_NEW";
			this.Text = "FacilityInfo_NEW";
			this.Load += new System.EventHandler(this.FacilityInfo_NEW_Load);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacGrpList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_FacList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbo_OutSourcing;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbo_Enable;
		private System.Windows.Forms.Label label1;
		private SearchControl searchControl1;
		private SortControl sortControl1;
		private CustomDataGridView dgv_FacGrpList;
		private CustomDataGridView dgv_FacList;
		protected System.Windows.Forms.Button btn_AddFacGrp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbo_Fgrp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}