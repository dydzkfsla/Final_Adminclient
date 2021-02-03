namespace AdminClient.PopUp
{
    partial class BORPopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_BORInfo = new System.Windows.Forms.Panel();
            this.cbo_Pcs = new System.Windows.Forms.ComboBox();
            this.txt_Delay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_State = new System.Windows.Forms.ComboBox();
            this.txt_Priority = new System.Windows.Forms.TextBox();
            this.txt_Tact = new System.Windows.Forms.TextBox();
            this.btn_prodSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Fac = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Prod = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.pnl_BORInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_Delete);
            this.pnl_Main.Controls.Add(this.btn_Update);
            this.pnl_Main.Controls.Add(this.btn_Add);
            this.pnl_Main.Controls.Add(this.txt_Note);
            this.pnl_Main.Controls.Add(this.label14);
            this.pnl_Main.Controls.Add(this.pnl_BORInfo);
            this.pnl_Main.Controls.Add(this.label15);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Size = new System.Drawing.Size(656, 381);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(630, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(678, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "공정명";
            // 
            // pnl_BORInfo
            // 
            this.pnl_BORInfo.Controls.Add(this.lbl_Code);
            this.pnl_BORInfo.Controls.Add(this.cbo_Pcs);
            this.pnl_BORInfo.Controls.Add(this.txt_Delay);
            this.pnl_BORInfo.Controls.Add(this.label4);
            this.pnl_BORInfo.Controls.Add(this.label13);
            this.pnl_BORInfo.Controls.Add(this.cbo_State);
            this.pnl_BORInfo.Controls.Add(this.txt_Priority);
            this.pnl_BORInfo.Controls.Add(this.txt_Tact);
            this.pnl_BORInfo.Controls.Add(this.btn_prodSearch);
            this.pnl_BORInfo.Controls.Add(this.label11);
            this.pnl_BORInfo.Controls.Add(this.label12);
            this.pnl_BORInfo.Controls.Add(this.label9);
            this.pnl_BORInfo.Controls.Add(this.label10);
            this.pnl_BORInfo.Controls.Add(this.label2);
            this.pnl_BORInfo.Controls.Add(this.label8);
            this.pnl_BORInfo.Controls.Add(this.label7);
            this.pnl_BORInfo.Controls.Add(this.label6);
            this.pnl_BORInfo.Controls.Add(this.cbo_Fac);
            this.pnl_BORInfo.Controls.Add(this.label5);
            this.pnl_BORInfo.Controls.Add(this.label19);
            this.pnl_BORInfo.Controls.Add(this.txt_Prod);
            this.pnl_BORInfo.Controls.Add(this.label20);
            this.pnl_BORInfo.Controls.Add(this.label3);
            this.pnl_BORInfo.Location = new System.Drawing.Point(10, 12);
            this.pnl_BORInfo.Name = "pnl_BORInfo";
            this.pnl_BORInfo.Size = new System.Drawing.Size(637, 128);
            this.pnl_BORInfo.TabIndex = 36;
            // 
            // cbo_Pcs
            // 
            this.cbo_Pcs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Pcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Pcs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Pcs.FormattingEnabled = true;
            this.cbo_Pcs.Location = new System.Drawing.Point(435, 33);
            this.cbo_Pcs.Name = "cbo_Pcs";
            this.cbo_Pcs.Size = new System.Drawing.Size(188, 25);
            this.cbo_Pcs.TabIndex = 58;
            // 
            // txt_Delay
            // 
            this.txt_Delay.Location = new System.Drawing.Point(435, 64);
            this.txt_Delay.Name = "txt_Delay";
            this.txt_Delay.Size = new System.Drawing.Size(188, 25);
            this.txt_Delay.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "◆";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(341, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "공정 선행일";
            // 
            // cbo_State
            // 
            this.cbo_State.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_State.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_State.FormattingEnabled = true;
            this.cbo_State.Location = new System.Drawing.Point(435, 96);
            this.cbo_State.Name = "cbo_State";
            this.cbo_State.Size = new System.Drawing.Size(188, 25);
            this.cbo_State.TabIndex = 53;
            // 
            // txt_Priority
            // 
            this.txt_Priority.Location = new System.Drawing.Point(122, 98);
            this.txt_Priority.Name = "txt_Priority";
            this.txt_Priority.Size = new System.Drawing.Size(188, 25);
            this.txt_Priority.TabIndex = 52;
            // 
            // txt_Tact
            // 
            this.txt_Tact.Location = new System.Drawing.Point(122, 67);
            this.txt_Tact.Name = "txt_Tact";
            this.txt_Tact.Size = new System.Drawing.Size(188, 25);
            this.txt_Tact.TabIndex = 51;
            // 
            // btn_prodSearch
            // 
            this.btn_prodSearch.Location = new System.Drawing.Point(321, 3);
            this.btn_prodSearch.Name = "btn_prodSearch";
            this.btn_prodSearch.Size = new System.Drawing.Size(75, 27);
            this.btn_prodSearch.TabIndex = 50;
            this.btn_prodSearch.Text = "품목검색";
            this.btn_prodSearch.UseVisualStyleBackColor = true;
            this.btn_prodSearch.Click += new System.EventHandler(this.btn_prodSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(318, 99);
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
            this.label12.Location = new System.Drawing.Point(341, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "사용유무";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(318, 36);
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
            this.label10.Location = new System.Drawing.Point(341, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "공정";
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
            this.label2.Text = "우선순위";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(26, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tact Time";
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
            // cbo_Fac
            // 
            this.cbo_Fac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Fac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Fac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Fac.FormattingEnabled = true;
            this.cbo_Fac.Location = new System.Drawing.Point(122, 33);
            this.cbo_Fac.Name = "cbo_Fac";
            this.cbo_Fac.Size = new System.Drawing.Size(188, 25);
            this.cbo_Fac.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "◆";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "◆";
            // 
            // txt_Prod
            // 
            this.txt_Prod.Location = new System.Drawing.Point(122, 2);
            this.txt_Prod.Name = "txt_Prod";
            this.txt_Prod.Size = new System.Drawing.Size(188, 25);
            this.txt_Prod.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(26, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "설비";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(132, 146);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(515, 169);
            this.txt_Note.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(36, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "비고";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 17);
            this.label15.TabIndex = 52;
            this.label15.Text = "◆";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(171, 320);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(74, 53);
            this.btn_Delete.TabIndex = 56;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(98, 320);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(67, 53);
            this.btn_Update.TabIndex = 55;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(16, 320);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(76, 53);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(564, 5);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(0, 17);
            this.lbl_Code.TabIndex = 59;
            // 
            // BORPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(666, 439);
            this.Name = "BORPopUp";
            this.Load += new System.EventHandler(this.BORPopUp_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.pnl_BORInfo.ResumeLayout(false);
            this.pnl_BORInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_BORInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Fac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Prod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_prodSearch;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Delay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.TextBox txt_Priority;
        private System.Windows.Forms.TextBox txt_Tact;
        private System.Windows.Forms.ComboBox cbo_Pcs;
        private System.Windows.Forms.Label lbl_Code;
    }
}
