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
using System.Data.SqlClient; 

namespace QUANLIPHONGTRO
{
    public partial class FormTruyVan : Form
    {
        public FormTruyVan()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            QuanLiPhongTroDataContext db = new QuanLiPhongTroDataContext();
            string data = dataBox.Text;
            if (cbBox.Text == "1. Danh Sách Hoá Đơn Đã Thanh Toán Đủ")
            {
                var query = from hdn in db.HoaDons
                            where hdn.SOTIENPHAITRA == hdn.DATHANHTOAN
                            select new
                            {
                                MaHoaDon = hdn.MA,
                                MaHopDong = hdn.MAHOPDONG,
                                SoTienPhaiTra = hdn.SOTIENPHAITRA,
                                DaThanhToan = hdn.DATHANHTOAN
                            };
                dgvTruyVan.DataSource = query;
            }

            if (cbBox.Text == "2. Danh Sách Hoá Đơn Thanh Toán Thiếu")
            {
                var query = from hdn in db.HoaDons
                            where hdn.SOTIENPHAITRA > hdn.DATHANHTOAN
                            select new
                            {
                                MaHoaDon = hdn.MA,
                                MaHopDong = hdn.MAHOPDONG,
                                SoTienPhaiTra = hdn.SOTIENPHAITRA,
                                DaThanhToan = hdn.DATHANHTOAN
                            };
                dgvTruyVan.DataSource = query;
            }

            if (cbBox.Text == "3. Danh Sách Khách Hàng Thuê Phòng Có/Không Có Nội Thất")
            {
                if (data == "")
                {
                    MessageBox.Show("Mời bạn nhập lựa chọn!");
                }
                else
                {
                    if(data == "Có")
                    {
                        var query = from kh in db.KhachHangs
                                    join hdg in db.HopDongs on kh.MA equals hdg.MAKHACHHANG
                                    join ph in db.Phongs on hdg.MAPHONG equals ph.MA
                                    where ph.MALOAIPHONG == 0
                                    select kh;
                        dgvTruyVan.DataSource = query;
                    }
                    else if (data == "Không")
                    {
                        var query = from kh in db.KhachHangs
                                    join hdg in db.HopDongs on kh.MA equals hdg.MAKHACHHANG
                                    join ph in db.Phongs on hdg.MAPHONG equals ph.MA
                                    where ph.MALOAIPHONG == 1
                                    select kh;
                        dgvTruyVan.DataSource = query;
                    }

                }    
            }   
            
            if (cbBox.Text== "4. Danh Sách Khách Hàng Theo Giới Tính")
            {
                if (data == "")
                {
                    MessageBox.Show("Mời bạn nhập giới tính!");
                }
                else
                {
                    if (data == "Nam")
                    {
                        var query = from kh in db.KhachHangs
                                    where kh.PHAI == true
                                    select new
                                    {
                                        MaKhachHang=kh.MA,
                                        HoTenDem=kh.HOTENDEM,
                                        Ten=kh.TEN,
                                        Phai=kh.PHAI,
                                        CMND=kh.CMND,
                                        SoDT=kh.SODT,
                                        QueQuan=kh.QUEQUAN,
                                        HKTT=kh.HKTT
                                    };
                        dgvTruyVan.DataSource = query;
                    }
                    else if (data == "Nữ")
                    {
                        var query = from kh in db.KhachHangs
                                    where kh.PHAI == false
                                    select new
                                    {
                                        MaKhachHang = kh.MA,
                                        HoTenDem = kh.HOTENDEM,
                                        Ten = kh.TEN,
                                        Phai = kh.PHAI,
                                        CMND = kh.CMND,
                                        SoDT = kh.SODT,
                                        QueQuan = kh.QUEQUAN,
                                        HKTT = kh.HKTT
                                    };
                        dgvTruyVan.DataSource = query;
                    }

                }
            }

            if (cbBox.Text == "5. Danh Sách Khách Hàng Thuê Phòng Từ Năm")
            {
                if (data == "")
                {
                    MessageBox.Show("Mời bạn nhập số năm!");
                }
                else
                {
                    int a = int.Parse(data);
                    var query = from kh in db.KhachHangs
                                join hdg in db.HopDongs on kh.MA equals hdg.MAKHACHHANG
                                where hdg.NGAYTHUE.Value.Year >= a
                                select new {kh.MA,kh.HOTENDEM,kh.TEN,kh.PHAI,kh.CMND,hdg.NGAYTHUE};
                    dgvTruyVan.DataSource = query;
                }    
            }

            if (cbBox.Text == "6. Đếm Số Lượng Khách Hàng Theo Quê Quán")
            {
                var query = from kh in db.KhachHangs
                            group kh by kh.QUEQUAN into g
                            select new { QueQuan = g.Key, SoLuong = g.Count() };
                dgvTruyVan.DataSource = query;   
            }

            if (cbBox.Text == "7. Danh Sách Hoá Đơn Có Số Tiền Lớn Hơn Số Tiền Được Nhập")
            {
                if ( data == "")
                {
                    MessageBox.Show("Mời bạn nhập số tiền!");
                }
                else
                {
                    int a = int.Parse(data);
                    var query = from hdn in db.HoaDons
                                where hdn.SOTIENPHAITRA > a
                                select new
                                {
                                    MaHoaDon = hdn.MA,
                                    MaHopDong= hdn.MAHOPDONG,
                                    SoTienPhaiTra=hdn.SOTIENPHAITRA,
                                    DaThanhToan=hdn.DATHANHTOAN
                                };
                    dgvTruyVan.DataSource = query;
                }    
            }    

            if (cbBox.Text == "8. Danh Sách 3 Khách Hàng Nam Đầu Tiên")
            {
                var query = (from kh in db.KhachHangs
                             where kh.PHAI == true
                             select new
                             {
                                 MaKhachHang = kh.MA,
                                 HoTenDem = kh.HOTENDEM,
                                 Ten = kh.TEN,
                                 CMND = kh.CMND,
                                 SoDT = kh.SODT,
                                 QueQuan = kh.QUEQUAN,
                                 HKTT = kh.HKTT
                             })
                            .Take(3);
                dgvTruyVan.DataSource = query;
            }

            if (cbBox.Text == "9. Danh Sách Thiết Bị Từng Phòng (Nếu Có)")
            {
                if(data=="")
                {
                    MessageBox.Show("Mời bạn nhập mã phòng!");
                }    
                else
                {
                    int a = int.Parse(data);
                    var query = from ph in db.Phongs
                                join tbph in db.TbPhongs on ph.MA equals tbph.MAPHONG
                                join tb in db.ThietBis on tbph.MATHIETBI equals tb.MA
                                where ph.MA == a
                                select new { MaPhong = ph.MA, TenPhong = ph.TENPHONG, TenThietBi=tb.TENTHIETBI };
                    dgvTruyVan.DataSource = query;
                }    
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormTruyVan_Load(object sender, EventArgs e)
        {

        }
    }
}
