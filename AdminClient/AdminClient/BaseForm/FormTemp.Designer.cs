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
            this.From_minimize = new System.Windows.Forms.PictureBox();
            this.Form_maximise = new System.Windows.Forms.PictureBox();
            this.Form_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).BeginInit();
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
            this.TitleColor.Size = new System.Drawing.Size(814, 7);
            this.TitleColor.TabIndex = 3;
            // 
            // From_minimize
            // 
            this.From_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.From_minimize.BackColor = System.Drawing.Color.Transparent;
            this.From_minimize.Image = global::AdminClient.Properties.Resources.Remove_32x32;
            this.From_minimize.Location = new System.Drawing.Point(694, 9);
            this.From_minimize.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.From_minimize.Name = "From_minimize";
            this.From_minimize.Size = new System.Drawing.Size(32, 32);
            this.From_minimize.TabIndex = 2;
            this.From_minimize.TabStop = false;
            this.From_minimize.Click += new System.EventHandler(this.From_minimize_Click);
            // 
            // Form_maximise
            // 
            this.Form_maximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_maximise.BackColor = System.Drawing.Color.Transparent;
            this.Form_maximise.Image = ((System.Drawing.Image)(resources.GetObject("Form_maximise.Image")));
            this.Form_maximise.Location = new System.Drawing.Point(730, 9);
            this.Form_maximise.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Form_maximise.Name = "Form_maximise";
            this.Form_maximise.Size = new System.Drawing.Size(32, 32);
            this.Form_maximise.TabIndex = 1;
            this.Form_maximise.TabStop = false;
            this.Form_maximise.Click += new System.EventHandler(this.Form_maximise_Click);
            // 
            // Form_close
            // 
            this.Form_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_close.BackColor = System.Drawing.Color.Transparent;
            this.Form_close.Image = ((System.Drawing.Image)(resources.GetObject("Form_close.Image")));
            this.Form_close.Location = new System.Drawing.Point(766, 8);
            this.Form_close.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Form_close.Name = "Form_close";
            this.Form_close.Size = new System.Drawing.Size(32, 32);
            this.Form_close.TabIndex = 0;
            this.Form_close.TabStop = false;
            this.Form_close.Click += new System.EventHandler(this.Form_close_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 552);
            this.Controls.Add(this.From_minimize);
            this.Controls.Add(this.Form_maximise);
            this.Controls.Add(this.TitleColor);
            this.Controls.Add(this.Form_close);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.From_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_maximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox Form_close;
        protected System.Windows.Forms.PictureBox Form_maximise;
        protected System.Windows.Forms.PictureBox From_minimize;
        protected System.Windows.Forms.Panel TitleColor;
    }
}