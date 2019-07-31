using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class FixPokemonMoves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Pokemons_PokemonId",
                table: "Moves");

            migrationBuilder.DropIndex(
                name: "IX_Moves_PokemonId",
                table: "Moves");

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
                name: "PokemonId",
                table: "Moves");

            migrationBuilder.CreateTable(
                name: "PokemonMoves",
                columns: table => new
                {
                    PokemonId = table.Column<Guid>(nullable: false),
                    MoveId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoves", x => new { x.PokemonId, x.MoveId });
                    table.ForeignKey(
                        name: "FK_PokemonMoves_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonMoves_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 10, 47, 9, 675, DateTimeKind.Local).AddTicks(9090), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 8, 47, 9, 677, DateTimeKind.Local).AddTicks(597), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 199, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 180, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 207, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 214, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 214, DateTimeKind.Local).AddTicks(9305));

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
                value: new DateTime(2019, 7, 31, 10, 47, 10, 227, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 227, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 47, 10, 227, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_MoveId",
                table: "PokemonMoves",
                column: "MoveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonMoves");

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

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId",
                table: "Moves",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 10, 29, 55, 257, DateTimeKind.Local).AddTicks(7451), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 8, 29, 55, 258, DateTimeKind.Local).AddTicks(8543), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 216, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 209, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(7700));

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
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 31, 10, 29, 56, 217, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.CreateIndex(
                name: "IX_Moves_PokemonId",
                table: "Moves",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Pokemons_PokemonId",
                table: "Moves",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
