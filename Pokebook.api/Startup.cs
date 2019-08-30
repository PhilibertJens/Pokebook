using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokebook.core.Data;
using Pokebook.core.Repositories;
using Pokebook.core.Repositories.Specific;
using Pokebook.core.Services.Automapper;

namespace Pokebook.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            }
            );
            services.AddCors();
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<PokebookContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PokebookDb")));
            services.AddScoped<ChatRepository>();
            services.AddScoped<MessageRepository>();
            services.AddScoped<UserChatRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<FriendshipRepository>();
            services.AddScoped<PokemonRepository>();
            services.AddScoped<PokemonCatchRepository>();
            services.AddScoped<TypeRepository>();
            services.AddScoped<MoveRepository>();
            services.AddScoped<PokemonUserRepository>();
            services.AddScoped<PokemonTypeRepository>();
            services.AddScoped<UnitOfWork>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder => 
                builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            app.UseMvc();
        }
    }
}
