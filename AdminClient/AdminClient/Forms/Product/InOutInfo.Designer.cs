namespace AdminClient.Forms
{
    partial class InOutInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_Unit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_List = new AdminClient.CustomDataGridView();
            this.sch_Ctrl = new AdminClient.SearchControl();
            this.sort_Ctrl = new AdminClient.SortControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.chk_in = new System.Windows.Forms.CheckBox();
            this.chk_out = new System.Windows.Forms.CheckBox();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(124, 43);
            this.lbl_Title.Text = "입출고";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.chk_out);
            this.gb_Sherch.Controls.Add(this.chk_in);
            this.gb_Sherch.Controls.Add(this.txt_Keyword);
            this.gb_Sherch.Controls.Add(this.label3);
            this.gb_Sherch.Controls.Add(this.cbo_Unit);
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.cbo_Category);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Size = new System.Drawing.Size(348, 279);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Category, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_Unit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label3, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.txt_Keyword, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_in, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_out, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sort_Ctrl);
            this.gb_detail.Controls.Add(this.sch_Ctrl);
            this.gb_detail.Location = new System.Drawing.Point(3, 296);
            this.gb_detail.Size = new System.Drawing.Size(348, 197);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(147, 25);
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
            this.splitContainer1.Panel2.Controls.Add(this.dgv_List);
            this.splitContainer1.Size = new System.Drawing.Size(1654, 925);
            this.splitContainer1.SplitterDistance = 365;
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
            this.btn_search.Location = new System.Drawing.Point(269, 18);
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
            // cbo_Unit
            // 
            this.cbo_Unit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Unit.FormattingEnabled = true;
            this.cbo_Unit.Location = new System.Drawing.Point(16, 210);
            this.cbo_Unit.Name = "cbo_Unit";
            this.cbo_Unit.Size = new System.Drawing.Size(222, 25);
            this.cbo_Unit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "단위";
            // 
            // cbo_Category
            // 
            this.cbo_Category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(16, 162);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(222, 25);
            this.cbo_Category.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "품목유형";
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_List.GridColor = System.Drawing.Color.Black;
            this.dgv_List.IsChkVisible = false;
            this.dgv_List.IsEditVisible = false;
            this.dgv_List.Location = new System.Drawing.Point(36, 3);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.RowHeadersVisible = false;
            this.dgv_List.RowTemplate.Height = 23;
            this.dgv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_List.Size = new System.Drawing.Size(1246, 919);
            this.dgv_List.TabIndex = 3;
            // 
            // sch_Ctrl
            // 
            this.sch_Ctrl.BackColor = System.Drawing.Color.Transparent;
            this.sch_Ctrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sch_Ctrl.Location = new System.Drawing.Point(5, 24);
            this.sch_Ctrl.Margin = new System.Windows.Forms.Padding(4);
            this.sch_Ctrl.Name = "sch_Ctrl";
            this.sch_Ctrl.Size = new System.Drawing.Size(320, 75);
            this.sch_Ctrl.TabIndex = 0;
            // 
            // sort_Ctrl
            // 
            this.sort_Ctrl.BackColor = System.Drawing.Color.Transparent;
            this.sort_Ctrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sort_Ctrl.Location = new System.Drawing.Point(3, 98);
            this.sort_Ctrl.Margin = new System.Windows.Forms.Padding(4);
            this.sort_Ctrl.Name = "sort_Ctrl";
            this.sort_Ctrl.Size = new System.Drawing.Size(325, 69);
            this.sort_Ctrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "품목명";
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(16, 114);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(222, 25);
            this.txt_Keyword.TabIndex = 16;
            // 
            // chk_in
            // 
            this.chk_in.AutoSize = true;
            this.chk_in.Location = new System.Drawing.Point(16, 54);
            this.chk_in.Name = "chk_in";
            this.chk_in.Size = new System.Drawing.Size(55, 21);
            this.chk_in.TabIndex = 17;
            this.chk_in.Text = "입고";
            this.chk_in.UseVisualStyleBackColor = true;
            this.chk_in.CheckedChanged += new System.EventHandler(this.chk_in_CheckedChanged);
            // 
            // chk_out
            // 
            this.chk_out.AutoSize = true;
            this.chk_out.Location = new System.Drawing.Point(99, 54);
            this.chk_out.Name = "chk_out";
            this.chk_out.Size = new System.Drawing.Size(55, 21);
            this.chk_out.TabIndex = 18;
            this.chk_out.Text = "출고";
            this.chk_out.UseVisualStyleBackColor = true;
            this.chk_out.CheckedChanged += new System.EventHandler(this.chk_out_CheckedChanged);
            // 
            // InOutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "InOutInfo";
            this.Load += new System.EventHandler(this.InOutInfo_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Category;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_List;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.Label label3;
        private SortControl sort_Ctrl;
        private SearchControl sch_Ctrl;
        private System.Windows.Forms.CheckBox chk_out;
        private System.Windows.Forms.CheckBox chk_in;
    }
}
