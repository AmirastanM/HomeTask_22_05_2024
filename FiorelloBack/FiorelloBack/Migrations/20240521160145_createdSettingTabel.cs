using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloBack.Migrations
{
    public partial class createdSettingTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6504), "HeadeLogo", false, "logo.png" },
                    { 2, new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6507), "Phone", false, "994518579645" },
                    { 3, new DateTime(2024, 5, 21, 20, 1, 45, 372, DateTimeKind.Local).AddTicks(6509), "Address", false, "Ahmadli" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 18, 19, 55, 368, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 18, 19, 55, 368, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 18, 19, 55, 368, DateTimeKind.Local).AddTicks(2581));
        }
    }
}
