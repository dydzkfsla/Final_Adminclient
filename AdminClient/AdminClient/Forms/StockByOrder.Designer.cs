﻿
namespace AdminClient.Forms
{
	partial class StockByOrder
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.rd_descending = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.rd_ascending = new System.Windows.Forms.RadioButton();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.customDataGridView1 = new AdminClient.CustomDataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1387, 9);
			this.btn_add.Text = "이동\r\n처리";
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1470, 9);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(1305, 9);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(7, 6);
			this.panel1.Size = new System.Drawing.Size(1555, 69);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Update, 0);
			this.panel1.Controls.SetChildIndex(this.label3, 0);
			this.panel1.Controls.SetChildIndex(this.label5, 0);
			this.panel1.Controls.SetChildIndex(this.comboBox1, 0);
			this.panel1.Controls.SetChildIndex(this.label2, 0);
			this.panel1.Controls.SetChildIndex(this.label1, 0);
			this.panel1.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(274, 43);
			this.lbl_Title.Text = "주문별 재고현황";
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1565, 638);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.comboBox3);
			this.gb_Sherch.Controls.Add(this.comboBox4);
			this.gb_Sherch.Controls.Add(this.label7);
			this.gb_Sherch.Controls.Add(this.label8);
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Size = new System.Drawing.Size(295, 228);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.button1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label8, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label7, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.comboBox4, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.comboBox3, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.comboBox5);
			this.gb_detail.Controls.Add(this.button3);
			this.gb_detail.Controls.Add(this.comboBox7);
			this.gb_detail.Controls.Add(this.button4);
			this.gb_detail.Controls.Add(this.label9);
			this.gb_detail.Controls.Add(this.rd_descending);
			this.gb_detail.Controls.Add(this.label10);
			this.gb_detail.Controls.Add(this.rd_ascending);
			this.gb_detail.Controls.Add(this.comboBox6);
			this.gb_detail.Controls.Add(this.comboBox8);
			this.gb_detail.Controls.Add(this.comboBox9);
			this.gb_detail.Controls.Add(this.textBox4);
			this.gb_detail.Controls.Add(this.label11);
			this.gb_detail.Location = new System.Drawing.Point(11, 234);
			this.gb_detail.Size = new System.Drawing.Size(295, 319);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(7, 80);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.customDataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(1565, 557);
			this.splitContainer1.SplitterDistance = 317;
			// 
			// btn_folding
			// 
			this.btn_folding.Location = new System.Drawing.Point(0, 235);
			// 
			// splitter1
			// 
			this.splitter1.Size = new System.Drawing.Size(33, 557);
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(1544, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(1655, 7);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(161, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 25);
			this.comboBox1.TabIndex = 39;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(54, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 17);
			this.label5.TabIndex = 38;
			this.label5.Text = "◆";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(77, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 17);
			this.label3.TabIndex = 37;
			this.label3.Text = "From창고";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(504, 21);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(188, 25);
			this.comboBox2.TabIndex = 42;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(418, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 41;
			this.label1.Text = "◆";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(441, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 40;
			this.label2.Text = "To창고";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(12, 124);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(189, 25);
			this.comboBox3.TabIndex = 22;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(12, 74);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(189, 25);
			this.comboBox4.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 17);
			this.label7.TabIndex = 20;
			this.label7.Text = "품목";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "고객사";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.dateTimePicker4);
			this.groupBox1.Location = new System.Drawing.Point(5, 159);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 64);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "날짜";
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
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(14, 200);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(189, 25);
			this.comboBox5.TabIndex = 61;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Image = global::AdminClient.Properties.Resources.BelowAverage_32x32;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(209, 40);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(74, 56);
			this.button3.TabIndex = 70;
			this.button3.Text = "조건\r\n적용";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// comboBox7
			// 
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(14, 150);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(189, 25);
			this.comboBox7.TabIndex = 60;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(209, 240);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(74, 59);
			this.button4.TabIndex = 69;
			this.button4.Text = "정렬";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 178);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 17);
			this.label9.TabIndex = 59;
			this.label9.Text = "품목";
			// 
			// rd_descending
			// 
			this.rd_descending.AutoSize = true;
			this.rd_descending.Location = new System.Drawing.Point(108, 240);
			this.rd_descending.Name = "rd_descending";
			this.rd_descending.Size = new System.Drawing.Size(106, 21);
			this.rd_descending.TabIndex = 68;
			this.rd_descending.TabStop = true;
			this.rd_descending.Text = "Descending";
			this.rd_descending.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 130);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 17);
			this.label10.TabIndex = 58;
			this.label10.Text = "고객사";
			// 
			// rd_ascending
			// 
			this.rd_ascending.AutoSize = true;
			this.rd_ascending.Location = new System.Drawing.Point(13, 240);
			this.rd_ascending.Name = "rd_ascending";
			this.rd_ascending.Size = new System.Drawing.Size(98, 21);
			this.rd_ascending.TabIndex = 67;
			this.rd_ascending.TabStop = true;
			this.rd_ascending.Text = "Ascending";
			this.rd_ascending.UseVisualStyleBackColor = true;
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(14, 274);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(189, 25);
			this.comboBox6.TabIndex = 66;
			// 
			// comboBox8
			// 
			this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(11, 71);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(108, 25);
			this.comboBox8.TabIndex = 65;
			// 
			// comboBox9
			// 
			this.comboBox9.FormattingEnabled = true;
			this.comboBox9.Location = new System.Drawing.Point(11, 40);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(192, 25);
			this.comboBox9.TabIndex = 64;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(11, 102);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 25);
			this.textBox4.TabIndex = 63;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 17);
			this.label11.TabIndex = 62;
			this.label11.Text = "검색조건";
			// 
			// customDataGridView1
			// 
			this.customDataGridView1.AllowUserToAddRows = false;
			this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column2});
			this.customDataGridView1.Location = new System.Drawing.Point(36, 2);
			this.customDataGridView1.Name = "customDataGridView1";
			this.customDataGridView1.RowHeadersVisible = false;
			this.customDataGridView1.RowTemplate.Height = 23;
			this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.customDataGridView1.Size = new System.Drawing.Size(1198, 551);
			this.customDataGridView1.TabIndex = 4;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "No.";
			this.Column1.Name = "Column1";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "품목코드";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "품목명";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "고객사코드";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "고객사";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "잔여수량";
			this.Column10.Name = "Column10";
			// 
			// Column11
			// 
			this.Column11.HeaderText = "From창고";
			this.Column11.Name = "Column11";
			// 
			// Column12
			// 
			this.Column12.HeaderText = "From창고재고";
			this.Column12.Name = "Column12";
			// 
			// Column13
			// 
			this.Column13.HeaderText = "To창고";
			this.Column13.Name = "Column13";
			// 
			// Column14
			// 
			this.Column14.HeaderText = "To창고재고";
			this.Column14.Name = "Column14";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "이동수량";
			this.Column2.Name = "Column2";
			// 
			// StockByOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1576, 738);
			this.Name = "StockByOrder";
			this.Text = "StockByOrder";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
			((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rd_descending;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton rd_ascending;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label11;
		private CustomDataGridView customDataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}