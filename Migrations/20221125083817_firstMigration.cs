using Microsoft.EntityFrameworkCore.Migrations;

namespace LegitBankApp.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "varchar(767)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    AccountNumber = table.Column<string>(type: "varchar(767)", nullable: false),
                    Pin = table.Column<string>(type: "text", nullable: true),
                    AccountType = table.Column<string>(type: "text", nullable: true),
                    AccountBalance = table.Column<double>(type: "double", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "managingDirector",
                columns: table => new
                {
                    ManagerId = table.Column<string>(type: "varchar(767)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managingDirector", x => x.ManagerId);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    AccountNumber = table.Column<string>(type: "varchar(767)", nullable: false),
                    AccountBalance = table.Column<double>(type: "double", nullable: false),
                    WithdrawalAmount = table.Column<double>(type: "double", nullable: false),
                    DepositAmount = table.Column<double>(type: "double", nullable: false),
                    AirtimeAmount = table.Column<double>(type: "double", nullable: false),
                    TransferAmount = table.Column<double>(type: "double", nullable: false),
                    Pin = table.Column<string>(type: "text", nullable: true),
                    DateTime = table.Column<string>(type: "text", nullable: true),
                    RefNum = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.AccountNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "managingDirector");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
