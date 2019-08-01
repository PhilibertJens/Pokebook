using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddSeedingData3 : Migration
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
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 16, 37, 8, 306, DateTimeKind.Local).AddTicks(7228), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 14, 37, 8, 307, DateTimeKind.Local).AddTicks(7778), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "Id", "Created", "Description", "Generation", "Name", "PokemonCatchId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1429), "Lowers the target's Speed by two stages.", "1", "String Shot", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1475), "Deals damage and has a 10% chance of confusing the target.", "1", "Psybeam", null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 1, 16, 37, 8, 797, DateTimeKind.Local).AddTicks(1521), "Deals damage and has a 10% chance of freezing the target.", "1", "Ice Beam", null }
                });

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.InsertData(
                table: "PokemonEvolutions",
                columns: new[] { "BasePokemonId", "EvolutionId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3865), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(3959), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(4003), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(4047), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 8, 1, 16, 37, 8, 815, DateTimeKind.Local).AddTicks(4090), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 828, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3672), 850, 60, 0.7f, 6.9f, 10, 30, 0.2f, 2f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3767), 1200, 80, 1.5f, 9.9f, 300, 50, 0.5f, 5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3859), 2500, 120, 14f, 70f, 800, 70, 7.2f, 25f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(3956), 850, 60, 0.7f, 6.9f, 10, 30, 0.2f, 2f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4047), 1200, 80, 1.5f, 9.9f, 300, 50, 0.5f, 5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4145), 2500, 120, 14f, 70f, 800, 70, 7.2f, 25f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4236), 500, 50, 0.7f, 1.5f, 10, 20, 0.2f, 0.2f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4326), 400, 25, 1.5f, 1f, 10, 20, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4420), 1800, 100, 1.7f, 1f, 10, 40, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4509), 500, 50, 0.7f, 1.5f, 10, 20, 0.2f, 0.2f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4603), 400, 25, 1.5f, 1f, 10, 20, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4693), 1800, 100, 1.7f, 1f, 10, 40, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(5189), 1000, 60, 0.6f, 1.8f, 10, 10, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4783), 680, 60, 0.5f, 1f, 10, 10, 0.1f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(6221), 1500, 80, 0.9f, 3.5f, 50, 40, 0.4f, 1.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(5737), 1250, 70, 1.2f, 1.8f, 10, 20, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(6583), 1800, 100, 2.8f, 60f, 30, 50, 1.5f, 30f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(5938), 1500, 100, 1.5f, 2f, 10, 40, 0.5f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(5834), 2300, 120, 4.7f, 400f, 100, 50, 2.2f, 200f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(4878), 2000, 100, 1.7f, 1f, 30, 40, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(5293), 1650, 100, 1.8f, 3f, 10, 40, 0.2f, 0.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(6678), 950, 60, 1.5f, 25f, 30, 40, 0.6f, 7.5f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 16, 37, 8, 802, DateTimeKind.Local).AddTicks(6485), 3200, 150, 2f, 35f, 1000, 90, 1.6f, 17.5f });

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.InsertData(
                table: "TypeAdvantages",
                columns: new[] { "AdvantageTypeId", "DisadvantageTypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8265), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8309), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8353), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8397), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8441), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 8, 1, 16, 37, 8, 843, DateTimeKind.Local).AddTicks(8484), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 833, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 848, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 848, DateTimeKind.Local).AddTicks(4440));

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

            migrationBuilder.InsertData(
                table: "PokemonMoves",
                columns: new[] { "PokemonId", "MoveId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7602), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7644), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7686), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7729), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 1, 16, 37, 8, 822, DateTimeKind.Local).AddTicks(7771), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 861, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 861, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 16, 37, 8, 861, DateTimeKind.Local).AddTicks(6105));
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
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 11, 58, 34, 450, DateTimeKind.Local).AddTicks(7491), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 9, 58, 34, 451, DateTimeKind.Local).AddTicks(8130), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.InsertData(
                table: "PokemonEvolutions",
                columns: new[] { "BasePokemonId", "EvolutionId", "Created", "Id" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(4105), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 436, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(5922), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6023), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6124), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6221), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6321), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6418), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6513), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6612), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6708), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6802), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6903), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(6998), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7290), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7098), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7778), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7487), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7975), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7684), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7588), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7194), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7391), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(8074), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "Created", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight" },
                values: new object[] { new DateTime(2019, 8, 1, 11, 58, 35, 435, DateTimeKind.Local).AddTicks(7879), 0, 0, 0f, 0f, 0, 0, 0f, 0f });

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(5682));

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
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 8, 1, 11, 58, 35, 437, DateTimeKind.Local).AddTicks(6658));
        }
    }
}
