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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void truyXuấtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormTruyVan();
            frm.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormPhong();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormKhachHang();
            frm.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormHopDong();
            frm.Show();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormHoaDon();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tổngQuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormChinh();
            frm.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Form frm = new FormDangNhap();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FormThongTin();
            frm.Show();
        }
    }
}
