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
using Timekeeper.DAL;

namespace Timekeeper
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var x = Configuration["CosmosDB:Uri"];

            DAccess = new DataAccess(
                
                configuration.GetSection("CosmosDB").GetValue(typeof(string), "Uri").ToString(),
                configuration.GetSection("CosmosDB").GetValue(typeof(string), "Key").ToString(),
                configuration.GetSection("CosmosDB").GetValue(typeof(string), "Id").ToString(),
                (bool)configuration.GetValue(typeof(bool), "InitializeCosmosDB"));
        }

        public IConfiguration Configuration { get; }
        public IDataAccess DAccess { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            List<string> s = new List<string>();
            s.Add("Test");
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IDataAccess>(DAccess);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
