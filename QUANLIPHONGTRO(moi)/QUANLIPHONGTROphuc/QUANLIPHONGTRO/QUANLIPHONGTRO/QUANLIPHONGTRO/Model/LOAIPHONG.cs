namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA { get; set; }

        [StringLength(30)]
        public string TENLOAIPHONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? DONGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
    public partial class LOAIPHONG
    {
        public static List<LOAIPHONG> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.LOAIPHONGs.ToList();
        }
        public static LOAIPHONG GetLoaiPhong(int idLoaiPhong)
        {
            QLNTModel context = new QLNTModel();
            return context.LOAIPHONGs.Where(p => p.MA == idLoaiPhong).FirstOrDefault();
        }
    }
}
