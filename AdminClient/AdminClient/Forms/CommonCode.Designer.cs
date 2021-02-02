﻿namespace AdminClient.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_CommList = new AdminClient.CustomDataGridView();
            this.cbo_catagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Pcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchControl1 = new AdminClient.SearchControl();
            this.panel1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.gb_Sherch.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1200, 25);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Xls
            // 
            this.btn_Xls.Location = new System.Drawing.Point(1283, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Pcode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Cate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Code);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Size = new System.Drawing.Size(1375, 111);
            this.panel1.Controls.SetChildIndex(this.btn_add, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Xls, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Code, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Name, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Cate, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Pcode, 0);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(331, 43);
            this.lbl_Title.Text = "CommonManager";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Main.Size = new System.Drawing.Size(1391, 865);
            // 
            // gb_Sherch
            // 
            this.gb_Sherch.Controls.Add(this.label1);
            this.gb_Sherch.Controls.Add(this.cbo_catagory);
            this.gb_Sherch.Size = new System.Drawing.Size(330, 104);
            this.gb_Sherch.Controls.SetChildIndex(this.btn_search, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.chk_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.nu_limit, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.cbo_catagory, 0);
            this.gb_Sherch.Controls.SetChildIndex(this.label1, 0);
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.searchControl1);
            this.gb_detail.Controls.Add(this.button2);
            this.gb_detail.Controls.Add(this.rd_descending);
            this.gb_detail.Controls.Add(this.rd_ascending);
            this.gb_detail.Controls.Add(this.comboBox3);
            this.gb_detail.Location = new System.Drawing.Point(10, 110);
            this.gb_detail.Size = new System.Drawing.Size(348, 193);
            // 
            // nu_limit
            // 
            this.nu_limit.Size = new System.Drawing.Size(109, 25);
            // 
            // chk_limit
            // 
            this.chk_limit.CheckedChanged += new System.EventHandler(this.chk_limit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 130);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_CommList);
            this.splitContainer1.Size = new System.Drawing.Size(1389, 733);
            this.splitContainer1.SplitterDistance = 371;
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(0, 323);
            // 
            // splitter1
            // 
            this.splitter1.Size = new System.Drawing.Size(34, 733);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(244, 18);
            this.btn_search.Size = new System.Drawing.Size(85, 74);
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1359, 9);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1480, 7);
            // 
            // dgv_CommList
            // 
            this.dgv_CommList.AllowUserToAddRows = false;
            this.dgv_CommList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CommList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CommList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CommList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CommList.GridColor = System.Drawing.Color.Black;
            this.dgv_CommList.IsChkVisible = false;
            this.dgv_CommList.IsEditVisible = false;
            this.dgv_CommList.Location = new System.Drawing.Point(36, 0);
            this.dgv_CommList.Name = "dgv_CommList";
            this.dgv_CommList.RowHeadersVisible = false;
            this.dgv_CommList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CommList.Size = new System.Drawing.Size(975, 730);
            this.dgv_CommList.TabIndex = 3;
            this.dgv_CommList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CommList_CellClick);
            // 
            // cbo_catagory
            // 
            this.cbo_catagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_catagory.FormattingEnabled = true;
            this.cbo_catagory.Location = new System.Drawing.Point(9, 66);
            this.cbo_catagory.Name = "cbo_catagory";
            this.cbo_catagory.Size = new System.Drawing.Size(199, 25);
            this.cbo_catagory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "카테고리";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 148);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 25);
            this.comboBox3.TabIndex = 7;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Location = new System.Drawing.Point(26, 109);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(98, 21);
            this.rd_ascending.TabIndex = 8;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(124, 109);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(106, 21);
            this.rd_descending.TabIndex = 9;
            this.rd_descending.TabStop = true;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::AdminClient.Properties.Resources.SortAsc_32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(251, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "정렬";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "코드";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(40, 17);
            this.txt_Code.MaxLength = 7;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(123, 25);
            this.txt_Code.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(40, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(123, 25);
            this.txt_Name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "이름";
            // 
            // txt_Cate
            // 
            this.txt_Cate.Location = new System.Drawing.Point(230, 17);
            this.txt_Cate.MaxLength = 7;
            this.txt_Cate.Name = "txt_Cate";
            this.txt_Cate.Size = new System.Drawing.Size(128, 25);
            this.txt_Cate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "카테고리";
            // 
            // txt_Pcode
            // 
            this.txt_Pcode.Location = new System.Drawing.Point(230, 52);
            this.txt_Pcode.MaxLength = 7;
            this.txt_Pcode.Name = "txt_Pcode";
            this.txt_Pcode.Size = new System.Drawing.Size(128, 25);
            this.txt_Pcode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(169, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "부모코드";
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.Color.Transparent;
            this.searchControl1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchControl1.Location = new System.Drawing.Point(13, 24);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(322, 78);
            this.searchControl1.TabIndex = 11;
            // 
            // CommandCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1401, 964);
            this.Name = "CommandCode";
            this.Load += new System.EventHandler(this.CommandCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.gb_Sherch.ResumeLayout(false);
            this.gb_Sherch.PerformLayout();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_limit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgv_CommList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_catagory;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Code;
        private SearchControl searchControl1;
    }
}
