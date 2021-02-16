namespace AdminClient.PopUp
{
    partial class BOMPopUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_code = new System.Windows.Forms.Label();
            this.btn_UpItemSch = new System.Windows.Forms.Button();
            this.btn_ProdSearch = new System.Windows.Forms.Button();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_AutoDecreaseState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_ProdP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_Delete);
            this.pnl_Main.Controls.Add(this.btn_Update);
            this.pnl_Main.Controls.Add(this.btn_Add);
            this.pnl_Main.Controls.Add(this.txt_Note);
            this.pnl_Main.Controls.Add(this.label13);
            this.pnl_Main.Controls.Add(this.label14);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Size = new System.Drawing.Size(659, 447);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(176, 43);
            this.lbl_Title.Text = "BOM관리";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(633, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(681, 7);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.btn_UpItemSch);
            this.panel1.Controls.Add(this.btn_ProdSearch);
            this.panel1.Controls.Add(this.dtp_End);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtp_Start);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbo_AutoDecreaseState);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbo_State);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbo_ProdP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txt_Count);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ProdName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 129);
            this.panel1.TabIndex = 35;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(462, 10);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(0, 17);
            this.lbl_code.TabIndex = 7;
            // 
            // btn_UpItemSch
            // 
            this.btn_UpItemSch.Location = new System.Drawing.Point(323, 4);
            this.btn_UpItemSch.Name = "btn_UpItemSch";
            this.btn_UpItemSch.Size = new System.Drawing.Size(124, 28);
            this.btn_UpItemSch.TabIndex = 50;
            this.btn_UpItemSch.Text = "상위 품목 재검색";
            this.btn_UpItemSch.UseVisualStyleBackColor = true;
            this.btn_UpItemSch.Click += new System.EventHandler(this.btn_UpItemSch_Click);
            // 
            // btn_ProdSearch
            // 
            this.btn_ProdSearch.Location = new System.Drawing.Point(538, 5);
            this.btn_ProdSearch.Name = "btn_ProdSearch";
            this.btn_ProdSearch.Size = new System.Drawing.Size(75, 27);
            this.btn_ProdSearch.TabIndex = 49;
            this.btn_ProdSearch.Text = "품목검색";
            this.btn_ProdSearch.UseVisualStyleBackColor = true;
            this.btn_ProdSearch.Click += new System.EventHandler(this.btn_ProdSearch_Click);
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(425, 95);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(188, 25);
            this.dtp_End.TabIndex = 48;
            this.dtp_End.ValueChanged += new System.EventHandler(this.dtp_End_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(320, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "◆";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(343, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "종료일";
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(425, 64);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(188, 25);
            this.dtp_Start.TabIndex = 45;
            this.dtp_Start.ValueChanged += new System.EventHandler(this.dtp_Start_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(320, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "◆";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(343, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "시작일";
            // 
            // cbo_AutoDecreaseState
            // 
            this.cbo_AutoDecreaseState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_AutoDecreaseState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_AutoDecreaseState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_AutoDecreaseState.FormattingEnabled = true;
            this.cbo_AutoDecreaseState.Location = new System.Drawing.Point(122, 97);
            this.cbo_AutoDecreaseState.Name = "cbo_AutoDecreaseState";
            this.cbo_AutoDecreaseState.Size = new System.Drawing.Size(188, 25);
            this.cbo_AutoDecreaseState.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "자동차감";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "◆";
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(122, 66);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(188, 25);
            this.cbo_State.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(26, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "사용유무";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "◆";
            // 
            // cbo_ProdP
            // 
            this.cbo_ProdP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ProdP.FormattingEnabled = true;
            this.cbo_ProdP.Location = new System.Drawing.Point(122, 4);
            this.cbo_ProdP.Name = "cbo_ProdP";
            this.cbo_ProdP.Size = new System.Drawing.Size(188, 25);
            this.cbo_ProdP.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "◆";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(320, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "◆";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(3, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "◆";
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(122, 35);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(188, 25);
            this.txt_Count.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(26, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "상위품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "소요량";
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Location = new System.Drawing.Point(425, 36);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.Size = new System.Drawing.Size(188, 25);
            this.txt_ProdName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(343, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(183, 344);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(74, 53);
            this.btn_Delete.TabIndex = 53;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(110, 344);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(67, 53);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(28, 344);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(76, 53);
            this.btn_Add.TabIndex = 51;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(132, 153);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(515, 169);
            this.txt_Note.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(36, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "비고";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "◆";
            // 
            // BOMPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(669, 505);
            this.Name = "BOMPopUp";
            this.Load += new System.EventHandler(this.BOMPopUp_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_AutoDecreaseState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_ProdP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_UpItemSch;
        private System.Windows.Forms.Button btn_ProdSearch;
        private System.Windows.Forms.Label lbl_code;
    }
}
