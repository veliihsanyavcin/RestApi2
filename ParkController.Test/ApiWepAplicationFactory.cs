using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace ParkController.Test
{
    //public class ApiWebApplicationFactory 
    //{
    //    protected override void ConfigureWebHost(IWebHostBuilder builder)
    //    {
    //        builder.ConfigureAppConfiguration(config =>
    //        {
    //            var integrationConfig = new ConfigurationBuilder()
    //              .AddJsonFile("integrationsettings.json")
    //              .Build();

    //            config.AddConfiguration(integrationConfig);
    //        });

    //        // is called after the `ConfigureServices` from the Startup
    //        builder.ConfigureTestServices(services =>
    //        {
    //            //services.AddTransient<IWeatherForecastConfigService, WeatherForecastConfigStub>();
    //        });
    //    }
    //}
}
