namespace AdminClient.BaseForm
{
    partial class EmpFormNoSerchTemp
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
            this.btn_Xls = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Size = new System.Drawing.Size(781, 597);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Size = new System.Drawing.Size(185, 43);
            this.lbl_Title.Text = "FormBase";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(756, 10);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(817, 7);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_Xls);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 65);
            this.panel1.TabIndex = 5;
            // 
            // btn_Xls
            // 
            this.btn_Xls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xls.BackColor = System.Drawing.Color.White;
            this.btn_Xls.Image = global::AdminClient.Properties.Resources.ExportToXLS_32x32;
            this.btn_Xls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xls.Location = new System.Drawing.Point(674, 9);
            this.btn_Xls.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xls.Name = "btn_Xls";
            this.btn_Xls.Size = new System.Drawing.Size(82, 47);
            this.btn_Xls.TabIndex = 3;
            this.btn_Xls.Text = "엑셀";
            this.btn_Xls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xls.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Image = global::AdminClient.Properties.Resources.EditName_32x32;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(591, 9);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = " 등록";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // EmpFormNoSerchTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(799, 673);
            this.Name = "EmpFormNoSerchTemp";
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btn_Xls;
        protected System.Windows.Forms.Button btn_add;
    }
}
