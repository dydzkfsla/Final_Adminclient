namespace AdminClient.PopUp
{
    partial class ProcessInfo_PopUp
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
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.txt_PcsName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt_PcsCode = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.pnl_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_Main
			// 
			this.pnl_Main.Controls.Add(this.btn_Delete);
			this.pnl_Main.Controls.Add(this.panel1);
			this.pnl_Main.Controls.Add(this.btn_Update);
			this.pnl_Main.Controls.Add(this.btn_Add);
			this.pnl_Main.Size = new System.Drawing.Size(351, 193);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Size = new System.Drawing.Size(185, 43);
			this.lbl_Title.Text = "FormBase";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(325, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(373, 7);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbo_State);
			this.panel1.Controls.Add(this.txt_PcsName);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.txt_PcsCode);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(6, 14);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 101);
			this.panel1.TabIndex = 37;
			// 
			// cbo_State
			// 
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(122, 62);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(188, 25);
			this.cbo_State.TabIndex = 52;
			// 
			// txt_PcsName
			// 
			this.txt_PcsName.Location = new System.Drawing.Point(122, 33);
			this.txt_PcsName.Name = "txt_PcsName";
			this.txt_PcsName.Size = new System.Drawing.Size(188, 25);
			this.txt_PcsName.TabIndex = 51;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(26, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 38;
			this.label7.Text = "사용여부";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(3, 65);
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
			// txt_PcsCode
			// 
			this.txt_PcsCode.Location = new System.Drawing.Point(122, 2);
			this.txt_PcsCode.Name = "txt_PcsCode";
			this.txt_PcsCode.Size = new System.Drawing.Size(188, 25);
			this.txt_PcsCode.TabIndex = 31;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label20.Location = new System.Drawing.Point(26, 5);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 17);
			this.label20.TabIndex = 30;
			this.label20.Text = "공정코드";
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
			this.label3.Text = "공정이름";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(123, 121);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(67, 53);
			this.btn_Delete.TabIndex = 59;
			this.btn_Delete.Text = "삭제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(196, 121);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(67, 53);
			this.btn_Update.TabIndex = 58;
			this.btn_Update.Text = "수정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(269, 121);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(67, 53);
			this.btn_Add.TabIndex = 57;
			this.btn_Add.Text = "추가";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// ProcessPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(361, 251);
			this.Name = "ProcessPopUp";
			this.Load += new System.EventHandler(this.ProcessPopUp_Load);
			this.pnl_Main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_PcsName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_PcsCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
    }
}
