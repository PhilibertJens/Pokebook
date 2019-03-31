using Microsoft.EntityFrameworkCore;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    UserName = "Tyrion Lannister"
                },
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserName = "Jon Snow"
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
        }
    }
}
