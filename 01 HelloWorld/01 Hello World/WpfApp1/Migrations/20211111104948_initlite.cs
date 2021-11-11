using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfApp1.Migrations
{
    public partial class initlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ulice = table.Column<string>(type: "TEXT", nullable: true),
                    Mesto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KrestniJmeno = table.Column<string>(type: "TEXT", nullable: true),
                    Prijmeni = table.Column<string>(type: "TEXT", nullable: true),
                    DatumNarozeni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdresaDomovId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Addresses_AdresaDomovId",
                        column: x => x.AdresaDomovId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegistracniZnacka = table.Column<string>(type: "TEXT", nullable: true),
                    Barva = table.Column<string>(type: "TEXT", nullable: true),
                    NajeteKilometry = table.Column<double>(type: "REAL", nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PersonId",
                table: "Cars",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_AdresaDomovId",
                table: "People",
                column: "AdresaDomovId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
