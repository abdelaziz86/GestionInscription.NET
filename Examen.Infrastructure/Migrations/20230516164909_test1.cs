using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exemples");

            migrationBuilder.CreateTable(
                name: "Seminaires",
                columns: table => new
                {
                    code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intitule = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    lieu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    tarif = table.Column<double>(type: "float", nullable: false),
                    dateSeminaire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nombreMaximal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminaires", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Specialites",
                columns: table => new
                {
                    specialiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    abreviation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialites", x => x.specialiteId);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    prenom = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    numeroTelephone = table.Column<int>(type: "int", nullable: false),
                    TypeParticipant = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    fonction = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    nomEntreprise = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    niveau = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    nomInstitut = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    SpecialiteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.id);
                    table.ForeignKey(
                        name: "FK_Participants_Specialites_SpecialiteFK",
                        column: x => x.SpecialiteFK,
                        principalTable: "Specialites",
                        principalColumn: "specialiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscriptions",
                columns: table => new
                {
                    dateInscription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeminiareFK = table.Column<int>(type: "int", nullable: false),
                    ParticipantFK = table.Column<int>(type: "int", nullable: false),
                    tauxReduction = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => new { x.ParticipantFK, x.SeminiareFK, x.dateInscription });
                    table.ForeignKey(
                        name: "FK_Inscriptions_Participants_ParticipantFK",
                        column: x => x.ParticipantFK,
                        principalTable: "Participants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscriptions_Seminaires_SeminiareFK",
                        column: x => x.SeminiareFK,
                        principalTable: "Seminaires",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_SeminiareFK",
                table: "Inscriptions",
                column: "SeminiareFK");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_SpecialiteFK",
                table: "Participants",
                column: "SpecialiteFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Seminaires");

            migrationBuilder.DropTable(
                name: "Specialites");

            migrationBuilder.CreateTable(
                name: "exemples",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exemples", x => x.id);
                });
        }
    }
}
