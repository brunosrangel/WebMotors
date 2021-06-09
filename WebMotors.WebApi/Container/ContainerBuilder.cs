using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webMotors.Services;
using Webmotors.Repository.Repositorys;
using WebMotors.WebApi.Controllers;

namespace WebMotors.WebApi.Container
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
