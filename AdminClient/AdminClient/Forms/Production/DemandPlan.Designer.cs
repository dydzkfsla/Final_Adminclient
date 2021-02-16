﻿
namespace AdminClient.Forms
{
	partial class DemandPlan
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
			this.dtp_edate = new System.Windows.Forms.DateTimePicker();
			this.dtp_sdate = new System.Windows.Forms.DateTimePicker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dgv_Demand = new AdminClient.CustomDataGridView();
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
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Demand)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1476, 9);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1559, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(7, 6);
			this.panel1.Size = new System.Drawing.Size(1644, 69);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.button2, 0);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(229, 43);
			this.lbl_Title.Text = "자재소요계획";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.comboBox2);
			this.gb_Sherch.Controls.Add(this.label7);
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Size = new System.Drawing.Size(335, 228);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label7, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortCtrl);
			this.gb_detail.Controls.Add(this.schCtrl);
			this.gb_detail.Location = new System.Drawing.Point(11, 234);
			this.gb_detail.Size = new System.Drawing.Size(335, 203);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(7, 80);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgv_Demand);
			this.splitContainer1.Size = new System.Drawing.Size(1654, 844);
			this.splitContainer1.SplitterDistance = 379;
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
			this.btn_search.Location = new System.Drawing.Point(242, 18);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtp_edate);
			this.groupBox1.Controls.Add(this.dtp_sdate);
			this.groupBox1.Location = new System.Drawing.Point(12, 116);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 64);
			this.groupBox1.TabIndex = 8;
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
			// dtp_edate
			// 
			this.dtp_edate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_edate.Location = new System.Drawing.Point(145, 24);
			this.dtp_edate.Name = "dtp_edate";
			this.dtp_edate.Size = new System.Drawing.Size(108, 25);
			this.dtp_edate.TabIndex = 4;
			// 
			// dtp_sdate
			// 
			this.dtp_sdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_sdate.Location = new System.Drawing.Point(7, 24);
			this.dtp_sdate.Name = "dtp_sdate";
			this.dtp_sdate.Size = new System.Drawing.Size(108, 25);
			this.dtp_sdate.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(19, 75);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(189, 25);
			this.comboBox2.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "품목";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button2.Image = global::AdminClient.Properties.Resources.EditName_32x32;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(1394, 9);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 47);
			this.button2.TabIndex = 16;
			this.button2.Text = "생산계획\r\n생성";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// dgv_Demand
			// 
			this.dgv_Demand.AllowUserToAddRows = false;
			this.dgv_Demand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Demand.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Demand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Demand.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Demand.GridColor = System.Drawing.Color.Black;
			this.dgv_Demand.IsChkVisible = true;
			this.dgv_Demand.IsEditVisible = false;
			this.dgv_Demand.Location = new System.Drawing.Point(36, 3);
			this.dgv_Demand.Name = "dgv_Demand";
			this.dgv_Demand.RowHeadersVisible = false;
			this.dgv_Demand.RowTemplate.Height = 23;
			this.dgv_Demand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Demand.Size = new System.Drawing.Size(1225, 838);
			this.dgv_Demand.TabIndex = 3;
			// 
			// schCtrl
			// 
			this.schCtrl.BackColor = System.Drawing.Color.Transparent;
			this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.schCtrl.Location = new System.Drawing.Point(5, 27);
			this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.schCtrl.Name = "schCtrl";
			this.schCtrl.Size = new System.Drawing.Size(320, 75);
			this.schCtrl.TabIndex = 0;
			// 
			// sortCtrl
			// 
			this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
			this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
			this.sortCtrl.Location = new System.Drawing.Point(1, 110);
			this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
			this.sortCtrl.Name = "sortCtrl";
			this.sortCtrl.Size = new System.Drawing.Size(325, 69);
			this.sortCtrl.TabIndex = 1;
			// 
			// DemandPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "DemandPlan";
			this.Text = "DemandPlan";
			this.Load += new System.EventHandler(this.DemandPlan_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_Demand)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp_edate;
		private System.Windows.Forms.DateTimePicker dtp_sdate;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		protected System.Windows.Forms.Button button2;
		private CustomDataGridView dgv_Demand;
        private SortControl sortCtrl;
        private SearchControl schCtrl;
    }
}