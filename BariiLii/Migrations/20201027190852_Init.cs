using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BariiLii.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DId = table.Column<string>(maxLength: 9, nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    Availability = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    PreviousExprience = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<string>(maxLength: 9, nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    TypeOfPain = table.Column<string>(nullable: true),
                    DocRate = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentSystems",
                columns: table => new
                {
                    TypeOfPain = table.Column<string>(nullable: false),
                    DId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    AvailabilityQueues = table.Column<DateTime>(nullable: false),
                    DoctorDId = table.Column<string>(nullable: true),
                    PatientId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentSystems", x => x.TypeOfPain);
                    table.ForeignKey(
                        name: "FK_AppointmentSystems_Doctors_DoctorDId",
                        column: x => x.DoctorDId,
                        principalTable: "Doctors",
                        principalColumn: "DId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentSystems_Patients_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSystems_DoctorDId",
                table: "AppointmentSystems",
                column: "DoctorDId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSystems_PatientId1",
                table: "AppointmentSystems",
                column: "PatientId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentSystems");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
