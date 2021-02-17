
namespace AdminClient.Forms
{
	partial class OutSourcingPlan
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
			this.dgv_Plan = new AdminClient.CustomDataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp_to = new System.Windows.Forms.DateTimePicker();
			this.dtp_from = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.pnl_Main.SuspendLayout();
			this.gb_Sherch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Plan)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1476, 9);
			this.btn_add.Visible = false;
			// 
			// btn_Xls
			// 
			this.btn_Xls.Location = new System.Drawing.Point(1559, 9);
			this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(7, 6);
			this.panel1.Size = new System.Drawing.Size(1644, 69);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(169, 43);
			this.lbl_Title.Text = "외주 계획";
			// 
			// gb_Sherch
			// 
			this.gb_Sherch.Controls.Add(this.groupBox1);
			this.gb_Sherch.Size = new System.Drawing.Size(348, 130);
			this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
			this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
			// 
			// gb_detail
			// 
			this.gb_detail.Location = new System.Drawing.Point(11, 234);
			this.gb_detail.Size = new System.Drawing.Size(348, 230);
			this.gb_detail.Visible = false;
			// 
			// nu_limit
			// 
			this.nu_limit.Visible = false;
			// 
			// chk_limit
			// 
			this.chk_limit.Visible = false;
			this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(7, 80);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgv_Plan);
			this.splitContainer1.Size = new System.Drawing.Size(1647, 844);
			this.splitContainer1.SplitterDistance = 381;
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(264, 17);
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// dgv_Plan
			// 
			this.dgv_Plan.AllowUserToAddRows = false;
			this.dgv_Plan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Plan.BackgroundColor = System.Drawing.Color.White;
			this.dgv_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Plan.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Plan.GridColor = System.Drawing.Color.Black;
			this.dgv_Plan.IsChkVisible = false;
			this.dgv_Plan.IsEditVisible = false;
			this.dgv_Plan.Location = new System.Drawing.Point(36, 3);
			this.dgv_Plan.Name = "dgv_Plan";
			this.dgv_Plan.RowHeadersVisible = false;
			this.dgv_Plan.RowTemplate.Height = 23;
			this.dgv_Plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Plan.Size = new System.Drawing.Size(1220, 838);
			this.dgv_Plan.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtp_to);
			this.groupBox1.Controls.Add(this.dtp_from);
			this.groupBox1.Location = new System.Drawing.Point(5, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 64);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "날짜";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(120, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "~";
			// 
			// dtp_to
			// 
			this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_to.Location = new System.Drawing.Point(138, 24);
			this.dtp_to.Name = "dtp_to";
			this.dtp_to.Size = new System.Drawing.Size(108, 25);
			this.dtp_to.TabIndex = 4;
			// 
			// dtp_from
			// 
			this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_from.Location = new System.Drawing.Point(12, 24);
			this.dtp_from.Name = "dtp_from";
			this.dtp_from.Size = new System.Drawing.Size(108, 25);
			this.dtp_from.TabIndex = 3;
			// 
			// OutSourcingPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1665, 1025);
			this.Name = "OutSourcingPlan";
			this.Text = "OutSourcingPlan";
			this.Load += new System.EventHandler(this.OutSourcingPlan_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_Plan)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private CustomDataGridView dgv_Plan;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp_to;
		private System.Windows.Forms.DateTimePicker dtp_from;
	}
}