
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
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dgv_ShipList = new AdminClient.CustomDataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
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
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1379, 9);
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
			this.gb_Sherch.Controls.Add(this.comboBox1);
			this.gb_Sherch.Controls.Add(this.label8);
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Location = new System.Drawing.Point(5, 2);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 174);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label8, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Location = new System.Drawing.Point(4, 180);
			this.gb_detail.Size = new System.Drawing.Size(349, 210);
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
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.dateTimePicker4);
			this.groupBox1.Location = new System.Drawing.Point(5, 93);
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
			// dateTimePicker3
			// 
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(145, 24);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(108, 25);
			this.dateTimePicker3.TabIndex = 4;
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker4.Location = new System.Drawing.Point(7, 24);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(108, 25);
			this.dateTimePicker4.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 62);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(189, 25);
			this.comboBox1.TabIndex = 20;
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
			this.dgv_ShipList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
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
			// Column1
			// 
			this.Column1.HeaderText = "No.";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "수주코드";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "납기일";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "고객사코드";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "고객사명";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "도착지코드";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "도착지명";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "품목코드";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "품목명";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "주문수량";
			this.Column10.Name = "Column10";
			// 
			// Column11
			// 
			this.Column11.HeaderText = "출하된수량";
			this.Column11.Name = "Column11";
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
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private CustomDataGridView dgv_ShipList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private SortControl sortControl1;
		private SearchControl searchControl1;
	}
}