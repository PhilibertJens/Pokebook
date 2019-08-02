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
        public DbSet<TypeAdvantage> TypeAdvantages { get; set; }
        public DbSet<PokemonMove> PokemonMoves { get; set; }
        public DbSet<PokemonEvolution> PokemonEvolutions { get; set; }
        public DbSet<PokemonMoveCatch> PokemonMoveCatches { get; set; }

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

            modelBuilder.Entity<PokemonType>()
                .HasKey(pt => new { pt.PokemonId, pt.TypeId });

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

            /*Pokemon Moves link voor Pokemon sjabloon*/
            modelBuilder.Entity<PokemonMove>()
                .HasKey(pm => new { pm.PokemonId, pm.MoveId });

            modelBuilder.Entity<PokemonMove>()
                .HasOne(pm => pm.Pokemon)
                .WithMany(p => p.PokemonMoves)
                .HasForeignKey(pm => pm.PokemonId);

            modelBuilder.Entity<PokemonMove>()
                .HasOne(pm => pm.Move)
                .WithMany(t => t.PokemonMoves)
                .HasForeignKey(pm => pm.MoveId);

            /*Pokemon Moves link voor caught Pokemon*/
            modelBuilder.Entity<PokemonMoveCatch>()
                .HasKey(pmc => new { pmc.PokemonId, pmc.MoveId });

            modelBuilder.Entity<PokemonMoveCatch>()
                .HasOne(pmc => pmc.Pokemon)
                .WithMany(pc => pc.PokemonMoveCatches)
                .HasForeignKey(pmc => pmc.PokemonId);

            modelBuilder.Entity<PokemonMoveCatch>()
                .HasOne(pmc => pmc.Move)
                .WithMany(m => m.PokemonMoveCatches)
                .HasForeignKey(pmc => pmc.MoveId);

            /*Evolutions*/
            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.PokemonEvolutions)
                .WithOne(pe => pe.Evolution);

            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.PokemonPreEvolutions)
                .WithOne(pe => pe.BasePokemon);

            modelBuilder.Entity<PokemonEvolution>()
                .HasOne(pe => pe.Evolution)
                .WithMany(e => e.PokemonEvolutions)
                .HasForeignKey(pe => pe.EvolutionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonEvolution>()
                .HasOne(pe => pe.BasePokemon)
                .WithMany(e => e.PokemonPreEvolutions)
                .HasForeignKey(pe => pe.BasePokemonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PokemonEvolution>()
                .HasKey(pe => new { pe.BasePokemonId, pe.EvolutionId });

            /*Advantages en disadvantages*/
            modelBuilder.Entity<Type>()
                .HasMany(t => t.AdvantagesOver)
                .WithOne(a => a.AdvantageType);

            modelBuilder.Entity<Type>()
                .HasMany(t => t.DisadvantagesOver)
                .WithOne(d => d.DisadvantageType);

            modelBuilder.Entity<TypeAdvantage>()
                .HasOne(ta => ta.AdvantageType)
                .WithMany(t => t.AdvantagesOver)
                .HasForeignKey(ta => ta.AdvantageTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TypeAdvantage>()
                .HasOne(ta => ta.DisadvantageType)
                .WithMany(t => t.DisadvantagesOver)
                .HasForeignKey(ta => ta.DisadvantageTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TypeAdvantage>()
                .HasKey(ta => new { ta.AdvantageTypeId, ta.DisadvantageTypeId });

            DataSeeder.Seed(modelBuilder);
        }
    }
}
