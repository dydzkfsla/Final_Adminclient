namespace AdminClient.BaseForm
{
    partial class FormListTemp
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.gb_Sherch = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.nu_limit = new System.Windows.Forms.NumericUpDown();
            this.chk_limit = new System.Windows.Forms.CheckBox();
            this.btn_folding = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1191, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1302, 7);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Location = new System.Drawing.Point(11, 28);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title.Size = new System.Drawing.Size(121, 43);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "label1";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.splitContainer1);
            this.pnl_Main.Location = new System.Drawing.Point(0, 89);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1212, 597);
            this.pnl_Main.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gb_detail);
            this.splitContainer1.Panel1.Controls.Add(this.gb_Sherch);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_folding);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(1212, 597);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gb_detail
            // 
            this.gb_detail.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_detail.Location = new System.Drawing.Point(3, 193);
            this.gb_detail.Margin = new System.Windows.Forms.Padding(2);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Padding = new System.Windows.Forms.Padding(2);
            this.gb_detail.Size = new System.Drawing.Size(285, 194);
            this.gb_detail.TabIndex = 1;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "세부검색";
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.btn_search);
            this.gb_Sherch.Controls.Add(this.nu_limit);
            this.gb_Sherch.Controls.Add(this.chk_limit);
            this.gb_Sherch.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_Sherch.Location = new System.Drawing.Point(3, 2);
            this.gb_Sherch.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Sherch.Name = "gb_Sherch";
            this.gb_Sherch.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Sherch.Size = new System.Drawing.Size(285, 186);
            this.gb_Sherch.TabIndex = 0;
            this.gb_Sherch.TabStop = false;
            this.gb_Sherch.Text = "검색조건";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Image = global::AdminClient.Properties.Resources.Find_32x32;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(206, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(74, 64);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "검색";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // nu_limit
            // 
            this.nu_limit.Location = new System.Drawing.Point(99, 17);
            this.nu_limit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nu_limit.Name = "nu_limit";
            this.nu_limit.Size = new System.Drawing.Size(102, 25);
            this.nu_limit.TabIndex = 1;
            // 
            // chk_limit
            // 
            this.chk_limit.AutoSize = true;
            this.chk_limit.Location = new System.Drawing.Point(12, 18);
            this.chk_limit.Margin = new System.Windows.Forms.Padding(2);
            this.chk_limit.Name = "chk_limit";
            this.chk_limit.Size = new System.Drawing.Size(83, 21);
            this.chk_limit.TabIndex = 0;
            this.chk_limit.Text = "검색제한";
            this.chk_limit.UseVisualStyleBackColor = true;
            // 
            // btn_folding
            // 
            this.btn_folding.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_folding.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_folding.Location = new System.Drawing.Point(0, 255);
            this.btn_folding.Margin = new System.Windows.Forms.Padding(0);
            this.btn_folding.Name = "btn_folding";
            this.btn_folding.Size = new System.Drawing.Size(33, 63);
            this.btn_folding.TabIndex = 2;
            this.btn_folding.Text = "<<";
            this.btn_folding.UseVisualStyleBackColor = true;
            this.btn_folding.Click += new System.EventHandler(this.btn_folding_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(33, 597);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormListTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1223, 697);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FormListTemp";
            this.Load += new System.EventHandler(this.FormListTemp_Load);
            this.Controls.SetChildIndex(this.lbl_Title, 0);
            this.Controls.SetChildIndex(this.pnl_Main, 0);
            this.Controls.SetChildIndex(this.Form_close, 0);
            this.Controls.SetChildIndex(this.TitleColor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_Sherch.ResumeLayout(false);
            this.gb_Sherch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbl_Title;
        protected System.Windows.Forms.Panel pnl_Main;
        protected System.Windows.Forms.GroupBox gb_Sherch;
        protected System.Windows.Forms.GroupBox gb_detail;
        protected System.Windows.Forms.NumericUpDown nu_limit;
        protected System.Windows.Forms.CheckBox chk_limit;
        public System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.Button btn_folding;
        protected System.Windows.Forms.Splitter splitter1;
        protected System.Windows.Forms.Button btn_search;
    }
}
