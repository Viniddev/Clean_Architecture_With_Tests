using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUserAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "UserInformations");

            migrationBuilder.AddColumn<Guid>(
                name: "UserAddressId",
                table: "UserInformations",
                type: "UNIQUEIDENTIFIER",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cep = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Neighborhood = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Number = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_BaseEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_UserAddressId",
                table: "UserInformations",
                column: "UserAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_BaseEntity_Id",
                table: "UserInformations",
                column: "Id",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_UserAddress_UserAddressId",
                table: "UserInformations",
                column: "UserAddressId",
                principalTable: "UserAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_BaseEntity_Id",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_UserAddress_UserAddressId",
                table: "UserInformations");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_UserInformations_UserAddressId",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "UserInformations");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "UserInformations",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserInformations",
                type: "BIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "UserInformations",
                type: "DATETIME2",
                nullable: true);
        }
    }
}
