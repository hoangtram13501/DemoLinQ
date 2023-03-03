using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo123.Migrations
{
    /// <inheritdoc />
    public partial class addtlb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Spj",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spj", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Suppiler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppiler", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Spj");

            migrationBuilder.DropTable(
                name: "Suppiler");
        }
    }
}
