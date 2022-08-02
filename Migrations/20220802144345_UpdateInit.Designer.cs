﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix.Database;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixContext))]
    [Migration("20220802144345_UpdateInit")]
    partial class UpdateInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContenutoVideoPlayList", b =>
                {
                    b.Property<int>("ContenutoVideosId")
                        .HasColumnType("int");

                    b.Property<int>("PlayListsId")
                        .HasColumnType("int");

                    b.HasKey("ContenutoVideosId", "PlayListsId");

                    b.HasIndex("PlayListsId");

                    b.ToTable("ContenutoVideoPlayList");
                });

            modelBuilder.Entity("ContenutoVideoProfilo", b =>
                {
                    b.Property<int>("ContenutoVideosId")
                        .HasColumnType("int");

                    b.Property<int>("ProfiliId")
                        .HasColumnType("int");

                    b.HasKey("ContenutoVideosId", "ProfiliId");

                    b.HasIndex("ProfiliId");

                    b.ToTable("ContenutoVideoProfilo");
                });

            modelBuilder.Entity("csharp_boolflix.Models.ContenutoVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<int>("GenereId")
                        .HasColumnType("int");

                    b.Property<bool>("Novità")
                        .HasColumnType("bit");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenereId");

                    b.ToTable("ContenutiVideo");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ContenutoVideo");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeGenere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generi");
                });

            modelBuilder.Entity("csharp_boolflix.Models.PlayList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProfiloId")
                        .HasColumnType("int");

                    b.Property<string>("TitoloPlayList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfiloId");

                    b.ToTable("PlayLists");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Profilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Bambino")
                        .HasColumnType("bit");

                    b.Property<string>("NomeProfilo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profili");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TitoloSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Stagione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NumeroStagione")
                        .HasColumnType("int");

                    b.Property<string>("TitoloStagione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stagioni");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episodio", b =>
                {
                    b.HasBaseType("csharp_boolflix.Models.ContenutoVideo");

                    b.Property<string>("NomeEpisodio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Episodio");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.HasBaseType("csharp_boolflix.Models.ContenutoVideo");

                    b.Property<string>("NomeFilm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("ContenutoVideoPlayList", b =>
                {
                    b.HasOne("csharp_boolflix.Models.ContenutoVideo", null)
                        .WithMany()
                        .HasForeignKey("ContenutoVideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.PlayList", null)
                        .WithMany()
                        .HasForeignKey("PlayListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContenutoVideoProfilo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.ContenutoVideo", null)
                        .WithMany()
                        .HasForeignKey("ContenutoVideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.Profilo", null)
                        .WithMany()
                        .HasForeignKey("ProfiliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Models.ContenutoVideo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Genere", "Genere")
                        .WithMany("ContenutoVideos")
                        .HasForeignKey("GenereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genere");
                });

            modelBuilder.Entity("csharp_boolflix.Models.PlayList", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Profilo", "Profilo")
                        .WithMany("PlayLists")
                        .HasForeignKey("ProfiloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profilo");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genere", b =>
                {
                    b.Navigation("ContenutoVideos");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Profilo", b =>
                {
                    b.Navigation("PlayLists");
                });
#pragma warning restore 612, 618
        }
    }
}