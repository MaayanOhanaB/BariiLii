﻿// <auto-generated />
using System;
using BariiLii.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BariiLii.Migrations
{
    [DbContext(typeof(BariiLiiContext))]
    partial class BariiLiiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BariiLii.Models.AppointmentSystem", b =>
                {
                    b.Property<string>("TypeOfPain")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AvailabilityQueues")
                        .HasColumnType("datetime2");

                    b.Property<int>("DId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorDId")
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PatientId1")
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("TypeOfPain");

                    b.HasIndex("DoctorDId");

                    b.HasIndex("PatientId1");

                    b.ToTable("AppointmentSystems");
                });

            modelBuilder.Entity("BariiLii.Models.Doctor", b =>
                {
                    b.Property<string>("DId")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<DateTime>("Availability")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousExprience")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("BariiLii.Models.Patient", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocRate")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfPain")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("BariiLii.Models.AppointmentSystem", b =>
                {
                    b.HasOne("BariiLii.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorDId");

                    b.HasOne("BariiLii.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId1");
                });
#pragma warning restore 612, 618
        }
    }
}
