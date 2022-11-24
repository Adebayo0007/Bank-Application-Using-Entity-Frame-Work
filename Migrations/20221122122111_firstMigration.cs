using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    _staffID = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
