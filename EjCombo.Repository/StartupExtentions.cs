using EjCombo.Repository.Implementation;
using EjCombo.Repository.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjCombo.Repository
{
    public static class StartupExtentions
    {
        public static void AddEjComboRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IComboRepository, ComboRepository>();
            services.AddTransient<IAgregadoRepository, AgregadoRepository>();
            services.AddTransient<IGaseosaRepository, GaseosaRepository>();
            services.AddTransient < IHamburguesaRepository, HamburguesaRepository>();
            services.AddTransient<IPapasRepository, PapasRepository>();
        }
    }
}
