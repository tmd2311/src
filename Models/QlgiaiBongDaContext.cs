﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace src.Models;

public partial class QlgiaiBongDaContext : DbContext
{
    public QlgiaiBongDaContext()
    {
    }

    public QlgiaiBongDaContext(DbContextOptions<QlgiaiBongDaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cau5> Cau5s { get; set; }

    public virtual DbSet<Caulacbo> Caulacbos { get; set; }

    public virtual DbSet<Cauthu> Cauthus { get; set; }

    public virtual DbSet<Huanluyenvien> Huanluyenviens { get; set; }

    public virtual DbSet<Sanvandong> Sanvandongs { get; set; }

    public virtual DbSet<Trandau> Trandaus { get; set; }

    public virtual DbSet<TrandauCauthu> TrandauCauthus { get; set; }

    public virtual DbSet<TrandauGhiban> TrandauGhibans { get; set; }

    public virtual DbSet<Trongtai> Trongtais { get; set; }

    public virtual DbSet<TrongtaiTrandau> TrongtaiTrandaus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TA-MANH-DUNG;Initial Catalog=QLGiaiBongDa;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cau5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau5");

            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.HoVaTen).HasMaxLength(40);
            entity.Property(e => e.NgayThiDau).HasColumnType("datetime");
            entity.Property(e => e.TenClb)
                .HasMaxLength(80)
                .HasColumnName("TenCLB");
        });

        modelBuilder.Entity<Caulacbo>(entity =>
        {
            entity.HasKey(e => e.CauLacBoId).HasName("PK__CAULACBO__144BAB43E7A2205D");

            entity.ToTable("CAULACBO");

            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.Anh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HuanLuyenVienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HuanLuyenVienID");
            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");
            entity.Property(e => e.TenClb)
                .HasMaxLength(80)
                .HasColumnName("TenCLB");
            entity.Property(e => e.TenGoi)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.HuanLuyenVien).WithMany(p => p.Caulacbos)
                .HasForeignKey(d => d.HuanLuyenVienId)
                .HasConstraintName("FK_CAULACBO_HUANLUYENVIEN");

            entity.HasOne(d => d.SanVanDong).WithMany(p => p.Caulacbos)
                .HasForeignKey(d => d.SanVanDongId)
                .HasConstraintName("FK_CAULACBO_SANVANDONG");
        });

        modelBuilder.Entity<Cauthu>(entity =>
        {
            entity.HasKey(e => e.CauThuId).HasName("PK__CAUTHU__023D5A04");

            entity.ToTable("CAUTHU");

            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.HoVaTen).HasMaxLength(40);
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.QuocTich)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SoAo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ViTri)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.CauLacBo).WithMany(p => p.Cauthus)
                .HasForeignKey(d => d.CauLacBoId)
                .HasConstraintName("FK_CAUTHU_CAULACBO");
        });

        modelBuilder.Entity<Huanluyenvien>(entity =>
        {
            entity.HasKey(e => e.HuanLuyenVienId).HasName("PK__HUANLUYE__8DF5FB21E74D98E8");

            entity.ToTable("HUANLUYENVIEN");

            entity.Property(e => e.HuanLuyenVienId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HuanLuyenVienID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.QuocTich).HasMaxLength(40);
            entity.Property(e => e.TenHlv)
                .HasMaxLength(40)
                .HasColumnName("TenHLV");
        });

        modelBuilder.Entity<Sanvandong>(entity =>
        {
            entity.HasKey(e => e.SanVanDongId).HasName("PK__SANVANDONG__7E6CC920");

            entity.ToTable("SANVANDONG");

            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenSan).HasMaxLength(60);
            entity.Property(e => e.ThanhPho)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Trandau>(entity =>
        {
            entity.HasKey(e => e.TranDauId).HasName("PK__TRANDAU__0425A276");

            entity.ToTable("TRANDAU");

            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
            entity.Property(e => e.Anh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clbkhach)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLBKhach");
            entity.Property(e => e.Clbnha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLBNha");
            entity.Property(e => e.HiepPhu).HasColumnType("datetime");
            entity.Property(e => e.KetQua).HasMaxLength(30);
            entity.Property(e => e.NgayThiDau).HasColumnType("datetime");
            entity.Property(e => e.SanVanDongId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SanVanDongID");

            entity.HasOne(d => d.ClbkhachNavigation).WithMany(p => p.TrandauClbkhachNavigations)
                .HasForeignKey(d => d.Clbkhach)
                .HasConstraintName("FK_TRANDAU_CLBKHACH");

            entity.HasOne(d => d.ClbnhaNavigation).WithMany(p => p.TrandauClbnhaNavigations)
                .HasForeignKey(d => d.Clbnha)
                .HasConstraintName("FK_TRANDAU_CLBNHA");

            entity.HasOne(d => d.SanVanDong).WithMany(p => p.Trandaus)
                .HasForeignKey(d => d.SanVanDongId)
                .HasConstraintName("FK_TRANDAU_SANVANDONG");
        });

        modelBuilder.Entity<TrandauCauthu>(entity =>
        {
            entity.HasKey(e => new { e.TranDauId, e.CauThuId }).HasName("PK__TRANDAU_CAUTHU__07F6335A");

            entity.ToTable("TRANDAU_CAUTHU");

            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.PhamLoi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CauThu).WithMany(p => p.TrandauCauthus)
                .HasForeignKey(d => d.CauThuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANDAU_CAUTHU_CAUTHU");

            entity.HasOne(d => d.TranDau).WithMany(p => p.TrandauCauthus)
                .HasForeignKey(d => d.TranDauId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANDAU_CAUTHU_TRANDAU");
        });

        modelBuilder.Entity<TrandauGhiban>(entity =>
        {
            entity.HasKey(e => e.GhiBanId).HasName("PK__TRANDAU_GHIBAN__060DEAE8");

            entity.ToTable("TRANDAU_GHIBAN");

            entity.Property(e => e.GhiBanId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GhiBanID");
            entity.Property(e => e.CauLacBoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauLacBoID");
            entity.Property(e => e.CauThuId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CauThuID");
            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");

            entity.HasOne(d => d.CauLacBo).WithMany(p => p.TrandauGhibans)
                .HasForeignKey(d => d.CauLacBoId)
                .HasConstraintName("FK_TRANDAU_GHIBAN_CAULACBO");

            entity.HasOne(d => d.CauThu).WithMany(p => p.TrandauGhibans)
                .HasForeignKey(d => d.CauThuId)
                .HasConstraintName("FK_TRANDAU_GHIBAN_CAUTHU");

            entity.HasOne(d => d.TranDau).WithMany(p => p.TrandauGhibans)
                .HasForeignKey(d => d.TranDauId)
                .HasConstraintName("FK_TRANDAU_GHIBAN_TRANDAU");
        });

        modelBuilder.Entity<Trongtai>(entity =>
        {
            entity.HasKey(e => e.TrongTaiId).HasName("PK__TRONGTAI__94867D37D86E6CC5");

            entity.ToTable("TRONGTAI");

            entity.Property(e => e.TrongTaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TrongTaiID");
            entity.Property(e => e.Anh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoVaTen).HasMaxLength(50);
            entity.Property(e => e.QueHuong).HasMaxLength(50);
            entity.Property(e => e.QuocTich).HasMaxLength(50);
        });

        modelBuilder.Entity<TrongtaiTrandau>(entity =>
        {
            entity.HasKey(e => new { e.TrongTaiId, e.TranDauId }).HasName("pk_trongtai_trandau");

            entity.ToTable("TRONGTAI_TRANDAU");

            entity.Property(e => e.TrongTaiId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TrongTaiID");
            entity.Property(e => e.TranDauId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TranDauID");
            entity.Property(e => e.ViTri).HasMaxLength(50);

            entity.HasOne(d => d.TranDau).WithMany(p => p.TrongtaiTrandaus)
                .HasForeignKey(d => d.TranDauId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRONGTAI_TRANDAU");

            entity.HasOne(d => d.TrongTai).WithMany(p => p.TrongtaiTrandaus)
                .HasForeignKey(d => d.TrongTaiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANDAU_TRONGTAI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
