using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace firstWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
                app.UseStaticFiles();
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();
            // app.UseStaticFiles();

            // app.UseRouting();

            // app.UseAuthorization();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapGet("/", async context =>
                // {
                //     await context.Response.WriteAsync("Hello World!");
                // });

                endpoints.MapControllerRoute(
                    name: "Home",
                    pattern: "{controller=Home}"
                );

                endpoints.MapControllerRoute(
                    name: "Contact",
                    pattern: "{controller=Contact}"
                );
                      endpoints.MapControllerRoute(
                    name: "Projects",
                    pattern: "{controller=Projects}"
                );
            });
        }
    }
}
