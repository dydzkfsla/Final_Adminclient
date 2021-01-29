namespace AdminClient
{
    partial class SearchControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbo_key = new System.Windows.Forms.ComboBox();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.cbo_keyword = new System.Windows.Forms.ComboBox();
            this.pnl_string = new System.Windows.Forms.Panel();
            this.pnl_int = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IntTo = new System.Windows.Forms.TextBox();
            this.txt_IntFrom = new System.Windows.Forms.TextBox();
            this.pnl_DateTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.pnl_string.SuspendLayout();
            this.pnl_int.SuspendLayout();
            this.pnl_DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::AdminClient.Properties.Resources.BelowAverage_32x32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(248, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(74, 67);
            this.btn_Search.TabIndex = 108;
            this.btn_Search.Text = "조건\r\n적용";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbo_key
            // 
            this.cbo_key.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_key.FormattingEnabled = true;
            this.cbo_key.Location = new System.Drawing.Point(0, 3);
            this.cbo_key.Name = "cbo_key";
            this.cbo_key.Size = new System.Drawing.Size(238, 25);
            this.cbo_key.TabIndex = 110;
            this.cbo_key.SelectedIndexChanged += new System.EventHandler(this.cbo_key_SelectedIndexChanged);
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(99, 3);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(139, 25);
            this.txt_keyword.TabIndex = 109;
            // 
            // cbo_keyword
            // 
            this.cbo_keyword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_keyword.FormattingEnabled = true;
            this.cbo_keyword.Location = new System.Drawing.Point(3, 3);
            this.cbo_keyword.Name = "cbo_keyword";
            this.cbo_keyword.Size = new System.Drawing.Size(90, 25);
            this.cbo_keyword.TabIndex = 111;
            // 
            // pnl_string
            // 
            this.pnl_string.Controls.Add(this.txt_keyword);
            this.pnl_string.Controls.Add(this.cbo_keyword);
            this.pnl_string.Location = new System.Drawing.Point(0, 34);
            this.pnl_string.Name = "pnl_string";
            this.pnl_string.Size = new System.Drawing.Size(241, 32);
            this.pnl_string.TabIndex = 112;
            // 
            // pnl_int
            // 
            this.pnl_int.Controls.Add(this.label1);
            this.pnl_int.Controls.Add(this.txt_IntTo);
            this.pnl_int.Controls.Add(this.txt_IntFrom);
            this.pnl_int.Location = new System.Drawing.Point(0, 37);
            this.pnl_int.Name = "pnl_int";
            this.pnl_int.Size = new System.Drawing.Size(241, 33);
            this.pnl_int.TabIndex = 113;
            this.pnl_int.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "~";
            // 
            // txt_IntTo
            // 
            this.txt_IntTo.Location = new System.Drawing.Point(124, 5);
            this.txt_IntTo.Name = "txt_IntTo";
            this.txt_IntTo.Size = new System.Drawing.Size(114, 25);
            this.txt_IntTo.TabIndex = 6;
            // 
            // txt_IntFrom
            // 
            this.txt_IntFrom.Location = new System.Drawing.Point(3, 5);
            this.txt_IntFrom.Name = "txt_IntFrom";
            this.txt_IntFrom.Size = new System.Drawing.Size(98, 25);
            this.txt_IntFrom.TabIndex = 5;
            // 
            // pnl_DateTime
            // 
            this.pnl_DateTime.Controls.Add(this.label2);
            this.pnl_DateTime.Controls.Add(this.dtp_to);
            this.pnl_DateTime.Controls.Add(this.dtp_From);
            this.pnl_DateTime.Location = new System.Drawing.Point(-1, 36);
            this.pnl_DateTime.Name = "pnl_DateTime";
            this.pnl_DateTime.Size = new System.Drawing.Size(241, 33);
            this.pnl_DateTime.TabIndex = 114;
            this.pnl_DateTime.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(134, 3);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(104, 25);
            this.dtp_to.TabIndex = 1;
            // 
            // dtp_From
            // 
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(2, 3);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(107, 25);
            this.dtp_From.TabIndex = 0;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_DateTime);
            this.Controls.Add(this.pnl_int);
            this.Controls.Add(this.pnl_string);
            this.Controls.Add(this.cbo_key);
            this.Controls.Add(this.btn_Search);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(320, 75);
            this.pnl_string.ResumeLayout(false);
            this.pnl_string.PerformLayout();
            this.pnl_int.ResumeLayout(false);
            this.pnl_int.PerformLayout();
            this.pnl_DateTime.ResumeLayout(false);
            this.pnl_DateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_key;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.ComboBox cbo_keyword;
        private System.Windows.Forms.Panel pnl_string;
        private System.Windows.Forms.Panel pnl_int;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IntTo;
        private System.Windows.Forms.TextBox txt_IntFrom;
        private System.Windows.Forms.Panel pnl_DateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_From;
    }
}
