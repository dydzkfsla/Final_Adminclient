namespace AdminClient.Forms.LogIn
{
    partial class Login
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
			this.로그인 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_EmpID = new System.Windows.Forms.TextBox();
			this.txt_EmpPwd = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(606, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Location = new System.Drawing.Point(-172, 0);
			this.TitleColor.Size = new System.Drawing.Size(809, 7);
			// 
			// 로그인
			// 
			this.로그인.AutoSize = true;
			this.로그인.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.로그인.Location = new System.Drawing.Point(139, 424);
			this.로그인.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.로그인.Name = "로그인";
			this.로그인.Size = new System.Drawing.Size(70, 24);
			this.로그인.TabIndex = 4;
			this.로그인.Text = "로그인";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(119, 460);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "비밀번호";
			// 
			// txt_EmpID
			// 
			this.txt_EmpID.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txt_EmpID.Location = new System.Drawing.Point(213, 421);
			this.txt_EmpID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_EmpID.MaxLength = 7;
			this.txt_EmpID.Name = "txt_EmpID";
			this.txt_EmpID.Size = new System.Drawing.Size(210, 32);
			this.txt_EmpID.TabIndex = 6;
			this.txt_EmpID.Text = "Emp0001";
			// 
			// txt_EmpPwd
			// 
			this.txt_EmpPwd.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txt_EmpPwd.Location = new System.Drawing.Point(213, 457);
			this.txt_EmpPwd.Margin = new System.Windows.Forms.Padding(2);
			this.txt_EmpPwd.Name = "txt_EmpPwd";
			this.txt_EmpPwd.Size = new System.Drawing.Size(210, 32);
			this.txt_EmpPwd.TabIndex = 7;
			this.txt_EmpPwd.Text = "sa";
			this.txt_EmpPwd.UseSystemPasswordChar = true;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(427, 421);
			this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(123, 68);
			this.btn_Login.TabIndex = 8;
			this.btn_Login.Text = "로그인";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AdminClient.Properties.Resources.cowboy_2028626_1280;
			this.pictureBox1.Location = new System.Drawing.Point(139, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(359, 403);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(636, 510);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_EmpPwd);
			this.Controls.Add(this.txt_EmpID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.로그인);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3);
			this.Name = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.Form_close, 0);
			this.Controls.SetChildIndex(this.TitleColor, 0);
			this.Controls.SetChildIndex(this.로그인, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.txt_EmpID, 0);
			this.Controls.SetChildIndex(this.txt_EmpPwd, 0);
			this.Controls.SetChildIndex(this.btn_Login, 0);
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 로그인;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.TextBox txt_EmpPwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
