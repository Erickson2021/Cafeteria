﻿// <auto-generated />
using Bookshop.Services.CuponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookshop.Services.CuponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookshop.Services.CuponAPI.Models.Cupon", b =>
                {
                    b.Property<int>("CuponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuponId"));

                    b.Property<string>("CodigoCupon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Descuento")
                        .HasColumnType("float");

                    b.Property<int>("MinCanti")
                        .HasColumnType("int");

                    b.HasKey("CuponId");

                    b.ToTable("Cupons");

                    b.HasData(
                        new
                        {
                            CuponId = 1,
                            CodigoCupon = "100FF",
                            Descuento = 10.0,
                            MinCanti = 20
                        },
                        new
                        {
                            CuponId = 2,
                            CodigoCupon = "200FF",
                            Descuento = 20.0,
                            MinCanti = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
