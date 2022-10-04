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

namespace QUANLIPHONGTRO.Model
{
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }
        private PHONG GetPhong()
        {
            PHONG p = new PHONG();
            p.MA = int.Parse(textMa.Text);
            p.TENPHONG = textTen.Text;
            p.MALOAIPHONG = int.Parse(textLoai.Text);
            return p;
        }
        private void BindGrid(List<PHONG> listPhong)
        {
            dgvPhong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = item.MA;
                dgvPhong.Rows[index].Cells[1].Value = item.TENPHONG;
                dgvPhong.Rows[index].Cells[2].Value = item.LOAIPHONG.TENLOAIPHONG;
                dgvPhong.Rows[index].Cells[3].Value = item.LOAIPHONG.DONGIA;
            }
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(PHONG.GetAll());
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG s = GetPhong();
                PHONG db = PHONG.GetPhong(s.MA);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm thành công!");
                }
                BindGrid(PHONG.GetAll());
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
                int r = dgvPhong.CurrentCell.RowIndex;
                // Lấy Ma của record hiện hành
                string strMA =
                dgvPhong.Rows[r].Cells[0].Value.ToString();

                PHONG.Delete(int.Parse(strMA));
                BindGrid(PHONG.GetAll());
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
                DataGridViewRow row = this.dgvPhong.Rows[e.RowIndex];
                int ma = int.Parse(row.Cells[0].Value.ToString());
                PHONG db = PHONG.GetPhong(ma);
                textMa.Text = db.MA.ToString();
                textTen.Text = db.TENPHONG.ToString();
                textLoai.Text = db.LOAIPHONG.MA.ToString();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
