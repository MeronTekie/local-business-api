// <auto-generated />
using LocalBusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocalBusinessApi.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20220610165320_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusinessApi.Models.LocalBusiness", b =>
                {
                    b.Property<int>("LocalBusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("LocalBusinessId");

                    b.ToTable("LocalBusinesses");
                });
#pragma warning restore 612, 618
        }
    }
}
