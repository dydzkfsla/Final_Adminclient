namespace AdminClient.BaseForm
{
    partial class EmpFormTemp
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(827, 8);
            // 
            // Form_maximise
            // 
            this.Form_maximise.Location = new System.Drawing.Point(791, 9);
            // 
            // From_minimize
            // 
            this.From_minimize.Location = new System.Drawing.Point(755, 9);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(875, 7);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Location = new System.Drawing.Point(6, 55);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(853, 615);
            this.pnl_Main.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Location = new System.Drawing.Point(8, 9);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title.Size = new System.Drawing.Size(121, 43);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "label1";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(863, 673);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Main);
            this.Name = "FormBase1";
            this.Controls.SetChildIndex(this.Form_close, 0);
            this.Controls.SetChildIndex(this.TitleColor, 0);
            this.Controls.SetChildIndex(this.Form_maximise, 0);
            this.Controls.SetChildIndex(this.From_minimize, 0);
            this.Controls.SetChildIndex(this.pnl_Main, 0);
            this.Controls.SetChildIndex(this.lbl_Title, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnl_Main;
        protected System.Windows.Forms.Label lbl_Title;
    }
}
