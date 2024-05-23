namespace Management_System
{
    partial class frmNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayNhapHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbNhanVienNhap = new System.Windows.Forms.ComboBox();
            this.mtbNgayNhap = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNhaCungCap
            // 
            this.cbbNhaCungCap.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhaCungCap.FormattingEnabled = true;
            this.cbbNhaCungCap.Location = new System.Drawing.Point(783, 78);
            this.cbbNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhaCungCap.Name = "cbbNhaCungCap";
            this.cbbNhaCungCap.Size = new System.Drawing.Size(213, 31);
            this.cbbNhaCungCap.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(612, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhà Cung Cấp:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnRemove.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(897, 144);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 43);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "XÓA";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(783, 144);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "THÊM";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhân Viên Nhập:";
            // 
            // lblNgayNhapHang
            // 
            this.lblNgayNhapHang.AutoSize = true;
            this.lblNgayNhapHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhapHang.Location = new System.Drawing.Point(108, 154);
            this.lblNgayNhapHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhapHang.Name = "lblNgayNhapHang";
            this.lblNgayNhapHang.Size = new System.Drawing.Size(120, 23);
            this.lblNgayNhapHang.TabIndex = 19;
            this.lblNgayNhapHang.Text = "Ngày Nhập:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ DANH SÁCH PHIẾU NHẬP HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtgvHoaDonNhap
            // 
            this.dtgvHoaDonNhap.AllowUserToAddRows = false;
            this.dtgvHoaDonNhap.AllowUserToDeleteRows = false;
            this.dtgvHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoaDonNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NgayNhap,
            this.tenncc,
            this.trangthai,
            this.tongtien,
            this.dathanhtoan,
            this.danhap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHoaDonNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHoaDonNhap.EnableHeadersVisualStyles = false;
            this.dtgvHoaDonNhap.Location = new System.Drawing.Point(13, 222);
            this.dtgvHoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvHoaDonNhap.Name = "dtgvHoaDonNhap";
            this.dtgvHoaDonNhap.ReadOnly = true;
            this.dtgvHoaDonNhap.RowHeadersWidth = 51;
            this.dtgvHoaDonNhap.Size = new System.Drawing.Size(1053, 320);
            this.dtgvHoaDonNhap.TabIndex = 15;
            this.dtgvHoaDonNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDonNhap_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã phiếu nhập";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 150;
            // 
            // tenncc
            // 
            this.tenncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Nhà cung cấp";
            this.tenncc.MinimumWidth = 6;
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 150;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 150;
            // 
            // dathanhtoan
            // 
            this.dathanhtoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dathanhtoan.DataPropertyName = "dathanhtoan";
            this.dathanhtoan.HeaderText = "Đã thanh toán";
            this.dathanhtoan.MinimumWidth = 6;
            this.dathanhtoan.Name = "dathanhtoan";
            this.dathanhtoan.ReadOnly = true;
            this.dathanhtoan.Width = 125;
            // 
            // danhap
            // 
            this.danhap.DataPropertyName = "danhap";
            this.danhap.HeaderText = "Đã nhập";
            this.danhap.MinimumWidth = 6;
            this.danhap.Name = "danhap";
            this.danhap.ReadOnly = true;
            this.danhap.Width = 130;
            // 
            // cbbNhanVienNhap
            // 
            this.cbbNhanVienNhap.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhanVienNhap.FormattingEnabled = true;
            this.cbbNhanVienNhap.Location = new System.Drawing.Point(308, 73);
            this.cbbNhanVienNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNhanVienNhap.Name = "cbbNhanVienNhap";
            this.cbbNhanVienNhap.Size = new System.Drawing.Size(213, 31);
            this.cbbNhanVienNhap.TabIndex = 26;
            // 
            // mtbNgayNhap
            // 
            this.mtbNgayNhap.Font = new System.Drawing.Font("Consolas", 12F);
            this.mtbNgayNhap.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbNgayNhap.Location = new System.Drawing.Point(308, 150);
            this.mtbNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgayNhap.Mask = "00/00/0000";
            this.mtbNgayNhap.Name = "mtbNgayNhap";
            this.mtbNgayNhap.PromptChar = ' ';
            this.mtbNgayNhap.Size = new System.Drawing.Size(213, 31);
            this.mtbNgayNhap.TabIndex = 27;
            this.mtbNgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1144, 567);
            this.Controls.Add(this.mtbNgayNhap);
            this.Controls.Add(this.cbbNhanVienNhap);
            this.Controls.Add(this.cbbNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNgayNhapHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvHoaDonNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.Text = "Quản Lý Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNhaCungCap;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayNhapHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvHoaDonNhap;
        private System.Windows.Forms.ComboBox cbbNhanVienNhap;
        private System.Windows.Forms.MaskedTextBox mtbNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhap;
    }
}