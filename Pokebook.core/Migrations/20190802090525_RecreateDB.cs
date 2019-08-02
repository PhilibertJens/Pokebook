using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class RecreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Theme = table.Column<string>(nullable: true),
                    CreatorId = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    NumberOfMessages = table.Column<int>(nullable: false),
                    NumberOfUsers = table.Column<int>(nullable: false),
                    LastMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    NDex = table.Column<short>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    HasAllolanForm = table.Column<bool>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    MinHP = table.Column<int>(nullable: false),
                    MaxHP = table.Column<int>(nullable: false),
                    MinCP = table.Column<int>(nullable: false),
                    MaxCP = table.Column<int>(nullable: false),
                    MinWeight = table.Column<float>(nullable: false),
                    MaxWeight = table.Column<float>(nullable: false),
                    MinHeight = table.Column<float>(nullable: false),
                    MaxHeight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTime>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    NumberOfFriends = table.Column<int>(nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    CoverPicture = table.Column<string>(nullable: true),
                    FavoritePokemon = table.Column<string>(nullable: true),
                    FavoritePokemonGame = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEvolutions",
                columns: table => new
                {
                    BasePokemonId = table.Column<Guid>(nullable: false),
                    EvolutionId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEvolutions", x => new { x.BasePokemonId, x.EvolutionId });
                    table.ForeignKey(
                        name: "FK_PokemonEvolutions_Pokemons_BasePokemonId",
                        column: x => x.BasePokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonEvolutions_Pokemons_EvolutionId",
                        column: x => x.EvolutionId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Generation = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    PokemonId = table.Column<Guid>(nullable: false),
                    TypeId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => new { x.PokemonId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeAdvantages",
                columns: table => new
                {
                    AdvantageTypeId = table.Column<Guid>(nullable: false),
                    DisadvantageTypeId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAdvantages", x => new { x.AdvantageTypeId, x.DisadvantageTypeId });
                    table.ForeignKey(
                        name: "FK_TypeAdvantages_Types_AdvantageTypeId",
                        column: x => x.AdvantageTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypeAdvantages_Types_DisadvantageTypeId",
                        column: x => x.DisadvantageTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    IdRequester = table.Column<Guid>(nullable: false),
                    IdApprover = table.Column<Guid>(nullable: false),
                    Accepted = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    ChatId = table.Column<Guid>(nullable: false),
                    SenderId = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    SendDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonCatches",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    PokemonId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    CP = table.Column<int>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonCatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonCatches_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonCatches_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonUsers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    PokemonId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    Catches = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonUsers", x => new { x.PokemonId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PokemonUsers_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserChats",
                columns: table => new
                {
                    ChatId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChats", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserChats_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "PokemonMoveCatches",
                columns: table => new
                {
                    PokemonId = table.Column<Guid>(nullable: false),
                    MoveId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMoveCatches", x => new { x.PokemonId, x.MoveId });
                    table.ForeignKey(
                        name: "FK_PokemonMoveCatches_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonMoveCatches_PokemonCatches_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "PokemonCatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 24, 574, DateTimeKind.Local).AddTicks(1085), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 9, 5, 24, 575, DateTimeKind.Local).AddTicks(2936), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                    { new Guid("00000000-0000-0000-0000-000000000147"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(3548), "is filled with life energy. Dratini is constantly growing, and can thus reach lengths of over six feet.", false, "Dratini.png", "Somewhere", 950, 60, 1.5f, 25f, 30, 40, 0.6f, 7.5f, (short)147, "Dratini" },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(3259), "Has a snowy white, furry body, which renders it virtually invisible in snowy conditions.", false, "Dewgong.png", "Somewhere", 1800, 100, 2.8f, 60f, 30, 50, 1.5f, 30f, (short)87, "Dewgong" },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(3164), "Is a Pokémon created by science. It is a bipedal, humanoid creature with some feline features.", false, "Mewtwo.png", "Somewhere", 3200, 150, 2f, 35f, 1000, 90, 1.6f, 17.5f, (short)150, "Mewtwo" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2899), "Is covered in yellow fur with two horizontal brown stripes on its back.", true, "Pikachu.png", "Somewhere", 1500, 80, 0.9f, 3.5f, 50, 40, 0.4f, 1.5f, (short)25, "Pikachu" },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2778), "Has no true form, due to 95% of its body being poisonous gas.", false, "Gastly.png", "Somewhere", 1500, 100, 1.5f, 2f, 10, 40, 0.5f, 0.5f, (short)92, "Gastly" },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2546), "Is a tiny, brown Pokémon that seems to be perpetually buried within the earth, leaving only its head visible.", true, "Diglett.png", "Somewhere", 1250, 70, 1.2f, 1.8f, 10, 20, 0.2f, 0.5f, (short)50, "Diglett" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2445), "Creates gases within its body by mixing toxins with garbage, and produces more gas in higher temperatures.", false, "Koffing.png", "Somewhere", 1650, 100, 1.8f, 3f, 10, 40, 0.2f, 0.5f, (short)109, "Koffing" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2146), "Has an extremely sharp sense of direction and homing instincts.", false, "Pidgey.png", "Somewhere", 1000, 60, 0.6f, 1.8f, 10, 10, 0.2f, 0.5f, (short)16, "Pidgey" },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1901), "Is a humanoid Pokémon with an ovoid body. Hitmonlee's legs freely contract and stretch similar to a coiled spring.", false, "Hitmonlee.png", "Somewhere", 2000, 100, 1.7f, 1f, 30, 40, 0.2f, 0.5f, (short)106, "Hitmonlee" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1801), "Is a small, quadruped rodent Pokémon. Its most notable feature is its large teeth.", true, "Rattata.png", "Somewhere", 680, 60, 0.5f, 1f, 10, 10, 0.1f, 0.5f, (short)19, "Rattata" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1532), "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", false, "Beedrill.png", "Evolve Kakuna", 1800, 100, 1.7f, 1f, 10, 40, 0.2f, 0.5f, (short)15, "Beedrill" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1244), "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.", false, "Kakuna.png", "Routes 24 and 25, Viridian Forest", 400, 25, 1.5f, 1f, 10, 20, 0.2f, 0.5f, (short)14, "Kakuna" },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(2653), "Resembles a giant chain of gray boulders that become smaller towards the tail.", false, "Onix.png", "Somewhere", 2300, 120, 4.7f, 400f, 100, 50, 2.2f, 200f, (short)95, "Onix" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1045), "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", false, "Butterfree.png", "Evolve Metapod", 1800, 100, 1.7f, 1f, 10, 40, 0.2f, 0.5f, (short)12, "Butterfree" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(1148), "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", false, "Weedle.png", "Routes 2, 24, and 25, Viridian Forest", 500, 50, 0.7f, 1.5f, 10, 20, 0.2f, 0.2f, (short)13, "Weedle" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 12, DateTimeKind.Local).AddTicks(8440), "It bears the seed of a plant on its back from birth. The seed slowly develops. Researchers are unsure whether to classify Bulbasaur as a plant or animal. Bulbasaur are extremely calm and very difficult to capture in the wild. ", false, "Bulbasaur.png", "Starter", 850, 60, 0.7f, 6.9f, 10, 30, 0.2f, 2f, (short)1, "Bulbasaur" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 12, DateTimeKind.Local).AddTicks(8859), "When the bulb on its back grows large, it appears to lose the ability to stand on its hind leg", false, "Ivysaur.png", "Evolve Bulbasaur", 1200, 80, 1.5f, 9.9f, 300, 50, 0.5f, 5f, (short)2, "Ivysaur" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 12, DateTimeKind.Local).AddTicks(9551), "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", false, "Charmander.png", "Starter", 850, 60, 0.7f, 6.9f, 10, 30, 0.2f, 2f, (short)4, "Charmander" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 12, DateTimeKind.Local).AddTicks(9847), "When it swings its burning tail, it elevates the temperature to unbearably high levels.", false, "Charmeleon.png", "Evolve Charmander", 1200, 80, 1.5f, 9.9f, 300, 50, 0.5f, 5f, (short)5, "Charmeleon" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 12, DateTimeKind.Local).AddTicks(9134), "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", false, "Venusaur.png", "Evolve Ivysaur", 2500, 120, 14f, 70f, 800, 70, 7.2f, 25f, (short)3, "Venusaur" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(189), "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", false, "Squirtle.png", "Starter", 850, 60, 0.7f, 6.9f, 10, 30, 0.2f, 2f, (short)7, "Squirtle" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(297), "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance", false, "Wartortle.png", "Evolve Squirtle", 1200, 80, 1.5f, 9.9f, 300, 50, 0.5f, 5f, (short)8, "Wartortle" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(397), "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.", false, "Blastoise.png", "evolve Wartortle", 2500, 120, 14f, 70f, 800, 70, 7.2f, 25f, (short)9, "Blastoise" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(494), "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", false, "Caterpie.png", "Routes 2, 24 and 25,Viridian Forest", 500, 50, 0.7f, 1.5f, 10, 20, 0.2f, 0.2f, (short)10, "Caterpie" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(947), "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body", false, "Metapod.png", "Routes 24 and 25, Viridian Forest or evolve Caterpie", 400, 25, 1.5f, 1f, 10, 20, 0.2f, 0.5f, (short)11, "Metapod" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 13, DateTimeKind.Local).AddTicks(88), "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", false, "Charizard.png", "Evolve Charmeleon", 2500, 120, 14f, 70f, 800, 70, 7.2f, 25f, (short)6, "Charizard" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Colour", "Created", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "#EE99AC", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9721), "Fairy" },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "#6890F0", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9397), "Water" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "#705848", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9675), "Dark" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "#7038F8", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9628), "Dragon" },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "#98D8D8", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9578), "Ice" },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "#F85888", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9533), "Psychic" },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "#F8D030", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9488), "Electric" },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "#78C850", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9442), "Grass" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "#F08030", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9351), "Fire" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "#A040A0", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9064), "Poison" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "#705898", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9252), "Ghost" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "#A8B820", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9205), "Bug" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "#B8A038", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9158), "Rock" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "#E0C068", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9112), "Ground" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "#A890F0", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9016), "Flying" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "#C03028", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(8962), "Fighting" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "#A8A878", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(8877), "Normal" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "#B8B8D0", new DateTime(2019, 8, 2, 11, 5, 25, 44, DateTimeKind.Local).AddTicks(9305), "Steel" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CoverPicture", "Created", "Email", "EmailConfirmed", "FavoritePokemon", "FavoritePokemonGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumberOfFriends", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, "Mt._Molteau.png", new DateTime(2019, 8, 2, 11, 5, 25, 58, DateTimeKind.Local).AddTicks(9616), null, false, "Pikachu", "Pokemon Red", "Tyrion", "Lannister", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Pikachu.png", null, false, "TyrionLannister" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, "mountain.jpg", new DateTime(2019, 8, 2, 11, 5, 25, 58, DateTimeKind.Local).AddTicks(9769), null, false, null, null, "Jon", "Snow", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Magikarp.png", null, false, "JonSnow" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002"), "Hello Tyrion. I'm Jon" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "Hello Jon. This is Tyrion" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "ImageName", "SendDate", "SenderId", "Text" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000001"), "This is a chat with myself. Is this even possible?" });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "Id", "Created", "Description", "Generation", "Name", "TypeId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2461), "Deals damage with no additional effect.", "1", "Hydro Pump", new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2895), "Lowers the target's Speed by two stages.", "1", "String Shot", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2555), "Deals damage and has an increased critical hit ratio.", "1", "Razor Leaf", new Guid("00000000-0000-0000-0000-00000000000c") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2843), "The user of Solar Beam will absorb light on the first turn. On the second turn, Solar Beam deals damage.", "1", "Solar Beam", new Guid("00000000-0000-0000-0000-00000000000c") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2673), "Deals damage and has a 10% chance of paralyzing the target.", "1", "Thunderbold", new Guid("00000000-0000-0000-0000-00000000000d") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2616), "Deals damage and has a 10% chance of burning the target.", "1", "Flamethrower", new Guid("00000000-0000-0000-0000-00000000000a") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(3008), "Deals damage and has a 10% chance of freezing the target.", "1", "Ice Beam", new Guid("00000000-0000-0000-0000-00000000000f") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2790), "The user of Fly will fly up high on the first turn, disappearing from view and becoming invulnerable to most attacks. On the second turn, Fly deals damage.", "1", "Fly", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2951), "Deals damage and has a 10% chance of confusing the target.", "1", "Psybeam", new Guid("00000000-0000-0000-0000-00000000000e") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 8, DateTimeKind.Local).AddTicks(2736), "Deals damage with no additional effect in battle.", "1", "Cut", new Guid("00000000-0000-0000-0000-000000000001") }
                });

            migrationBuilder.InsertData(
                table: "PokemonEvolutions",
                columns: new[] { "BasePokemonId", "EvolutionId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8666), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8277), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8332), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8378), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8473), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8426), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8189), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8567), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8621), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 8, 2, 11, 5, 25, 26, DateTimeKind.Local).AddTicks(8521), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7956), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7999), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8042), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9287), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8126), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8215), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9245), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9203), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7658), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7775), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7864), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9160), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8168), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9117), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9028), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8516), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7728), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8385), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8084), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7819), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(7907), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8602), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8470), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8559), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8644), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8770), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8859), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8728), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8817), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8902), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8986), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8943), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8258), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8300), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8686), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8342), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(8427), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 39, DateTimeKind.Local).AddTicks(9070), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "TypeAdvantages",
                columns: new[] { "AdvantageTypeId", "DisadvantageTypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4896), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(5210), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4575), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(5076), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4801), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4521), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4849), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(4430), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(5167), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 54, DateTimeKind.Local).AddTicks(5119), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 71, DateTimeKind.Local).AddTicks(3636), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 71, DateTimeKind.Local).AddTicks(3755), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 71, DateTimeKind.Local).AddTicks(3708), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "PokemonMoves",
                columns: new[] { "PokemonId", "MoveId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8953), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8734), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8867), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8824), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8780), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8635), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9128), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9086), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8558), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9044), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9001), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8689), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9255), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9213), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9170), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(8910), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9304), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 2, 11, 5, 25, 33, DateTimeKind.Local).AddTicks(9347), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserId",
                table: "Friendships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_TypeId",
                table: "Moves",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCatches_PokemonId",
                table: "PokemonCatches",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCatches_UserId",
                table: "PokemonCatches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEvolutions_EvolutionId",
                table: "PokemonEvolutions",
                column: "EvolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoveCatches_MoveId",
                table: "PokemonMoveCatches",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMoves_MoveId",
                table: "PokemonMoves",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_TypeId",
                table: "PokemonTypes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonUsers_UserId",
                table: "PokemonUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeAdvantages_DisadvantageTypeId",
                table: "TypeAdvantages",
                column: "DisadvantageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChats_UserId",
                table: "UserChats",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PokemonEvolutions");

            migrationBuilder.DropTable(
                name: "PokemonMoveCatches");

            migrationBuilder.DropTable(
                name: "PokemonMoves");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "PokemonUsers");

            migrationBuilder.DropTable(
                name: "TypeAdvantages");

            migrationBuilder.DropTable(
                name: "UserChats");

            migrationBuilder.DropTable(
                name: "PokemonCatches");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
