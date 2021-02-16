namespace AdminClient.Forms
{
    partial class WorkOrderInfo
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_woList = new AdminClient.CustomDataGridView();
            this.dtp_wfrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_wto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_work = new System.Windows.Forms.GroupBox();
            this.gb_due = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_dto = new System.Windows.Forms.DateTimePicker();
            this.dtp_dfrom = new System.Windows.Forms.DateTimePicker();
            this.sortCtrl = new AdminClient.SortControl();
            this.schCtrl = new AdminClient.SearchControl();
            this.chk_Work = new System.Windows.Forms.CheckBox();
            this.chk_Due = new System.Windows.Forms.CheckBox();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_woList)).BeginInit();
            this.gb_work.SuspendLayout();
            this.gb_due.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.chk_Due);
            this.gb_Sherch.Controls.Add(this.chk_Work);
            this.gb_Sherch.Controls.Add(this.gb_due);
            this.gb_Sherch.Controls.Add(this.gb_work);
            this.gb_Sherch.Location = new System.Drawing.Point(11, 3);
            this.gb_Sherch.Size = new System.Drawing.Size(348, 233);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.gb_work, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.gb_due, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_Work, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_Due, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Location = new System.Drawing.Point(11, 240);
            this.gb_detail.Size = new System.Drawing.Size(348, 196);
            // 
            // nu_limit
            // 
            this.nu_limit.Location = new System.Drawing.Point(96, 21);
            this.nu_limit.Size = new System.Drawing.Size(147, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.Location = new System.Drawing.Point(9, 22);
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_woList);
            this.splitContainer1.Size = new System.Drawing.Size(1654, 925);
            this.splitContainer1.SplitterDistance = 370;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 419);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 925);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(269, 17);
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
            // dgv_woList
            // 
            this.dgv_woList.AllowUserToAddRows = false;
            this.dgv_woList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_woList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_woList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_woList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_woList.GridColor = System.Drawing.Color.Black;
            this.dgv_woList.IsChkVisible = false;
            this.dgv_woList.IsEditVisible = false;
            this.dgv_woList.Location = new System.Drawing.Point(36, 3);
            this.dgv_woList.Name = "dgv_woList";
            this.dgv_woList.RowHeadersVisible = false;
            this.dgv_woList.RowTemplate.Height = 23;
            this.dgv_woList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_woList.Size = new System.Drawing.Size(1243, 919);
            this.dgv_woList.TabIndex = 3;
            // 
            // dtp_wfrom
            // 
            this.dtp_wfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_wfrom.Location = new System.Drawing.Point(7, 24);
            this.dtp_wfrom.Name = "dtp_wfrom";
            this.dtp_wfrom.Size = new System.Drawing.Size(119, 25);
            this.dtp_wfrom.TabIndex = 6;
            // 
            // dtp_wto
            // 
            this.dtp_wto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_wto.Location = new System.Drawing.Point(159, 24);
            this.dtp_wto.Name = "dtp_wto";
            this.dtp_wto.Size = new System.Drawing.Size(119, 25);
            this.dtp_wto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "~";
            // 
            // gb_work
            // 
            this.gb_work.Controls.Add(this.label3);
            this.gb_work.Controls.Add(this.dtp_wto);
            this.gb_work.Controls.Add(this.dtp_wfrom);
            this.gb_work.Location = new System.Drawing.Point(7, 100);
            this.gb_work.Name = "gb_work";
            this.gb_work.Size = new System.Drawing.Size(298, 58);
            this.gb_work.TabIndex = 13;
            this.gb_work.TabStop = false;
            this.gb_work.Text = "작업일자";
            // 
            // gb_due
            // 
            this.gb_due.Controls.Add(this.label2);
            this.gb_due.Controls.Add(this.dtp_dto);
            this.gb_due.Controls.Add(this.dtp_dfrom);
            this.gb_due.Location = new System.Drawing.Point(7, 164);
            this.gb_due.Name = "gb_due";
            this.gb_due.Size = new System.Drawing.Size(298, 58);
            this.gb_due.TabIndex = 14;
            this.gb_due.TabStop = false;
            this.gb_due.Text = "납기일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // dtp_dto
            // 
            this.dtp_dto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dto.Location = new System.Drawing.Point(159, 24);
            this.dtp_dto.Name = "dtp_dto";
            this.dtp_dto.Size = new System.Drawing.Size(119, 25);
            this.dtp_dto.TabIndex = 7;
            // 
            // dtp_dfrom
            // 
            this.dtp_dfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dfrom.Location = new System.Drawing.Point(7, 24);
            this.dtp_dfrom.Name = "dtp_dfrom";
            this.dtp_dfrom.Size = new System.Drawing.Size(119, 25);
            this.dtp_dfrom.TabIndex = 6;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(14, 111);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 0;
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(14, 28);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(320, 75);
            this.schCtrl.TabIndex = 1;
            // 
            // chk_Work
            // 
            this.chk_Work.AutoSize = true;
            this.chk_Work.Location = new System.Drawing.Point(76, 102);
            this.chk_Work.Name = "chk_Work";
            this.chk_Work.Size = new System.Drawing.Size(15, 14);
            this.chk_Work.TabIndex = 9;
            this.chk_Work.UseVisualStyleBackColor = true;
            this.chk_Work.CheckedChanged += new System.EventHandler(this.chk_Work_CheckedChanged);
            // 
            // chk_Due
            // 
            this.chk_Due.AutoSize = true;
            this.chk_Due.Location = new System.Drawing.Point(76, 166);
            this.chk_Due.Name = "chk_Due";
            this.chk_Due.Size = new System.Drawing.Size(15, 14);
            this.chk_Due.TabIndex = 15;
            this.chk_Due.UseVisualStyleBackColor = true;
            this.chk_Due.CheckedChanged += new System.EventHandler(this.chk_Due_CheckedChanged);
            // 
            // WorkOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "WorkOrderInfo";
            this.Load += new System.EventHandler(this.WorkOrderInfo_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_woList)).EndInit();
            this.gb_work.ResumeLayout(false);
            this.gb_work.PerformLayout();
            this.gb_due.ResumeLayout(false);
            this.gb_due.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_woList;
        private System.Windows.Forms.GroupBox gb_due;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_dto;
        private System.Windows.Forms.DateTimePicker dtp_dfrom;
        private System.Windows.Forms.GroupBox gb_work;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_wto;
        private System.Windows.Forms.DateTimePicker dtp_wfrom;
        private SearchControl schCtrl;
        private SortControl sortCtrl;
        private System.Windows.Forms.CheckBox chk_Due;
        private System.Windows.Forms.CheckBox chk_Work;
    }
}
