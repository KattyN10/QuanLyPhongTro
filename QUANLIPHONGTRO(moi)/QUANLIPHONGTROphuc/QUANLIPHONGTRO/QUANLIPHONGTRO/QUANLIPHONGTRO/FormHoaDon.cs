using QUANLIPHONGTRO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIPHONGTRO
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void BindGrid(List<HOADON> listHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var item in listHoaDon)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MA;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MAHOPDONG;
                dgvHoaDon.Rows[index].Cells[2].Value = item.TIENDIEN;
                dgvHoaDon.Rows[index].Cells[3].Value = item.TIENNUOC;
                dgvHoaDon.Rows[index].Cells[4].Value = item.DICHVUKHAC;
                dgvHoaDon.Rows[index].Cells[5].Value = item.SOTIENPHAITRA;
                dgvHoaDon.Rows[index].Cells[6].Value = item.DATHANHTOAN;
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(HOADON.GetAll());
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private HOADON GetHoaDon()
        {
            HOADON h = new HOADON();
            h.MA = int.Parse(textMa.Text);
            h.MAHOPDONG = int.Parse(textMaHopDong.Text);
            h.TIENDIEN = int.Parse(textTienDien.Text);
            h.TIENNUOC = int.Parse(textTienNuoc.Text);
            h.DICHVUKHAC = int.Parse(textDVKhac.Text);
            h.SOTIENPHAITRA = int.Parse(textSoTienPhaiTra.Text);
            h.DATHANHTOAN = int.Parse(textDaThanhToan.Text);
            return h;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON s = GetHoaDon();
                HOADON db = HOADON.GetHoaDon(s.MA);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm thành công!");
                }
                BindGrid(HOADON.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvHoaDon.CurrentCell.RowIndex;
                // Lấy Ma của record hiện hành
                string strMA =
                dgvHoaDon.Rows[r].Cells[0].Value.ToString();

                HOADON.Delete(int.Parse(strMA));
                BindGrid(HOADON.GetAll());
                MessageBox.Show("Xoa Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHoaDon.Rows[e.RowIndex];
                int ma = int.Parse(row.Cells[0].Value.ToString());
                HOADON db = HOADON.GetHoaDon(ma);
                textMa.Text = db.MA.ToString();
                textMaHopDong.Text = db.MAHOPDONG.ToString();
                textTienDien.Text = db.TIENDIEN.ToString();
                textTienNuoc.Text = db.TIENNUOC.ToString();
                textDVKhac.Text = db.DICHVUKHAC.ToString();
                textSoTienPhaiTra.Text = db.SOTIENPHAITRA.ToString();
                textDaThanhToan.Text = db.DATHANHTOAN.ToString();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
