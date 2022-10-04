
namespace QUANLIPHONGTRO
{
    partial class FormHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVuKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textTienNuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTienDien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoTienPhaiTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDaThanhToan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaHopDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDVKhac = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.MaHopDong,
            this.TienDien,
            this.TienNuoc,
            this.DichVuKhac,
            this.SoTienPhaiTra,
            this.DaThanhToan});
            this.dgvHoaDon.Location = new System.Drawing.Point(17, 355);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1058, 289);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MA";
            this.Ma.HeaderText = "Ma";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 60;
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MAHOPDONG";
            this.MaHopDong.HeaderText = "MaHopDong";
            this.MaHopDong.MinimumWidth = 6;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Width = 80;
            // 
            // TienDien
            // 
            this.TienDien.DataPropertyName = "TIENDIEN";
            this.TienDien.HeaderText = "TienDien";
            this.TienDien.MinimumWidth = 6;
            this.TienDien.Name = "TienDien";
            this.TienDien.Width = 80;
            // 
            // TienNuoc
            // 
            this.TienNuoc.DataPropertyName = "TIENNUOC";
            this.TienNuoc.HeaderText = "TienNuoc";
            this.TienNuoc.MinimumWidth = 6;
            this.TienNuoc.Name = "TienNuoc";
            this.TienNuoc.Width = 80;
            // 
            // DichVuKhac
            // 
            this.DichVuKhac.DataPropertyName = "DICHVUKHAC";
            this.DichVuKhac.HeaderText = "DichVuKhac";
            this.DichVuKhac.MinimumWidth = 6;
            this.DichVuKhac.Name = "DichVuKhac";
            this.DichVuKhac.Width = 80;
            // 
            // SoTienPhaiTra
            // 
            this.SoTienPhaiTra.DataPropertyName = "SOTIENPHAITRA";
            this.SoTienPhaiTra.HeaderText = "SoTienPhaiTra";
            this.SoTienPhaiTra.MinimumWidth = 6;
            this.SoTienPhaiTra.Name = "SoTienPhaiTra";
            this.SoTienPhaiTra.Width = 125;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DATHANHTOAN";
            this.DaThanhToan.HeaderText = "DaThanhToan";
            this.DaThanhToan.MinimumWidth = 6;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.Width = 125;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(904, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 48);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(760, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 48);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(332, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tiền Nước";
            // 
            // textTienNuoc
            // 
            this.textTienNuoc.Location = new System.Drawing.Point(508, 196);
            this.textTienNuoc.Name = "textTienNuoc";
            this.textTienNuoc.Size = new System.Drawing.Size(165, 22);
            this.textTienNuoc.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(332, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tiền Điện";
            // 
            // textTienDien
            // 
            this.textTienDien.Location = new System.Drawing.Point(508, 152);
            this.textTienDien.Name = "textTienDien";
            this.textTienDien.Size = new System.Drawing.Size(165, 22);
            this.textTienDien.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(697, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số Tiền Phải Trả";
            // 
            // textSoTienPhaiTra
            // 
            this.textSoTienPhaiTra.Location = new System.Drawing.Point(900, 156);
            this.textSoTienPhaiTra.Name = "textSoTienPhaiTra";
            this.textSoTienPhaiTra.Size = new System.Drawing.Size(139, 22);
            this.textSoTienPhaiTra.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(697, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Đã Thanh Toán";
            // 
            // textDaThanhToan
            // 
            this.textDaThanhToan.Location = new System.Drawing.Point(900, 194);
            this.textDaThanhToan.Name = "textDaThanhToan";
            this.textDaThanhToan.Size = new System.Drawing.Size(139, 22);
            this.textDaThanhToan.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mã Hợp Đồng";
            // 
            // textMaHopDong
            // 
            this.textMaHopDong.Location = new System.Drawing.Point(199, 196);
            this.textMaHopDong.Name = "textMaHopDong";
            this.textMaHopDong.Size = new System.Drawing.Size(101, 22);
            this.textMaHopDong.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã Hoá Đơn";
            // 
            // textMa
            // 
            this.textMa.Location = new System.Drawing.Point(199, 149);
            this.textMa.Name = "textMa";
            this.textMa.Size = new System.Drawing.Size(101, 22);
            this.textMa.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(332, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Dịch Vụ Khác";
            // 
            // textDVKhac
            // 
            this.textDVKhac.Location = new System.Drawing.Point(508, 235);
            this.textDVKhac.Name = "textDVKhac";
            this.textDVKhac.Size = new System.Drawing.Size(165, 22);
            this.textDVKhac.TabIndex = 52;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTroVe.Location = new System.Drawing.Point(22, 14);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(129, 68);
            this.btnTroVe.TabIndex = 54;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Hiển thị dữ liệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(45, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Nhập thông tin hoá đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 185);
            this.panel1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(423, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 56);
            this.label10.TabIndex = 58;
            this.label10.Text = "HOÁ ĐƠN";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1103, 703);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.textDVKhac);
            this.Controls.Add(this.textTienNuoc);
            this.Controls.Add(this.textTienDien);
            this.Controls.Add(this.textSoTienPhaiTra);
            this.Controls.Add(this.textDaThanhToan);
            this.Controls.Add(this.textMaHopDong);
            this.Controls.Add(this.textMa);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hoá Đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVuKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienPhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTienNuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTienDien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoTienPhaiTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDaThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMaHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDVKhac;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}