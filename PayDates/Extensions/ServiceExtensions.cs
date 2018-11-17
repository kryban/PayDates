using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayDates.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfirgureCors(this IServiceCollection services)
        {
            services.AddCors(option);
        }

        private static void option(CorsOptions obj)
        {
            obj.AddPolicy("CorsPolicy", CorsPolicyBuildr);
        }

        private static void CorsPolicyBuildr(CorsPolicyBuilder obj)
        {
            obj.AllowAnyHeader();
            obj.AllowAnyMethod();
            obj.AllowCredentials();
            obj.AllowAnyOrigin();
        }
    }
}
