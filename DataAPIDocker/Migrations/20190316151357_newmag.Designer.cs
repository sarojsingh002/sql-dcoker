﻿// <auto-generated />
using DataAPIDocker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAPIDocker.Migrations
{
    [DbContext(typeof(MagContext))]
    [Migration("20190316151357_newmag")]
    partial class newmag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAPIDocker.Magazine", b =>
                {
                    b.Property<int>("MagazineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("MagazineId");

                    b.ToTable("Magazine");

                    b.HasData(
                        new
                        {
                            MagazineId = 1,
                            Name = "MSDN Magazine"
                        },
                        new
                        {
                            MagazineId = 2,
                            Name = "Docker Magazine"
                        },
                        new
                        {
                            MagazineId = 3,
                            Name = "EFCore Magazine"
                        },
                        new
                        {
                            MagazineId = 4,
                            Name = "DockerCompose Magazine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}