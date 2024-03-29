﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VinylDatabase.Models;

#nullable disable

namespace VinylDatabase.Migrations
{
    [DbContext(typeof(VinylDbContext))]
    [Migration("20231201162119_UpdateTypes")]
    partial class UpdateTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("VinylDatabase.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Length")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VinylId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrackId");

                    b.HasIndex("VinylId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("VinylDatabase.Models.Vinyl", b =>
                {
                    b.Property<int>("VinylId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfLps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfTracks")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VinylId");

                    b.ToTable("Vinyls");
                });

            modelBuilder.Entity("VinylDatabase.Models.Track", b =>
                {
                    b.HasOne("VinylDatabase.Models.Vinyl", "Vinyl")
                        .WithMany("Tracks")
                        .HasForeignKey("VinylId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vinyl");
                });

            modelBuilder.Entity("VinylDatabase.Models.Vinyl", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
