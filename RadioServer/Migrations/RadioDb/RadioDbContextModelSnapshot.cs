// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RadioServer.Data;

namespace RadioServer.Migrations.RadioDb
{
    [DbContext(typeof(RadioDbContext))]
    partial class RadioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("RadioServer.Models.RadioStations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IconUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("StationName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StationUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RadioStations");
                });
#pragma warning restore 612, 618
        }
    }
}
