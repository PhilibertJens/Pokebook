using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Data
{
    public class PokebookDbContextFactory : DesignTimeDbContextFactory<PokebookContext>
    {
        public PokebookDbContextFactory() : base("PokebookDb") { }

        protected override PokebookContext CreateDbContext(DbContextOptions<PokebookContext> options)
        => new PokebookContext(options);
    }
}
