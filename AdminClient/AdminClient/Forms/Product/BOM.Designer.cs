namespace AdminClient.Forms
{
    partial class BOM
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
            this.dgv_bom = new AdminClient.CustomDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_choice = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ProdSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ProdSearch);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbo_state);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.cbo_choice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Code);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(1629, 65);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.cbo_choice, 0);
            this.panel1.Controls.SetChildIndex(this.dtp_date, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.cbo_state, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Search, 0);
            this.panel1.Controls.SetChildIndex(this.btn_ProdSearch, 0);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1544, 9);
            this.btn_Xls.Click += new System.EventHandler(this.btn_Xls_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1461, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_bom);
            this.pnl_Main.Size = new System.Drawing.Size(1647, 958);
            this.pnl_Main.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_Main.Controls.SetChildIndex(this.dgv_bom, 0);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(106, 43);
            this.lbl_Title.Text = "BOM";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1629, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1677, 7);
            // 
            // dgv_bom
            // 
            this.dgv_bom.AllowUserToAddRows = false;
            this.dgv_bom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bom.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bom.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bom.GridColor = System.Drawing.Color.Black;
            this.dgv_bom.IsChkVisible = false;
            this.dgv_bom.IsEditVisible = true;
            this.dgv_bom.Location = new System.Drawing.Point(10, 87);
            this.dgv_bom.Name = "dgv_bom";
            this.dgv_bom.RowHeadersVisible = false;
            this.dgv_bom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bom.Size = new System.Drawing.Size(1625, 856);
            this.dgv_bom.TabIndex = 6;
            this.dgv_bom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bom_CellContentClick);
            this.dgv_bom.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_BOMList_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "기준일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "품목코드";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(297, 20);
            this.txt_Code.MaxLength = 7;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(112, 25);
            this.txt_Code.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "전개방식";
            // 
            // cbo_choice
            // 
            this.cbo_choice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_choice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_choice.FormattingEnabled = true;
            this.cbo_choice.Location = new System.Drawing.Point(596, 20);
            this.cbo_choice.Name = "cbo_choice";
            this.cbo_choice.Size = new System.Drawing.Size(121, 25);
            this.cbo_choice.TabIndex = 11;
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(88, 20);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(119, 25);
            this.dtp_date.TabIndex = 12;
            // 
            // cbo_state
            // 
            this.cbo_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Location = new System.Drawing.Point(809, 20);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(60, 25);
            this.cbo_state.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(735, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "사용유무";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::AdminClient.Properties.Resources.Find_32x32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1378, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 47);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "조회";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ProdSearch
            // 
            this.btn_ProdSearch.BackColor = System.Drawing.Color.White;
            this.btn_ProdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ProdSearch.Location = new System.Drawing.Point(415, 20);
            this.btn_ProdSearch.Name = "btn_ProdSearch";
            this.btn_ProdSearch.Size = new System.Drawing.Size(75, 25);
            this.btn_ProdSearch.TabIndex = 16;
            this.btn_ProdSearch.Text = "검색";
            this.btn_ProdSearch.UseVisualStyleBackColor = false;
            this.btn_ProdSearch.Click += new System.EventHandler(this.btn_ProdSearch_Click);
            // 
            // BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "BOM";
            this.Load += new System.EventHandler(this.BOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_bom;
        private System.Windows.Forms.ComboBox cbo_choice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_ProdSearch;
    }
}
