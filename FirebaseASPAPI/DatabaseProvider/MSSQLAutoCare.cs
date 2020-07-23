 namespace DatabaseProvider
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MSSQLAutoCare : DbContext
    {
        public MSSQLAutoCare()
            : base("name=MSSQLAutoCare")
        {
        }

        public virtual DbSet<BaoGiaCongTho> BaoGiaCongThoes { get; set; }
        public virtual DbSet<BaoGiaCongThoTam> BaoGiaCongThoTams { get; set; }
        public virtual DbSet<BaoGiaPhuTung> BaoGiaPhuTungs { get; set; }
        public virtual DbSet<BaoGiaPhuTungTam> BaoGiaPhuTungTams { get; set; }
        public virtual DbSet<BaoGiaSuaChua> BaoGiaSuaChuas { get; set; }
        public virtual DbSet<BaoGiaSuaChuaTam> BaoGiaSuaChuaTams { get; set; }
        public virtual DbSet<BoPhan> BoPhans { get; set; }
        public virtual DbSet<CauHinhDauDoc_CongTy> CauHinhDauDoc_CongTy { get; set; }
        public virtual DbSet<CauHinhThe_Xe> CauHinhThe_Xe { get; set; }
        public virtual DbSet<CauHinhTichDiem> CauHinhTichDiems { get; set; }
        public virtual DbSet<CauHinhTinNhan> CauHinhTinNhans { get; set; }
        public virtual DbSet<ChiNhanhNganHang> ChiNhanhNganHangs { get; set; }
        public virtual DbSet<ChiTietBanXe> ChiTietBanXes { get; set; }
        public virtual DbSet<ChuanDoanXe> ChuanDoanXes { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CongTho> CongThoes { get; set; }
        public virtual DbSet<CongThoSoTien> CongThoSoTiens { get; set; }
        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<CongtyDoitac> CongtyDoitacs { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<GioViec> GioViecs { get; set; }
        public virtual DbSet<HangXeMay> HangXeMays { get; set; }
        public virtual DbSet<HoaDonBanXe> HoaDonBanXes { get; set; }
        public virtual DbSet<HoaDonNhapXe> HoaDonNhapXes { get; set; }
        public virtual DbSet<HopDongTraGop> HopDongTraGops { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachHangBaoDuongTruocKy> KhachHangBaoDuongTruocKies { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<KhoXuat> KhoXuats { get; set; }
        public virtual DbSet<KieuXe1> KieuXe1 { get; set; }
        public virtual DbSet<LichSuBaoDuongXe> LichSuBaoDuongXes { get; set; }
        public virtual DbSet<LichSuBaoDuongXeTamNotification> LichSuBaoDuongXeTamNotifications { get; set; }
        public virtual DbSet<LichSuBaoDuongXeTamNotificationHistory> LichSuBaoDuongXeTamNotificationHistories { get; set; }
        public virtual DbSet<LichSuCapQuota> LichSuCapQuotas { get; set; }
        public virtual DbSet<LichSuCapQuotaLog> LichSuCapQuotaLogs { get; set; }
        public virtual DbSet<LichSuDatPhuTung> LichSuDatPhuTungs { get; set; }
        public virtual DbSet<LichSuTichDiem> LichSuTichDiems { get; set; }
        public virtual DbSet<LichSuXuatKhoNgoai> LichSuXuatKhoNgoais { get; set; }
        public virtual DbSet<LoaiHoaDOn> LoaiHoaDOns { get; set; }
        public virtual DbSet<LoaiPhieuChi> LoaiPhieuChis { get; set; }
        public virtual DbSet<LoaiPhieuThu> LoaiPhieuThus { get; set; }
        public virtual DbSet<LoaiTinNhan> LoaiTinNhans { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<MauXe> MauXes { get; set; }
        public virtual DbSet<MauXeMay> MauXeMays { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<NhomKhachHang> NhomKhachHangs { get; set; }
        public virtual DbSet<PhieuChi> PhieuChis { get; set; }
        public virtual DbSet<PhuTung> PhuTungs { get; set; }
        public virtual DbSet<SMSBirthdayConfig> SMSBirthdayConfigs { get; set; }
        public virtual DbSet<SMSCaringConfig> SMSCaringConfigs { get; set; }
        public virtual DbSet<SmsChangOilByKmHistory> SmsChangOilByKmHistories { get; set; }
        public virtual DbSet<SMSConfig> SMSConfigs { get; set; }
        public virtual DbSet<SMSKiemTraBaoDuongConfig> SMSKiemTraBaoDuongConfigs { get; set; }
        public virtual DbSet<SMSMaintenanceConfig> SMSMaintenanceConfigs { get; set; }
        public virtual DbSet<SMSMaintenanceConfigALL> SMSMaintenanceConfigALLs { get; set; }
        public virtual DbSet<SMSMoiThayDau_Config> SMSMoiThayDau_Config { get; set; }
        public virtual DbSet<SMSMoiThayDauMay_Config> SMSMoiThayDauMay_Config { get; set; }
        public virtual DbSet<SMSNhanDichVuConfig> SMSNhanDichVuConfigs { get; set; }
        public virtual DbSet<SMSTuyBienStore> SMSTuyBienStores { get; set; }
        public virtual DbSet<Software_Update> Software_Update { get; set; }
        public virtual DbSet<Software_UpdateHistory> Software_UpdateHistory { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanDangNhap> TaiKhoanDangNhaps { get; set; }
        public virtual DbSet<TaiKhoanDangNhap_Log> TaiKhoanDangNhap_Log { get; set; }
        public virtual DbSet<TaiKhoanDangNhapWeb> TaiKhoanDangNhapWebs { get; set; }
        public virtual DbSet<TblCongviec> TblCongviecs { get; set; }
        public virtual DbSet<tblDiaChiKhachHang> tblDiaChiKhachHangs { get; set; }
        public virtual DbSet<tblPhieuTiepNhan> tblPhieuTiepNhans { get; set; }
        public virtual DbSet<TBLTELCOLOGSY> TBLTELCOLOGSYS { get; set; }
        public virtual DbSet<TbltrangthaiBD> TbltrangthaiBDs { get; set; }
        public virtual DbSet<TestDB> TestDBs { get; set; }
        public virtual DbSet<ThoDichVu> ThoDichVus { get; set; }
        public virtual DbSet<ThoDichVu_TienCongTho> ThoDichVu_TienCongTho { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }
        public virtual DbSet<ThongBao_audits> ThongBao_audits { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieux { get; set; }
        public virtual DbSet<TichDiem> TichDiems { get; set; }
        public virtual DbSet<TienCongTho> TienCongThoes { get; set; }
        public virtual DbSet<TinNhan> TinNhans { get; set; }
        public virtual DbSet<TinNhan_bak> TinNhan_bak { get; set; }
        public virtual DbSet<XeCuaHang> XeCuaHangs { get; set; }
        public virtual DbSet<XeDaBan> XeDaBans { get; set; }
        public virtual DbSet<XeMay> XeMays { get; set; }
        public virtual DbSet<XeMayNgoaiHeThong> XeMayNgoaiHeThongs { get; set; }
        public virtual DbSet<ChiTietNhapPhuKien> ChiTietNhapPhuKiens { get; set; }
        public virtual DbSet<ChiTietNhapXe> ChiTietNhapXes { get; set; }
        public virtual DbSet<ChiTietPhuKien> ChiTietPhuKiens { get; set; }
        public virtual DbSet<ChiTietXe> ChiTietXes { get; set; }
        public virtual DbSet<ChuanDoanXeTam> ChuanDoanXeTams { get; set; }
        public virtual DbSet<HoaDonNhapPhuTung> HoaDonNhapPhuTungs { get; set; }
        public virtual DbSet<khachhang_cvfont> khachhang_cvfont { get; set; }
        public virtual DbSet<KhoNhap> KhoNhaps { get; set; }
        public virtual DbSet<KieuNhapXe> KieuNhapXes { get; set; }
        public virtual DbSet<KyThuatVien_BaoDuong> KyThuatVien_BaoDuong { get; set; }
        public virtual DbSet<LichSuBaoDuongXe_2017> LichSuBaoDuongXe_2017 { get; set; }
        public virtual DbSet<LichSuBaoDuongXe_bkthangloi_20180409> LichSuBaoDuongXe_bkthangloi_20180409 { get; set; }
        public virtual DbSet<LichSuBaoDuongXe_bkvietan> LichSuBaoDuongXe_bkvietan { get; set; }
        public virtual DbSet<LichSuBaoDuongXeTam> LichSuBaoDuongXeTams { get; set; }
        public virtual DbSet<LoaiTraGop> LoaiTraGops { get; set; }
        public virtual DbSet<MatKhauEdit> MatKhauEdits { get; set; }
        public virtual DbSet<NganHang> NganHangs { get; set; }
        public virtual DbSet<NguoiLapPhieu> NguoiLapPhieux { get; set; }
        public virtual DbSet<PhieuThu> PhieuThus { get; set; }
        public virtual DbSet<PhuKien> PhuKiens { get; set; }
        public virtual DbSet<QuotaRemainByDay> QuotaRemainByDays { get; set; }
        public virtual DbSet<TBLTELCO> TBLTELCOes { get; set; }
        public virtual DbSet<ThoDichVu_GioViec> ThoDichVu_GioViec { get; set; }
        public virtual DbSet<ThoDichVu_TienCongTho2> ThoDichVu_TienCongTho2 { get; set; }
        public virtual DbSet<ThoDichVu_TienCongThoTam> ThoDichVu_TienCongThoTam { get; set; }
        public virtual DbSet<ThueNgoai> ThueNgoais { get; set; }
        public virtual DbSet<tinnhan_xedaban> tinnhan_xedaban { get; set; }
        public virtual DbSet<xedaban_99_201801> xedaban_99_201801 { get; set; }
        public virtual DbSet<xedaban_bk20180418> xedaban_bk20180418 { get; set; }
        public virtual DbSet<xedabanbk_43> xedabanbk_43 { get; set; }
        public virtual DbSet<xedabantest> xedabantests { get; set; }

        public virtual DbSet<TimKiemThongTinKHTheoBienSo> TimKiemThongTinKHTheoBienSo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoGiaCongTho>()
                .Property(e => e.TienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaCongThoTam>()
                .Property(e => e.TienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaPhuTung>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaPhuTung>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaPhuTungTam>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaPhuTungTam>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChua>()
                .Property(e => e.TongTienVatTu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChua>()
                .Property(e => e.TongTienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChua>()
                .Property(e => e.VAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChua>()
                .Property(e => e.TongSauVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChua>()
                .HasMany(e => e.BaoGiaPhuTungs)
                .WithRequired(e => e.BaoGiaSuaChua)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BaoGiaSuaChuaTam>()
                .Property(e => e.TongTienVatTu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChuaTam>()
                .Property(e => e.TongTienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChuaTam>()
                .Property(e => e.VAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BaoGiaSuaChuaTam>()
                .Property(e => e.TongSauVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CauHinhDauDoc_CongTy>()
                .Property(e => e.idDauDoc)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhDauDoc_CongTy>()
                .Property(e => e.loai)
                .IsFixedLength();

            modelBuilder.Entity<CauHinhThe_Xe>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhThe_Xe>()
                .Property(e => e.bienso)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhThe_Xe>()
                .Property(e => e.sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhThe_Xe>()
                .Property(e => e.somay)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhThe_Xe>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhTinNhan>()
                .Property(e => e.maLoaiTin)
                .IsUnicode(false);

            modelBuilder.Entity<CauHinhTinNhan>()
                .Property(e => e.noiDungTinNhan)
                .IsUnicode(false);

            modelBuilder.Entity<ChiNhanhNganHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.DonGiaVao)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.VAT)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.GiaCoVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietBanXe>()
                .Property(e => e.SoChungTu)
                .IsUnicode(false);

            modelBuilder.Entity<CongTho>()
                .Property(e => e.Thang)
                .IsUnicode(false);

            modelBuilder.Entity<CongTho>()
                .Property(e => e.Nam)
                .IsUnicode(false);

            modelBuilder.Entity<CongThoSoTien>()
                .Property(e => e.Nam)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.SecretKey)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.GoiPhanMem)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.BoPhans)
                .WithOptional(e => e.CongTy)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.ChucVus)
                .WithOptional(e => e.CongTy)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.CongtyDoitacs)
                .WithOptional(e => e.CongTy)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.CuaHangs)
                .WithOptional(e => e.CongTy)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CongtyDoitac>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<CongtyDoitac>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CongtyDoitac>()
                .Property(e => e.Masothue)
                .IsUnicode(false);

            modelBuilder.Entity<CongtyDoitac>()
                .Property(e => e.TaiKhoanNganHang)
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<CuaHang>()
                .HasMany(e => e.XeCuaHangs)
                .WithOptional(e => e.CuaHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<HoaDonBanXe>()
                .Property(e => e.SoHoaDonBanHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanXe>()
                .Property(e => e.SoChungTu)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBanXe>()
                .Property(e => e.TienPhuThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonBanXe>()
                .Property(e => e.TienDaTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonNhapXe>()
                .Property(e => e.SoHoaDonNhap)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapXe>()
                .Property(e => e.SoChungTu)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapXe>()
                .Property(e => e.LoHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapXe>()
                .Property(e => e.TienDaTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HopDongTraGop>()
                .Property(e => e.SoHopDongTraGop)
                .IsUnicode(false);

            modelBuilder.Entity<HopDongTraGop>()
                .Property(e => e.LaiSuat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HopDongTraGop>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HopDongTraGop>()
                .Property(e => e.SoTienTraGop)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HopDongTraGop>()
                .Property(e => e.SoTienThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoSBH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHangBaoDuongTruocKy>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.Sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.BANNANG)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.KhachDenTu)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.idReader)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotification>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.KhachDenTu)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.idReader)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTamNotificationHistory>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTinNhan>()
                .Property(e => e.maLoaiTin)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaSoThue)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuChi>()
                .Property(e => e.SoTienChi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuChi>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<SMSMaintenanceConfig>()
                .Property(e => e.ThangNhan)
                .IsUnicode(false);

            modelBuilder.Entity<SMSMaintenanceConfigALL>()
                .Property(e => e.ThangNhan)
                .IsUnicode(false);

            modelBuilder.Entity<Software_Update>()
                .Property(e => e.SWName)
                .IsUnicode(false);

            modelBuilder.Entity<Software_Update>()
                .Property(e => e.OldVersion)
                .IsUnicode(false);

            modelBuilder.Entity<Software_Update>()
                .Property(e => e.NewVersion)
                .IsUnicode(false);

            modelBuilder.Entity<Software_Update>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Software_Update>()
                .HasMany(e => e.Software_UpdateHistory)
                .WithRequired(e => e.Software_Update)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Software_UpdateHistory>()
                .Property(e => e.OldVersion)
                .IsUnicode(false);

            modelBuilder.Entity<Software_UpdateHistory>()
                .Property(e => e.NewVersion)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanDangNhap>()
                .Property(e => e.Quyen)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTELCOLOGSY>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TestDB>()
                .Property(e => e.HoTen)
                .IsFixedLength();

            modelBuilder.Entity<TestDB>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<ThoDichVu>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<ThongBao_audits>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<ThuongHieu>()
                .Property(e => e.ThuongHieu1)
                .IsUnicode(false);

            modelBuilder.Entity<TichDiem>()
                .Property(e => e.bienSo)
                .IsUnicode(false);

            modelBuilder.Entity<TichDiem>()
                .Property(e => e.soKhung)
                .IsUnicode(false);

            modelBuilder.Entity<TichDiem>()
                .Property(e => e.soMay)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan>()
                .Property(e => e.smstype)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan_bak>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan_bak>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<TinNhan_bak>()
                .Property(e => e.smstype)
                .IsUnicode(false);

            modelBuilder.Entity<XeCuaHang>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<XeCuaHang>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.LogTimeSent)
                .IsUnicode(false);

            modelBuilder.Entity<XeDaBan>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<XeMay>()
                .Property(e => e.IDXe)
                .IsUnicode(false);

            modelBuilder.Entity<XeMay>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<XeMayNgoaiHeThong>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<XeMayNgoaiHeThong>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<XeMayNgoaiHeThong>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapPhuKien>()
                .Property(e => e.SoHoaDonNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapPhuKien>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.SoHoaDonNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.IdXe)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.GiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.SoChungTu)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.VAT)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietNhapXe>()
                .Property(e => e.GiaCoVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhuKien>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietXe>()
                .Property(e => e.IdKey)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXe>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXe>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXe>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.IDNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.IDNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.IdCuaHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.IDKieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.IDCongTy)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.TienDaTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonNhapPhuTung>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<khachhang_cvfont>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang_cvfont>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang_cvfont>()
                .Property(e => e.SoSBH)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_2017>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_2017>()
                .Property(e => e.Sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_2017>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_2017>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_2017>()
                .Property(e => e.BANNANG)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkthangloi_20180409>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkthangloi_20180409>()
                .Property(e => e.Sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkthangloi_20180409>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkthangloi_20180409>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkvietan>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkvietan>()
                .Property(e => e.Sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkvietan>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXe_bkvietan>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.Sokhung)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.LoaiBaoDuong)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.BANNANG)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuBaoDuongXeTam>()
                .Property(e => e.idTag)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhauEdit>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhauEdit>()
                .Property(e => e.privilege)
                .IsFixedLength();

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.SoTienThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.SoHopDong)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaRemainByDay>()
                .Property(e => e.login_name)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaRemainByDay>()
                .Property(e => e.sender_name)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaRemainByDay>()
                .Property(e => e.sms_type)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaRemainByDay>()
                .Property(e => e.responsed_code)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTELCO>()
                .Property(e => e.MSISDN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThoDichVu_TienCongTho2>()
                .Property(e => e.TienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThoDichVu_TienCongTho2>()
                .Property(e => e.TienKhachTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThoDichVu_TienCongTho2>()
                .Property(e => e.PhanTramTrietKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThoDichVu_TienCongTho2>()
                .Property(e => e.TienTrietKhau)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThoDichVu_TienCongThoTam>()
                .Property(e => e.TienCong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThoDichVu_TienCongThoTam>()
                .Property(e => e.MaTho)
                .IsUnicode(false);

            modelBuilder.Entity<ThoDichVu_TienCongThoTam>()
                .Property(e => e.TienKhachTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThoDichVu_TienCongThoTam>()
                .Property(e => e.PhanTramTrietKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThoDichVu_TienCongThoTam>()
                .Property(e => e.TienTrietKhau)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThueNgoai>()
                .Property(e => e.PhanTramTrietKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ThueNgoai>()
                .Property(e => e.TienTrietKhau)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xedaban_99_201801>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_99_201801>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_99_201801>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_99_201801>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xedaban_99_201801>()
                .Property(e => e.LogTimeSent)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_bk20180418>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_bk20180418>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_bk20180418>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<xedaban_bk20180418>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xedaban_bk20180418>()
                .Property(e => e.LogTimeSent)
                .IsUnicode(false);

            modelBuilder.Entity<xedabanbk_43>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<xedabanbk_43>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<xedabanbk_43>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<xedabanbk_43>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xedabanbk_43>()
                .Property(e => e.LogTimeSent)
                .IsUnicode(false);

            modelBuilder.Entity<xedabantest>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<xedabantest>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<xedabantest>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<xedabantest>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xedabantest>()
                .Property(e => e.LogTimeSent)
                .IsUnicode(false);
        }
    }
}
