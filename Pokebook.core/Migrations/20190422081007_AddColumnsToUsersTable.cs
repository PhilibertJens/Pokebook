using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddColumnsToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.AddColumn<string>(
                name: "CoverPicture",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 22, 10, 10, 6, 641, DateTimeKind.Local).AddTicks(934), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 4, 22, 8, 10, 6, 643, DateTimeKind.Local).AddTicks(3115), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CoverPicture", "Created", "ProfilePicture", "UserName" },
                values: new object[] { "Mt._Molteau.png", new DateTime(2019, 4, 22, 10, 10, 7, 130, DateTimeKind.Local).AddTicks(2232), "Pikachu.png", "TyrionLannister" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CoverPicture", "Created", "ProfilePicture", "UserName" },
                values: new object[] { "mountain.jpg", new DateTime(2019, 4, 22, 10, 10, 7, 130, DateTimeKind.Local).AddTicks(2396), "Magikarp.png", "JonSnow" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "This is a chat with myself. Is this even possible?" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "Hello Jon. This is Tyrion" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002"), "Hello Tyrion. I'm Jon" });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 22, 10, 10, 7, 146, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 22, 10, 10, 7, 146, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 4, 22, 10, 10, 7, 146, DateTimeKind.Local).AddTicks(9754));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DropColumn(
                name: "CoverPicture",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 20, 16, 58, 35, 984, DateTimeKind.Local).AddTicks(5876), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 4, 20, 14, 58, 35, 987, DateTimeKind.Local).AddTicks(7489), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Created", "UserName" },
                values: new object[] { new DateTime(2019, 4, 20, 16, 58, 36, 912, DateTimeKind.Local).AddTicks(8073), "Tyrion Lannister" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Created", "UserName" },
                values: new object[] { new DateTime(2019, 4, 20, 16, 58, 36, 912, DateTimeKind.Local).AddTicks(8207), "Jon Snow" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "This is a chat with myself. Is this even possible?" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "Hello Jon. This is Tyrion" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002"), "Hello Tyrion. I'm Jon" });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 20, 16, 58, 36, 912, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 4, 20, 16, 58, 36, 912, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 4, 20, 16, 58, 36, 912, DateTimeKind.Local).AddTicks(9171));
        }
    }
}
