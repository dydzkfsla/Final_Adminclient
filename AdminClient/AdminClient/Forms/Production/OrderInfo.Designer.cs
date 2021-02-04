namespace AdminClient.Forms
{
    partial class OrderInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dgv_Odlist = new AdminClient.CustomDataGridView();
            this.dgv_oddList = new AdminClient.CustomDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.schCtrl = new AdminClient.SearchControl();
            this.sortCtrl = new AdminClient.SortControl();
            this.rb_Today = new System.Windows.Forms.RadioButton();
            this.rb_OneWeek = new System.Windows.Forms.RadioButton();
            this.rb_1Month = new System.Windows.Forms.RadioButton();
            this.rb_3Month = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Odlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oddList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgv_oddList);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button6);
            this.splitContainer3.Panel2.Controls.Add(this.button5);
            this.splitContainer3.Panel2.Controls.Add(this.button4);
            this.splitContainer3.Panel2.Controls.Add(this.textBox5);
            this.splitContainer3.Panel2.Controls.Add(this.textBox4);
            this.splitContainer3.Panel2.Controls.Add(this.textBox3);
            this.splitContainer3.Panel2.Controls.Add(this.textBox2);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(1149, 552);
            this.splitContainer3.SplitterDistance = 779;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_Odlist);
            this.splitContainer2.Size = new System.Drawing.Size(1149, 940);
            this.splitContainer2.SplitterDistance = 382;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1468, 9);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1636, 64);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Size = new System.Drawing.Size(1654, 941);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.groupBox1);
            this.gb_Sherch.Size = new System.Drawing.Size(326, 182);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.sortCtrl);
            this.gb_detail.Controls.Add(this.schCtrl);
            this.gb_detail.Location = new System.Drawing.Point(11, 188);
            this.gb_detail.Size = new System.Drawing.Size(341, 321);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(134, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1654, 860);
            this.splitContainer1.SplitterDistance = 468;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 476);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 860);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(238, 17);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_3Month);
            this.groupBox1.Controls.Add(this.rb_1Month);
            this.groupBox1.Controls.Add(this.rb_OneWeek);
            this.groupBox1.Controls.Add(this.rb_Today);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "납기일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(160, 24);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(108, 25);
            this.dtp_end.TabIndex = 4;
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(22, 24);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(108, 25);
            this.dtp_start.TabIndex = 3;
            // 
            // dgv_Odlist
            // 
            this.dgv_Odlist.AllowUserToAddRows = false;
            this.dgv_Odlist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Odlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Odlist.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Odlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Odlist.GridColor = System.Drawing.Color.Black;
            this.dgv_Odlist.IsChkVisible = false;
            this.dgv_Odlist.IsEditVisible = true;
            this.dgv_Odlist.Location = new System.Drawing.Point(0, 0);
            this.dgv_Odlist.Name = "dgv_Odlist";
            this.dgv_Odlist.RowHeadersVisible = false;
            this.dgv_Odlist.RowTemplate.Height = 23;
            this.dgv_Odlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Odlist.Size = new System.Drawing.Size(1149, 382);
            this.dgv_Odlist.TabIndex = 0;
            this.dgv_Odlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Odlist_CellClick);
            this.dgv_Odlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Odlist_CellContentClick);
            // 
            // dgv_oddList
            // 
            this.dgv_oddList.AllowUserToAddRows = false;
            this.dgv_oddList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_oddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_oddList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_oddList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_oddList.GridColor = System.Drawing.Color.Black;
            this.dgv_oddList.IsChkVisible = false;
            this.dgv_oddList.IsEditVisible = false;
            this.dgv_oddList.Location = new System.Drawing.Point(0, 0);
            this.dgv_oddList.Name = "dgv_oddList";
            this.dgv_oddList.RowHeadersVisible = false;
            this.dgv_oddList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_oddList.Size = new System.Drawing.Size(779, 552);
            this.dgv_oddList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "주문수량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "입고수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "취소수량";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 25);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 25);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(82, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 25);
            this.textBox5.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 29);
            this.button6.TabIndex = 16;
            this.button6.Text = "삭제";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "수정";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "물품추가";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // schCtrl
            // 
            this.schCtrl.BackColor = System.Drawing.Color.Transparent;
            this.schCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schCtrl.Location = new System.Drawing.Point(6, 24);
            this.schCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.schCtrl.Name = "schCtrl";
            this.schCtrl.Size = new System.Drawing.Size(320, 75);
            this.schCtrl.TabIndex = 0;
            // 
            // sortCtrl
            // 
            this.sortCtrl.BackColor = System.Drawing.Color.Transparent;
            this.sortCtrl.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.sortCtrl.Location = new System.Drawing.Point(6, 107);
            this.sortCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.sortCtrl.Name = "sortCtrl";
            this.sortCtrl.Size = new System.Drawing.Size(325, 69);
            this.sortCtrl.TabIndex = 1;
            // 
            // rb_Today
            // 
            this.rb_Today.AutoSize = true;
            this.rb_Today.Location = new System.Drawing.Point(14, 63);
            this.rb_Today.Name = "rb_Today";
            this.rb_Today.Size = new System.Drawing.Size(54, 21);
            this.rb_Today.TabIndex = 6;
            this.rb_Today.TabStop = true;
            this.rb_Today.Text = "당일";
            this.rb_Today.UseVisualStyleBackColor = true;
            this.rb_Today.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_OneWeek
            // 
            this.rb_OneWeek.AutoSize = true;
            this.rb_OneWeek.Location = new System.Drawing.Point(87, 63);
            this.rb_OneWeek.Name = "rb_OneWeek";
            this.rb_OneWeek.Size = new System.Drawing.Size(49, 21);
            this.rb_OneWeek.TabIndex = 7;
            this.rb_OneWeek.TabStop = true;
            this.rb_OneWeek.Text = "1주";
            this.rb_OneWeek.UseVisualStyleBackColor = true;
            this.rb_OneWeek.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_1Month
            // 
            this.rb_1Month.AutoSize = true;
            this.rb_1Month.Location = new System.Drawing.Point(160, 63);
            this.rb_1Month.Name = "rb_1Month";
            this.rb_1Month.Size = new System.Drawing.Size(49, 21);
            this.rb_1Month.TabIndex = 8;
            this.rb_1Month.TabStop = true;
            this.rb_1Month.Text = "1달";
            this.rb_1Month.UseVisualStyleBackColor = true;
            this.rb_1Month.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // rb_3Month
            // 
            this.rb_3Month.AutoSize = true;
            this.rb_3Month.Location = new System.Drawing.Point(226, 63);
            this.rb_3Month.Name = "rb_3Month";
            this.rb_3Month.Size = new System.Drawing.Size(49, 21);
            this.rb_3Month.TabIndex = 9;
            this.rb_3Month.TabStop = true;
            this.rb_3Month.Text = "3달";
            this.rb_3Month.UseVisualStyleBackColor = true;
            this.rb_3Month.CheckedChanged += new System.EventHandler(this.rb_CheckedChange);
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Odlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oddList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private CustomDataGridView dgv_oddList;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgv_Odlist;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private SortControl sortCtrl;
        private SearchControl schCtrl;
        private System.Windows.Forms.RadioButton rb_3Month;
        private System.Windows.Forms.RadioButton rb_1Month;
        private System.Windows.Forms.RadioButton rb_OneWeek;
        private System.Windows.Forms.RadioButton rb_Today;
    }
}
