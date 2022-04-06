using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingEF.DBContext;
using HandsOnAPIUsingEF.Repositories;

namespace HandsOnAPIUsingEF
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

            services.AddControllers();
           
            services.AddDbContext<MyContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MyDBConn")));
            services.AddScoped<IProductRepository, ProductRepository>();
            //enable cors
            services.AddCors(c => c.AddPolicy("CorsOrigin", policy => 
            policy.AllowAnyOrigin() //allow any clint address
               .AllowAnyMethod() //allow any http method like get,post,put,delete
               .AllowAnyHeader() //allow request and response headers
            )
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HandsOnAPIUsingEF", Version = "v1" });
            });
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HandsOnAPIUsingEF v1"));
            }
           
            app.UseRouting();
            app.UseCors("CorsOrigin");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
