﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_murdodav.Models;

namespace Mission06_murdodav.Migrations
{
    [DbContext(typeof(MovieCollectionContext))]
    [Migration("20230213191259_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06_murdodav.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("movieinfo");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Action/Adventure",
                            Director = "George Lucas",
                            Edited = false,
                            Notes = "This is the unedited v.",
                            Rating = "PG",
                            Title = "Star Wars: A New Hope",
                            Year = 1977
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Family",
                            Director = "Chris McKay",
                            Edited = false,
                            Notes = "Lots of fun!",
                            Rating = "PG",
                            Title = "LEGO Batman",
                            Year = 2017
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Comedy",
                            Director = "Andy Fickman",
                            Edited = false,
                            Notes = "This is a good one!",
                            Rating = "PG-13",
                            Title = "She's the Man",
                            Year = 2006
                        });
                });
#pragma warning restore 612, 618
        }
    }
}