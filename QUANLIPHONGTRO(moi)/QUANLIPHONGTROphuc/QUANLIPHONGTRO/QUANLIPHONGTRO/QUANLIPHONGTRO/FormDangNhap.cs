using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QUANLIPHONGTRO
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M7FM8QV\MAYAO;Initial Catalog=QLPHONGTRO;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtDangNhap.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from QuanLy Where USERNAME='" + tk + "'and PASS='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    this.Close();
             
                }
                else
                {
                    MessageBox.Show("Tên Người Dùng Hoặc Mật Khẩu Không Đúng!");
                    this.txtDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối!");
                this.txtDangNhap.Focus();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        
        private void llDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new FormDangKy();
            frm.ShowDialog();
        }
    }
}
