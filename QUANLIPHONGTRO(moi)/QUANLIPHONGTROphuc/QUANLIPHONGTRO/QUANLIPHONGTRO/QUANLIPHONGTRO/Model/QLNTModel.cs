using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLIPHONGTRO.Model
{
    public partial class QLNTModel : DbContext
    {
        public QLNTModel()
            : base("name=QLNTModel")
        {
        }

        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<QUANLY> QUANLies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .Property(e => e.TIENDIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TIENNUOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.DICHVUKHAC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SOTIENPHAITRA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.DATHANHTOAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.TIENDATCOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.HOADONs)
                .WithOptional(e => e.HOPDONG)
                .HasForeignKey(e => e.MAHOPDONG);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SODT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOPDONGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.MAKHACHHANG);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithOptional(e => e.LOAIPHONG)
                .HasForeignKey(e => e.MALOAIPHONG);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.HOPDONGs)
                .WithOptional(e => e.PHONG)
                .HasForeignKey(e => e.MAPHONG);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THIETBIs)
                .WithMany(e => e.PHONGs)
                .Map(m => m.ToTable("TBPHONG").MapLeftKey("MAPHONG").MapRightKey("MATHIETBI"));

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.USERNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.PASS)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
