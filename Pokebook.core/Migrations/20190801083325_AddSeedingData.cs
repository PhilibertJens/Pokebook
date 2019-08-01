using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 24, 724, DateTimeKind.Local).AddTicks(1748), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreateDate", "CreatorId", "Image", "LastMessage", "Name", "NumberOfMessages", "NumberOfUsers", "Theme" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 8, 33, 24, 725, DateTimeKind.Local).AddTicks(2048), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Another awesome Chat", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), true, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "Accepted", "IdApprover", "IdRequester", "UserId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), false, new Guid("63ed99a2-e0dc-46d5-4c0c-08d6bce3eda7"), new Guid("00000000-0000-0000-0000-000000000001"), null });

            migrationBuilder.InsertData(
                table: "Moves",
                columns: new[] { "Id", "Created", "Description", "Generation", "Name", "PokemonCatchId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 170, DateTimeKind.Local).AddTicks(5489), "Deals damage with no additional effect.", "1", "Hydro Pump", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 170, DateTimeKind.Local).AddTicks(5574), "Deals damage and has an increased critical hit ratio.", "1", "Razor Leaf", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 170, DateTimeKind.Local).AddTicks(5626), "Deals damage and has a 10% chance of burning the target.", "1", "Flamethrower", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 170, DateTimeKind.Local).AddTicks(5672), "Deals damage and has a 10% chance of paralyzing the target.", "1", "Flamethrower", null }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Created", "Description", "HasAllolanForm", "ImgUrl", "Location", "MaxCP", "MaxHP", "MaxHeight", "MaxWeight", "MinCP", "MinHP", "MinHeight", "MinWeight", "NDex", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7826), "Is a small, quadruped rodent Pokémon. Its most notable feature is its large teeth.", true, "Rattata.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)19, "Rattata" },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7916), "Is a humanoid Pokémon with an ovoid body. Hitmonlee's legs freely contract and stretch similar to a coiled spring.", false, "Hitmonlee.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)106, "Hitmonlee" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8009), "Has an extremely sharp sense of direction and homing instincts.", false, "Pidgey.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)16, "Pidgey" },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8192), "Is a tiny, brown Pokémon that seems to be perpetually buried within the earth, leaving only its head visible.", true, "Diglett.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)50, "Diglett" },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8281), "Resembles a giant chain of gray boulders that become smaller towards the tail.", false, "Onix.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)95, "Onix" },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8644), "Has a snowy white, furry body, which renders it virtually invisible in snowy conditions.", false, "Dewgong.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)87, "Dewgong" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8463), "Is covered in yellow fur with two horizontal brown stripes on its back.", true, "Pikachu.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)25, "Pikachu" },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8551), "Is a Pokémon created by science. It is a bipedal, humanoid creature with some feline features.", false, "Mewtwo.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)150, "Mewtwo" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7736), "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", false, "Beedrill.png", "Evolve Kakuna", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)15, "Beedrill" },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8733), "is filled with life energy. Dratini is constantly growing, and can thus reach lengths of over six feet.", false, "Dratini.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)147, "Dratini" },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8370), "Has no true form, due to 95% of its body being poisonous gas.", false, "Gastly.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)92, "Gastly" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7643), "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.", false, "Kakuna.png", "Routes 24 and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)14, "Kakuna" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(8099), "Creates gases within its body by mixing toxins with garbage, and produces more gas in higher temperatures.", false, "Koffing.png", "Somewhere", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)109, "Koffing" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7459), "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", false, "Butterfree.png", "Evolve Metapod", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)12, "Butterfree" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7554), "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", false, "Weedle.png", "Routes 2, 24, and 25, Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)13, "Weedle" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6358), "It bears the seed of a plant on its back from birth. The seed slowly develops. Researchers are unsure whether to classify Bulbasaur as a plant or animal. Bulbasaur are extremely calm and very difficult to capture in the wild. ", false, "Bulbasaur.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)1, "Bulbasaur" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6495), "When the bulb on its back grows large, it appears to lose the ability to stand on its hind leg", false, "Ivysaur.png", "Evolve Bulbasaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)2, "Ivysaur" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6693), "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", false, "Charmander.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)4, "Charmander" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6793), "When it swings its burning tail, it elevates the temperature to unbearably high levels.", false, "Charmeleon.png", "Evolve Charmander", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)5, "Charmeleon" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6883), "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", false, "Charizard.png", "Evolve Charmeleon", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)6, "Charizard" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6598), "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", false, "Venusaur.png", "Evolve Ivysaur", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)3, "Venusaur" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7069), "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance", false, "Wartortle.png", "Evolve Squirtle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)8, "Wartortle" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7158), "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.", false, "Blastoise.png", "evolve Wartortle", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)9, "Blastoise" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7252), "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", false, "Caterpie.png", "Routes 2, 24 and 25,Viridian Forest", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)10, "Caterpie" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(7341), "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body", false, "Metapod.png", "Routes 24 and 25, Viridian Forest or evolve Caterpie", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)11, "Metapod" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 175, DateTimeKind.Local).AddTicks(6974), "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", false, "Squirtle.png", "Starter", 0, 0, 0f, 0f, 0, 0, 0f, 0f, (short)7, "Squirtle" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Colour", "Created", "MoveId", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "#EE99AC", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5981), null, "Fairy" },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "#6890F0", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5666), null, "Water" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "#705848", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5937), null, "Dark" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "#7038F8", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5891), null, "Dragon" },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "#98D8D8", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5843), null, "Ice" },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "#F85888", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5798), null, "Psychic" },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "#F8D030", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5755), null, "Electric" },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "#78C850", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5710), null, "Grass" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "#F08030", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5622), null, "Fire" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "#A040A0", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5341), null, "Poison" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "#705898", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5527), null, "Ghost" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "#A8B820", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5481), null, "Bug" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "#B8A038", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5435), null, "Rock" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "#E0C068", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5389), null, "Ground" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "#A890F0", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5293), null, "Flying" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "#C03028", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5239), null, "Fighting" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "#A8A878", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5162), null, "Normal" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "#B8B8D0", new DateTime(2019, 8, 1, 10, 33, 25, 205, DateTimeKind.Local).AddTicks(5577), null, "Steel" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CoverPicture", "Created", "Email", "EmailConfirmed", "FavoritePokemon", "FavoritePokemonGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumberOfFriends", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, "Mt._Molteau.png", new DateTime(2019, 8, 1, 10, 33, 25, 220, DateTimeKind.Local).AddTicks(2662), null, false, "Pikachu", "Pokemon Red", "Tyrion", "Lannister", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Pikachu.png", null, false, "TyrionLannister" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, "mountain.jpg", new DateTime(2019, 8, 1, 10, 33, 25, 220, DateTimeKind.Local).AddTicks(2814), null, false, null, null, "Jon", "Snow", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k", null, false, "Magikarp.png", null, false, "JonSnow" }
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
                table: "PokemonEvolutions",
                columns: new[] { "BasePokemonId", "EvolutionId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4100), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4177), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4225), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4269), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4314), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2019, 8, 1, 10, 33, 25, 188, DateTimeKind.Local).AddTicks(4357), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "PokemonMoves",
                columns: new[] { "PokemonId", "MoveId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 195, DateTimeKind.Local).AddTicks(1863), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 195, DateTimeKind.Local).AddTicks(1956), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 195, DateTimeKind.Local).AddTicks(1787), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 195, DateTimeKind.Local).AddTicks(1912), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonId", "TypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9185), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9610), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8545), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8587), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8631), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8715), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8763), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9742), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9826), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8242), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8363), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8459), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9699), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-00000000000f"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9783), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000147"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9868), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8804), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9102), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8888), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8929), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9269), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9399), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9311), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8673), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8972), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9358), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9014), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8407), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8502), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8312), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9060), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9144), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9227), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9441), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9657), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9483), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9567), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(9526), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2019, 8, 1, 10, 33, 25, 200, DateTimeKind.Local).AddTicks(8846), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "TypeAdvantages",
                columns: new[] { "AdvantageTypeId", "DisadvantageTypeId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2019, 8, 1, 10, 33, 25, 215, DateTimeKind.Local).AddTicks(5477), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 215, DateTimeKind.Local).AddTicks(5527), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2019, 8, 1, 10, 33, 25, 215, DateTimeKind.Local).AddTicks(5583), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2019, 8, 1, 10, 33, 25, 215, DateTimeKind.Local).AddTicks(5401), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "UserChats",
                columns: new[] { "ChatId", "UserId", "Created", "Id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 232, DateTimeKind.Local).AddTicks(7777), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 8, 1, 10, 33, 25, 232, DateTimeKind.Local).AddTicks(7896), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2019, 8, 1, 10, 33, 25, 232, DateTimeKind.Local).AddTicks(7849), new Guid("00000000-0000-0000-0000-000000000000") }
                });
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
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "PokemonEvolutions",
                keyColumns: new[] { "BasePokemonId", "EvolutionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "PokemonMoves",
                keyColumns: new[] { "PokemonId", "MoveId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000004") });

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
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000c"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TypeAdvantages",
                keyColumns: new[] { "AdvantageTypeId", "DisadvantageTypeId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000000d"), new Guid("00000000-0000-0000-0000-00000000000b") });

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
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Moves",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

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
        }
    }
}
