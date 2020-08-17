namespace DataProviderNFC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NFCDB : DbContext
    {
        public NFCDB()
            : base("name=NFCDB")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheTichDiemSpa> TheTichDiemSpas { get; set; }
        public virtual DbSet<ThongTinGiaoVien> ThongTinGiaoViens { get; set; }
        public virtual DbSet<ThongTinHocSinh> ThongTinHocSinhs { get; set; }
        public virtual DbSet<ThongTinLop> ThongTinLops { get; set; }
        public virtual DbSet<ThongTinTruong> ThongTinTruongs { get; set; }
        public virtual DbSet<ThongTinNguoiThan> ThongTinNguoiThans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThongTinGiaoVien>()
                .Property(e => e.magv)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinGiaoVien>()
                .Property(e => e.sodienthoai)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinGiaoVien>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinGiaoVien>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinGiaoVien>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinHocSinh>()
                .Property(e => e.mahs)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinHocSinh>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinHocSinh>()
                .Property(e => e.magv)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinLop>()
                .Property(e => e.malop)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinLop>()
                .Property(e => e.matruong)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinTruong>()
                .Property(e => e.matruong)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinNguoiThan>()
                .Property(e => e.uid)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinNguoiThan>()
                .Property(e => e.mahs)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinNguoiThan>()
                .Property(e => e.sodienthoai)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinNguoiThan>()
                .Property(e => e.malop)
                .IsFixedLength();
        }
    }
}
