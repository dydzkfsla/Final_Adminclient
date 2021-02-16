namespace AdminClient.BaseForm
{
    partial class FormSerchListTemp
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Xls = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Size = new System.Drawing.Size(1654, 925);
            this.pnl_Main.Controls.SetChildIndex(this.splitContainer1, 0);
            this.pnl_Main.Controls.SetChildIndex(this.panel1, 0);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Location = new System.Drawing.Point(11, 2);
            // 
            // gb_detail
            // 
            this.gb_detail.Location = new System.Drawing.Point(11, 192);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.None;
            this.splitContainer1.Location = new System.Drawing.Point(0, 81);
            this.splitContainer1.Size = new System.Drawing.Size(1654, 844);
            this.splitContainer1.SplitterDistance = 365;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 379);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(33, 844);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1633, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1744, 7);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Image = global::AdminClient.Properties.Resources.EditName_32x32;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(1468, 9);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = " 등록";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_Xls
            // 
            this.btn_Xls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xls.BackColor = System.Drawing.Color.White;
            this.btn_Xls.Image = global::AdminClient.Properties.Resources.ExportToXLS_32x32;
            this.btn_Xls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xls.Location = new System.Drawing.Point(1551, 9);
            this.btn_Xls.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xls.Name = "btn_Xls";
            this.btn_Xls.Size = new System.Drawing.Size(82, 47);
            this.btn_Xls.TabIndex = 3;
            this.btn_Xls.Text = "엑셀";
            this.btn_Xls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xls.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_Xls);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1636, 64);
            this.panel1.TabIndex = 4;
            // 
            // FormSerchListTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1665, 1025);
            this.Name = "FormSerchListTemp";
            this.Load += new System.EventHandler(this.FormSerchListTemp_Load);
            this.pnl_Main.ResumeLayout(false);
            this.gb_Sherch.ResumeLayout(false);
            this.gb_Sherch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btn_add;
        protected System.Windows.Forms.Button btn_Xls;
        protected System.Windows.Forms.Panel panel1;
    }
}
