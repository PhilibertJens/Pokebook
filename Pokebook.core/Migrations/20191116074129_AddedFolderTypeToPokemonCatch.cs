using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddedFolderTypeToPokemonCatch : Migration
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
                name: "FolderType",
                table: "PokemonCatches",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 11, 16, 8, 41, 28, 347, DateTimeKind.Local).AddTicks(6959), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 11, 16, 6, 41, 28, 349, DateTimeKind.Local).AddTicks(3276), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 870, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 891, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 899, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 906, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 875, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 875, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 875, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 875, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 875, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 876, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 922, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 911, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 912, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 932, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 932, DateTimeKind.Local).AddTicks(2824));

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
                value: new DateTime(2019, 11, 16, 8, 41, 28, 945, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 945, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 28, 945, DateTimeKind.Local).AddTicks(6661));
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
                name: "FolderType",
                table: "PokemonCatches");

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
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 26, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 28, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 27, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 29, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 30, DateTimeKind.Local).AddTicks(6744));

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
                value: new DateTime(2019, 11, 2, 14, 24, 40, 32, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 32, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 2, 14, 24, 40, 32, DateTimeKind.Local).AddTicks(2569));
        }
    }
}
