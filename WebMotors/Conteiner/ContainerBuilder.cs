using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using webMotors.Services;
using Webmotors.Repository.Repositorys;

namespace WebMotors.WebApi.Conteiner
{
    public static class ContainerBuilder
    {
        public static void ConfigureContainer(IServiceCollection services)
        {
            services.AddTransient<IAnunciosRepository, AnunciosRepository>();
            services.AddTransient<IAnunciosServices, AnunciosServices>();
            services.AddTransient<IAnunciosController, AnunciosController>();



        }
    }
}
