using Microsoft.EntityFrameworkCore.Migrations;

namespace LegitBankApp.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "_accountBalance",
                table: "Transaction",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "_accountNumber",
                table: "Transaction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "_airtimeAmount",
                table: "Transaction",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "_dateTime",
                table: "Transaction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "_depositAmount",
                table: "Transaction",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "_pin",
                table: "Transaction",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "_transferAmount",
                table: "Transaction",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "_withdrawalAmount",
                table: "Transaction",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_accountBalance",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_accountNumber",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_airtimeAmount",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_dateTime",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_depositAmount",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_pin",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_transferAmount",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "_withdrawalAmount",
                table: "Transaction");
        }
    }
}
