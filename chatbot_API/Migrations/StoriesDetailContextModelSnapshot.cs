﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chatbot_API.Models;

namespace chatbot_API.Migrations
{
    [DbContext(typeof(StoriesDetailContext))]
    partial class StoriesDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("chatbot_API.Models.StoriesDetail", b =>
                {
                    b.Property<int>("Stories_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Stories_Text")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Stories_headName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Stories_Id");

                    b.ToTable("StoriesDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
