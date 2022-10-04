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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Form frm = new FormPhong();
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form frm = new FormKhachHang();
            frm.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            Form frm = new FormHopDong();
            frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Form frm = new FormHoaDon();
            frm.Show();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            Form frm = new FormTruyVan();
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
