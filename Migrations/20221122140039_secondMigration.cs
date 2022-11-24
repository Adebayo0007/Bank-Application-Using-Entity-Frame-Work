using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace LegitBankApp.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    _accountNumber = table.Column<string>(type: "text", nullable: true),
                    _pin = table.Column<string>(type: "text", nullable: true),
                    _accountType = table.Column<string>(type: "text", nullable: true),
                    _customerRegNum = table.Column<int>(type: "int", nullable: false),
                    _accountBalance = table.Column<double>(type: "double", nullable: false),
                    _firstName = table.Column<string>(type: "text", nullable: true),
                    _lastName = table.Column<string>(type: "text", nullable: true),
                    _age = table.Column<string>(type: "text", nullable: true),
                    _email = table.Column<string>(type: "text", nullable: true),
                    _password = table.Column<string>(type: "text", nullable: true),
                    _phoneNumber = table.Column<string>(type: "text", nullable: true),
                    _address = table.Column<string>(type: "text", nullable: true),
                    _gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "managingDirector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    _firstName = table.Column<string>(type: "text", nullable: true),
                    _lastName = table.Column<string>(type: "text", nullable: true),
                    _age = table.Column<string>(type: "text", nullable: true),
                    _phoneNumber = table.Column<string>(type: "text", nullable: true),
                    _managerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managingDirector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    _refNum = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "managingDirector");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
