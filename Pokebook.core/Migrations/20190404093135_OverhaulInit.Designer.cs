﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokebook.core.Data;

namespace Pokebook.core.Migrations
{
    [DbContext(typeof(PokebookContext))]
    [Migration("20190404093135_OverhaulInit")]
    partial class OverhaulInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pokebook.core.Models.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<Guid>("CreatorId");

                    b.Property<string>("Image");

                    b.Property<string>("LastMessage");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfMessages");

                    b.Property<int>("NumberOfUsers");

                    b.Property<string>("Theme");

                    b.HasKey("Id");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreateDate = new DateTime(2019, 4, 4, 11, 31, 35, 100, DateTimeKind.Local).AddTicks(8914),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Awesome Chat",
                            NumberOfMessages = 0,
                            NumberOfUsers = 0
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreateDate = new DateTime(2019, 4, 4, 9, 31, 35, 102, DateTimeKind.Local).AddTicks(8417),
                            CreatorId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Another awesome Chat",
                            NumberOfMessages = 0,
                            NumberOfUsers = 0
                        });
                });

            modelBuilder.Entity("Pokebook.core.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ChatId");

                    b.Property<string>("ImageName");

                    b.Property<DateTime>("SendDate");

                    b.Property<Guid>("SenderId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000002"),
                            SendDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SenderId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "Hello Jon. This is Tyrion"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000002"),
                            SendDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SenderId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Text = "Hello Tyrion. I'm Jon"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000001"),
                            SendDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SenderId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "This is a chat with myself. Is this even possible?"
                        });
                });

            modelBuilder.Entity("Pokebook.core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTime>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            AccessFailedCount = 0,
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            LockoutEnd = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Tyrion Lannister"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            AccessFailedCount = 0,
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            LockoutEnd = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Jon Snow"
                        });
                });

            modelBuilder.Entity("Pokebook.core.Models.UserChat", b =>
                {
                    b.Property<Guid>("ChatId");

                    b.Property<Guid>("UserId");

                    b.Property<Guid>("Id");

                    b.HasKey("ChatId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChats");

                    b.HasData(
                        new
                        {
                            ChatId = new Guid("00000000-0000-0000-0000-000000000001"),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Id = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            ChatId = new Guid("00000000-0000-0000-0000-000000000002"),
                            UserId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Id = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            ChatId = new Guid("00000000-0000-0000-0000-000000000002"),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Id = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Pokebook.core.Models.Message", b =>
                {
                    b.HasOne("Pokebook.core.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pokebook.core.Models.User", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pokebook.core.Models.UserChat", b =>
                {
                    b.HasOne("Pokebook.core.Models.Chat", "Chat")
                        .WithMany("UserChats")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pokebook.core.Models.User", "User")
                        .WithMany("UserChats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}