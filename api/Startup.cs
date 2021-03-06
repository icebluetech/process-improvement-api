﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;
using data;
using Microsoft.EntityFrameworkCore;
using idata;

namespace process_improvement_api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            var connection = @"Server=tcp:process-improvement.database.windows.net,1433;Initial Catalog=process-improvement-db;Persist Security Info=False;User ID=chrischeshire;Password=kikibubz1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<ProcessImprovementContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInnovationRepository, InnovationRepository>();
            services.AddScoped<IDocsRepository, DocsRepository>();
            services.AddScoped<IInnovationUserRepository, InnovationUserRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IProcessRepository, ProcessRepository>();
            services.AddScoped<IWidgetRepository, WidgetRepository>();
            services.AddScoped<IInnovationTypeRepository, InnovationTypeRepository>();
            services.AddScoped<IInnovationCategoryRepository, InnovationCategoryRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen();

            services.AddMvc()
        .AddJsonOptions(
            options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            // Shows UseCors with CorsPolicyBuilder.
            app.UseCors(builder => { builder.AllowAnyHeader(); builder.AllowAnyOrigin();builder.AllowAnyMethod(); });

            app.UseMvc();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUi();
        }
    }
}
