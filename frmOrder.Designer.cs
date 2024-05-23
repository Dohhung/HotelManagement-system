namespace Management_System
{
    partial class frmOrder
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
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblYeuCau = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblTenMatHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhong
            // 
            this.lblPhong.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.White;
            this.lblPhong.Location = new System.Drawing.Point(20, 20);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(200, 22);
            this.lblPhong.TabIndex = 33;
            this.lblPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYeuCau
            // 
            this.lblYeuCau.AutoSize = true;
            this.lblYeuCau.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYeuCau.ForeColor = System.Drawing.Color.White;
            this.lblYeuCau.Location = new System.Drawing.Point(20, 100);
            this.lblYeuCau.Name = "lblYeuCau";
            this.lblYeuCau.Size = new System.Drawing.Size(162, 19);
            this.lblYeuCau.TabIndex = 34;
            this.lblYeuCau.Text = "Số Lượng Yêu Cầu:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(202, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(150, 26);
            this.txtSoLuong.TabIndex = 35;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(223, 149);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(129, 35);
            this.btnXacNhan.TabIndex = 36;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblTenMatHang
            // 
            this.lblTenMatHang.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMatHang.ForeColor = System.Drawing.Color.White;
            this.lblTenMatHang.Location = new System.Drawing.Point(20, 60);
            this.lblTenMatHang.Name = "lblTenMatHang";
            this.lblTenMatHang.Size = new System.Drawing.Size(200, 22);
            this.lblTenMatHang.TabIndex = 37;
            this.lblTenMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(364, 196);
            this.Controls.Add(this.lblTenMatHang);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblYeuCau);
            this.Controls.Add(this.lblPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrder";
            this.Text = "Quản Lý Đặt Hàng";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblYeuCau;
        private System.Windows.Forms.TextBox txtSoLuong;
        public System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblTenMatHang;
    }
}