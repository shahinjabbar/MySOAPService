using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SoapCore;
using System.ServiceModel;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MySOAPService.Services;
using MySOAPService.Infrastructures;
using Serilog;
using Microsoft.Extensions.Configuration;
using Serilog.Configuration;
using Serilog.Configuration;

namespace MySOAPService
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        IConfiguration _configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<ISampleService, SampleService>();


            services.AddMvc().AddXmlSerializerFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSoapEndpoint<ISampleService>("/MyCustomService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
        }
    }
}
