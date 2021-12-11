﻿// <auto-generated />
using System;
using CafeCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CafeCore.Migrations
{
    [DbContext(typeof(CafeContext))]
    [Migration("20211211070042_deneme2")]
    partial class deneme2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CafeCore.Model.Kat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Kodu")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("MasaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("SiraNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Katlar");
                });

            modelBuilder.Entity("CafeCore.Model.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SiraNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("CafeCore.Model.Masa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KatId")
                        .HasColumnType("int");

                    b.Property<int>("No")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KatId");

                    b.ToTable("Masalar");
                });

            modelBuilder.Entity("CafeCore.Model.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MasaId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MasaId");

                    b.HasIndex("UrunId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("CafeCore.Model.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int?>("SiparisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("SiparisId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("CafeCore.Model.Masa", b =>
                {
                    b.HasOne("CafeCore.Model.Kat", "Kat")
                        .WithMany("Masalar")
                        .HasForeignKey("KatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kat");
                });

            modelBuilder.Entity("CafeCore.Model.Siparis", b =>
                {
                    b.HasOne("CafeCore.Model.Masa", "Masa")
                        .WithMany("Siparisler")
                        .HasForeignKey("MasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CafeCore.Model.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Masa");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("CafeCore.Model.Urun", b =>
                {
                    b.HasOne("CafeCore.Model.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CafeCore.Model.Siparis", null)
                        .WithMany("Urunler")
                        .HasForeignKey("SiparisId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("CafeCore.Model.Kat", b =>
                {
                    b.Navigation("Masalar");
                });

            modelBuilder.Entity("CafeCore.Model.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("CafeCore.Model.Masa", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("CafeCore.Model.Siparis", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
