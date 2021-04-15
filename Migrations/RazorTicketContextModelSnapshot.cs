﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorTicket.Data;

namespace RazorTicket.Migrations
{
    [DbContext(typeof(RazorTicketContext))]
    partial class RazorTicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorTicket.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActivityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ActivityId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("RazorTicket.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("RazorTicket.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("RazorTicket.Models.Priority", b =>
                {
                    b.Property<int>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PriorityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriorityId");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("RazorTicket.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("RazorTicket.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("RazorTicket.Models.Subcategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubcategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubcategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory");
                });

            modelBuilder.Entity("RazorTicket.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignedUserId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PriorityId")
                        .HasColumnType("int");

                    b.Property<int>("ReportingUserId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TicketDateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TicketDateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TicketDateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("TicketDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.HasIndex("AssignedUserId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("ReportingUserId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("RazorTicket.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RazorTicket.Models.Activity", b =>
                {
                    b.HasOne("RazorTicket.Models.Ticket", "Ticket")
                        .WithMany("Activity")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.User", "User")
                        .WithMany("Activity")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RazorTicket.Models.Subcategory", b =>
                {
                    b.HasOne("RazorTicket.Models.Category", "Category")
                        .WithMany("Subcategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RazorTicket.Models.Ticket", b =>
                {
                    b.HasOne("RazorTicket.Models.User", "AssignedUser")
                        .WithMany("AssignedTickets")
                        .HasForeignKey("AssignedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.Category", "Category")
                        .WithMany("Ticket")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.Priority", "Priority")
                        .WithMany("Ticket")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.User", "ReportingUser")
                        .WithMany("ReportedTickets")
                        .HasForeignKey("ReportingUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.Status", "Status")
                        .WithMany("Ticket")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.Subcategory", "Subcategory")
                        .WithMany("Ticket")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedUser");

                    b.Navigation("Category");

                    b.Navigation("Priority");

                    b.Navigation("ReportingUser");

                    b.Navigation("Status");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("RazorTicket.Models.User", b =>
                {
                    b.HasOne("RazorTicket.Models.Department", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorTicket.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RazorTicket.Models.Category", b =>
                {
                    b.Navigation("Subcategory");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("RazorTicket.Models.Department", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("RazorTicket.Models.Priority", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("RazorTicket.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("RazorTicket.Models.Status", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("RazorTicket.Models.Subcategory", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("RazorTicket.Models.Ticket", b =>
                {
                    b.Navigation("Activity");
                });

            modelBuilder.Entity("RazorTicket.Models.User", b =>
                {
                    b.Navigation("Activity");

                    b.Navigation("AssignedTickets");

                    b.Navigation("ReportedTickets");
                });
#pragma warning restore 612, 618
        }
    }
}
