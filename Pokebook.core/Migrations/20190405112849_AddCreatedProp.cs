using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddCreatedProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "UserChats",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Messages",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Chats",
                nullable: true,
                defaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2019, 4, 5, 13, 28, 48, 567, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2019, 4, 5, 11, 28, 48, 569, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 5, 13, 28, 49, 89, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 5, 13, 28, 49, 89, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 4, 5, 13, 28, 49, 89, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 4, 5, 13, 28, 49, 70, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 4, 5, 13, 28, 49, 70, DateTimeKind.Local).AddTicks(4023));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "UserChats");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2019, 4, 4, 11, 31, 35, 100, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2019, 4, 4, 9, 31, 35, 102, DateTimeKind.Local).AddTicks(8417));
        }
    }
}
