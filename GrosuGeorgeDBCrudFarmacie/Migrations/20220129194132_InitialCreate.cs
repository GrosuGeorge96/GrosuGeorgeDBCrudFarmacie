using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrosuGeorgeDBCrudFarmacie.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farmacii",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    farmacieDen = table.Column<string>(maxLength: 30, nullable: false),
                    farmacieAdr = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmacii", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Oras",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    orasDen = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    produsNume = table.Column<string>(maxLength: 30, nullable: false),
                    produsProd = table.Column<string>(maxLength: 60, nullable: false),
                    produsExp = table.Column<DateTime>(nullable: false),
                    FarmaciiID = table.Column<int>(nullable: false),
                    OrasID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produse_Farmacii_FarmaciiID",
                        column: x => x.FarmaciiID,
                        principalTable: "Farmacii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produse_Oras_OrasID",
                        column: x => x.OrasID,
                        principalTable: "Oras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FarmacieOras",
                columns: table => new
                {
                    FarmacieOrasID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdusID = table.Column<int>(nullable: false),
                    ProduseID = table.Column<int>(nullable: true),
                    FarmaciiID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmacieOras", x => x.FarmacieOrasID);
                    table.ForeignKey(
                        name: "FK_FarmacieOras_Farmacii_FarmaciiID",
                        column: x => x.FarmaciiID,
                        principalTable: "Farmacii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FarmacieOras_Produse_ProduseID",
                        column: x => x.ProduseID,
                        principalTable: "Produse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FarmacieOras_FarmaciiID",
                table: "FarmacieOras",
                column: "FarmaciiID");

            migrationBuilder.CreateIndex(
                name: "IX_FarmacieOras_ProduseID",
                table: "FarmacieOras",
                column: "ProduseID");

            migrationBuilder.CreateIndex(
                name: "IX_Produse_FarmaciiID",
                table: "Produse",
                column: "FarmaciiID");

            migrationBuilder.CreateIndex(
                name: "IX_Produse_OrasID",
                table: "Produse",
                column: "OrasID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmacieOras");

            migrationBuilder.DropTable(
                name: "Produse");

            migrationBuilder.DropTable(
                name: "Farmacii");

            migrationBuilder.DropTable(
                name: "Oras");
        }
    }
}
