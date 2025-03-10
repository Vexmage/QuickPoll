﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QuickPoll.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250310054353_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("PollOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PollId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollOptions");
                });

            modelBuilder.Entity("PollOption", b =>
                {
                    b.HasOne("Poll", null)
                        .WithMany("Options")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Poll", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
