﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReviewingAPI.Data;

#nullable disable

namespace MovieReviewingAPI.Migrations
{
    [DbContext(typeof(MovieData))]
    partial class MovieDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieReviewingAPI.Model.AdminPage", b =>
                {
                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MovieDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RatingonIMD")
                        .HasColumnType("real");

                    b.HasKey("MovieName");

                    b.ToTable("MovieDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
