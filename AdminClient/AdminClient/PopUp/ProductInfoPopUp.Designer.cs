namespace AdminClient.PopUp
{
    partial class ProductInfoPopUp
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
			this.cbo_WH = new System.Windows.Forms.ComboBox();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Safety = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbo_Cate = new System.Windows.Forms.ComboBox();
			this.cbo_State = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_Unit = new System.Windows.Forms.TextBox();
			this.pnl_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_Main
			// 
			this.pnl_Main.Controls.Add(this.txt_Unit);
			this.pnl_Main.Controls.Add(this.label2);
			this.pnl_Main.Controls.Add(this.label7);
			this.pnl_Main.Controls.Add(this.btn_Delete);
			this.pnl_Main.Controls.Add(this.btn_Update);
			this.pnl_Main.Controls.Add(this.btn_Add);
			this.pnl_Main.Controls.Add(this.cbo_State);
			this.pnl_Main.Controls.Add(this.label9);
			this.pnl_Main.Controls.Add(this.txt_Safety);
			this.pnl_Main.Controls.Add(this.label18);
			this.pnl_Main.Controls.Add(this.label10);
			this.pnl_Main.Controls.Add(this.cbo_Cate);
			this.pnl_Main.Controls.Add(this.label4);
			this.pnl_Main.Controls.Add(this.panel1);
			this.pnl_Main.Controls.Add(this.label17);
			this.pnl_Main.Controls.Add(this.label8);
			this.pnl_Main.Size = new System.Drawing.Size(347, 326);
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_Title.Size = new System.Drawing.Size(136, 31);
			this.lbl_Title.Text = "FormBase";
			// 
			// Form_close
			// 
			this.Form_close.Location = new System.Drawing.Point(321, 8);
			// 
			// TitleColor
			// 
			this.TitleColor.Size = new System.Drawing.Size(369, 7);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbo_WH);
			this.panel1.Controls.Add(this.txt_Code);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txt_Name);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(10, 18);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 110);
			this.panel1.TabIndex = 34;
			// 
			// cbo_WH
			// 
			this.cbo_WH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_WH.FormattingEnabled = true;
			this.cbo_WH.Location = new System.Drawing.Point(122, 69);
			this.cbo_WH.Name = "cbo_WH";
			this.cbo_WH.Size = new System.Drawing.Size(188, 25);
			this.cbo_WH.TabIndex = 33;
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
			this.label20.Text = "품목코드";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(26, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "창고코드";
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(122, 33);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(188, 25);
			this.txt_Name.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(26, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "품목이름";
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
			this.label19.TabIndex = 32;
			this.label19.Text = "◆";
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
			this.label5.TabIndex = 9;
			this.label5.Text = "◆";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(3, 69);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "◆";
			// 
			// txt_Safety
			// 
			this.txt_Safety.Location = new System.Drawing.Point(132, 232);
			this.txt_Safety.Name = "txt_Safety";
			this.txt_Safety.Size = new System.Drawing.Size(188, 25);
			this.txt_Safety.TabIndex = 28;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.White;
			this.label18.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label18.ForeColor = System.Drawing.Color.Black;
			this.label18.Location = new System.Drawing.Point(36, 236);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 17);
			this.label18.TabIndex = 27;
			this.label18.Text = "안전재고";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label17.ForeColor = System.Drawing.Color.Black;
			this.label17.Location = new System.Drawing.Point(13, 236);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(23, 17);
			this.label17.TabIndex = 29;
			this.label17.Text = "◆";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(36, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 33;
			this.label4.Text = "구분";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label8.Location = new System.Drawing.Point(13, 143);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 35;
			this.label8.Text = "◆";
			// 
			// cbo_Cate
			// 
			this.cbo_Cate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Cate.FormattingEnabled = true;
			this.cbo_Cate.Location = new System.Drawing.Point(132, 139);
			this.cbo_Cate.Name = "cbo_Cate";
			this.cbo_Cate.Size = new System.Drawing.Size(188, 25);
			this.cbo_Cate.TabIndex = 33;
			// 
			// cbo_State
			// 
			this.cbo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_State.FormattingEnabled = true;
			this.cbo_State.Location = new System.Drawing.Point(132, 170);
			this.cbo_State.Name = "cbo_State";
			this.cbo_State.Size = new System.Drawing.Size(188, 25);
			this.cbo_State.TabIndex = 39;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(36, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 17);
			this.label9.TabIndex = 40;
			this.label9.Text = "단종여부";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(13, 174);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 17);
			this.label10.TabIndex = 41;
			this.label10.Text = "◆";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(183, 264);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(74, 53);
			this.btn_Delete.TabIndex = 46;
			this.btn_Delete.Text = "삭제";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(110, 264);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(67, 53);
			this.btn_Update.TabIndex = 45;
			this.btn_Update.Text = "수정";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(16, 264);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(76, 53);
			this.btn_Add.TabIndex = 44;
			this.btn_Add.Text = "추가";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(36, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 47;
			this.label2.Text = "단위";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(13, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 17);
			this.label7.TabIndex = 48;
			this.label7.Text = "◆";
			// 
			// txt_Unit
			// 
			this.txt_Unit.Location = new System.Drawing.Point(132, 201);
			this.txt_Unit.Name = "txt_Unit";
			this.txt_Unit.Size = new System.Drawing.Size(188, 25);
			this.txt_Unit.TabIndex = 49;
			// 
			// ProductInfoPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.ClientSize = new System.Drawing.Size(357, 384);
			this.Name = "ProductInfoPopUp";
			this.Load += new System.EventHandler(this.ProductPopUp_Load);
			this.pnl_Main.ResumeLayout(false);
			this.pnl_Main.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_State;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Safety;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_Cate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cbo_WH;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}
