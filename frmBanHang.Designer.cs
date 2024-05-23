namespace Management_System
{
    partial class frmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPhongDangChon = new System.Windows.Forms.Label();
            this.dtgvMatHangSuDung = new System.Windows.Forms.DataGridView();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.mtbNgayKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNgayBatDau = new System.Windows.Forms.MaskedTextBox();
            this.lblNgayNhapHang = new System.Windows.Forms.Label();
            this.timeDongHo = new System.Windows.Forms.Timer(this.components);
            this.pdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pddHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.tpLichSuDatPhong = new System.Windows.Forms.TabPage();
            this.dtgvLichSuDatPhong = new System.Windows.Forms.DataGridView();
            this.tbcQuanLy = new System.Windows.Forms.TabControl();
            this.tpDanhSachPhong = new System.Windows.Forms.TabPage();
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgBatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgKetthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHangSuDung)).BeginInit();
            this.pnlOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpLichSuDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuDatPhong)).BeginInit();
            this.tbcQuanLy.SuspendLayout();
            this.tpDanhSachPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.dtgvDanhSachMatHang);
            this.pnlControl.Controls.Add(this.lblPhongDangChon);
            this.pnlControl.Controls.Add(this.dtgvMatHangSuDung);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlControl.Location = new System.Drawing.Point(801, 0);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(636, 639);
            this.pnlControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "DANH SÁCH MẶT HÀNG PHÒNG SỬ DỤNG";
            // 
            // dtgvDanhSachMatHang
            // 
            this.dtgvDanhSachMatHang.AllowUserToAddRows = false;
            this.dtgvDanhSachMatHang.AllowUserToDeleteRows = false;
            this.dtgvDanhSachMatHang.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDanhSachMatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhang,
            this.dvt,
            this.dg,
            this.tonkho});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhSachMatHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvDanhSachMatHang.EnableHeadersVisualStyles = false;
            this.dtgvDanhSachMatHang.Location = new System.Drawing.Point(8, 50);
            this.dtgvDanhSachMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDanhSachMatHang.MultiSelect = false;
            this.dtgvDanhSachMatHang.Name = "dtgvDanhSachMatHang";
            this.dtgvDanhSachMatHang.ReadOnly = true;
            this.dtgvDanhSachMatHang.RowHeadersWidth = 51;
            this.dtgvDanhSachMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachMatHang.Size = new System.Drawing.Size(624, 197);
            this.dtgvDanhSachMatHang.TabIndex = 32;
            this.dtgvDanhSachMatHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachMatHang_CellDoubleClick);
            // 
            // tenhang
            // 
            this.tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhang.DataPropertyName = "tenhang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenhang.HeaderText = "Tên mặt hàng";
            this.tenhang.MinimumWidth = 6;
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvt.HeaderText = "ĐVT";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 80;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "dg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.dg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg.HeaderText = "Đơn giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Width = 120;
            // 
            // tonkho
            // 
            this.tonkho.DataPropertyName = "tonkho";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.tonkho.DefaultCellStyle = dataGridViewCellStyle5;
            this.tonkho.HeaderText = "Tồn kho";
            this.tonkho.MinimumWidth = 6;
            this.tonkho.Name = "tonkho";
            this.tonkho.ReadOnly = true;
            this.tonkho.Width = 125;
            // 
            // lblPhongDangChon
            // 
            this.lblPhongDangChon.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongDangChon.ForeColor = System.Drawing.Color.White;
            this.lblPhongDangChon.Location = new System.Drawing.Point(255, 9);
            this.lblPhongDangChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongDangChon.Name = "lblPhongDangChon";
            this.lblPhongDangChon.Size = new System.Drawing.Size(267, 27);
            this.lblPhongDangChon.TabIndex = 32;
            this.lblPhongDangChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgvMatHangSuDung
            // 
            this.dtgvMatHangSuDung.AllowUserToAddRows = false;
            this.dtgvMatHangSuDung.AllowUserToDeleteRows = false;
            this.dtgvMatHangSuDung.AllowUserToOrderColumns = true;
            this.dtgvMatHangSuDung.BackgroundColor = System.Drawing.Color.White;
            this.dtgvMatHangSuDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMatHangSuDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvMatHangSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatHangSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phong,
            this.tgBatdau,
            this.tgKetthuc,
            this.soTien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMatHangSuDung.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvMatHangSuDung.EnableHeadersVisualStyles = false;
            this.dtgvMatHangSuDung.Location = new System.Drawing.Point(8, 295);
            this.dtgvMatHangSuDung.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvMatHangSuDung.MultiSelect = false;
            this.dtgvMatHangSuDung.Name = "dtgvMatHangSuDung";
            this.dtgvMatHangSuDung.ReadOnly = true;
            this.dtgvMatHangSuDung.RowHeadersWidth = 51;
            this.dtgvMatHangSuDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMatHangSuDung.Size = new System.Drawing.Size(624, 257);
            this.dtgvMatHangSuDung.TabIndex = 33;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.panel1);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOrder.Location = new System.Drawing.Point(0, 353);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(801, 286);
            this.pnlOrder.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKetThuc);
            this.panel1.Controls.Add(this.btnBatDau);
            this.panel1.Controls.Add(this.mtbNgayKetThuc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtbNgayBatDau);
            this.panel1.Controls.Add(this.lblNgayNhapHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 286);
            this.panel1.TabIndex = 34;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnKetThuc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(139, 156);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(128, 43);
            this.btnKetThuc.TabIndex = 33;
            this.btnKetThuc.Text = "TRẢ PHÒNG";
            this.btnKetThuc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnBatDau.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.White;
            this.btnBatDau.Location = new System.Drawing.Point(9, 156);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(122, 43);
            this.btnBatDau.TabIndex = 33;
            this.btnBatDau.Text = "ĐẶT PHÒNG";
            this.btnBatDau.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // mtbNgayKetThuc
            // 
            this.mtbNgayKetThuc.Font = new System.Drawing.Font("Consolas", 12F);
            this.mtbNgayKetThuc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbNgayKetThuc.Location = new System.Drawing.Point(21, 111);
            this.mtbNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgayKetThuc.Mask = "00/00/0000 90:00";
            this.mtbNgayKetThuc.Name = "mtbNgayKetThuc";
            this.mtbNgayKetThuc.PromptChar = ' ';
            this.mtbNgayKetThuc.Size = new System.Drawing.Size(213, 31);
            this.mtbNgayKetThuc.TabIndex = 31;
            this.mtbNgayKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày Kết Thúc:";
            // 
            // mtbNgayBatDau
            // 
            this.mtbNgayBatDau.Font = new System.Drawing.Font("Consolas", 12F);
            this.mtbNgayBatDau.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbNgayBatDau.Location = new System.Drawing.Point(21, 41);
            this.mtbNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgayBatDau.Mask = "00/00/0000 90:00";
            this.mtbNgayBatDau.Name = "mtbNgayBatDau";
            this.mtbNgayBatDau.PromptChar = ' ';
            this.mtbNgayBatDau.Size = new System.Drawing.Size(213, 31);
            this.mtbNgayBatDau.TabIndex = 29;
            this.mtbNgayBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // lblNgayNhapHang
            // 
            this.lblNgayNhapHang.AutoSize = true;
            this.lblNgayNhapHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhapHang.Location = new System.Drawing.Point(16, 9);
            this.lblNgayNhapHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhapHang.Name = "lblNgayNhapHang";
            this.lblNgayNhapHang.Size = new System.Drawing.Size(153, 23);
            this.lblNgayNhapHang.TabIndex = 28;
            this.lblNgayNhapHang.Text = "Ngày Bắt Đầu:";
            // 
            // timeDongHo
            // 
            this.timeDongHo.Enabled = true;
            // 
            // pdHoaDon
            // 
            this.pdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdHoaDon_PrintPage);
            // 
            // pddHoaDon
            // 
            this.pddHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pddHoaDon.Enabled = true;
            this.pddHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pddHoaDon.Icon")));
            this.pddHoaDon.Name = "pddHoaDon";
            this.pddHoaDon.Visible = false;
            // 
            // tpLichSuDatPhong
            // 
            this.tpLichSuDatPhong.Controls.Add(this.dtgvLichSuDatPhong);
            this.tpLichSuDatPhong.Location = new System.Drawing.Point(4, 32);
            this.tpLichSuDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tpLichSuDatPhong.Name = "tpLichSuDatPhong";
            this.tpLichSuDatPhong.Padding = new System.Windows.Forms.Padding(4);
            this.tpLichSuDatPhong.Size = new System.Drawing.Size(793, 317);
            this.tpLichSuDatPhong.TabIndex = 1;
            this.tpLichSuDatPhong.Text = "Lịch Sử Đặt Phòng";
            this.tpLichSuDatPhong.UseVisualStyleBackColor = true;
            // 
            // dtgvLichSuDatPhong
            // 
            this.dtgvLichSuDatPhong.AllowUserToAddRows = false;
            this.dtgvLichSuDatPhong.AllowUserToDeleteRows = false;
            this.dtgvLichSuDatPhong.AllowUserToOrderColumns = true;
            this.dtgvLichSuDatPhong.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLichSuDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLichSuDatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvLichSuDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLichSuDatPhong.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvLichSuDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLichSuDatPhong.EnableHeadersVisualStyles = false;
            this.dtgvLichSuDatPhong.Location = new System.Drawing.Point(4, 4);
            this.dtgvLichSuDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvLichSuDatPhong.MultiSelect = false;
            this.dtgvLichSuDatPhong.Name = "dtgvLichSuDatPhong";
            this.dtgvLichSuDatPhong.ReadOnly = true;
            this.dtgvLichSuDatPhong.RowHeadersWidth = 51;
            this.dtgvLichSuDatPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLichSuDatPhong.Size = new System.Drawing.Size(785, 309);
            this.dtgvLichSuDatPhong.TabIndex = 33;
            this.dtgvLichSuDatPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLichSuDatPhong_CellDoubleClick);
            // 
            // tbcQuanLy
            // 
            this.tbcQuanLy.Controls.Add(this.tpDanhSachPhong);
            this.tbcQuanLy.Controls.Add(this.tpLichSuDatPhong);
            this.tbcQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcQuanLy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tbcQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.tbcQuanLy.Name = "tbcQuanLy";
            this.tbcQuanLy.SelectedIndex = 0;
            this.tbcQuanLy.Size = new System.Drawing.Size(801, 353);
            this.tbcQuanLy.TabIndex = 3;
            // 
            // tpDanhSachPhong
            // 
            this.tpDanhSachPhong.Controls.Add(this.tbcContent);
            this.tpDanhSachPhong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDanhSachPhong.Location = new System.Drawing.Point(4, 32);
            this.tpDanhSachPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tpDanhSachPhong.Name = "tpDanhSachPhong";
            this.tpDanhSachPhong.Padding = new System.Windows.Forms.Padding(4);
            this.tpDanhSachPhong.Size = new System.Drawing.Size(793, 317);
            this.tpDanhSachPhong.TabIndex = 0;
            this.tpDanhSachPhong.Text = "Danh Sách Phòng";
            this.tpDanhSachPhong.UseVisualStyleBackColor = true;
            // 
            // tbcContent
            // 
            this.tbcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcContent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcContent.Location = new System.Drawing.Point(4, 4);
            this.tbcContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(785, 309);
            this.tbcContent.TabIndex = 38;
            this.tbcContent.SelectedIndexChanged += new System.EventHandler(this.tbcContent_SelectedIndexChanged);
            // 
            // phong
            // 
            this.phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phong.DataPropertyName = "phong";
            this.phong.HeaderText = "Phòng";
            this.phong.MinimumWidth = 6;
            this.phong.Name = "phong";
            this.phong.ReadOnly = true;
            // 
            // tgBatdau
            // 
            this.tgBatdau.DataPropertyName = "tgBatdau";
            this.tgBatdau.HeaderText = "Bắt đầu";
            this.tgBatdau.MinimumWidth = 6;
            this.tgBatdau.Name = "tgBatdau";
            this.tgBatdau.ReadOnly = true;
            this.tgBatdau.Width = 120;
            // 
            // tgKetthuc
            // 
            this.tgKetthuc.DataPropertyName = "tgKetthuc";
            this.tgKetthuc.HeaderText = "Kết thúc";
            this.tgKetthuc.MinimumWidth = 6;
            this.tgKetthuc.Name = "tgKetthuc";
            this.tgKetthuc.ReadOnly = true;
            this.tgKetthuc.Width = 130;
            // 
            // soTien
            // 
            this.soTien.DataPropertyName = "soTien";
            this.soTien.HeaderText = "Tổng tiền";
            this.soTien.MinimumWidth = 6;
            this.soTien.Name = "soTien";
            this.soTien.ReadOnly = true;
            this.soTien.Width = 140;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1437, 639);
            this.Controls.Add(this.tbcQuanLy);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đặt Phòng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatHangSuDung)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpLichSuDatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuDatPhong)).EndInit();
            this.tbcQuanLy.ResumeLayout(false);
            this.tpDanhSachPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblPhongDangChon;
        private System.Windows.Forms.DataGridView dtgvDanhSachMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timeDongHo;
        private System.Windows.Forms.DataGridView dtgvMatHangSuDung;
        private System.Drawing.Printing.PrintDocument pdHoaDon;
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
        private System.Windows.Forms.TabPage tpLichSuDatPhong;
        private System.Windows.Forms.DataGridView dtgvLichSuDatPhong;
        private System.Windows.Forms.TabControl tbcQuanLy;
        private System.Windows.Forms.TabPage tpDanhSachPhong;
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnKetThuc;
        public System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.MaskedTextBox mtbNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNgayBatDau;
        private System.Windows.Forms.Label lblNgayNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgBatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgKetthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTien;
    }
}