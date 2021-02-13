﻿
namespace AdminClient.Forms
{
	partial class ProductionPlan_NEW
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_ConfirmedContract = new AdminClient.CustomDataGridView();
			this.customDataGridView2 = new AdminClient.CustomDataGridView();
			this.btn_CreateDemand = new System.Windows.Forms.Button();
			this.dgv_ProductionCount = new AdminClient.CustomDataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnl_Main.SuspendLayout();
			this.gb_Sherch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ConfirmedContract)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProductionCount)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer2
			// 
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.dgv_ProductionCount);
			this.splitContainer2.Panel1.Controls.Add(this.dgv_ConfirmedContract);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label3);
			this.splitContainer2.Panel2.Controls.Add(this.customDataGridView2);
			this.splitContainer2.Size = new System.Drawing.Size(1288, 844);
			this.splitContainer2.SplitterDistance = 406;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1468, 9);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_CreateDemand);
			this.panel1.Size = new System.Drawing.Size(1636, 64);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.btn_CreateDemand, 0);
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Size = new System.Drawing.Size(1654, 844);
			this.splitContainer1.SplitterDistance = 329;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 379);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 844);
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(1633, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(1744, 7);
			// 
			// dgv_ConfirmedContract
			// 
			this.dgv_ConfirmedContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_ConfirmedContract.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ConfirmedContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ConfirmedContract.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_ConfirmedContract.GridColor = System.Drawing.Color.Black;
			this.dgv_ConfirmedContract.IsChkVisible = false;
			this.dgv_ConfirmedContract.IsEditVisible = false;
			this.dgv_ConfirmedContract.Location = new System.Drawing.Point(423, 24);
			this.dgv_ConfirmedContract.Name = "dgv_ConfirmedContract";
			this.dgv_ConfirmedContract.RowTemplate.Height = 23;
			this.dgv_ConfirmedContract.Size = new System.Drawing.Size(862, 376);
			this.dgv_ConfirmedContract.TabIndex = 0;
			// 
			// customDataGridView2
			// 
			this.customDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.customDataGridView2.BackgroundColor = System.Drawing.Color.White;
			this.customDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.customDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
			this.customDataGridView2.GridColor = System.Drawing.Color.Black;
			this.customDataGridView2.IsChkVisible = false;
			this.customDataGridView2.IsEditVisible = false;
			this.customDataGridView2.Location = new System.Drawing.Point(3, 25);
			this.customDataGridView2.Name = "customDataGridView2";
			this.customDataGridView2.RowTemplate.Height = 23;
			this.customDataGridView2.Size = new System.Drawing.Size(1282, 406);
			this.customDataGridView2.TabIndex = 0;
			// 
			// btn_CreateDemand
			// 
			this.btn_CreateDemand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CreateDemand.BackColor = System.Drawing.Color.White;
			this.btn_CreateDemand.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_CreateDemand.Image = global::AdminClient.Properties.Resources.Edit_32x32;
			this.btn_CreateDemand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_CreateDemand.Location = new System.Drawing.Point(1386, 9);
			this.btn_CreateDemand.Margin = new System.Windows.Forms.Padding(0);
			this.btn_CreateDemand.Name = "btn_CreateDemand";
			this.btn_CreateDemand.Size = new System.Drawing.Size(82, 47);
			this.btn_CreateDemand.TabIndex = 18;
			this.btn_CreateDemand.Text = "수요계획\r\n생성";
			this.btn_CreateDemand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_CreateDemand.UseVisualStyleBackColor = false;
			// 
			// dgv_ProductionCount
			// 
			this.dgv_ProductionCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgv_ProductionCount.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ProductionCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ProductionCount.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_ProductionCount.GridColor = System.Drawing.Color.Black;
			this.dgv_ProductionCount.IsChkVisible = false;
			this.dgv_ProductionCount.IsEditVisible = false;
			this.dgv_ProductionCount.Location = new System.Drawing.Point(3, 24);
			this.dgv_ProductionCount.Name = "dgv_ProductionCount";
			this.dgv_ProductionCount.RowTemplate.Height = 23;
			this.dgv_ProductionCount.Size = new System.Drawing.Size(397, 376);
			this.dgv_ProductionCount.TabIndex = 1;
			this.dgv_ProductionCount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductionCount_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "총수량(납기일)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(432, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "수주 정보";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "생산 계획";
			// 
			// ProductionPlan_NEW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "ProductionPlan_NEW";
			this.Text = "ProductionPlan_NEW";
			this.Load += new System.EventHandler(this.ProductionPlan_NEW_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ConfirmedContract)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProductionCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomDataGridView dgv_ConfirmedContract;
		private CustomDataGridView customDataGridView2;
		protected System.Windows.Forms.Button btn_CreateDemand;
		private CustomDataGridView dgv_ProductionCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}