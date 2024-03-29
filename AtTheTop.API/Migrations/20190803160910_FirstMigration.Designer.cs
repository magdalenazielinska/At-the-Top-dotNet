﻿// <auto-generated />
using System;
using AtTheTop.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtTheTop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190803160910_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("AtTheTop.API.Models.Summit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Altitude");

                    b.Property<string>("Country");

                    b.Property<string>("Date");

                    b.Property<string>("Difficulty");

                    b.Property<string>("MountainRange");

                    b.Property<string>("Name");

                    b.Property<string>("Route");

                    b.Property<string>("UserDescription");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Summits");
                });

            modelBuilder.Entity("AtTheTop.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("ProfilePhotoUrl");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AtTheTop.API.Models.Summit", b =>
                {
                    b.HasOne("AtTheTop.API.Models.User", "User")
                        .WithMany("Summits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
