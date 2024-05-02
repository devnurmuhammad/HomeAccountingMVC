using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAccountingMVC.Migrations
{
    /// <inheritdoc />
    public partial class categoryChangedToStringFromEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Income",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Outcome",
                table: "Categories",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "Sum",
                table: "Transactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sum",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Categories",
                newName: "Outcome");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Income",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
