using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class Duan1QlBanquanaoContext : DbContext
{
    public Duan1QlBanquanaoContext()
    {
    }

    public Duan1QlBanquanaoContext(DbContextOptions<Duan1QlBanquanaoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Kichthuoc> Kichthuocs { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Salesanpham> Salesanphams { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sanphamchitiet> Sanphamchitiets { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MN98SD2\\SQLEXPRESS;Initial Catalog=DUAN1_QL_BANQUANAO;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__CHATLIEU__453995BC2A7A9CD4");

            entity.ToTable("CHATLIEU");

            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HOADON__835ED13BD7B2FF69");

            entity.ToTable("HOADON");

            entity.Property(e => e.MaHoaDon)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaKhuyenMai)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NgayLap).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(255);

            entity.HasOne(d => d.MaKhuyenMaiNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaKhuyenMai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MaKhuyen__3F466844");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MaNhanVi__3E52440B");

            entity.HasOne(d => d.SoDienThoaiNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.SoDienThoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__SoDienTh__403A8C7D");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonChiTiet).HasName("PK__HOADONCH__6C2FD0CE2BFABCA0");

            entity.ToTable("HOADONCHITIET");

            entity.Property(e => e.MaHoaDonChiTiet)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MaHoaDon)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(255);

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHI__MaHoa__4316F928");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHI__MaSan__440B1D61");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.SoDienThoai).HasName("PK__KHACHHAN__0389B7BCEBAA2195");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasMaxLength(5);
            entity.Property(e => e.HoVaTen).HasMaxLength(255);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.MaKhuyenMai).HasName("PK__KHUYENMA__6F56B3BDEBB201FD");

            entity.ToTable("KHUYENMAI");

            entity.Property(e => e.MaKhuyenMai)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.KieuKhuyenMai)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MucGiam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NgayHetHan).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(255);
        });

        modelBuilder.Entity<Kichthuoc>(entity =>
        {
            entity.HasKey(e => e.MaKichThuoc).HasName("PK__KICHTHUO__22BFD6642F595FDC");

            entity.ToTable("KICHTHUOC");

            entity.Property(e => e.MaKichThuoc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.MaMauSac).HasName("PK__MAUSAC__B9A911626A680158");

            entity.ToTable("MAUSAC");

            entity.Property(e => e.MaMauSac)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NHANVIEN__77B2CA470F64574E");

            entity.ToTable("NHANVIEN");

            entity.HasIndex(e => e.MaNhanVien, "UQ__NHANVIEN__77B2CA467D8A2E70").IsUnique();

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NamSinh).HasColumnType("datetime");
            entity.Property(e => e.NgayVaoLam).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TenChucVu).HasMaxLength(255);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(255);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Salesanpham>(entity =>
        {
            entity.HasKey(e => e.MaSale).HasName("PK__SALESANP__B234B7A7E0DF38A8");

            entity.ToTable("SALESANPHAM");

            entity.Property(e => e.MaSale)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GiaTri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SANPHAM__FAC7442D62427FD4");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.MaSanPham)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaThuongHieu)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);

            entity.HasOne(d => d.MaThuongHieuNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.MaThuongHieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAM__MaThuon__267ABA7A");
        });

        modelBuilder.Entity<Sanphamchitiet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SANPHAMCHITIET");

            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaKichThuoc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaMauSac)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaSale)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaSanPhamChiTiet)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaThuongHieu)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.MoTaChiTiet).HasMaxLength(255);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany()
                .HasForeignKey(d => d.MaChatLieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaCha__31EC6D26");

            entity.HasOne(d => d.MaKichThuocNavigation).WithMany()
                .HasForeignKey(d => d.MaKichThuoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaKic__30F848ED");

            entity.HasOne(d => d.MaMauSacNavigation).WithMany()
                .HasForeignKey(d => d.MaMauSac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaMau__32E0915F");

            entity.HasOne(d => d.MaSaleNavigation).WithMany()
                .HasForeignKey(d => d.MaSale)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaSal__34C8D9D1");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany()
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaSan__300424B4");

            entity.HasOne(d => d.MaThuongHieuNavigation).WithMany()
                .HasForeignKey(d => d.MaThuongHieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCH__MaThu__33D4B598");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.MaThuongHieu).HasName("PK__THUONGHI__A3733E2CBB27C74E");

            entity.ToTable("THUONGHIEU");

            entity.Property(e => e.MaThuongHieu)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TenThuongHieu).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
