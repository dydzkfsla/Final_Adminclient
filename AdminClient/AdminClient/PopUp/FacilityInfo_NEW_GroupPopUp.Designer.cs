namespace AdminClient.PopUp
{
    partial class FacilityInfo_NEW_GroupPopUp
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
			this.txt_FgrpName = new System.Windows.Forms.TextBox();
			this.cbo_FgrpEnable = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt_FgrpCode = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_FgrpDescrip = new System.Windows.Forms.TextBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.pnl_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_Main
			// 
			this.pnl_Main.Controls.Add(this.btn_Update);
			this.pnl_Main.Controls.Add(this.btn_Delete);
			this.pnl_Main.Controls.Add(this.txt_FgrpDescrip);
			this.pnl_Main.Controls.Add(this.btn_Add);
			this.pnl_Main.Controls.Add(this.panel1);
			this.pnl_Main.Controls.Add(this.label2);
			this.pnl_Main.Controls.Add(this.label8);
			this.pnl_Main.Size = new System.Drawing.Size(336, 390);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_Title.Location = new System.Drawing.Point(83, 16);
			this.lbl_Title.Size = new System.Drawing.Size(147, 31);
			this.lbl_Title.Text = "설비군 등록";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(310, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(358, 7);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_FgrpName);
			this.panel1.Controls.Add(this.cbo_FgrpEnable);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.txt_FgrpCode);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(6, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 104);
			this.panel1.TabIndex = 36;
			// 
			// txt_FgrpName
			// 
			this.txt_FgrpName.Location = new System.Drawing.Point(122, 36);
			this.txt_FgrpName.Name = "txt_FgrpName";
			this.txt_FgrpName.Size = new System.Drawing.Size(188, 25);
			this.txt_FgrpName.TabIndex = 43;
			// 
			// cbo_FgrpEnable
			// 
			this.cbo_FgrpEnable.FormattingEnabled = true;
			this.cbo_FgrpEnable.Location = new System.Drawing.Point(122, 67);
			this.cbo_FgrpEnable.Name = "cbo_FgrpEnable";
			this.cbo_FgrpEnable.Size = new System.Drawing.Size(188, 25);
			this.cbo_FgrpEnable.TabIndex = 39;
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
			// txt_FgrpCode
			// 
			this.txt_FgrpCode.Location = new System.Drawing.Point(122, 2);
			this.txt_FgrpCode.Name = "txt_FgrpCode";
			this.txt_FgrpCode.Size = new System.Drawing.Size(188, 25);
			this.txt_FgrpCode.TabIndex = 31;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label20.Location = new System.Drawing.Point(26, 5);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(83, 17);
			this.label20.TabIndex = 30;
			this.label20.Text = "설비군코드";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(26, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "설비군명";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(32, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 41;
			this.label2.Text = "설비군 설명";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(9, 110);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 40;
			this.label8.Text = "◆";
			// 
			// txt_FgrpDescrip
			// 
			this.txt_FgrpDescrip.Location = new System.Drawing.Point(12, 130);
			this.txt_FgrpDescrip.Multiline = true;
			this.txt_FgrpDescrip.Name = "txt_FgrpDescrip";
			this.txt_FgrpDescrip.Size = new System.Drawing.Size(304, 177);
			this.txt_FgrpDescrip.TabIndex = 44;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(78, 313);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(74, 53);
			this.btn_Delete.TabIndex = 56;
			this.btn_Delete.Text = "삭제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(240, 313);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(76, 53);
			this.btn_Add.TabIndex = 54;
			this.btn_Add.Text = "저장";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(158, 313);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(76, 53);
			this.btn_Update.TabIndex = 57;
			this.btn_Update.Text = "수정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// FacilityGroupPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(346, 448);
			this.Name = "FacilityGroupPopUp";
			this.Load += new System.EventHandler(this.FacilityGroupPopUp_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_FgrpEnable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_FgrpCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_FgrpName;
        private System.Windows.Forms.TextBox txt_FgrpDescrip;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Update;
	}
}
