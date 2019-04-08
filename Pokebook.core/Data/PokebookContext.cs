using Microsoft.EntityFrameworkCore;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Data
{
    public class PokebookContext : DbContext
    {
        public PokebookContext(DbContextOptions<PokebookContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<FriendConnection> FriendConnections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .HasMany(c => c.UserChats)
                .WithOne(uc => uc.Chat);

            modelBuilder.Entity<Chat>()
                .HasMany(c => c.Messages)
                .WithOne(m => m.Chat);

            modelBuilder.Entity<Chat>()
                .Property(p => p.Created)
                    .HasDefaultValueSql("GETDATE()")
                    .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<UserChat>()
                .HasKey(uc => new { uc.ChatId, uc.UserId });

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(s => s.Messages)
                .HasForeignKey(m => m.SenderId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId);

            modelBuilder.Entity<Message>()
                .Property(p => p.Created)
                    .HasDefaultValueSql("GETDATE()")
                    .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<FriendConnection>()
                .HasKey(fc => new { fc.IdRequester, fc.IdApprover });

            modelBuilder.Entity<FriendConnection>()
                .Property(f => f.Created)
                    .HasDefaultValueSql("GETDATE()")
                    .ValueGeneratedOnAddOrUpdate();

            DataSeeder.Seed(modelBuilder);
        }
    }
}
