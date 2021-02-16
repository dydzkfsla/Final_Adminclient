namespace AdminClient.PopUp
{
    partial class EmpInfoPopUp
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
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_HireDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_RetireDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_empPassworad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_EmpCode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Delet = new System.Windows.Forms.Button();
            this.btn_Alladd = new System.Windows.Forms.Button();
            this.btn_AllUpdate = new System.Windows.Forms.Button();
            this.btn_AllDelete = new System.Windows.Forms.Button();
            this.dgv_EmpGroup = new AdminClient.CustomDataGridView();
            this.dgv_Group = new AdminClient.CustomDataGridView();
            this.dgv_AddrSearch = new AdminClient.CustomDataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.chk_cheal = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Post = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_AddressDetail = new System.Windows.Forms.TextBox();
            this.btn_SerchAddress = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmpGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddrSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dgv_AddrSearch);
            this.pnl_Main.Controls.Add(this.chk_cheal);
            this.pnl_Main.Controls.Add(this.label23);
            this.pnl_Main.Controls.Add(this.dgv_Group);
            this.pnl_Main.Controls.Add(this.dgv_EmpGroup);
            this.pnl_Main.Controls.Add(this.groupBox1);
            this.pnl_Main.Controls.Add(this.btn_AllDelete);
            this.pnl_Main.Controls.Add(this.btn_AllUpdate);
            this.pnl_Main.Controls.Add(this.btn_Alladd);
            this.pnl_Main.Controls.Add(this.btn_Delet);
            this.pnl_Main.Controls.Add(this.label8);
            this.pnl_Main.Controls.Add(this.label4);
            this.pnl_Main.Controls.Add(this.dtp_RetireDate);
            this.pnl_Main.Controls.Add(this.btn_add);
            this.pnl_Main.Controls.Add(this.label22);
            this.pnl_Main.Controls.Add(this.label21);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.txt_Number);
            this.pnl_Main.Controls.Add(this.label9);
            this.pnl_Main.Controls.Add(this.label10);
            this.pnl_Main.Size = new System.Drawing.Size(1155, 933);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(185, 43);
            this.lbl_Title.Text = "FormBase";
            // 
            // Form_close
            // 
            this.Form_close.Location = new System.Drawing.Point(1129, 8);
            // 
            // TitleColor
            // 
            this.TitleColor.Size = new System.Drawing.Size(1177, 7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원이름";
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(122, 33);
            this.txt_EmpName.MaxLength = 30;
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(188, 25);
            this.txt_EmpName.TabIndex = 2;
            this.txt_EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_EmpEmail
            // 
            this.txt_EmpEmail.Location = new System.Drawing.Point(122, 65);
            this.txt_EmpEmail.MaxLength = 30;
            this.txt_EmpEmail.Name = "txt_EmpEmail";
            this.txt_EmpEmail.Size = new System.Drawing.Size(188, 25);
            this.txt_EmpEmail.TabIndex = 4;
            this.txt_EmpEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "직원이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "입사일";
            // 
            // dtp_HireDate
            // 
            this.dtp_HireDate.Location = new System.Drawing.Point(122, 129);
            this.dtp_HireDate.Name = "dtp_HireDate";
            this.dtp_HireDate.Size = new System.Drawing.Size(188, 25);
            this.dtp_HireDate.TabIndex = 6;
            // 
            // dtp_RetireDate
            // 
            this.dtp_RetireDate.Enabled = false;
            this.dtp_RetireDate.Location = new System.Drawing.Point(129, 262);
            this.dtp_RetireDate.Name = "dtp_RetireDate";
            this.dtp_RetireDate.Size = new System.Drawing.Size(188, 25);
            this.dtp_RetireDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "퇴사일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "◆";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "◆";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "◆";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "◆";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "◆";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(42, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "폰 번호";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(129, 210);
            this.txt_Number.MaxLength = 30;
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(188, 25);
            this.txt_Number.TabIndex = 16;
            this.txt_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(3, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "◆";
            // 
            // txt_empPassworad
            // 
            this.txt_empPassworad.Location = new System.Drawing.Point(122, 97);
            this.txt_empPassworad.MaxLength = 30;
            this.txt_empPassworad.Name = "txt_empPassworad";
            this.txt_empPassworad.Size = new System.Drawing.Size(188, 25);
            this.txt_empPassworad.TabIndex = 28;
            this.txt_empPassworad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(26, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "비밀번호";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "◆";
            // 
            // txt_EmpCode
            // 
            this.txt_EmpCode.Location = new System.Drawing.Point(122, 2);
            this.txt_EmpCode.MaxLength = 7;
            this.txt_EmpCode.Name = "txt_EmpCode";
            this.txt_EmpCode.Size = new System.Drawing.Size(188, 25);
            this.txt_EmpCode.TabIndex = 31;
            this.txt_EmpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(26, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "직원코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_EmpCode);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_empPassworad);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.dtp_HireDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_EmpEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_EmpName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 166);
            this.panel1.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(446, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 17);
            this.label21.TabIndex = 37;
            this.label21.Text = "직원그룹";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(820, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 17);
            this.label22.TabIndex = 38;
            this.label22.Text = "그룹목록";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(778, 84);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(39, 32);
            this.btn_add.TabIndex = 39;
            this.btn_add.Text = "<<";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Delet
            // 
            this.btn_Delet.BackColor = System.Drawing.Color.White;
            this.btn_Delet.Location = new System.Drawing.Point(778, 195);
            this.btn_Delet.Name = "btn_Delet";
            this.btn_Delet.Size = new System.Drawing.Size(39, 31);
            this.btn_Delet.TabIndex = 40;
            this.btn_Delet.Text = ">>";
            this.btn_Delet.UseVisualStyleBackColor = false;
            this.btn_Delet.Click += new System.EventHandler(this.btn_Delet_Click);
            // 
            // btn_Alladd
            // 
            this.btn_Alladd.BackColor = System.Drawing.Color.White;
            this.btn_Alladd.Location = new System.Drawing.Point(674, 809);
            this.btn_Alladd.Name = "btn_Alladd";
            this.btn_Alladd.Size = new System.Drawing.Size(100, 100);
            this.btn_Alladd.TabIndex = 41;
            this.btn_Alladd.Text = "추가";
            this.btn_Alladd.UseVisualStyleBackColor = false;
            this.btn_Alladd.Click += new System.EventHandler(this.btn_Alladd_Click);
            // 
            // btn_AllUpdate
            // 
            this.btn_AllUpdate.BackColor = System.Drawing.Color.White;
            this.btn_AllUpdate.Location = new System.Drawing.Point(841, 809);
            this.btn_AllUpdate.Name = "btn_AllUpdate";
            this.btn_AllUpdate.Size = new System.Drawing.Size(100, 100);
            this.btn_AllUpdate.TabIndex = 42;
            this.btn_AllUpdate.Text = "수정";
            this.btn_AllUpdate.UseVisualStyleBackColor = false;
            this.btn_AllUpdate.Click += new System.EventHandler(this.btn_AllUpdate_Click);
            // 
            // btn_AllDelete
            // 
            this.btn_AllDelete.BackColor = System.Drawing.Color.White;
            this.btn_AllDelete.Location = new System.Drawing.Point(992, 809);
            this.btn_AllDelete.Name = "btn_AllDelete";
            this.btn_AllDelete.Size = new System.Drawing.Size(100, 100);
            this.btn_AllDelete.TabIndex = 43;
            this.btn_AllDelete.Text = "삭제";
            this.btn_AllDelete.UseVisualStyleBackColor = false;
            this.btn_AllDelete.Click += new System.EventHandler(this.btn_AllDelete_Click);
            // 
            // dgv_EmpGroup
            // 
            this.dgv_EmpGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgv_EmpGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_EmpGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_EmpGroup.GridColor = System.Drawing.Color.Black;
            this.dgv_EmpGroup.IsChkVisible = false;
            this.dgv_EmpGroup.IsEditVisible = false;
            this.dgv_EmpGroup.Location = new System.Drawing.Point(449, 31);
            this.dgv_EmpGroup.Name = "dgv_EmpGroup";
            this.dgv_EmpGroup.RowTemplate.Height = 23;
            this.dgv_EmpGroup.Size = new System.Drawing.Size(323, 261);
            this.dgv_EmpGroup.TabIndex = 44;
            // 
            // dgv_Group
            // 
            this.dgv_Group.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Group.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Group.GridColor = System.Drawing.Color.Black;
            this.dgv_Group.IsChkVisible = false;
            this.dgv_Group.IsEditVisible = false;
            this.dgv_Group.Location = new System.Drawing.Point(823, 31);
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.RowTemplate.Height = 23;
            this.dgv_Group.Size = new System.Drawing.Size(310, 261);
            this.dgv_Group.TabIndex = 45;
            // 
            // dgv_AddrSearch
            // 
            this.dgv_AddrSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AddrSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AddrSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AddrSearch.GridColor = System.Drawing.Color.Black;
            this.dgv_AddrSearch.IsChkVisible = false;
            this.dgv_AddrSearch.IsEditVisible = false;
            this.dgv_AddrSearch.Location = new System.Drawing.Point(8, 442);
            this.dgv_AddrSearch.Name = "dgv_AddrSearch";
            this.dgv_AddrSearch.RowTemplate.Height = 23;
            this.dgv_AddrSearch.Size = new System.Drawing.Size(1078, 318);
            this.dgv_AddrSearch.TabIndex = 46;
            this.dgv_AddrSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AddrSearch_CellDoubleClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 422);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 17);
            this.label23.TabIndex = 47;
            this.label23.Text = "주소검색";
            // 
            // chk_cheal
            // 
            this.chk_cheal.AutoSize = true;
            this.chk_cheal.Location = new System.Drawing.Point(129, 241);
            this.chk_cheal.Name = "chk_cheal";
            this.chk_cheal.Size = new System.Drawing.Size(97, 21);
            this.chk_cheal.TabIndex = 48;
            this.chk_cheal.Text = "퇴사일지정";
            this.chk_cheal.UseVisualStyleBackColor = true;
            this.chk_cheal.CheckedChanged += new System.EventHandler(this.chk_cheal_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(27, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "직원우편번호";
            // 
            // txt_Post
            // 
            this.txt_Post.Location = new System.Drawing.Point(401, 24);
            this.txt_Post.MaxLength = 5;
            this.txt_Post.Name = "txt_Post";
            this.txt_Post.Size = new System.Drawing.Size(189, 25);
            this.txt_Post.TabIndex = 18;
            this.txt_Post.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(28, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "직원주소";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "◆";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(130, 55);
            this.txt_Address.MaxLength = 300;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(460, 25);
            this.txt_Address.TabIndex = 21;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "◆";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(28, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "직원주소상세";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(6, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "◆";
            // 
            // txt_AddressDetail
            // 
            this.txt_AddressDetail.Location = new System.Drawing.Point(130, 86);
            this.txt_AddressDetail.MaxLength = 300;
            this.txt_AddressDetail.Name = "txt_AddressDetail";
            this.txt_AddressDetail.Size = new System.Drawing.Size(460, 25);
            this.txt_AddressDetail.TabIndex = 24;
            this.txt_AddressDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SerchAddress
            // 
            this.btn_SerchAddress.BackColor = System.Drawing.Color.White;
            this.btn_SerchAddress.Location = new System.Drawing.Point(596, 23);
            this.btn_SerchAddress.Name = "btn_SerchAddress";
            this.btn_SerchAddress.Size = new System.Drawing.Size(55, 87);
            this.btn_SerchAddress.TabIndex = 26;
            this.btn_SerchAddress.Text = "검색";
            this.btn_SerchAddress.UseVisualStyleBackColor = false;
            this.btn_SerchAddress.Click += new System.EventHandler(this.btn_SerchAddress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SerchAddress);
            this.groupBox1.Controls.Add(this.txt_AddressDetail);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_Post);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 123);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주소입력";
            // 
            // EmpInfoPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1165, 1000);
            this.Name = "EmpInfoPopUp";
            this.Load += new System.EventHandler(this.EmpPopUp_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmpGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddrSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_RetireDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_HireDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EmpEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_EmpCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_empPassworad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AllDelete;
        private System.Windows.Forms.Button btn_AllUpdate;
        private System.Windows.Forms.Button btn_Alladd;
        private System.Windows.Forms.Button btn_Delet;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private CustomDataGridView dgv_Group;
        private CustomDataGridView dgv_EmpGroup;
        private CustomDataGridView dgv_AddrSearch;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chk_cheal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SerchAddress;
        private System.Windows.Forms.TextBox txt_AddressDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Post;
        private System.Windows.Forms.Label label12;
    }
}
