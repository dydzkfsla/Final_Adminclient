namespace AdminClient.PopUp
{
    partial class ContractInfoPopUp
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
			this.txt_ContCount = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cbo_ProdName = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cbo_CompName = new System.Windows.Forms.ComboBox();
			this.txt_ContDestination = new System.Windows.Forms.TextBox();
			this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt_ContCode = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.lbl_ContCancelCountMark = new System.Windows.Forms.Label();
			this.lbl_ContCancelCount = new System.Windows.Forms.Label();
			this.txt_ContCancelCount = new System.Windows.Forms.TextBox();
			this.txt_ContNote = new System.Windows.Forms.TextBox();
			this.btn_Update = new System.Windows.Forms.Button();
			this.pnl_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_Main
			// 
			this.pnl_Main.Controls.Add(this.btn_Update);
			this.pnl_Main.Controls.Add(this.txt_ContCancelCount);
			this.pnl_Main.Controls.Add(this.lbl_ContCancelCountMark);
			this.pnl_Main.Controls.Add(this.lbl_ContCancelCount);
			this.pnl_Main.Controls.Add(this.btn_Delete);
			this.pnl_Main.Controls.Add(this.txt_ContNote);
			this.pnl_Main.Controls.Add(this.btn_Add);
			this.pnl_Main.Controls.Add(this.label11);
			this.pnl_Main.Controls.Add(this.label12);
			this.pnl_Main.Controls.Add(this.panel1);
			this.pnl_Main.Size = new System.Drawing.Size(349, 481);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(159, 43);
			this.lbl_Title.Text = "수주등록";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(323, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(371, 7);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_ContCount);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.cbo_ProdName);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.cbo_CompName);
			this.panel1.Controls.Add(this.txt_ContDestination);
			this.panel1.Controls.Add(this.dtp_DueDate);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.txt_ContCode);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(346, 187);
			this.panel1.TabIndex = 36;
			// 
			// txt_ContCount
			// 
			this.txt_ContCount.Location = new System.Drawing.Point(122, 155);
			this.txt_ContCount.Name = "txt_ContCount";
			this.txt_ContCount.Size = new System.Drawing.Size(216, 25);
			this.txt_ContCount.TabIndex = 59;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label15.Location = new System.Drawing.Point(26, 159);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 17);
			this.label15.TabIndex = 58;
			this.label15.Text = "주문수량";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label16.Location = new System.Drawing.Point(3, 159);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(23, 17);
			this.label16.TabIndex = 57;
			this.label16.Text = "◆";
			// 
			// cbo_ProdName
			// 
			this.cbo_ProdName.FormattingEnabled = true;
			this.cbo_ProdName.Location = new System.Drawing.Point(122, 124);
			this.cbo_ProdName.Name = "cbo_ProdName";
			this.cbo_ProdName.Size = new System.Drawing.Size(216, 25);
			this.cbo_ProdName.TabIndex = 56;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label13.Location = new System.Drawing.Point(3, 128);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 17);
			this.label13.TabIndex = 55;
			this.label13.Text = "◆";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label14.Location = new System.Drawing.Point(26, 128);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(38, 17);
			this.label14.TabIndex = 54;
			this.label14.Text = "품목";
			// 
			// cbo_CompName
			// 
			this.cbo_CompName.FormattingEnabled = true;
			this.cbo_CompName.Location = new System.Drawing.Point(122, 33);
			this.cbo_CompName.Name = "cbo_CompName";
			this.cbo_CompName.Size = new System.Drawing.Size(216, 25);
			this.cbo_CompName.TabIndex = 53;
			// 
			// txt_ContDestination
			// 
			this.txt_ContDestination.Location = new System.Drawing.Point(122, 62);
			this.txt_ContDestination.Name = "txt_ContDestination";
			this.txt_ContDestination.Size = new System.Drawing.Size(216, 25);
			this.txt_ContDestination.TabIndex = 52;
			// 
			// dtp_DueDate
			// 
			this.dtp_DueDate.Location = new System.Drawing.Point(122, 93);
			this.dtp_DueDate.Name = "dtp_DueDate";
			this.dtp_DueDate.Size = new System.Drawing.Size(216, 25);
			this.dtp_DueDate.TabIndex = 45;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(3, 97);
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
			this.label10.Location = new System.Drawing.Point(26, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 17);
			this.label10.TabIndex = 43;
			this.label10.Text = "납기일";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(26, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 17);
			this.label7.TabIndex = 38;
			this.label7.Text = "도착지";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(3, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 17);
			this.label6.TabIndex = 37;
			this.label6.Text = "◆";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(3, 37);
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
			this.label19.Location = new System.Drawing.Point(3, 6);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 17);
			this.label19.TabIndex = 33;
			this.label19.Text = "◆";
			// 
			// txt_ContCode
			// 
			this.txt_ContCode.Location = new System.Drawing.Point(122, 2);
			this.txt_ContCode.Name = "txt_ContCode";
			this.txt_ContCode.Size = new System.Drawing.Size(216, 25);
			this.txt_ContCode.TabIndex = 31;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label20.Location = new System.Drawing.Point(26, 6);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 17);
			this.label20.TabIndex = 30;
			this.label20.Text = "수주번호";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(26, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "고객사";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(6, 229);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 17);
			this.label11.TabIndex = 46;
			this.label11.Text = "◆";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(29, 229);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 17);
			this.label12.TabIndex = 47;
			this.label12.Text = "비고";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(128, 419);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(67, 53);
			this.btn_Delete.TabIndex = 56;
			this.btn_Delete.Text = "삭제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(274, 419);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(67, 53);
			this.btn_Add.TabIndex = 54;
			this.btn_Add.Text = "추가";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// lbl_ContCancelCountMark
			// 
			this.lbl_ContCancelCountMark.AutoSize = true;
			this.lbl_ContCancelCountMark.BackColor = System.Drawing.Color.White;
			this.lbl_ContCancelCountMark.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_ContCancelCountMark.ForeColor = System.Drawing.Color.Black;
			this.lbl_ContCancelCountMark.Location = new System.Drawing.Point(6, 203);
			this.lbl_ContCancelCountMark.Name = "lbl_ContCancelCountMark";
			this.lbl_ContCancelCountMark.Size = new System.Drawing.Size(23, 17);
			this.lbl_ContCancelCountMark.TabIndex = 57;
			this.lbl_ContCancelCountMark.Text = "◆";
			// 
			// lbl_ContCancelCount
			// 
			this.lbl_ContCancelCount.AutoSize = true;
			this.lbl_ContCancelCount.BackColor = System.Drawing.Color.White;
			this.lbl_ContCancelCount.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_ContCancelCount.ForeColor = System.Drawing.Color.Black;
			this.lbl_ContCancelCount.Location = new System.Drawing.Point(29, 203);
			this.lbl_ContCancelCount.Name = "lbl_ContCancelCount";
			this.lbl_ContCancelCount.Size = new System.Drawing.Size(68, 17);
			this.lbl_ContCancelCount.TabIndex = 58;
			this.lbl_ContCancelCount.Text = "취소수량";
			// 
			// txt_ContCancelCount
			// 
			this.txt_ContCancelCount.Location = new System.Drawing.Point(125, 200);
			this.txt_ContCancelCount.Name = "txt_ContCancelCount";
			this.txt_ContCancelCount.Size = new System.Drawing.Size(216, 25);
			this.txt_ContCancelCount.TabIndex = 60;
			// 
			// txt_ContNote
			// 
			this.txt_ContNote.Location = new System.Drawing.Point(9, 249);
			this.txt_ContNote.Multiline = true;
			this.txt_ContNote.Name = "txt_ContNote";
			this.txt_ContNote.Size = new System.Drawing.Size(332, 160);
			this.txt_ContNote.TabIndex = 53;
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(201, 419);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(67, 53);
			this.btn_Update.TabIndex = 61;
			this.btn_Update.Text = "수정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// ContractPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(359, 539);
			this.Name = "ContractPopUp";
			this.Load += new System.EventHandler(this.ContractPopUp_Load);
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
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_ContCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ContDestination;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TextBox txt_ContCancelCount;
		private System.Windows.Forms.Label lbl_ContCancelCountMark;
		private System.Windows.Forms.Label lbl_ContCancelCount;
		private System.Windows.Forms.TextBox txt_ContCount;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cbo_ProdName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbo_CompName;
		private System.Windows.Forms.TextBox txt_ContNote;
		private System.Windows.Forms.Button btn_Update;
	}
}
