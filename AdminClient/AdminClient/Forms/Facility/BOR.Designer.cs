namespace AdminClient.Forms
{
    partial class BOR
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
            this.dgv_BOR = new AdminClient.CustomDataGridView();
            this.txt_Prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Pcs = new System.Windows.Forms.ComboBox();
            this.cbo_Fac = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BOR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_state);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbo_Fac);
            this.panel1.Controls.Add(this.cbo_Pcs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Prod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(1637, 65);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Prod, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.cbo_Pcs, 0);
            this.panel1.Controls.SetChildIndex(this.cbo_Fac, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Search, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.cbo_state, 0);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1552, 9);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1469, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_BOR);
            this.pnl_Main.Size = new System.Drawing.Size(1655, 967);
            this.pnl_Main.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_Main.Controls.SetChildIndex(this.dgv_BOR, 0);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1629, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1677, 7);
            // 
            // dgv_BOR
            // 
            this.dgv_BOR.AllowUserToAddRows = false;
            this.dgv_BOR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BOR.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BOR.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BOR.GridColor = System.Drawing.Color.Black;
            this.dgv_BOR.IsChkVisible = false;
            this.dgv_BOR.IsEditVisible = true;
            this.dgv_BOR.Location = new System.Drawing.Point(10, 84);
            this.dgv_BOR.Name = "dgv_BOR";
            this.dgv_BOR.RowHeadersVisible = false;
            this.dgv_BOR.RowTemplate.Height = 23;
            this.dgv_BOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BOR.Size = new System.Drawing.Size(1637, 873);
            this.dgv_BOR.TabIndex = 6;
            this.dgv_BOR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BOR_CellContentClick);
            // 
            // txt_Prod
            // 
            this.txt_Prod.Location = new System.Drawing.Point(93, 21);
            this.txt_Prod.Name = "txt_Prod";
            this.txt_Prod.Size = new System.Drawing.Size(100, 25);
            this.txt_Prod.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "품목코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "공정명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "설비명";
            // 
            // cbo_Pcs
            // 
            this.cbo_Pcs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Pcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Pcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Pcs.FormattingEnabled = true;
            this.cbo_Pcs.Location = new System.Drawing.Point(260, 21);
            this.cbo_Pcs.Name = "cbo_Pcs";
            this.cbo_Pcs.Size = new System.Drawing.Size(121, 25);
            this.cbo_Pcs.TabIndex = 18;
            // 
            // cbo_Fac
            // 
            this.cbo_Fac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Fac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Fac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Fac.FormattingEnabled = true;
            this.cbo_Fac.Location = new System.Drawing.Point(457, 21);
            this.cbo_Fac.Name = "cbo_Fac";
            this.cbo_Fac.Size = new System.Drawing.Size(121, 25);
            this.cbo_Fac.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::AdminClient.Properties.Resources.Find_32x32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1386, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 47);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "조회";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbo_state
            // 
            this.cbo_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Location = new System.Drawing.Point(669, 21);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(60, 25);
            this.cbo_state.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(595, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "사용유무";
            // 
            // BOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "BOR";
            this.Load += new System.EventHandler(this.BOR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_BOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Fac;
        private System.Windows.Forms.ComboBox cbo_Pcs;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label label3;
    }
}
