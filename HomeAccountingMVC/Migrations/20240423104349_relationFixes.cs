using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAccountingMVC.Migrations
{
    /// <inheritdoc />
    public partial class relationFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Transactions_TransactionID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TransactionID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Transactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryID",
                table: "Transactions",
                column: "CategoryID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryID",
                table: "Transactions",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CategoryID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "TransactionID",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TransactionID",
                table: "Categories",
                column: "TransactionID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Transactions_TransactionID",
                table: "Categories",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
