﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCEFAPP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    appointmentno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientID = table.Column<int>(type: "int", nullable: false),
                    DocterID = table.Column<int>(type: "int", nullable: false),
                    DateOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.appointmentno);
                });

            migrationBuilder.CreateTable(
                name: "Docters",
                columns: table => new
                {
                    doctorno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VistingFee = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    PhoneNumber = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docters", x => x.doctorno);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "Docters");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
