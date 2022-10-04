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
    public partial class FormHopDong : Form
    {
        public FormHopDong()
        {
            InitializeComponent();
        }
        private void BindGrid(List<HOPDONG> listHopDong)
        {
            dgvHopDong.Rows.Clear();
            foreach (var item in listHopDong)
            {
                int index = dgvHopDong.Rows.Add();
                dgvHopDong.Rows[index].Cells[0].Value = item.MA;
                dgvHopDong.Rows[index].Cells[1].Value = item.MAKHACHHANG;
                dgvHopDong.Rows[index].Cells[2].Value = item.MAPHONG;
                dgvHopDong.Rows[index].Cells[3].Value = item.TIENDATCOC;
                dgvHopDong.Rows[index].Cells[4].Value = item.NGAYTHUE;
                dgvHopDong.Rows[index].Cells[5].Value = item.NGAYTRA;
            }
        }
        private void FormHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(HOPDONG.GetAll());
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private HOPDONG GetHopDong()
        {
            HOPDONG h = new HOPDONG();
            h.MA = int.Parse(textMa.Text);
            h.MAKHACHHANG = int.Parse(textMaKH.Text);
            h.MAPHONG = int.Parse(textMaPhong.Text);
            h.TIENDATCOC = int.Parse(textTienCoc.Text);
            h.NGAYTHUE = DateTime.Parse(textNgThue.Text);
            h.NGAYTRA = DateTime.Parse(textNgTra.Text);
            return h;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HOPDONG s = GetHopDong();
                HOPDONG db = HOPDONG.GetHopDong(s.MA);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm thành công!");
                }
                BindGrid(HOPDONG.GetAll());
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
                int r = dgvHopDong.CurrentCell.RowIndex;
                // Lấy Ma của record hiện hành
                string strMA =
                dgvHopDong.Rows[r].Cells[0].Value.ToString();

                HOPDONG.Delete(int.Parse(strMA));
                BindGrid(HOPDONG.GetAll());
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
                DataGridViewRow row = this.dgvHopDong.Rows[e.RowIndex];
                int ma = int.Parse(row.Cells[0].Value.ToString());
                HOPDONG db = HOPDONG.GetHopDong(ma);
                textMa.Text = db.MA.ToString();
                textMaKH.Text = db.MAKHACHHANG.ToString();
                textMaPhong.Text = db.MAPHONG.ToString();
                textTienCoc.Text = db.TIENDATCOC.ToString();
                textNgThue.Text = db.NGAYTHUE.ToString();
                textNgTra.Text = db.NGAYTRA.ToString();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
