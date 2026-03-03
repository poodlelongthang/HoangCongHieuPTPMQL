using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTPMQL_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ADD_COLUMN_AGE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Persons",
                newName: "PersonId");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Persons",
                newName: "PersonID");
        }
    }
}
