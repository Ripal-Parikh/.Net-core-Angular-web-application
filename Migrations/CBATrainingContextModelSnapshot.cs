﻿// <auto-generated />
using CBA_Training.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CBA_Training.Migrations
{
    [DbContext(typeof(CBATrainingContext))]
    partial class CBATrainingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CBA_Training.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "It is the company department charged with finding, screening, recruiting and training.",
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The accounting department is responsible for recording and reporting the cash flow transactions of a company.",
                            Name = "Account"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A sales department is the direct link between a company's product or service and its customers. ",
                            Name = "Sales"
                        });
                });
                     
#pragma warning restore 612, 618
        }
    }
}