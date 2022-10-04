namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("THIETBI")]
    public partial class THIETBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THIETBI()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        [StringLength(30)]
        public string TENTHIETBI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
    public partial class THIETBI
    {
        public static List<THIETBI> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.THIETBIs.ToList();
        }
        public static THIETBI GetThietBi(int thietbiId)
        {
            QLNTModel context = new QLNTModel();
            return context.THIETBIs.Where(p => p.MA == thietbiId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            context.THIETBIs.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLNTModel context = new QLNTModel();
            THIETBI db = context.THIETBIs.Where(p => p.MA == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.THIETBIs.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }

    }
}
