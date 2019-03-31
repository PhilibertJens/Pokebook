using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.api.Migrations
{
    public partial class AddedUserChatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserChats",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2019, 3, 27, 15, 58, 50, 478, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2019, 3, 27, 13, 58, 50, 480, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserChats");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2019, 3, 19, 11, 51, 57, 857, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2019, 3, 19, 9, 51, 57, 859, DateTimeKind.Local));
        }
    }
}
