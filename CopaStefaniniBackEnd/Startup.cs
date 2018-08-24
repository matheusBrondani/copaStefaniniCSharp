using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CopaStefaniniBackEnd.Repository;
using Microsoft.EntityFrameworkCore;
using CopaStefaniniBackEnd.Services;
using CopaStefaniniBackEnd.Data.Repositories;

namespace CopaStefaniniBackEnd
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
            services.AddDbContext<CupContext>(opt => opt.UseInMemoryDatabase("CopaDB"));
            services.AddTransient<PlayerService>();
            services.AddTransient<PlayerRepository>();
            services.AddTransient<TeamService>();
            services.AddTransient<TeamRepository>();
            services.AddMvc();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.WithOrigins("http://localhost:4222").AllowAnyMethod());

            app.UseMvc();
        }
    }
}
