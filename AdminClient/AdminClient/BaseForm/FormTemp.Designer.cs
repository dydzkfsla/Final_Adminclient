namespace AdminClient.BaseForm
{
    partial class FormTemp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemp));
            this.TitleColor = new System.Windows.Forms.Panel();
            this.Form_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleColor
            // 
            this.TitleColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleColor.Location = new System.Drawing.Point(-7, 0);
            this.TitleColor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TitleColor.Name = "TitleColor";
            this.TitleColor.Size = new System.Drawing.Size(798, 7);
            this.TitleColor.TabIndex = 3;
            // 
            // Form_close
            // 
            this.Form_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_close.BackColor = System.Drawing.Color.Transparent;
            this.Form_close.Image = ((System.Drawing.Image)(resources.GetObject("Form_close.Image")));
            this.Form_close.Location = new System.Drawing.Point(750, 8);
            this.Form_close.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Form_close.Name = "Form_close";
            this.Form_close.Size = new System.Drawing.Size(32, 32);
            this.Form_close.TabIndex = 0;
            this.Form_close.TabStop = false;
            this.Form_close.Click += new System.EventHandler(this.Form_close_Click);
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 552);
            this.ControlBox = false;
            this.Controls.Add(this.TitleColor);
            this.Controls.Add(this.Form_close);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormBase";
            this.Activated += new System.EventHandler(this.FormTemp_Activated);
            this.Load += new System.EventHandler(this.FormTemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox Form_close;
        protected System.Windows.Forms.Panel TitleColor;
    }
}