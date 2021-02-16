
namespace AdminClient.PopUp
{
    partial class CommandCode
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
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Pcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_common = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.pnl_common.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_common);
            this.pnl_Main.Controls.Add(this.btn_Delete);
            this.pnl_Main.Controls.Add(this.btn_Update);
            this.pnl_Main.Controls.Add(this.btn_add);
            this.pnl_Main.Controls.Add(this.label5);
            this.pnl_Main.Controls.Add(this.txt_Pcode);
            this.pnl_Main.Controls.Add(this.label6);
            this.pnl_Main.Size = new System.Drawing.Size(396, 259);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(185, 43);
            this.lbl_Title.Text = "FormBase";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(370, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(418, 7);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(12, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "◆";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(131, 13);
            this.txt_Code.MaxLength = 7;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(188, 25);
            this.txt_Code.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(35, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "공통코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "◆";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(131, 45);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(188, 25);
            this.txt_Name.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "코드이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "◆";
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(131, 76);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(188, 25);
            this.txt_Category.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(35, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "카테고리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "◆";
            // 
            // txt_Pcode
            // 
            this.txt_Pcode.Location = new System.Drawing.Point(137, 127);
            this.txt_Pcode.MaxLength = 7;
            this.txt_Pcode.Name = "txt_Pcode";
            this.txt_Pcode.Size = new System.Drawing.Size(188, 25);
            this.txt_Pcode.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "부모코드";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(176, 178);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(74, 53);
            this.btn_Delete.TabIndex = 73;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(103, 178);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(67, 53);
            this.btn_Update.TabIndex = 72;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(21, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(76, 53);
            this.btn_add.TabIndex = 71;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_common
            // 
            this.pnl_common.Controls.Add(this.label19);
            this.pnl_common.Controls.Add(this.label20);
            this.pnl_common.Controls.Add(this.txt_Code);
            this.pnl_common.Controls.Add(this.label2);
            this.pnl_common.Controls.Add(this.txt_Name);
            this.pnl_common.Controls.Add(this.label1);
            this.pnl_common.Controls.Add(this.label4);
            this.pnl_common.Controls.Add(this.label3);
            this.pnl_common.Controls.Add(this.txt_Category);
            this.pnl_common.Location = new System.Drawing.Point(6, 11);
            this.pnl_common.Name = "pnl_common";
            this.pnl_common.Size = new System.Drawing.Size(336, 110);
            this.pnl_common.TabIndex = 74;
            // 
            // CommonCodePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(406, 317);
            this.Name = "CommonCodePopUp";
            this.Load += new System.EventHandler(this.CommonPopUp_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.pnl_common.ResumeLayout(false);
            this.pnl_common.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Pcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_common;
    }
}
