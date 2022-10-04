namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            HOPDONGs = new HashSet<HOPDONG>();
            THIETBIs = new HashSet<THIETBI>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        [StringLength(30)]
        public string TENPHONG { get; set; }

        public int? MALOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBI> THIETBIs { get; set; }
    }
    public partial class PHONG
    {
        public static List<PHONG> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.PHONGs.ToList();
        }
        public static List<PHONG> GetAll(int loaiPhong)
        {
            QLNTModel context = new QLNTModel();
            return context.PHONGs.Where(p => p.MA == loaiPhong).ToList();
        }
        public static PHONG GetPhong(int phongid)
        {
            QLNTModel context = new QLNTModel();
            return context.PHONGs.Where(p => p.MA == phongid).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            context.PHONGs.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLNTModel context = new QLNTModel();
            PHONG ph = context.PHONGs.Where(p => p.MA == id).FirstOrDefault();
            if (ph != null)
            {
                //  context.Students.Attach(db);
                context.PHONGs.Remove(ph);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }

    }
}
