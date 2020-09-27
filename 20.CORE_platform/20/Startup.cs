﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace _20
{
    public class Startup
    {
        // подключенные сервисы из Azure(это метод не обязательный и вызывается после конструктора, если он есть)
        public void ConfigureServices(IServiceCollection services) 
        {

        }

        // выполняет обработку запроса (обязателен)
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //async - указывает что ф-ция явл ассинхронной await - ждем пока выплниться writeAsync
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
