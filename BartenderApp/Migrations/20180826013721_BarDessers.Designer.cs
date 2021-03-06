﻿// <auto-generated />
using System;
using BartenderApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BartenderApp.Migrations
{
    [DbContext(typeof(DrinkContext))]
    [Migration("20180826013721_BarDessers")]
    partial class BarDessers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BartenderApp.Models.BarDesserts", b =>
                {
                    b.Property<int>("BarDessertsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DessertName");

                    b.Property<DateTime>("DessertOrderTime");

                    b.HasKey("BarDessertsId");

                    b.ToTable("Desserts");
                });

            modelBuilder.Entity("BartenderApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrinkName");

                    b.Property<DateTime>("orderTime");

                    b.HasKey("OrderId");

                    b.ToTable("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
