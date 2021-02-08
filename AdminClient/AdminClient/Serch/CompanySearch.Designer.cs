namespace AdminClient.Serch
{
    partial class CompanySearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.customDataGridView1 = new AdminClient.CustomDataGridView();
            this.customDataGridView2 = new AdminClient.CustomDataGridView();
            this.schCtrl = new AdminClient.SearchControl();
            this.sortCtrl = new AdminClient.SortControl();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.customDataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.customDataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(847, 655);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.cbo_Category);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Controls.Add(this.cbo_State);
            this.gb_Sherch.Size = new System.Drawing.Size(347, 201);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_State, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Category, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.radioButton2);
            this.gb_detail.Controls.Add(this.radioButton1);
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Location = new System.Drawing.Point(11, 207);
            this.gb_detail.Size = new System.Drawing.Size(347, 426);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(150, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 370;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(262, 17);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1222, 10);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "업종";
            // 
            // cbo_Category
            // 
            this.cbo_Category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(8, 127);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(244, 25);
            this.cbo_Category.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "사용유무";
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(8, 79);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(244, 25);
            this.cbo_State.TabIndex = 17;
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGridView1.GridColor = System.Drawing.Color.Black;
            this.customDataGridView1.IsChkVisible = false;
            this.customDataGridView1.IsEditVisible = false;
            this.customDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.RowTemplate.Height = 23;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(847, 375);
            this.customDataGridView1.TabIndex = 1;
            // 
            // customDataGridView2
            // 
            this.customDataGridView2.AllowUserToAddRows = false;
            this.customDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGridView2.GridColor = System.Drawing.Color.Black;
            this.customDataGridView2.IsChkVisible = false;
            this.customDataGridView2.IsEditVisible = false;
            this.customDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.customDataGridView2.Name = "customDataGridView2";
            this.customDataGridView2.RowHeadersVisible = false;
            this.customDataGridView2.RowTemplate.Height = 23;
            this.customDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView2.Size = new System.Drawing.Size(847, 276);
            this.customDataGridView2.TabIndex = 2;
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(12, 77);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(320, 75);
            this.schCtrl.TabIndex = 0;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(11, 160);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "회사";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "물품";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // CompanySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1265, 836);
            this.Name = "CompanySearch";
            this.Load += new System.EventHandler(this.CompanySearch_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_State;
        private CustomDataGridView customDataGridView1;
        private CustomDataGridView customDataGridView2;
        private SortControl sortCtrl;
        private SearchControl schCtrl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
