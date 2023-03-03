using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo123.Migrations
{
    /// <inheritdoc />
    public partial class renametbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppiler",
                table: "Suppiler");

            migrationBuilder.RenameTable(
                name: "Suppiler",
                newName: "Supplier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppiler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppiler",
                table: "Suppiler",
                column: "id");
        }
    }
}
