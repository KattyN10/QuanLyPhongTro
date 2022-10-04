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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new FormMenu();
            frm.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                QUANLY q = GetQuanLy();
                QUANLY db = QUANLY.GetQuanLy(q.USERNAME);
                if (db == null)
                {
                    q.InsertUpdate();
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                }    
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private QUANLY GetQuanLy()
        {
            QUANLY q = new QUANLY();
            q.ID = 0;
            q.USERNAME = txtTaiKhoan.Text;
            q.PASS = txtMatKhau.Text;
            return q;
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
