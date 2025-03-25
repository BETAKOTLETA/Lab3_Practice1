using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Psotify.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class CorrectSpellOfLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lenght",
                table: "Songs",
                newName: "Length");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Songs",
                newName: "Lenght");
        }
    }
}
