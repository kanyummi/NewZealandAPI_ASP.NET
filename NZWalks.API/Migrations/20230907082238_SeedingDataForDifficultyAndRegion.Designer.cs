﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.API.Data;

#nullable disable

namespace NZWalks.API.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    [Migration("20230907082238_SeedingDataForDifficultyAndRegion")]
    partial class SeedingDataForDifficultyAndRegion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85a475dc-7179-4e62-87e4-97e50846089c"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("62880fd8-c0eb-4af8-8313-43dcb87581ae"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("b5e79ee9-126d-421d-beda-4764b359fff6"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47f44064-be12-464b-a4d6-bd64fba761f5"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://a.cdn-hotels.com/gdcs/production133/d294/4e4195aa-b9ca-42cd-923f-e8a65c8c5c7b.jpg?impolicy=fcrop&w=800&h=533&q=medium"
                        },
                        new
                        {
                            Id = new Guid("365c016a-8771-47bc-a434-6b75946f985b"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://tec.edu.vn/wp-content/uploads/2022/12/179180-Wellington.jpg"
                        },
                        new
                        {
                            Id = new Guid("488ccb62-37a8-4e23-88bc-4ba742cb53dd"),
                            Code = "NSN",
                            Name = "Nelson",
                            RegionImageUrl = "https://d27k8xmh3cuzik.cloudfront.net/wp-content/uploads/2018/11/Places-to-Visit-in-Nelson-OG-min.jpg"
                        },
                        new
                        {
                            Id = new Guid("c9eeb2a5-5f77-47a8-8625-907d7921d763"),
                            Code = "NSN",
                            Name = "Southland",
                            RegionImageUrl = "https://www.newzealand.com/assets/Tourism-NZ/Other/img-1536012255-9458-6899-2653996258_835f78284f_o__aWxvdmVrZWxseQo_CropResizeWzEyMDAsNjMwLDc1LCJqcGciXQ.jpg"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalks.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
