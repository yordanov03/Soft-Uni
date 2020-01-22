using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    MedicamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.MedicamentID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HasInsurance = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    DiagnoseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Comments = table.Column<string>(maxLength: 250, nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.DiagnoseId);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Patients",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perscriptions",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false),
                    MedicamentID = table.Column<int>(nullable: false),
                    PatientMedicamentMedicamentID = table.Column<int>(nullable: true),
                    PatientMedicamentPatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perscriptions", x => new { x.PatientID, x.MedicamentID });
                    table.ForeignKey(
                        name: "FK_Perscriptions_Medicaments_MedicamentID",
                        column: x => x.MedicamentID,
                        principalTable: "Medicaments",
                        principalColumn: "MedicamentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perscriptions_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perscriptions_Perscriptions_PatientMedicamentPatientID_PatientMedicamentMedicamentID",
                        columns: x => new { x.PatientMedicamentPatientID, x.PatientMedicamentMedicamentID },
                        principalTable: "Perscriptions",
                        principalColumns: new[] { "PatientID", "MedicamentID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitations",
                columns: table => new
                {
                    VisitationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValueSql: "GETDATE()"),
                    Comments = table.Column<string>(maxLength: 250, nullable: true),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitations", x => x.VisitationId);
                    table.ForeignKey(
                        name: "FK_Visitation_Patient",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_PatientID",
                table: "Diagnoses",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Perscriptions_MedicamentID",
                table: "Perscriptions",
                column: "MedicamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Perscriptions_PatientMedicamentPatientID_PatientMedicamentMedicamentID",
                table: "Perscriptions",
                columns: new[] { "PatientMedicamentPatientID", "PatientMedicamentMedicamentID" });

            migrationBuilder.CreateIndex(
                name: "IX_Visitations_PatientID",
                table: "Visitations",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Perscriptions");

            migrationBuilder.DropTable(
                name: "Visitations");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
