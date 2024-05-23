namespace Management_System
{
    partial class frmTonKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtSapHet = new System.Windows.Forms.RadioButton();
            this.rbtTatCa = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTonKho = new System.Windows.Forms.DataGridView();
            this.rbtDaHet = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtSapHet
            // 
            this.rbtSapHet.AutoSize = true;
            this.rbtSapHet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSapHet.ForeColor = System.Drawing.Color.White;
            this.rbtSapHet.Location = new System.Drawing.Point(236, 77);
            this.rbtSapHet.Name = "rbtSapHet";
            this.rbtSapHet.Size = new System.Drawing.Size(171, 23);
            this.rbtSapHet.TabIndex = 52;
            this.rbtSapHet.Text = "Mặt Hàng Sắp Hết";
            this.rbtSapHet.UseVisualStyleBackColor = true;
            // 
            // rbtTatCa
            // 
            this.rbtTatCa.AutoSize = true;
            this.rbtTatCa.Checked = true;
            this.rbtTatCa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTatCa.ForeColor = System.Drawing.Color.White;
            this.rbtTatCa.Location = new System.Drawing.Point(46, 77);
            this.rbtTatCa.Name = "rbtTatCa";
            this.rbtTatCa.Size = new System.Drawing.Size(162, 23);
            this.rbtTatCa.TabIndex = 51;
            this.rbtTatCa.TabStop = true;
            this.rbtTatCa.Text = "Tất Cả Mặt Hàng";
            this.rbtTatCa.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnThongKe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(625, 71);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(134, 35);
            this.btnThongKe.TabIndex = 50;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "QUẢN LÝ DANH SÁCH HÀNG TỒN KHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtgvTonKho
            // 
            this.dtgvTonKho.AllowUserToAddRows = false;
            this.dtgvTonKho.AllowUserToDeleteRows = false;
            this.dtgvTonKho.AllowUserToOrderColumns = true;
            this.dtgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTonKho.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTonKho.EnableHeadersVisualStyles = false;
            this.dtgvTonKho.Location = new System.Drawing.Point(22, 135);
            this.dtgvTonKho.Name = "dtgvTonKho";
            this.dtgvTonKho.ReadOnly = true;
            this.dtgvTonKho.Size = new System.Drawing.Size(740, 305);
            this.dtgvTonKho.TabIndex = 48;
            // 
            // rbtDaHet
            // 
            this.rbtDaHet.AutoSize = true;
            this.rbtDaHet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDaHet.ForeColor = System.Drawing.Color.White;
            this.rbtDaHet.Location = new System.Drawing.Point(435, 77);
            this.rbtDaHet.Name = "rbtDaHet";
            this.rbtDaHet.Size = new System.Drawing.Size(162, 23);
            this.rbtDaHet.TabIndex = 53;
            this.rbtDaHet.Text = "Mặt Hàng Đã Hết";
            this.rbtDaHet.UseVisualStyleBackColor = true;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.rbtDaHet);
            this.Controls.Add(this.rbtSapHet);
            this.Controls.Add(this.rbtTatCa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTonKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTonKho";
            this.Text = "frmTonKho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtSapHet;
        private System.Windows.Forms.RadioButton rbtTatCa;
        public System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTonKho;
        private System.Windows.Forms.RadioButton rbtDaHet;
    }
}