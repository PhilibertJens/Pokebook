using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddedPokemonProperties3 : Migration
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

            migrationBuilder.RenameColumn(
                name: "ImgUrlAllolan",
                table: "Pokemons",
                newName: "ImgUrlAlolan");

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
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 410, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 411, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 411, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 429, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 436, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 448, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 415, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 477, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 458, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 494, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 494, DateTimeKind.Local).AddTicks(4133));

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
                value: new DateTime(2019, 11, 2, 14, 17, 45, 521, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 521, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 17, 45, 521, DateTimeKind.Local).AddTicks(567));
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

            migrationBuilder.RenameColumn(
                name: "ImgUrlAlolan",
                table: "Pokemons",
                newName: "ImgUrlAllolan");

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 2, 14, 13, 44, 248, DateTimeKind.Local).AddTicks(2532), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 11, 2, 12, 13, 44, 249, DateTimeKind.Local).AddTicks(8381), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                value: new DateTime(2019, 11, 2, 14, 13, 45, 439, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 442, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 443, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 444, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 440, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 441, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 445, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 446, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 446, DateTimeKind.Local).AddTicks(4252));

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
                value: new DateTime(2019, 11, 2, 14, 13, 45, 446, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 446, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 13, 45, 446, DateTimeKind.Local).AddTicks(6638));
        }
    }
}
