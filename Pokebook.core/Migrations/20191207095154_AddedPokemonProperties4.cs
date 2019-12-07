using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddedPokemonProperties4 : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "IsLegendary",
                table: "Pokemons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMythical",
                table: "Pokemons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 12, 7, 10, 51, 53, 287, DateTimeKind.Local).AddTicks(331), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 12, 7, 8, 51, 53, 288, DateTimeKind.Local).AddTicks(7895), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 787, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 807, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 814, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 815, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 821, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "Created", "IsLegendary" },
                values: new object[] { new DateTime(2019, 12, 7, 10, 51, 53, 792, DateTimeKind.Local).AddTicks(4350), true });

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 836, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 839, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 826, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 844, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 844, DateTimeKind.Local).AddTicks(4200));

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
                value: new DateTime(2019, 12, 7, 10, 51, 53, 857, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 857, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 12, 7, 10, 51, 53, 857, DateTimeKind.Local).AddTicks(1514));
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
                name: "IsLegendary",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "IsMythical",
                table: "Pokemons");

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
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 484, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 486, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 485, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 487, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 488, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 488, DateTimeKind.Local).AddTicks(1879));

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
                value: new DateTime(2019, 11, 16, 8, 41, 29, 488, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 488, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 11, 16, 8, 41, 29, 488, DateTimeKind.Local).AddTicks(3898));
        }
    }
}
