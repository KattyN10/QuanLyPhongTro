namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        public int? MAKHACHHANG { get; set; }

        public int? MAPHONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENDATCOC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTHUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }
      
    }
    public partial class HOPDONG
    {
        public static List<HOPDONG> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.HOPDONGs.ToList();
        }
        public static HOPDONG GetHopDong(int hopdongId)
        {
            QLNTModel context = new QLNTModel();
            return context.HOPDONGs.Where(p => p.MA == hopdongId).FirstOrDefault();
        }
        public static HOPDONG GetHoaDonByPhong(int? phongId)
        {
            QLNTModel context = new QLNTModel();
            return context.HOPDONGs.LastOrDefault(p => p.MAPHONG == phongId);

        }
        public static HOPDONG GetHoaDonByHoaDon(int? khachhangId)
        {
            QLNTModel context = new QLNTModel();
            return context.HOPDONGs.LastOrDefault(p => p.MAKHACHHANG == khachhangId);

        }

        public int InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            context.HOPDONGs.AddOrUpdate(this);
            return context.SaveChanges();
        }
    
        public static void Delete(int id)
        {
            QLNTModel context = new QLNTModel();
            HOPDONG hd = context.HOPDONGs.Where(p => p.MA == id).FirstOrDefault();
            if (hd != null)
            {
                //  context.Students.Attach(db);
                context.HOPDONGs.Remove(hd);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
