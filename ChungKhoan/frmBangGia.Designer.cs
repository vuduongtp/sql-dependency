namespace ChungKhoan
{
    partial class frmBangGia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gvBangGia = new System.Windows.Forms.DataGridView();
            this.mACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAMUA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLMUA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAMUA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLMUA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAKHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLKHOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABAN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLBAN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABAN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLBAN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIATRUCTUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new ChungKhoan.DS();
            this.gIATRUCTUYENTableAdapter = new ChungKhoan.DSTableAdapters.GIATRUCTUYENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetPhienGD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIATRUCTUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatLenh.Location = new System.Drawing.Point(0, -1);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(92, 28);
            this.btnDatLenh.TabIndex = 0;
            this.btnDatLenh.Text = "Đặt lệnh";
            this.btnDatLenh.UseVisualStyleBackColor = false;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(273, -1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 28);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gvBangGia
            // 
            this.gvBangGia.AllowUserToAddRows = false;
            this.gvBangGia.AllowUserToDeleteRows = false;
            this.gvBangGia.AutoGenerateColumns = false;
            this.gvBangGia.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.gvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACPDataGridViewTextBoxColumn,
            this.gIAMUA2DataGridViewTextBoxColumn,
            this.kLMUA2DataGridViewTextBoxColumn,
            this.gIAMUA1DataGridViewTextBoxColumn,
            this.kLMUA1DataGridViewTextBoxColumn,
            this.gIAKHOPDataGridViewTextBoxColumn,
            this.kLKHOPDataGridViewTextBoxColumn,
            this.gIABAN1DataGridViewTextBoxColumn,
            this.kLBAN1DataGridViewTextBoxColumn,
            this.gIABAN2DataGridViewTextBoxColumn,
            this.kLBAN2DataGridViewTextBoxColumn});
            this.gvBangGia.DataSource = this.gIATRUCTUYENBindingSource;
            this.gvBangGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvBangGia.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gvBangGia.Location = new System.Drawing.Point(0, 192);
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.ReadOnly = true;
            this.gvBangGia.Size = new System.Drawing.Size(1146, 292);
            this.gvBangGia.TabIndex = 1;
            // 
            // mACPDataGridViewTextBoxColumn
            // 
            this.mACPDataGridViewTextBoxColumn.DataPropertyName = "MACP";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.mACPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.mACPDataGridViewTextBoxColumn.HeaderText = "Mã CP";
            this.mACPDataGridViewTextBoxColumn.Name = "mACPDataGridViewTextBoxColumn";
            this.mACPDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIAMUA2DataGridViewTextBoxColumn
            // 
            this.gIAMUA2DataGridViewTextBoxColumn.DataPropertyName = "GIAMUA2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gIAMUA2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gIAMUA2DataGridViewTextBoxColumn.HeaderText = "Giá 2";
            this.gIAMUA2DataGridViewTextBoxColumn.Name = "gIAMUA2DataGridViewTextBoxColumn";
            this.gIAMUA2DataGridViewTextBoxColumn.ReadOnly = true;
            this.gIAMUA2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kLMUA2DataGridViewTextBoxColumn
            // 
            this.kLMUA2DataGridViewTextBoxColumn.DataPropertyName = "KLMUA2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kLMUA2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.kLMUA2DataGridViewTextBoxColumn.HeaderText = "KL 2";
            this.kLMUA2DataGridViewTextBoxColumn.Name = "kLMUA2DataGridViewTextBoxColumn";
            this.kLMUA2DataGridViewTextBoxColumn.ReadOnly = true;
            this.kLMUA2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIAMUA1DataGridViewTextBoxColumn
            // 
            this.gIAMUA1DataGridViewTextBoxColumn.DataPropertyName = "GIAMUA1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gIAMUA1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gIAMUA1DataGridViewTextBoxColumn.HeaderText = "Giá 1";
            this.gIAMUA1DataGridViewTextBoxColumn.Name = "gIAMUA1DataGridViewTextBoxColumn";
            this.gIAMUA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.gIAMUA1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kLMUA1DataGridViewTextBoxColumn
            // 
            this.kLMUA1DataGridViewTextBoxColumn.DataPropertyName = "KLMUA1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kLMUA1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.kLMUA1DataGridViewTextBoxColumn.HeaderText = "KL 1";
            this.kLMUA1DataGridViewTextBoxColumn.Name = "kLMUA1DataGridViewTextBoxColumn";
            this.kLMUA1DataGridViewTextBoxColumn.ReadOnly = true;
            this.kLMUA1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIAKHOPDataGridViewTextBoxColumn
            // 
            this.gIAKHOPDataGridViewTextBoxColumn.DataPropertyName = "GIAKHOP";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gIAKHOPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.gIAKHOPDataGridViewTextBoxColumn.HeaderText = "Giá khớp";
            this.gIAKHOPDataGridViewTextBoxColumn.Name = "gIAKHOPDataGridViewTextBoxColumn";
            this.gIAKHOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.gIAKHOPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kLKHOPDataGridViewTextBoxColumn
            // 
            this.kLKHOPDataGridViewTextBoxColumn.DataPropertyName = "KLKHOP";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kLKHOPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.kLKHOPDataGridViewTextBoxColumn.HeaderText = "KL Khớp";
            this.kLKHOPDataGridViewTextBoxColumn.Name = "kLKHOPDataGridViewTextBoxColumn";
            this.kLKHOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.kLKHOPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIABAN1DataGridViewTextBoxColumn
            // 
            this.gIABAN1DataGridViewTextBoxColumn.DataPropertyName = "GIABAN1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gIABAN1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.gIABAN1DataGridViewTextBoxColumn.HeaderText = "Giá 1";
            this.gIABAN1DataGridViewTextBoxColumn.Name = "gIABAN1DataGridViewTextBoxColumn";
            this.gIABAN1DataGridViewTextBoxColumn.ReadOnly = true;
            this.gIABAN1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kLBAN1DataGridViewTextBoxColumn
            // 
            this.kLBAN1DataGridViewTextBoxColumn.DataPropertyName = "KLBAN1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kLBAN1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.kLBAN1DataGridViewTextBoxColumn.HeaderText = "KL 1";
            this.kLBAN1DataGridViewTextBoxColumn.Name = "kLBAN1DataGridViewTextBoxColumn";
            this.kLBAN1DataGridViewTextBoxColumn.ReadOnly = true;
            this.kLBAN1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIABAN2DataGridViewTextBoxColumn
            // 
            this.gIABAN2DataGridViewTextBoxColumn.DataPropertyName = "GIABAN2";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gIABAN2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.gIABAN2DataGridViewTextBoxColumn.HeaderText = "Giá 2";
            this.gIABAN2DataGridViewTextBoxColumn.Name = "gIABAN2DataGridViewTextBoxColumn";
            this.gIABAN2DataGridViewTextBoxColumn.ReadOnly = true;
            this.gIABAN2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kLBAN2DataGridViewTextBoxColumn
            // 
            this.kLBAN2DataGridViewTextBoxColumn.DataPropertyName = "KLBAN2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kLBAN2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.kLBAN2DataGridViewTextBoxColumn.HeaderText = "KL 2";
            this.kLBAN2DataGridViewTextBoxColumn.Name = "kLBAN2DataGridViewTextBoxColumn";
            this.kLBAN2DataGridViewTextBoxColumn.ReadOnly = true;
            this.kLBAN2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gIATRUCTUYENBindingSource
            // 
            this.gIATRUCTUYENBindingSource.DataMember = "GIATRUCTUYEN";
            this.gIATRUCTUYENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIATRUCTUYENTableAdapter
            // 
            this.gIATRUCTUYENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(397, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG GIÁ TRỰC TUYẾN";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(0, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Mã CP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(141, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Dư mua";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(537, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Khớp lệnh";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Location = new System.Drawing.Point(740, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(406, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Dư bán";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 31);
            this.panel1.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTime.Location = new System.Drawing.Point(484, 9);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(0, 19);
            this.txtTime.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetPhienGD
            // 
            this.btnResetPhienGD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetPhienGD.Location = new System.Drawing.Point(98, -1);
            this.btnResetPhienGD.Name = "btnResetPhienGD";
            this.btnResetPhienGD.Size = new System.Drawing.Size(169, 28);
            this.btnResetPhienGD.TabIndex = 7;
            this.btnResetPhienGD.Text = "Làm mới Phiên giao dịch";
            this.btnResetPhienGD.UseVisualStyleBackColor = false;
            this.btnResetPhienGD.Click += new System.EventHandler(this.btnResetPhienGD_Click);
            // 
            // frmBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1146, 484);
            this.Controls.Add(this.btnResetPhienGD);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBangGia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatLenh);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangGia";
            this.Text = "Bảng giá trực tuyến";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIATRUCTUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatLenh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView gvBangGia;
        private DS dS;
        private System.Windows.Forms.BindingSource gIATRUCTUYENBindingSource;
        private DSTableAdapters.GIATRUCTUYENTableAdapter gIATRUCTUYENTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAMUA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLMUA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAMUA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLMUA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAKHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLKHOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABAN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLBAN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABAN2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLBAN2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResetPhienGD;
    }
}

