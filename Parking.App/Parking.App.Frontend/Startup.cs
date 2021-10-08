using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.app.Persistencia;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
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
            services.AddRazorPages();
            Persistencia.AppContext _contexto = new Persistencia.AppContext();
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(_contexto));
            services.AddSingleton<IRepositorioGerente>(new RepositorioGerente(_contexto));
            services.AddSingleton<IRepositorioCliente>(new RepositorioCliente(_contexto));
            services.AddSingleton<IRepositorioAdministrador>(new RepositorioAdministrador(_contexto));
            services.AddSingleton<IRepositorioVehiculo>(new RepositorioVehiculo(_contexto));
            services.AddSingleton<IRepositorioReserva>(new RepositorioReserva(_contexto));
            services.AddSingleton<IRepositorioParqueadero>(new RepositorioParqueadero(_contexto));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
