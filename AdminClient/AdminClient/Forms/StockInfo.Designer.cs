namespace AdminClient.Forms
{
    partial class StockInfo
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
            this.customDataGridView1 = new AdminClient.CustomDataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.comboBox2);
            this.gb_Sherch.Controls.Add(this.label2);
            this.gb_Sherch.Controls.Add(this.comboBox1);
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Size = new System.Drawing.Size(330, 145);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.comboBox1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label2, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.button1, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.comboBox2, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.comboBox5);
            this.gb_detail.Controls.Add(this.comboBox6);
            this.gb_detail.Controls.Add(this.label3);
            this.gb_detail.Controls.Add(this.button3);
            this.gb_detail.Controls.Add(this.comboBox7);
            this.gb_detail.Controls.Add(this.label4);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.textBox1);
            this.gb_detail.Controls.Add(this.button4);
            this.gb_detail.Controls.Add(this.comboBox4);
            this.gb_detail.Controls.Add(this.comboBox3);
            this.gb_detail.Controls.Add(this.rd_descending);
            this.gb_detail.Controls.Add(this.rd_ascending);
            this.gb_detail.Location = new System.Drawing.Point(3, 151);
            this.gb_detail.Size = new System.Drawing.Size(330, 325);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(135, 25);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.customDataGridView1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 17);
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Location = new System.Drawing.Point(36, 0);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.RowTemplate.Height = 23;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(834, 594);
            this.customDataGridView1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 25);
            this.comboBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "단위";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 25);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "품목유형";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(16, 195);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(222, 25);
            this.comboBox5.TabIndex = 85;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(12, 37);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(214, 25);
            this.comboBox6.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "단위";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::AdminClient.Properties.Resources.BelowAverage_32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(242, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 87);
            this.button3.TabIndex = 94;
            this.button3.Text = "조건\r\n적용";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(16, 147);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(222, 25);
            this.comboBox7.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "검색조건";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "품목";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 25);
            this.textBox1.TabIndex = 87;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(242, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 64);
            this.button4.TabIndex = 93;
            this.button4.Text = "정렬";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 68);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(108, 25);
            this.comboBox4.TabIndex = 89;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(15, 279);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(211, 25);
            this.comboBox3.TabIndex = 90;
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(120, 240);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(106, 21);
            this.rd_descending.TabIndex = 92;
            this.rd_descending.TabStop = true;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Location = new System.Drawing.Point(16, 240);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(98, 21);
            this.rd_ascending.TabIndex = 91;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // StockInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1223, 697);
            this.Name = "StockInfo";
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
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView customDataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
    }
}
