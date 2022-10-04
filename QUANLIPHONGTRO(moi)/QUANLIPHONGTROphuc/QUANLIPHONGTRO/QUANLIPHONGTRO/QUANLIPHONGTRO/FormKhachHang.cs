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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void BindGrid(List<KHACHHANG> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MA;
                dgvKhachHang.Rows[index].Cells[1].Value = item.HOTENDEM;
                dgvKhachHang.Rows[index].Cells[2].Value = item.TEN;
                dgvKhachHang.Rows[index].Cells[3].Value = item.PHAI;
                dgvKhachHang.Rows[index].Cells[4].Value = item.CMND;
                dgvKhachHang.Rows[index].Cells[5].Value = item.SODT;
                dgvKhachHang.Rows[index].Cells[6].Value = item.QUEQUAN;
                dgvKhachHang.Rows[index].Cells[7].Value = item.HKTT;
            }
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(KHACHHANG.GetAll());
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private KHACHHANG GetKhachHang()
        {
            KHACHHANG k = new KHACHHANG();
            k.MA = int.Parse(textMa.Text);
            k.HOTENDEM = textHoTenDem.Text;
            k.TEN = textTen.Text;
            k.PHAI = bool.Parse(textPhai.Text);
            k.CMND = textCMND.Text;
            k.SODT = textSDT.Text;
            k.QUEQUAN = textQueQuan.Text;
            k.HKTT = textHKTT.Text;
            return k;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG s = GetKhachHang();
                KHACHHANG db = KHACHHANG.GetKhachHang(s.MA);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm thành công!");
                }
                BindGrid(KHACHHANG.GetAll());
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
                int r = dgvKhachHang.CurrentCell.RowIndex;
                // Lấy Ma của record hiện hành
                string strMA =
                dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                KHACHHANG.Delete(int.Parse(strMA));
                BindGrid(KHACHHANG.GetAll());
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
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                int ma = int.Parse(row.Cells[0].Value.ToString());
                KHACHHANG db = KHACHHANG.GetKhachHang(ma);
                textMa.Text = db.MA.ToString();
                textHoTenDem.Text = db.HOTENDEM.ToString();
                textTen.Text = db.TEN.ToString();
                textPhai.Text = db.PHAI.ToString();
                textCMND.Text = db.CMND.ToString();
                textSDT.Text = db.SODT.ToString();
                textQueQuan.Text = db.QUEQUAN.ToString();
                textHKTT.Text = db.HKTT.ToString();
            }
        }
        

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
