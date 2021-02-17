namespace AdminClient.PopUp
{
    partial class WareHouseInfoPopUp
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbo_Type = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
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
			this.pnl_Main.Size = new System.Drawing.Size(331, 229);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_Title.Size = new System.Drawing.Size(114, 31);
			this.lbl_Title.Text = "창고정보";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(305, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(353, 7);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txt_Name);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbo_State);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.cbo_Type);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.txt_Code);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Location = new System.Drawing.Point(0, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(325, 145);
			this.panel1.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 45;
			this.label1.Text = "◆";
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(122, 36);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(188, 25);
			this.txt_Name.TabIndex = 44;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(26, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 43;
			this.label3.Text = "창고이름";
			// 
			// cbo_State
			// 
			this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(122, 98);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(188, 25);
			this.cbo_State.TabIndex = 42;
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
			this.label2.Text = "사용여부";
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
			// cbo_Type
			// 
			this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Type.FormattingEnabled = true;
			this.cbo_Type.Location = new System.Drawing.Point(122, 67);
			this.cbo_Type.Name = "cbo_Type";
			this.cbo_Type.Size = new System.Drawing.Size(188, 25);
			this.cbo_Type.TabIndex = 39;
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
			this.label7.Text = "창고용도";
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
			// txt_Code
			// 
			this.txt_Code.Location = new System.Drawing.Point(122, 2);
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.Size = new System.Drawing.Size(188, 25);
			this.txt_Code.TabIndex = 31;
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
			this.label20.Text = "창고코드";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(161, 164);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(74, 53);
			this.btn_Delete.TabIndex = 59;
			this.btn_Delete.Text = "삭제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(88, 164);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(67, 53);
			this.btn_Update.TabIndex = 58;
			this.btn_Update.Text = "수정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(6, 164);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(76, 53);
			this.btn_Add.TabIndex = 57;
			this.btn_Add.Text = "추가";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// WareHouseInfoPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(341, 287);
			this.Name = "WareHouseInfoPopUp";
			this.Load += new System.EventHandler(this.WareHousePopUp_Load);
			this.pnl_Main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
    }
}
