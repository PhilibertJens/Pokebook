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
    public class PokebookContext : DbContext
    {
        public PokebookContext(DbContextOptions<PokebookContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }
        public DbSet<PokemonUser> PokemonUsers { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<PokemonCatch> PokemonCatches { get; set; }

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

            modelBuilder.Entity<Friendship>()
                .Property(f => f.Created)
                    .HasDefaultValueSql("GETDATE()")
                    .ValueGeneratedOnAddOrUpdate();

            /*modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.Evolutions);

            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.Moves);*/

            modelBuilder.Entity<PokemonType>()
                .HasKey(pt => new { pt.PokemonId, pt.TypeId });

            modelBuilder.Entity<Type>()
                .HasMany(t => t.Advantages);

            modelBuilder.Entity<Type>()
                .HasMany(t => t.Disadvantages);

            modelBuilder.Entity<PokemonType>()
                .HasOne(pt => pt.Pokemon)
                .WithMany(p => p.PokemonTypes)
                .HasForeignKey(pt => pt.PokemonId);

            modelBuilder.Entity<PokemonType>()
                .HasOne(pt => pt.Type)
                .WithMany(t => t.PokemonTypes)
                .HasForeignKey(pt => pt.TypeId);

            modelBuilder.Entity<PokemonUser>()
                .HasKey(pu => new { pu.PokemonId, pu.UserId });

            DataSeeder.Seed(modelBuilder);
        }
    }
}
