using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core_20
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // необязательный конструктор
            // если нет конструктора, по умолчанию вызывается этот конструктор
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // необязательный метод
            // если есть, то вызывается после конструктора
            // применяется для регистрации сервисов
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // обязательный метод
            // вызывается после ConfigureServices
            // выполняется обработка запроса

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
