using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Data
{
    public abstract class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T>
        where T : DbContext 
    {
        private IConfiguration Configuration { get; }
        private string ConfigKey { get; }

        public DesignTimeDbContextFactory(string configKey)
        {
            this.ConfigKey = configKey ?? throw new ArgumentNullException(nameof(configKey));
            ConfigurationBuilder cb = new ConfigurationBuilder();
            AddConfigurationSources(cb, Assembly.GetCallingAssembly());
            Configuration = cb.Build();
        }

        protected virtual void AddConfigurationSources(ConfigurationBuilder builder,
                                                       Assembly asm)
        {
            builder.AddUserSecrets(asm)
                   .AddEnvironmentVariables();
        }

        public T CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<T>();
            builder.UseSqlServer("Server =.\\SQLEXPRESS; Database = PokebookDb; Integrated Security = true;");
            return CreateDbContext(builder.Options);
        }

        protected abstract T CreateDbContext(DbContextOptions<T> options);
    }
}
