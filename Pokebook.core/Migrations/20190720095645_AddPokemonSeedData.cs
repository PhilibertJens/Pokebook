using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddPokemonSeedData : Migration
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
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 20, 11, 56, 44, 645, DateTimeKind.Local).AddTicks(7519), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 20, 9, 56, 44, 647, DateTimeKind.Local).AddTicks(1897), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                columns: new[] { "Id", "Created", "Description", "HasAllolanForm", "ImgUrl", "Location", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight", "NDex", "Name", "PokemonId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000147"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8602), "is filled with life energy. Dratini is constantly growing, and can thus reach lengths of over six feet.", false, "Dratini.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)147, "Dratini", null },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8472), "Has a snowy white, furry body, which renders it virtually invisible in snowy conditions.", false, "Dewgong.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)87, "Dewgong", null },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8380), "Is a Pokémon created by science. It is a bipedal, humanoid creature with some feline features.", false, "Mewtwo.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)150, "Mewtwo", null },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8290), "Is covered in yellow fur with two horizontal brown stripes on its back.", true, "Pikachu.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)25, "Pikachu", null },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8128), "Has no true form, due to 95% of its body being poisonous gas.", false, "Gastly.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)92, "Gastly", null },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7954), "Is a tiny, brown Pokémon that seems to be perpetually buried within the earth, leaving only its head visible.", true, "Diglett.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)50, "Diglett", null },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7862), "Creates gases within its body by mixing toxins with garbage, and produces more gas in higher temperatures.", false, "Koffing.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)109, "Koffing", null },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7776), "Has an extremely sharp sense of direction and homing instincts.", false, "Pidgey.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)16, "Pidgey", null },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7684), "Is a humanoid Pokémon with an ovoid body. Hitmonlee's legs freely contract and stretch similar to a coiled spring.", false, "Hitmonlee.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)106, "Hitmonlee", null },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7597), "Is a small, quadruped rodent Pokémon. Its most notable feature is its large teeth.", true, "Rattata.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)19, "Rattata", null },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7510), "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", false, "Beedrill.png", "Evolve Kakuna", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)15, "Beedrill", null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7419), "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.", false, "Kakuna.png", "Routes 24 and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)14, "Kakuna", null },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(8041), "Resembles a giant chain of gray boulders that become smaller towards the tail.", false, "Onix.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)95, "Onix", null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7242), "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", false, "Butterfree.png", "Evolve Metapod", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)12, "Butterfree", null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7332), "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", false, "Weedle.png", "Routes 2, 24, and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)13, "Weedle", null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6189), "It bears the seed of a plant on its back from birth. The seed slowly develops. Researchers are unsure whether to classify Bulbasaur as a plant or animal. Bulbasaur are extremely calm and very difficult to capture in the wild. ", false, "Bulbasaur.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)1, "Bulbasaur", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6332), "When the bulb on its back grows large, it appears to lose the ability to stand on its hind leg", false, "Ivysaur.png", "Evolve Bulbasaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)2, "Ivysaur", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6521), "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", false, "Charmander.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)4, "Charmander", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6617), "When it swings its burning tail, it elevates the temperature to unbearably high levels.", false, "Charmeleon.png", "Evolve Charmander", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)5, "Charmeleon", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6430), "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", false, "Venusaur.png", "Evolve Ivysaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)3, "Venusaur", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6798), "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", false, "Squirtle.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)7, "Squirtle", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6887), "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance", false, "Wartortle.png", "Evolve Squirtle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)8, "Wartortle", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6975), "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.", false, "Blastoise.png", "evolve Wartortle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)9, "Blastoise", null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7069), "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", false, "Caterpie.png", "Routes 2, 24 and 25,Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)10, "Caterpie", null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(7156), "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body", false, "Metapod.png", "Routes 24 and 25, Viridian Forest or evolve Caterpie", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)11, "Metapod", null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 7, 20, 11, 56, 45, 138, DateTimeKind.Local).AddTicks(6706), "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", false, "Charizard.png", "Evolve Charmeleon", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)6, "Charizard", null }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Colour", "Created", "MoveId", "Name", "TypeId", "TypeId1" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "#EE99AC", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1700), null, "Fairy", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "#6890F0", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1389), null, "Water", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "#705848", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1656), null, "Dark", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "#7038F8", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1612), null, "Dragon", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "#98D8D8", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1568), null, "Ice", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "#F85888", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1524), null, "Psychic", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "#F8D030", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1480), null, "Electric", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "#78C850", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1433), null, "Grass", null, null },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "#F08030", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1345), null, "Fire", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "#A040A0", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1024), null, "Poison", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "#705898", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1254), null, "Ghost", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "#A8B820", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1210), null, "Bug", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "#B8A038", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1162), null, "Rock", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "#E0C068", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1070), null, "Ground", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "#A890F0", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(978), null, "Flying", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "#C03028", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(926), null, "Fighting", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "#A8A878", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(841), null, "Normal", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "#B8B8D0", new DateTime(2019, 7, 20, 11, 56, 45, 168, DateTimeKind.Local).AddTicks(1300), null, "Steel", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 56, 45, 179, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 56, 45, 179, DateTimeKind.Local).AddTicks(636));

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
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7560), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7649), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7733), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7815), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8273), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7177), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7219), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7262), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7394), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7518), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7435), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8482), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(6695), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(6999), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7092), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8358), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8399), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7352), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7476), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8231), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8441), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7903), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8027), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7944), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7309), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7607), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8185), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(6911), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7986), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7134), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7691), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7774), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7857), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8101), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8316), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8144), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(7047), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 7, 20, 11, 56, 45, 159, DateTimeKind.Local).AddTicks(8529), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 56, 45, 192, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 56, 45, 192, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 56, 45, 192, DateTimeKind.Local).AddTicks(3625));
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
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

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
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 20, 11, 51, 11, 236, DateTimeKind.Local).AddTicks(7783), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 7, 20, 9, 51, 11, 238, DateTimeKind.Local).AddTicks(2914), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

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
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 51, 12, 194, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 51, 12, 194, DateTimeKind.Local).AddTicks(9470));

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
                value: new DateTime(2019, 7, 20, 11, 51, 12, 195, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001") },
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 51, 12, 195, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "UserChats",
                keyColumns: new[] { "ChatId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002") },
                column: "Created",
                value: new DateTime(2019, 7, 20, 11, 51, 12, 195, DateTimeKind.Local).AddTicks(500));
        }
    }
}
