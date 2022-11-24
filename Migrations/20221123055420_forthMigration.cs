using Microsoft.EntityFrameworkCore.Migrations;

namespace LegitBankApp.Migrations
{
    public partial class forthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_withdrawalAmount",
                table: "Transaction",
                newName: "WithdrawalAmount");

            migrationBuilder.RenameColumn(
                name: "_transferAmount",
                table: "Transaction",
                newName: "TransferAmount");

            migrationBuilder.RenameColumn(
                name: "_refNum",
                table: "Transaction",
                newName: "RefNum");

            migrationBuilder.RenameColumn(
                name: "_pin",
                table: "Transaction",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "_depositAmount",
                table: "Transaction",
                newName: "DepositAmount");

            migrationBuilder.RenameColumn(
                name: "_dateTime",
                table: "Transaction",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "_airtimeAmount",
                table: "Transaction",
                newName: "AirtimeAmount");

            migrationBuilder.RenameColumn(
                name: "_accountNumber",
                table: "Transaction",
                newName: "AccountNumber");

            migrationBuilder.RenameColumn(
                name: "_accountBalance",
                table: "Transaction",
                newName: "AccountBalance");

            migrationBuilder.RenameColumn(
                name: "_phoneNumber",
                table: "managingDirector",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "_managerId",
                table: "managingDirector",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "_lastName",
                table: "managingDirector",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "_firstName",
                table: "managingDirector",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "_age",
                table: "managingDirector",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "_pin",
                table: "Customer",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "_phoneNumber",
                table: "Customer",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "_password",
                table: "Customer",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "_lastName",
                table: "Customer",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "_gender",
                table: "Customer",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "_firstName",
                table: "Customer",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "_email",
                table: "Customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "_customerRegNum",
                table: "Customer",
                newName: "CustomerRegNum");

            migrationBuilder.RenameColumn(
                name: "_age",
                table: "Customer",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "_address",
                table: "Customer",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "_accountType",
                table: "Customer",
                newName: "AccountType");

            migrationBuilder.RenameColumn(
                name: "_accountNumber",
                table: "Customer",
                newName: "AccountNumber");

            migrationBuilder.RenameColumn(
                name: "_accountBalance",
                table: "Customer",
                newName: "AccountBalance");

            migrationBuilder.RenameColumn(
                name: "_staffID",
                table: "Admin",
                newName: "StaffID");

            migrationBuilder.RenameColumn(
                name: "_phoneNumber",
                table: "Admin",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "_password",
                table: "Admin",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "_lastName",
                table: "Admin",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "_gender",
                table: "Admin",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "_firstName",
                table: "Admin",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "_email",
                table: "Admin",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "_age",
                table: "Admin",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "_address",
                table: "Admin",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WithdrawalAmount",
                table: "Transaction",
                newName: "_withdrawalAmount");

            migrationBuilder.RenameColumn(
                name: "TransferAmount",
                table: "Transaction",
                newName: "_transferAmount");

            migrationBuilder.RenameColumn(
                name: "RefNum",
                table: "Transaction",
                newName: "_refNum");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Transaction",
                newName: "_pin");

            migrationBuilder.RenameColumn(
                name: "DepositAmount",
                table: "Transaction",
                newName: "_depositAmount");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Transaction",
                newName: "_dateTime");

            migrationBuilder.RenameColumn(
                name: "AirtimeAmount",
                table: "Transaction",
                newName: "_airtimeAmount");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "Transaction",
                newName: "_accountNumber");

            migrationBuilder.RenameColumn(
                name: "AccountBalance",
                table: "Transaction",
                newName: "_accountBalance");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "managingDirector",
                newName: "_phoneNumber");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "managingDirector",
                newName: "_managerId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "managingDirector",
                newName: "_lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "managingDirector",
                newName: "_firstName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "managingDirector",
                newName: "_age");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Customer",
                newName: "_pin");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customer",
                newName: "_phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customer",
                newName: "_password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customer",
                newName: "_lastName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Customer",
                newName: "_gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customer",
                newName: "_firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customer",
                newName: "_email");

            migrationBuilder.RenameColumn(
                name: "CustomerRegNum",
                table: "Customer",
                newName: "_customerRegNum");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Customer",
                newName: "_age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customer",
                newName: "_address");

            migrationBuilder.RenameColumn(
                name: "AccountType",
                table: "Customer",
                newName: "_accountType");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "Customer",
                newName: "_accountNumber");

            migrationBuilder.RenameColumn(
                name: "AccountBalance",
                table: "Customer",
                newName: "_accountBalance");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Admin",
                newName: "_staffID");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Admin",
                newName: "_phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Admin",
                newName: "_password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Admin",
                newName: "_lastName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Admin",
                newName: "_gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Admin",
                newName: "_firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Admin",
                newName: "_email");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Admin",
                newName: "_age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Admin",
                newName: "_address");
        }
    }
}
