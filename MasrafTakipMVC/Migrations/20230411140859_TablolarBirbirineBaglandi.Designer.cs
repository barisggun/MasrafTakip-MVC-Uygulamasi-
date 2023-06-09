﻿// <auto-generated />
using System;
using MasrafTakipMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasrafTakipMVC.Migrations
{
    [DbContext(typeof(MasrafTakipContext))]
    [Migration("20230411140859_TablolarBirbirineBaglandi")]
    partial class TablolarBirbirineBaglandi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MasrafTakipMVC.Models.Harcama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FisNo")
                        .HasColumnType("int");

                    b.Property<string>("Notlar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("Harcamalar");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.HarcamaDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HarcamaId")
                        .HasColumnType("int");

                    b.Property<int>("HarcamaTipiId")
                        .HasColumnType("int");

                    b.Property<int>("HarcamalarId")
                        .HasColumnType("int");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HarcamaId");

                    b.HasIndex("HarcamaTipiId");

                    b.ToTable("HarcamaDetaylari");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.HarcamaTipi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HarcamaTipleri");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gorev")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.Harcama", b =>
                {
                    b.HasOne("MasrafTakipMVC.Models.Personel", "Personel")
                        .WithMany("Harcamalar")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.HarcamaDetay", b =>
                {
                    b.HasOne("MasrafTakipMVC.Models.Harcama", "Harcama")
                        .WithMany("HarcamaDetaylari")
                        .HasForeignKey("HarcamaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasrafTakipMVC.Models.HarcamaTipi", "HarcamaTipi")
                        .WithMany("HarcamaDetaylari")
                        .HasForeignKey("HarcamaTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Harcama");

                    b.Navigation("HarcamaTipi");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.Harcama", b =>
                {
                    b.Navigation("HarcamaDetaylari");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.HarcamaTipi", b =>
                {
                    b.Navigation("HarcamaDetaylari");
                });

            modelBuilder.Entity("MasrafTakipMVC.Models.Personel", b =>
                {
                    b.Navigation("Harcamalar");
                });
#pragma warning restore 612, 618
        }
    }
}
