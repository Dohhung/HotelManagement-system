namespace Management_System
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtbNgayKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNgayBatDau = new System.Windows.Forms.MaskedTextBox();
            this.lblNgayNhapHang = new System.Windows.Forms.Label();
            this.rbtPhong = new System.Windows.Forms.RadioButton();
            this.rbtMatHang = new System.Windows.Forms.RadioButton();
            this.rbtTatCa = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaygd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbNgayKetThuc
            // 
            this.mtbNgayKetThuc.Font = new System.Drawing.Font("Consolas", 12F);
            this.mtbNgayKetThuc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbNgayKetThuc.Location = new System.Drawing.Point(204, 129);
            this.mtbNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbNgayKetThuc.Mask = "00/00/0000 90:00";
            this.mtbNgayKetThuc.Name = "mtbNgayKetThuc";
            this.mtbNgayKetThuc.PromptChar = ' ';
            this.mtbNgayKetThuc.Size = new System.Drawing.Size(213, 31);
            this.mtbNgayKetThuc.TabIndex = 35;
            this.mtbNgayKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày Kết Thúc:";
            // 
            // mtbNgayBatDau
            // 
            this.mtbNgayBatDau.Font = new System.Drawing.Font("Consolas", 12F);
            this.mtbNgayBatDau.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbNgayBatDau.Location = new System.Drawing.Point(204, 63);
            this.mtbNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbNgayBatDau.Mask = "00/00/0000 90:00";
            this.mtbNgayBatDau.Name = "mtbNgayBatDau";
            this.mtbNgayBatDau.PromptChar = ' ';
            this.mtbNgayBatDau.Size = new System.Drawing.Size(213, 31);
            this.mtbNgayBatDau.TabIndex = 33;
            this.mtbNgayBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // lblNgayNhapHang
            // 
            this.lblNgayNhapHang.AutoSize = true;
            this.lblNgayNhapHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhapHang.Location = new System.Drawing.Point(16, 71);
            this.lblNgayNhapHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhapHang.Name = "lblNgayNhapHang";
            this.lblNgayNhapHang.Size = new System.Drawing.Size(153, 23);
            this.lblNgayNhapHang.TabIndex = 32;
            this.lblNgayNhapHang.Text = "Ngày Bắt Đầu:";
            // 
            // rbtPhong
            // 
            this.rbtPhong.AutoSize = true;
            this.rbtPhong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPhong.ForeColor = System.Drawing.Color.White;
            this.rbtPhong.Location = new System.Drawing.Point(889, 69);
            this.rbtPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtPhong.Name = "rbtPhong";
            this.rbtPhong.Size = new System.Drawing.Size(86, 27);
            this.rbtPhong.TabIndex = 59;
            this.rbtPhong.Text = "Phòng";
            this.rbtPhong.UseVisualStyleBackColor = true;
            // 
            // rbtMatHang
            // 
            this.rbtMatHang.AutoSize = true;
            this.rbtMatHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMatHang.ForeColor = System.Drawing.Color.White;
            this.rbtMatHang.Location = new System.Drawing.Point(685, 69);
            this.rbtMatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtMatHang.Name = "rbtMatHang";
            this.rbtMatHang.Size = new System.Drawing.Size(119, 27);
            this.rbtMatHang.TabIndex = 58;
            this.rbtMatHang.Text = "Mặt Hàng";
            this.rbtMatHang.UseVisualStyleBackColor = true;
            // 
            // rbtTatCa
            // 
            this.rbtTatCa.AutoSize = true;
            this.rbtTatCa.Checked = true;
            this.rbtTatCa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTatCa.ForeColor = System.Drawing.Color.White;
            this.rbtTatCa.Location = new System.Drawing.Point(505, 69);
            this.rbtTatCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTatCa.Name = "rbtTatCa";
            this.rbtTatCa.Size = new System.Drawing.Size(97, 27);
            this.rbtTatCa.TabIndex = 57;
            this.rbtTatCa.TabStop = true;
            this.rbtTatCa.Text = "Tất Cả";
            this.rbtTatCa.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnThongKe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(833, 128);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(179, 43);
            this.btnThongKe.TabIndex = 56;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.AllowUserToAddRows = false;
            this.dtgvDoanhThu.AllowUserToDeleteRows = false;
            this.dtgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaygd,
            this.mathang,
            this.dvt,
            this.sl,
            this.dg});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(16, 204);
            this.dtgvDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.ReadOnly = true;
            this.dtgvDoanhThu.RowHeadersWidth = 51;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(1106, 348);
            this.dtgvDoanhThu.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(759, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "QUẢN LÝ DANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ngaygd
            // 
            this.ngaygd.DataPropertyName = "ngaygd";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ngaygd.DefaultCellStyle = dataGridViewCellStyle9;
            this.ngaygd.HeaderText = "Ngày giao dịch";
            this.ngaygd.MinimumWidth = 6;
            this.ngaygd.Name = "ngaygd";
            this.ngaygd.ReadOnly = true;
            this.ngaygd.Width = 160;
            // 
            // mathang
            // 
            this.mathang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mathang.DataPropertyName = "mathang";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.mathang.DefaultCellStyle = dataGridViewCellStyle10;
            this.mathang.HeaderText = "Tên mặt hàng";
            this.mathang.MinimumWidth = 6;
            this.mathang.Name = "mathang";
            this.mathang.ReadOnly = true;
            this.mathang.Width = 350;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvt.DefaultCellStyle = dataGridViewCellStyle11;
            this.dvt.HeaderText = "ĐVT";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 120;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "sl";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.sl.DefaultCellStyle = dataGridViewCellStyle12;
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 125;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "dg";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = "0";
            this.dg.DefaultCellStyle = dataGridViewCellStyle13;
            this.dg.HeaderText = "Đơn giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Width = 150;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1142, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtPhong);
            this.Controls.Add(this.rbtMatHang);
            this.Controls.Add(this.rbtTatCa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtgvDoanhThu);
            this.Controls.Add(this.mtbNgayKetThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbNgayBatDau);
            this.Controls.Add(this.lblNgayNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNgayBatDau;
        private System.Windows.Forms.Label lblNgayNhapHang;
        private System.Windows.Forms.RadioButton rbtPhong;
        private System.Windows.Forms.RadioButton rbtMatHang;
        private System.Windows.Forms.RadioButton rbtTatCa;
        public System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
    }
}