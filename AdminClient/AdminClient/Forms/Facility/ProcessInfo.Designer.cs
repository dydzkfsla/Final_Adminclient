
namespace AdminClient.Forms
{
	partial class ProcessInfo
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
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.searchControl1 = new AdminClient.SearchControl();
			this.sortControl1 = new AdminClient.SortControl();
			this.dgv_Process = new AdminClient.CustomDataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_ProcessDetail = new AdminClient.CustomDataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Add_PD = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_Process)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProcessDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer2
			// 
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.dgv_Process);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label3);
			this.splitContainer2.Panel2.Controls.Add(this.dgv_ProcessDetail);
			this.splitContainer2.Size = new System.Drawing.Size(1586, 1106);
			this.splitContainer2.SplitterDistance = 400;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1468, 9);
			this.btn_add.Text = "공정\r\n등록";
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
			this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Add_PD);
			this.panel1.Size = new System.Drawing.Size(1636, 64);
			this.panel1.Controls.SetChildIndex(this.btn_add, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
			this.panel1.Controls.SetChildIndex(this.btn_Add_PD, 0);
			// 
			// pnl_Main
			// 
			this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.cbo_State);
			this.gb_Sherch.Controls.Add(this.label1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 95);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Controls.Add(this.sortControl1);
			this.gb_detail.Controls.Add(this.searchControl1);
			this.gb_detail.Location = new System.Drawing.Point(11, 101);
			this.gb_detail.Size = new System.Drawing.Size(347, 194);
			// 
			// chk_limit
			// 
			this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Size = new System.Drawing.Size(1654, 844);
			this.splitContainer1.SplitterDistance = 516;
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
			this.btn_search.Location = new System.Drawing.Point(253, 18);
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
			// cbo_State
			// 
			this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(99, 48);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(102, 25);
			this.cbo_State.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "사용여부";
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
			this.sortControl1.Size = new System.Drawing.Size(325, 69);
			this.sortControl1.TabIndex = 1;
			// 
			// dgv_Process
			// 
			this.dgv_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Process.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Process.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Process.GridColor = System.Drawing.Color.Black;
			this.dgv_Process.IsChkVisible = false;
			this.dgv_Process.IsEditVisible = true;
			this.dgv_Process.Location = new System.Drawing.Point(3, 25);
			this.dgv_Process.Name = "dgv_Process";
			this.dgv_Process.RowTemplate.Height = 23;
			this.dgv_Process.Size = new System.Drawing.Size(1095, 372);
			this.dgv_Process.TabIndex = 0;
			this.dgv_Process.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Process_CellContentClick);
			this.dgv_Process.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Process_CellDoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "공정목록";
			// 
			// dgv_ProcessDetail
			// 
			this.dgv_ProcessDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_ProcessDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ProcessDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ProcessDetail.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_ProcessDetail.GridColor = System.Drawing.Color.Black;
			this.dgv_ProcessDetail.IsChkVisible = false;
			this.dgv_ProcessDetail.IsEditVisible = true;
			this.dgv_ProcessDetail.Location = new System.Drawing.Point(3, 22);
			this.dgv_ProcessDetail.Name = "dgv_ProcessDetail";
			this.dgv_ProcessDetail.RowTemplate.Height = 23;
			this.dgv_ProcessDetail.Size = new System.Drawing.Size(1095, 415);
			this.dgv_ProcessDetail.TabIndex = 0;
			this.dgv_ProcessDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProcessDetail_CellContentClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "세부공정 목록";
			// 
			// btn_Add_PD
			// 
			this.btn_Add_PD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add_PD.BackColor = System.Drawing.Color.White;
			this.btn_Add_PD.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_Add_PD.Image = global::AdminClient.Properties.Resources.EditName_32x32;
			this.btn_Add_PD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Add_PD.Location = new System.Drawing.Point(1386, 9);
			this.btn_Add_PD.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Add_PD.Name = "btn_Add_PD";
			this.btn_Add_PD.Size = new System.Drawing.Size(82, 47);
			this.btn_Add_PD.TabIndex = 18;
			this.btn_Add_PD.Text = "세부공정\r\n    등록";
			this.btn_Add_PD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Add_PD.UseVisualStyleBackColor = false;
			this.btn_Add_PD.Click += new System.EventHandler(this.btn_Add_PD_Click);
			// 
			// ProcessInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "ProcessInfo";
			this.Text = "ProcessInfo";
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_Process)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ProcessDetail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbo_State;
		private System.Windows.Forms.Label label1;
		private SortControl sortControl1;
		private SearchControl searchControl1;
		private System.Windows.Forms.Label label2;
		private CustomDataGridView dgv_Process;
		private System.Windows.Forms.Label label3;
		private CustomDataGridView dgv_ProcessDetail;
		protected System.Windows.Forms.Button btn_Add_PD;
	}
}