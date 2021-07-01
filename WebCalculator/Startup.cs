using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //добавление необходимых сервисов для работы с Razor Pages
            services.AddRazorPages();

            //добавление сервисов Server Blazor
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            //добавление middleware для обслуживания статических файлов
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //связь клиентской части приложения с сервером с помощью соединения SignalR (обмен сообщениями между клиентом и сервером в режиме реального времени)
                endpoints.MapBlazorHub();

                //установка страницы по уолчанию для приложения
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
