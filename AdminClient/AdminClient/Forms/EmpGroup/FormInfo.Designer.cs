namespace AdminClient.Forms
{
    partial class FormInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_formName = new System.Windows.Forms.TextBox();
            this.txt_ManuName = new System.Windows.Forms.TextBox();
            this.dgvNonSelectForm = new AdminClient.CustomDataGridView();
            this.dgvdeleted = new AdminClient.CustomDataGridView();
            this.dgvSelectForm = new AdminClient.CustomDataGridView();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSelectForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgvSelectForm);
            this.pnl_Main.Controls.Add(this.dgvdeleted);
            this.pnl_Main.Controls.Add(this.dgvNonSelectForm);
            this.pnl_Main.Controls.Add(this.txt_ManuName);
            this.pnl_Main.Controls.Add(this.txt_formName);
            this.pnl_Main.Controls.Add(this.label5);
            this.pnl_Main.Controls.Add(this.label4);
            this.pnl_Main.Controls.Add(this.btn_add);
            this.pnl_Main.Controls.Add(this.btn_delete);
            this.pnl_Main.Controls.Add(this.btn_Update);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Size = new System.Drawing.Size(1140, 571);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(159, 43);
            this.lbl_Title.Text = "메뉴등록";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1114, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1162, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "할당되지 않은  폼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "존재 하지 않은 폼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "할당된 폼";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(871, 463);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 77);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(974, 463);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 77);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(758, 463);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 77);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "폼 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "매뉴 이름";
            // 
            // txt_formName
            // 
            this.txt_formName.Location = new System.Drawing.Point(99, 466);
            this.txt_formName.Name = "txt_formName";
            this.txt_formName.Size = new System.Drawing.Size(170, 25);
            this.txt_formName.TabIndex = 11;
            // 
            // txt_ManuName
            // 
            this.txt_ManuName.Location = new System.Drawing.Point(99, 510);
            this.txt_ManuName.Name = "txt_ManuName";
            this.txt_ManuName.Size = new System.Drawing.Size(170, 25);
            this.txt_ManuName.TabIndex = 12;
            // 
            // dgvNonSelectForm
            // 
            this.dgvNonSelectForm.BackgroundColor = System.Drawing.Color.White;
            this.dgvNonSelectForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNonSelectForm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNonSelectForm.GridColor = System.Drawing.Color.Black;
            this.dgvNonSelectForm.IsChkVisible = false;
            this.dgvNonSelectForm.IsEditVisible = false;
            this.dgvNonSelectForm.Location = new System.Drawing.Point(10, 36);
            this.dgvNonSelectForm.Name = "dgvNonSelectForm";
            this.dgvNonSelectForm.RowTemplate.Height = 23;
            this.dgvNonSelectForm.Size = new System.Drawing.Size(313, 307);
            this.dgvNonSelectForm.TabIndex = 13;
            this.dgvNonSelectForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNonSelectForm_CellDoubleClick);
            // 
            // dgvdeleted
            // 
            this.dgvdeleted.BackgroundColor = System.Drawing.Color.White;
            this.dgvdeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdeleted.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdeleted.GridColor = System.Drawing.Color.Black;
            this.dgvdeleted.IsChkVisible = false;
            this.dgvdeleted.IsEditVisible = false;
            this.dgvdeleted.Location = new System.Drawing.Point(355, 36);
            this.dgvdeleted.Name = "dgvdeleted";
            this.dgvdeleted.RowTemplate.Height = 23;
            this.dgvdeleted.Size = new System.Drawing.Size(320, 307);
            this.dgvdeleted.TabIndex = 14;
            // 
            // dgvSelectForm
            // 
            this.dgvSelectForm.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectForm.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectForm.GridColor = System.Drawing.Color.Black;
            this.dgvSelectForm.IsChkVisible = false;
            this.dgvSelectForm.IsEditVisible = false;
            this.dgvSelectForm.Location = new System.Drawing.Point(710, 36);
            this.dgvSelectForm.Name = "dgvSelectForm";
            this.dgvSelectForm.RowTemplate.Height = 23;
            this.dgvSelectForm.Size = new System.Drawing.Size(355, 307);
            this.dgvSelectForm.TabIndex = 15;
            this.dgvSelectForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectForm_CellDoubleClick);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1150, 628);
            this.Name = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSelectForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ManuName;
        private System.Windows.Forms.TextBox txt_formName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomDataGridView dgvSelectForm;
        private CustomDataGridView dgvdeleted;
        private CustomDataGridView dgvNonSelectForm;
    }
}
