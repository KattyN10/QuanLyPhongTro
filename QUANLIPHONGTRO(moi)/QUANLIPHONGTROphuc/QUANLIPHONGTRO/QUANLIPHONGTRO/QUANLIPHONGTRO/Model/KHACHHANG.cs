namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOPDONGs = new HashSet<HOPDONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        [StringLength(30)]
        public string HOTENDEM { get; set; }

        [StringLength(15)]
        public string TEN { get; set; }

        public bool? PHAI { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        [StringLength(10)]
        public string SODT { get; set; }

        [StringLength(50)]
        public string QUEQUAN { get; set; }

        [StringLength(50)]
        public string HKTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
       
    }
    public partial class KHACHHANG
    {
        public static List<KHACHHANG> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.KHACHHANGs.ToList();
        }
        public static KHACHHANG GetKhachHang(int khachHangId)
        {
            QLNTModel context = new QLNTModel();
            return context.KHACHHANGs.Where(p => p.MA == khachHangId).FirstOrDefault();

        }
        public KHACHHANG InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            KHACHHANG kh = context.KHACHHANGs.Add(this);
            context.SaveChanges();
            return kh;

        }
        public static void Delete(int id)
        {
            QLNTModel context = new QLNTModel();
            KHACHHANG kh = context.KHACHHANGs.Where(p => p.MA == id).FirstOrDefault();
            if (kh != null)
            {
                //  context.Students.Attach(db);
                context.KHACHHANGs.Remove(kh);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
