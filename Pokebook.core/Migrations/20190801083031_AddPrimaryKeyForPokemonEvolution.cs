using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddPrimaryKeyForPokemonEvolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonEvolutions",
                table: "PokemonEvolutions");

            migrationBuilder.DropIndex(
                name: "IX_PokemonEvolutions_BasePokemonId",
                table: "PokemonEvolutions");

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
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010") });

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumns: new[] { "PokemonId", "TypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e") });

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"));

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonEvolutions",
                table: "PokemonEvolutions",
                columns: new[] { "BasePokemonId", "EvolutionId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonEvolutions",
                table: "PokemonEvolutions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonEvolutions",
                table: "PokemonEvolutions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 27, 964, DateTimeKind.Local).AddTicks(8465), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 9, 17, 27, 965, DateTimeKind.Local).AddTicks(8571), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Created", "Description", "HasAllolanForm", "ImgUrl", "Location", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight", "NDex", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000147"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(851), "is filled with life energy. Dratini is constantly growing, and can thus reach lengths of over six feet.", false, "Dratini.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)147, "Dratini" },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(754), "Has a snowy white, furry body, which renders it virtually invisible in snowy conditions.", false, "Dewgong.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)87, "Dewgong" },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(653), "Is a Pokémon created by science. It is a bipedal, humanoid creature with some feline features.", false, "Mewtwo.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)150, "Mewtwo" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(557), "Is covered in yellow fur with two horizontal brown stripes on its back.", true, "Pikachu.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)25, "Pikachu" },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(456), "Has no true form, due to 95% of its body being poisonous gas.", false, "Gastly.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)92, "Gastly" },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(263), "Is a tiny, brown Pokémon that seems to be perpetually buried within the earth, leaving only its head visible.", true, "Diglett.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)50, "Diglett" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(162), "Creates gases within its body by mixing toxins with garbage, and produces more gas in higher temperatures.", false, "Koffing.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)109, "Koffing" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(65), "Has an extremely sharp sense of direction and homing instincts.", false, "Pidgey.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)16, "Pidgey" },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9963), "Is a humanoid Pokémon with an ovoid body. Hitmonlee's legs freely contract and stretch similar to a coiled spring.", false, "Hitmonlee.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)106, "Hitmonlee" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9866), "Is a small, quadruped rodent Pokémon. Its most notable feature is its large teeth.", true, "Rattata.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)19, "Rattata" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9770), "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", false, "Beedrill.png", "Evolve Kakuna", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)15, "Beedrill" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9669), "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.", false, "Kakuna.png", "Routes 24 and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)14, "Kakuna" },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(360), "Resembles a giant chain of gray boulders that become smaller towards the tail.", false, "Onix.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)95, "Onix" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9471), "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", false, "Butterfree.png", "Evolve Metapod", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)12, "Butterfree" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9572), "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", false, "Weedle.png", "Routes 2, 24, and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)13, "Weedle" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8346), "It bears the seed of a plant on its back from birth. The seed slowly develops. Researchers are unsure whether to classify Bulbasaur as a plant or animal. Bulbasaur are extremely calm and very difficult to capture in the wild. ", false, "Bulbasaur.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)1, "Bulbasaur" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8474), "When the bulb on its back grows large, it appears to lose the ability to stand on its hind leg", false, "Ivysaur.png", "Evolve Bulbasaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)2, "Ivysaur" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8679), "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", false, "Charmander.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)4, "Charmander" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8784), "When it swings its burning tail, it elevates the temperature to unbearably high levels.", false, "Charmeleon.png", "Evolve Charmander", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)5, "Charmeleon" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8580), "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", false, "Venusaur.png", "Evolve Ivysaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)3, "Venusaur" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8983), "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", false, "Squirtle.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)7, "Squirtle" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9081), "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance", false, "Wartortle.png", "Evolve Squirtle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)8, "Wartortle" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9180), "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.", false, "Blastoise.png", "evolve Wartortle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)9, "Blastoise" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9280), "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", false, "Caterpie.png", "Routes 2, 24 and 25,Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)10, "Caterpie" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(9376), "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body", false, "Metapod.png", "Routes 24 and 25, Viridian Forest or evolve Caterpie", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)11, "Metapod" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 7, 31, 11, 17, 28, 931, DateTimeKind.Local).AddTicks(8882), "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", false, "Charizard.png", "Evolve Charmeleon", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)6, "Charizard" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Colour", "Created", "MoveId", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "#EE99AC", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2709), null, "Fairy" },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "#6890F0", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2367), null, "Water" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "#705848", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2660), null, "Dark" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "#7038F8", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2607), null, "Dragon" },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "#98D8D8", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2559), null, "Ice" },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "#F85888", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2511), null, "Psychic" },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "#F8D030", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2464), null, "Electric" },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "#78C850", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2416), null, "Grass" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "#F08030", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2318), null, "Fire" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "#A040A0", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2023), null, "Poison" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "#705898", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2219), null, "Ghost" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "#A8B820", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2171), null, "Bug" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "#B8A038", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2122), null, "Rock" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "#E0C068", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2073), null, "Ground" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "#A890F0", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(1972), null, "Flying" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "#C03028", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(1915), null, "Fighting" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "#A8A878", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(1853), null, "Normal" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "#B8B8D0", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(2267), null, "Steel" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CoverPicture", "Created", "Email", "EmailConfirmed", "FavoritePokemon", "FavoritePokemonGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumberOfFriends", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, "Mt._Molteau.png", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(5562), null, false, "Pikachu", "Pokemon Red", "Tyrion", "Lannister", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Pikachu.png", null, false, "TyrionLannister" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, "mountain.jpg", new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(5707), null, false, null, null, "Jon", "Snow", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Magikarp.png", null, false, "JonSnow" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002"), "Hello Tyrion. I'm Jon" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "This is a chat with myself. Is this even possible?" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "Hello Jon. This is Tyrion" });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8685), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7550), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7600), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7646), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7736), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7781), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7825), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7264), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8235), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7369), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7460), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8774), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8823), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8867), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8957), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8912), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8325), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8143), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7965), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8458), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8368), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7691), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8010), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8412), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7322), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7415), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8054), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8099), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7505), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8280), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8506), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8730), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8551), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8640), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8596), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7874), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(7920), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 31, 11, 17, 28, 932, DateTimeKind.Local).AddTicks(8191), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(6622), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(6723), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 31, 11, 17, 28, 933, DateTimeKind.Local).AddTicks(6676), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEvolutions_BasePokemonId",
                table: "PokemonEvolutions",
                column: "BasePokemonId");
        }
    }
}
