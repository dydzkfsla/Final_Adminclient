namespace AdminClient
{
    partial class SortControl
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
            this.btn_SortPrice = new System.Windows.Forms.Button();
            this.cbo_Sortkey = new System.Windows.Forms.ComboBox();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_SortPrice
            // 
            this.btn_SortPrice.BackColor = System.Drawing.Color.White;
            this.btn_SortPrice.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
            this.btn_SortPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SortPrice.Location = new System.Drawing.Point(235, 8);
            this.btn_SortPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SortPrice.Name = "btn_SortPrice";
            this.btn_SortPrice.Size = new System.Drawing.Size(81, 58);
            this.btn_SortPrice.TabIndex = 87;
            this.btn_SortPrice.Text = "정렬";
            this.btn_SortPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SortPrice.UseVisualStyleBackColor = false;
            this.btn_SortPrice.Click += new System.EventHandler(this.btn_SortPrice_Click);
            // 
            // cbo_Sortkey
            // 
            this.cbo_Sortkey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_Sortkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sortkey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Sortkey.FormattingEnabled = true;
            this.cbo_Sortkey.Location = new System.Drawing.Point(4, 37);
            this.cbo_Sortkey.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Sortkey.Name = "cbo_Sortkey";
            this.cbo_Sortkey.Size = new System.Drawing.Size(223, 25);
            this.cbo_Sortkey.TabIndex = 84;
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(121, 8);
            this.rd_descending.Margin = new System.Windows.Forms.Padding(4);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(106, 21);
            this.rd_descending.TabIndex = 86;
            this.rd_descending.TabStop = true;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Location = new System.Drawing.Point(6, 8);
            this.rd_ascending.Margin = new System.Windows.Forms.Padding(4);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(98, 21);
            this.rd_ascending.TabIndex = 85;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // SortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_SortPrice);
            this.Controls.Add(this.cbo_Sortkey);
            this.Controls.Add(this.rd_descending);
            this.Controls.Add(this.rd_ascending);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SortControl";
            this.Size = new System.Drawing.Size(325, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SortPrice;
        private System.Windows.Forms.ComboBox cbo_Sortkey;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
    }
}
