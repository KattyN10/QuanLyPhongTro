namespace QUANLIPHONGTRO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("QUANLY")]
    public partial class QUANLY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string USERNAME { get; set; }

        [StringLength(10)]
        public string PASS { get; set; }

    }
    public partial class QUANLY
    {
        public static List<QUANLY> GetAll()
        {
            QLNTModel context = new QLNTModel();
            return context.QUANLies.ToList();
        }

        public static List<QUANLY> GetAll(string username)
        {
            QLNTModel context = new QLNTModel();
            return context.QUANLies.Where(p => p.USERNAME == username).ToList();
        }

        public static QUANLY GetQuanLy(string user)
        {
            QLNTModel context = new QLNTModel();
            return context.QUANLies.Where(p => p.USERNAME == user).FirstOrDefault();

        }
        public QUANLY InsertUpdate()
        {
            QLNTModel context = new QLNTModel();
            QUANLY ql = context.QUANLies.Add(this);
            context.SaveChanges();
            return ql;
        }
    }
    
}
