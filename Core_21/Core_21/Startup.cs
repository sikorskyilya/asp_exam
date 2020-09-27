using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.Extensions.Logging;

namespace Core_21
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
            // необязательный методD:\ASP\Экзамен\Core_21\Core_21\Startup.cs
            // если есть, то вызывается после конструктора
            // применяется для регистрации сервисов
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            // обязательный метод
            // вызывается после ConfigureServices
            // выполняется обработка запроса

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            logger.AddConsole();

            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(options);

            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers.Append("X-KYA", "Karlenok Yury Andreevich");
                }
            });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "docs")),
                RequestPath = "/docs"
            });
        }
    }
}
