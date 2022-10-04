namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        public int? MAHOPDONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENDIEN { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENNUOC { get; set; }

        [Column(TypeName = "money")]
        public decimal? DICHVUKHAC { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOTIENPHAITRA { get; set; }

        [Column(TypeName = "money")]
        public decimal? DATHANHTOAN { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }
    }
    public partial class HOADON
    {
        public static List<HOADON> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.HOADONs.ToList();
        }
        public static HOADON GetHoaDon(int hoaDonId)
        {
            QLNTModel context = new QLNTModel();
            return context.HOADONs.Where(p => p.MA == hoaDonId).FirstOrDefault();
        }
        public static HOADON GetHoaDonByHopDong(int? HopDongId)
        {
            QLNTModel context = new QLNTModel();
            return context.HOADONs.LastOrDefault(p => p.MAHOPDONG == HopDongId);

        }

        public int InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            //HoaDon hoaDon = this;
            context.HOADONs.AddOrUpdate(this);
            return context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLNTModel context = new QLNTModel();
            HOADON hd = context.HOADONs.Where(p => p.MA == id).FirstOrDefault();
            if (hd != null)
            {
                //  context.Students.Attach(db);
                context.HOADONs.Remove(hd);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
