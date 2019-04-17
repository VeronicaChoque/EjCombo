using EjCombo.Repository;
using EjCombo.Services.Implementation;
using EjCombo.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Services
{
    public static class StartupExtentions
    {
        public static void AddEjComboServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEjComboRepository(configuration);

            services.AddTransient<IComboService, ComboService>();
            services.AddTransient<IAgregadoService, AgregadoService>();
            services.AddTransient<IGaseosaService, GaseosaService>();
            services.AddTransient<IHamburguesaService, HamburguesaService>();
            services.AddTransient<IPapasService, PapasService>();
        }
    }
}
