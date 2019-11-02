using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddedSeedingData : Migration
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

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 2, 14, 24, 38, 390, DateTimeKind.Local).AddTicks(7631), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 11, 2, 12, 24, 38, 392, DateTimeKind.Local).AddTicks(7651), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 259, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 282, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 290, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 297, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 298, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(321), "Bulbasaur_shiny.png" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(506), "Ivysaur_shiny.png" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(660), "Venusaur_shiny.png" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Created", "ImgUrlAlolan", "ImgUrlShiny", "ImgUrlShiny_Alolan" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2380), "Rattata_alolan.png", "Rattata_shiny.png", "Rattata_shiny_alolan.png" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 265, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 315, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 303, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 324, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 324, DateTimeKind.Local).AddTicks(8993));

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
                value: new DateTime(2019, 11, 2, 14, 24, 39, 340, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 340, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 39, 340, DateTimeKind.Local).AddTicks(4931));
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

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 2, 14, 17, 44, 908, DateTimeKind.Local).AddTicks(3356), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 11, 2, 12, 17, 44, 911, DateTimeKind.Local).AddTicks(5015), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(9463), null });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(9761), null });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Created", "ImgUrlShiny" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 17, 46, 73, DateTimeKind.Local).AddTicks(9905), null });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Created", "ImgUrlAlolan", "ImgUrlShiny", "ImgUrlShiny_Alolan" },
                values: new object[] { new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1687), null, null, null });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 74, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 75, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(4376));

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
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 46, 76, DateTimeKind.Local).AddTicks(5398));
        }
    }
}
