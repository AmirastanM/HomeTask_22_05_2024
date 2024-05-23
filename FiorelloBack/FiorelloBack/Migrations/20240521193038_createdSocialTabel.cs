using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloBack.Migrations
{
    public partial class createdSocialTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 23, 30, 38, 214, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fab fa-twitter mr-1", "Twitter" },
                    { 2, "fab fa-instagram mr-1", "Instagram" },
                    { 3, "fab fa-tumblr mr-1", "Tumblr" },
                    { 4, "fab fa-pinterest mr-1", "Pinterest" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6509));
        }
    }
}
