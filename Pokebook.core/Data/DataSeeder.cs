using Microsoft.EntityFrameworkCore;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Pokebook.core.Models.Type;

namespace Pokebook.core.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    UserName = "TyrionLannister",
                    FirstName = "Tyrion",
                    LastName = "Lannister",
                    ProfilePicture = "Pikachu.png",
                    CoverPicture = "Mt._Molteau.png",
                    FavoritePokemon = "Pikachu",
                    FavoritePokemonGame = "Pokemon Red",
                    PasswordHash = "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k"//test1234
                },
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserName = "JonSnow",
                    FirstName = "Jon",
                    LastName = "Snow",
                    ProfilePicture = "Magikarp.png",
                    CoverPicture = "mountain.jpg",
                    PasswordHash = "PW7h5Yl70M3o3LA9YQ5wUG+ycD7H01aXrDizkpC4lBX7hP/k"//test1234
                }
            );

            modelBuilder.Entity<Chat>().HasData(
                 new Chat
                 {
                     Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                     Name = "Awesome Chat",
                     CreateDate = DateTime.Now
                 },
                 new Chat
                 {
                     Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                     Name = "Another awesome Chat",
                     CreateDate = DateTime.Now.AddHours(-2)
                 }
             );

            modelBuilder.Entity<UserChat>().HasData(
                new UserChat
                {
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserChat
                {
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new UserChat
                {
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    SenderId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Text = "Hello Jon. This is Tyrion"
                },
                new Message
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    SenderId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Text = "Hello Tyrion. I'm Jon"
                },
                new Message
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    ChatId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    SenderId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Text = "This is a chat with myself. Is this even possible?"
                }
            );

            modelBuilder.Entity<Friendship>().HasData(
                new Friendship
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IdRequester = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IdApprover = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Accepted = true
                },
                new Friendship
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    IdRequester = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    IdApprover = Guid.Parse("63ED99A2-E0DC-46D5-4C0C-08D6BCE3EDA7"),
                    Accepted = false
                }
            );

            modelBuilder.Entity<Type>().HasData(
                //Guid: Id = Guid.Parse("11111111-1111-1111-1111-111111111111") --> 128 bits getal (32 hexa's, 1 hexa = 4bits)
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000001"), Name = "Normal", Colour = "#A8A878" },//mag niet volledig 0 zijn
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000002"), Name = "Fighting", Colour = "#C03028" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000003"), Name = "Flying", Colour = "#A890F0" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000004"), Name = "Poison", Colour = "#A040A0" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000005"), Name = "Ground", Colour = "#E0C068" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000006"), Name = "Rock", Colour = "#B8A038" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000007"), Name = "Bug", Colour = "#A8B820" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000008"), Name = "Ghost", Colour = "#705898" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000009"), Name = "Steel", Colour = "#B8B8D0" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000A"), Name = "Fire", Colour = "#F08030" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000B"), Name = "Water", Colour = "#6890F0" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000C"), Name = "Grass", Colour = "#78C850" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000D"), Name = "Electric", Colour = "#F8D030" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000E"), Name = "Psychic", Colour = "#F85888" },
                new Type { Id = new Guid("00000000-0000-0000-0000-00000000000F"), Name = "Ice", Colour = "#98D8D8" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000010"), Name = "Dragon", Colour = "#7038F8" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000011"), Name = "Dark", Colour = "#705848" },
                new Type { Id = new Guid("00000000-0000-0000-0000-000000000012"), Name = "Fairy", Colour = "#EE99AC" }
                );

            modelBuilder.Entity<TypeAdvantage>().HasData(
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B"),//water
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A")//fire
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A"),//fire
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C")//grass
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C"),//grass
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")//water
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000D"),//electric
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")//grass
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B"),//water
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-000000000006")//rock
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000F"),//ice
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C")//grass
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-000000000006"),//rock
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000D")//electric
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000E"),//Psychic
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-000000000002")//Fighting
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-000000000003"),//flying
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A")//fire
                },
                new TypeAdvantage
                {
                    AdvantageTypeId = Guid.Parse("00000000-0000-0000-0000-000000000007"),//bug
                    DisadvantageTypeId = Guid.Parse("00000000-0000-0000-0000-00000000000E")//Psychic
                }
            );

            modelBuilder.Entity<PokemonType>().HasData(
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000001"),//bulbasaur
                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000002"),//ivysaur
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000003"),//venusaur
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000C")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000004"),//charmander
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000005"),//charmeleon
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000006"),//charizard
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000A")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000003")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000007"),//squirtle
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000008"),//wartortle
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000009"),//blastoise
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000010"),//caterpie
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000011"),//metapod
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000012"),//butterfree
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000003")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000013"),//weedle
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000014"),//kakuna
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000015"),//beedrill
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000007")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000019"),//rattata
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000001")//normal
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000106"),//hitmonlee
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000002")//fighting
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000016"),//pidgey
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000003")//flying
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000001")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000109"),//koffing
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")//poison
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000050"),//diglett
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000005")//ground
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000095"),//onix
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000006")//rock
                            },
             new PokemonType
             {
                 PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000095"),
                 TypeId = Guid.Parse("00000000-0000-0000-0000-000000000005")
             },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000092"),//gastly
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000008")//ghost
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000092"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000004")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000025"),//pikachu
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000D")//electric
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000150"),//mewtwo
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000E")//psychic
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000087"),//dewgong
                                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000F")//ice
                            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000087"),
                TypeId = Guid.Parse("00000000-0000-0000-0000-00000000000B")
            },
            new PokemonType
            {
                PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000147"),//dratini
                                TypeId = Guid.Parse("00000000-0000-0000-0000-000000000010")//dragon
                            }
            );

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Name = "Bulbasaur",
                    HasAllolanForm = false,
                    ImgUrl = "Bulbasaur.png",
                    Location = "Starter",
                    Description = "It bears the seed of a plant on its back from birth. The seed slowly develops. Researchers are unsure whether to classify Bulbasaur as a plant or animal. Bulbasaur are extremely calm and very difficult to capture in the wild. ",
                    NDex = 1,
                    MinHP = 30,
                    MaxHP = 60,
                    MinCP = 10,
                    MaxCP = 850,
                    MinHeight = 0.20f,
                    MaxHeight = 0.70f,
                    MinWeight = 2.00f,
                    MaxWeight = 6.90f
                },
                new Pokemon
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    Name = "Ivysaur",
                    HasAllolanForm = false,
                    ImgUrl = "Ivysaur.png",
                    Location = "Evolve Bulbasaur",
                    Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind leg",
                    NDex = 2,
                    MinHP = 50,
                    MaxHP = 80,
                    MinCP = 300,
                    MaxCP = 1200,
                    MinHeight = 0.50f,
                    MaxHeight = 1.50f,
                    MinWeight = 5.00f,
                    MaxWeight = 9.90f
                },
                 new Pokemon
                 {
                     Id = new Guid("00000000-0000-0000-0000-000000000003"),
                     Name = "Venusaur",
                     HasAllolanForm = false,
                     ImgUrl = "Venusaur.png",
                     Location = "Evolve Ivysaur",
                     Description = "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
                     NDex = 3,
                     MinHP = 70,
                     MaxHP = 120,
                     MinCP = 800,
                     MaxCP = 2500,
                     MinHeight = 7.20f,
                     MaxHeight = 14.00f,
                     MinWeight = 25.00f,
                     MaxWeight = 70.00f
                 },
                 new Pokemon
                 {
                     Id = new Guid("00000000-0000-0000-0000-000000000004"),
                     Name = "Charmander",
                     HasAllolanForm = false,
                     ImgUrl = "Charmander.png",
                     Location = "Starter",
                     Description = "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.",
                     NDex = 4,
                     MinHP = 30,
                     MaxHP = 60,
                     MinCP = 10,
                     MaxCP = 850,
                     MinHeight = 0.20f,
                     MaxHeight = 0.70f,
                     MinWeight = 2.00f,
                     MaxWeight = 6.90f
                 },
                 new Pokemon
                 {
                     Id = new Guid("00000000-0000-0000-0000-000000000005"),
                     Name = "Charmeleon",
                     HasAllolanForm = false,
                     ImgUrl = "Charmeleon.png",
                     Location = "Evolve Charmander",
                     Description = "When it swings its burning tail, it elevates the temperature to unbearably high levels.",
                     NDex = 5,
                     MinHP = 50,
                     MaxHP = 80,
                     MinCP = 300,
                     MaxCP = 1200,
                     MinHeight = 0.50f,
                     MaxHeight = 1.50f,
                     MinWeight = 5.00f,
                     MaxWeight = 9.90f
                 },
                 new Pokemon
                 {
                     Id = new Guid("00000000-0000-0000-0000-000000000006"),
                     Name = "Charizard",
                     HasAllolanForm = false,
                     ImgUrl = "Charizard.png",
                     Location = "Evolve Charmeleon",
                     Description = "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.",
                     NDex = 6,
                     MinHP = 70,
                     MaxHP = 120,
                     MinCP = 800,
                     MaxCP = 2500,
                     MinHeight = 7.20f,
                     MaxHeight = 14.00f,
                     MinWeight = 25.00f,
                     MaxWeight = 70.00f
                 },
                 new Pokemon
                 {
                     Id = new Guid("00000000-0000-0000-0000-000000000007"),
                     Name = "Squirtle",
                     HasAllolanForm = false,
                     ImgUrl = "Squirtle.png",
                     Location = "Starter",
                     Description = "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.",
                     NDex = 7,
                     MinHP = 30,
                     MaxHP = 60,
                     MinCP = 10,
                     MaxCP = 850,
                     MinHeight = 0.20f,
                     MaxHeight = 0.70f,
                     MinWeight = 2.00f,
                     MaxWeight = 6.90f
                 },
                  new Pokemon
                  {
                      Id = new Guid("00000000-0000-0000-0000-000000000008"),
                      Name = "Wartortle",
                      HasAllolanForm = false,
                      ImgUrl = "Wartortle.png",
                      Location = "Evolve Squirtle",
                      Description = "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance",
                      NDex = 8,
                      MinHP = 50,
                      MaxHP = 80,
                      MinCP = 300,
                      MaxCP = 1200,
                      MinHeight = 0.50f,
                      MaxHeight = 1.50f,
                      MinWeight = 5.00f,
                      MaxWeight = 9.90f
                  },
                   new Pokemon
                   {
                       Id = new Guid("00000000-0000-0000-0000-000000000009"),
                       Name = "Blastoise",
                       HasAllolanForm = false,
                       ImgUrl = "Blastoise.png",
                       Location = "evolve Wartortle",
                       Description = "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.",
                       NDex = 9,
                       MinHP = 70,
                       MaxHP = 120,
                       MinCP = 800,
                       MaxCP = 2500,
                       MinHeight = 7.20f,
                       MaxHeight = 14.00f,
                       MinWeight = 25.00f,
                       MaxWeight = 70.00f
                   },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000010"),
                        Name = "Caterpie",
                        HasAllolanForm = false,
                        ImgUrl = "Caterpie.png",
                        Location = "Routes 2, 24 and 25,Viridian Forest",
                        Description = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.",
                        NDex = 10,
                        MinHP = 20,
                        MaxHP = 50,
                        MinCP = 10,
                        MaxCP = 500,
                        MinHeight = 0.20f,
                        MaxHeight = 0.70f,
                        MinWeight = 0.20f,
                        MaxWeight = 1.50f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000011"),
                        Name = "Metapod",
                        HasAllolanForm = false,
                        ImgUrl = "Metapod.png",
                        Location = "Routes 24 and 25, Viridian Forest or evolve Caterpie",
                        Description = "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body",
                        NDex = 11,
                        MinHP = 20,
                        MaxHP = 25,
                        MinCP = 10,
                        MaxCP = 400,
                        MinHeight = 0.20f,
                        MaxHeight = 1.50f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000012"),
                        Name = "Butterfree",
                        HasAllolanForm = false,
                        ImgUrl = "Butterfree.png",
                        Location = "Evolve Metapod",
                        Description = "In battle, it flaps its wings at high speed to release highly toxic dust into the air.",
                        NDex = 12,
                        MinHP = 40,
                        MaxHP = 100,
                        MinCP = 10,
                        MaxCP = 1800,
                        MinHeight = 0.20f,
                        MaxHeight = 1.70f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000013"),
                        Name = "Weedle",
                        HasAllolanForm = false,
                        ImgUrl = "Weedle.png",
                        Location = "Routes 2, 24, and 25, Viridian Forest",
                        Description = "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.",
                        NDex = 13,
                        MinHP = 20,
                        MaxHP = 50,
                        MinCP = 10,
                        MaxCP = 500,
                        MinHeight = 0.20f,
                        MaxHeight = 0.70f,
                        MinWeight = 0.20f,
                        MaxWeight = 1.50f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000014"),
                        Name = "Kakuna",
                        HasAllolanForm = false,
                        ImgUrl = "Kakuna.png",
                        Location = "Routes 24 and 25, Viridian Forest",
                        Description = "Almost incapable of moving, this Pokémon can only harden its shell to protect itself from predators.",
                        NDex = 14,
                        MinHP = 20,
                        MaxHP = 25,
                        MinCP = 10,
                        MaxCP = 400,
                        MinHeight = 0.20f,
                        MaxHeight = 1.50f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000015"),
                        Name = "Beedrill",
                        HasAllolanForm = false,
                        ImgUrl = "Beedrill.png",
                        Location = "Evolve Kakuna",
                        Description = "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.",
                        NDex = 15,
                        MinHP = 40,
                        MaxHP = 100,
                        MinCP = 10,
                        MaxCP = 1800,
                        MinHeight = 0.20f,
                        MaxHeight = 1.70f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000019"),
                        Name = "Rattata",
                        HasAllolanForm = true,
                        ImgUrl = "Rattata.png",
                        Location = "Somewhere",
                        Description = "Is a small, quadruped rodent Pokémon. Its most notable feature is its large teeth.",
                        NDex = 19,
                        MinHP = 10,
                        MaxHP = 60,
                        MinCP = 10,
                        MaxCP = 680,
                        MinHeight = 0.10f,
                        MaxHeight = 0.50f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000106"),
                        Name = "Hitmonlee",
                        HasAllolanForm = false,
                        ImgUrl = "Hitmonlee.png",
                        Location = "Somewhere",
                        Description = "Is a humanoid Pokémon with an ovoid body. Hitmonlee's legs freely contract and stretch similar to a coiled spring.",
                        NDex = 106,
                        MinHP = 40,
                        MaxHP = 100,
                        MinCP = 30,
                        MaxCP = 2000,
                        MinHeight = 0.20f,
                        MaxHeight = 1.70f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000016"),
                        Name = "Pidgey",
                        HasAllolanForm = false,
                        ImgUrl = "Pidgey.png",
                        Location = "Somewhere",
                        Description = "Has an extremely sharp sense of direction and homing instincts.",
                        NDex = 16,
                        MinHP = 10,
                        MaxHP = 60,
                        MinCP = 10,
                        MaxCP = 1000,
                        MinHeight = 0.20f,
                        MaxHeight = 0.60f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.80f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000109"),
                        Name = "Koffing",
                        HasAllolanForm = false,
                        ImgUrl = "Koffing.png",
                        Location = "Somewhere",
                        Description = "Creates gases within its body by mixing toxins with garbage, and produces more gas in higher temperatures.",
                        NDex = 109,
                        MinHP = 40,
                        MaxHP = 100,
                        MinCP = 10,
                        MaxCP = 1650,
                        MinHeight = 0.20f,
                        MaxHeight = 1.80f,
                        MinWeight = 0.50f,
                        MaxWeight = 3.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000050"),
                        Name = "Diglett",
                        HasAllolanForm = true,
                        ImgUrl = "Diglett.png",
                        Location = "Somewhere",
                        Description = "Is a tiny, brown Pokémon that seems to be perpetually buried within the earth, leaving only its head visible.",
                        NDex = 50,
                        MinHP = 20,
                        MaxHP = 70,
                        MinCP = 10,
                        MaxCP = 1250,
                        MinHeight = 0.20f,
                        MaxHeight = 1.20f,
                        MinWeight = 0.50f,
                        MaxWeight = 1.80f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000095"),
                        Name = "Onix",
                        HasAllolanForm = false,
                        ImgUrl = "Onix.png",
                        Location = "Somewhere",
                        Description = "Resembles a giant chain of gray boulders that become smaller towards the tail.",
                        NDex = 95,
                        MinHP = 50,
                        MaxHP = 120,
                        MinCP = 100,
                        MaxCP = 2300,
                        MinHeight = 2.20f,
                        MaxHeight = 4.70f,
                        MinWeight = 200.00f,
                        MaxWeight = 400.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000092"),
                        Name = "Gastly",
                        HasAllolanForm = false,
                        ImgUrl = "Gastly.png",
                        Location = "Somewhere",
                        Description = "Has no true form, due to 95% of its body being poisonous gas.",
                        NDex = 92,
                        MinHP = 40,
                        MaxHP = 100,
                        MinCP = 10,
                        MaxCP = 1500,
                        MinHeight = 0.50f,
                        MaxHeight = 1.50f,
                        MinWeight = 0.50f,
                        MaxWeight = 2.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000025"),
                        Name = "Pikachu",
                        HasAllolanForm = true,
                        ImgUrl = "Pikachu.png",
                        Location = "Somewhere",
                        Description = "Is covered in yellow fur with two horizontal brown stripes on its back.",
                        NDex = 25,
                        MinHP = 40,
                        MaxHP = 80,
                        MinCP = 50,
                        MaxCP = 1500,
                        MinHeight = 0.40f,
                        MaxHeight = 0.90f,
                        MinWeight = 1.50f,
                        MaxWeight = 3.50f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000150"),
                        Name = "Mewtwo",
                        HasAllolanForm = false,
                        ImgUrl = "Mewtwo.png",
                        Location = "Somewhere",
                        Description = "Is a Pokémon created by science. It is a bipedal, humanoid creature with some feline features.",
                        NDex = 150,
                        MinHP = 90,
                        MaxHP = 150,
                        MinCP = 1000,
                        MaxCP = 3200,
                        MinHeight = 1.60f,
                        MaxHeight = 2.00f,
                        MinWeight = 17.50f,
                        MaxWeight = 35.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000087"),
                        Name = "Dewgong",
                        HasAllolanForm = false,
                        ImgUrl = "Dewgong.png",
                        Location = "Somewhere",
                        Description = "Has a snowy white, furry body, which renders it virtually invisible in snowy conditions.",
                        NDex = 87,
                        MinHP = 50,
                        MaxHP = 100,
                        MinCP = 30,
                        MaxCP = 1800,
                        MinHeight = 1.50f,
                        MaxHeight = 2.80f,
                        MinWeight = 30.00f,
                        MaxWeight = 60.00f
                    },
                    new Pokemon
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000147"),
                        Name = "Dratini",
                        HasAllolanForm = false,
                        ImgUrl = "Dratini.png",
                        Location = "Somewhere",
                        Description = "is filled with life energy. Dratini is constantly growing, and can thus reach lengths of over six feet.",
                        NDex = 147,
                        MinHP = 40,
                        MaxHP = 60,
                        MinCP = 30,
                        MaxCP = 950,
                        MinHeight = 0.60f,
                        MaxHeight = 1.50f,
                        MinWeight = 7.50f,
                        MaxWeight = 25.00f
                    }
                );

            modelBuilder.Entity<Move>().HasData(
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Hydro Pump",
                    Description = "Deals damage with no additional effect.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Razor Leaf",
                    Description = "Deals damage and has an increased critical hit ratio.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Flamethrower",
                    Description = "Deals damage and has a 10% chance of burning the target.",
                    Generation = "1"
                },new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Thunderbold",
                    Description = "Deals damage and has a 10% chance of paralyzing the target.",
                    Generation = "1"
                },new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Cut",
                    Description = "Deals damage with no additional effect in battle.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Fly",
                    Description = "The user of Fly will fly up high on the first turn, disappearing from view and becoming invulnerable to most attacks. On the second turn, Fly deals damage.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Solar Beam",
                    Description = "The user of Solar Beam will absorb light on the first turn. On the second turn, Solar Beam deals damage.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "String Shot",
                    Description = "Lowers the target's Speed by two stages.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Psybeam",
                    Description = "Deals damage and has a 10% chance of confusing the target.",
                    Generation = "1"
                },
                new Move
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Ice Beam",
                    Description = "Deals damage and has a 10% chance of freezing the target.",
                    Generation = "1"
                }
            );

            modelBuilder.Entity<PokemonMove>().HasData(
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000006")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000150"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000009")
                },
                new PokemonMove
                {
                    PokemonId = Guid.Parse("00000000-0000-0000-0000-000000000087"),
                    MoveId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                }
            );

            modelBuilder.Entity<PokemonEvolution>().HasData(
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000006")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000009")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000011")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000012")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000014")
                },
                new PokemonEvolution
                {
                    BasePokemonId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    EvolutionId = Guid.Parse("00000000-0000-0000-0000-000000000015")
                }
            );

        }
    }
}
