using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "DateAdded", "GenreId", "Name", "NumberAvailable", "NumberInStock", "ReleaseDate" },
                values: new object[,]
                {
                    { 5, "Mroz", new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, "Nela", 0, 0, new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Mroz", new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, "Damian", 0, 0, new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pawel ");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MembershipTypeId", "Name" },
                values: new object[] { (byte)2, "ALA" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MembershipTypeId", "Name" },
                values: new object[] { (byte)3, "Ola ciska" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Rita Ora");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MembershipTypeId", "Name" },
                values: new object[] { (byte)1, "Kamila Tela" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MembershipTypeId", "Name" },
                values: new object[] { (byte)1, "Lee Child" });
        }
    }
}
