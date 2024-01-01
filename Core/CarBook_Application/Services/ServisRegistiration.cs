using MediatR.Registration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Services
{
    public static class ServisRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection
            services, IConfiguration configuration)
        { 
            services.AddMediatR(cfg =>cfg.RegisterServicesFromAssemblies(typeof
                (ServisRegistiration).Assembly));
        }
    }
}
