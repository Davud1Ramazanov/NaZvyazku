using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NaZvyazku.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    CreditCardID = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: true),
                    CVV = table.Column<int>(type: "int", nullable: true),
                    DateCard = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.CreditCardID);
                });

            migrationBuilder.CreateTable(
                name: "INFO",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Login = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DateReg = table.Column<DateTime>(type: "datetime", nullable: true),
                    Subscription = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TARIFF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INFO__1788CCAC4DB20A25", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalArea",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Avatar = table.Column<byte[]>(type: "image", nullable: true),
                    TariffID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionID = table.Column<int>(type: "int", nullable: true),
                    Cash = table.Column<int>(type: "int", nullable: true),
                    Gigabyte = table.Column<int>(type: "int", nullable: true),
                    DateReg = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Personal__1788CCAC9C9AA6FC", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    PhoneNumberID = table.Column<int>(type: "int", nullable: false),
                    PhoneNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RolesID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roles = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__C4B27820267AFAAF", x => x.RolesID);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Gigabyte = table.Column<int>(type: "int", nullable: true),
                    Calls = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TARIFF",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TariffID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Device = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Gigabyte = table.Column<int>(type: "int", nullable: true),
                    Calls = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Authorization",
                columns: table => new
                {
                    AuthorizationID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Login = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Password = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CreditCardID = table.Column<int>(type: "int", nullable: true),
                    PhoneNumberID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Authoriz__09019C379427AB51", x => x.AuthorizationID);
                    table.ForeignKey(
                        name: "FK__Authoriza__Credi__5AEE82B9",
                        column: x => x.CreditCardID,
                        principalTable: "CreditCard",
                        principalColumn: "CreditCardID");
                    table.ForeignKey(
                        name: "FK__Authoriza__Phone__59FA5E80",
                        column: x => x.PhoneNumberID,
                        principalTable: "PhoneNumber",
                        principalColumn: "PhoneNumberID");
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DateReg = table.Column<DateTime>(type: "datetime", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    AuthorizationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER__1788CCAC85EA8372", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__USER__Authorizat__5FB337D6",
                        column: x => x.AuthorizationID,
                        principalTable: "Authorization",
                        principalColumn: "AuthorizationID");
                    table.ForeignKey(
                        name: "FK__USER__RoleID__5EBF139D",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RolesID");
                    table.ForeignKey(
                        name: "FK__USER__UserID__5DCAEF64",
                        column: x => x.UserID,
                        principalTable: "PersonalArea",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK__USER__UserID__60A75C0F",
                        column: x => x.UserID,
                        principalTable: "INFO",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_CreditCardID",
                table: "Authorization",
                column: "CreditCardID");

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_PhoneNumberID",
                table: "Authorization",
                column: "PhoneNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_AuthorizationID",
                table: "USER",
                column: "AuthorizationID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_RoleID",
                table: "USER",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "TARIFF");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "Authorization");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "PersonalArea");

            migrationBuilder.DropTable(
                name: "INFO");

            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropTable(
                name: "PhoneNumber");
        }
    }
}
