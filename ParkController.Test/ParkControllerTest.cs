using System;
using Xunit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;



namespace ParkController.Test
{
    //public class ParkControllerTest : IntegrationTest
    //{
    //    [Fact]
    //    public void Test1()
    //    {
    //        var response = await _client.GetAsync("/ticket");
    //        response.StatusCode.Should().Be(HttpStatusCode.OK);
    //    }

    //    [Fact]
    //    public void Test2()
    //    {
    //        var client = _factory.WithWebHostBuilder(builder =>
    //        {
    //            builder.ConfigureServices(services =>
    //            {
    //                services.AddTransient<IWeatherForecastConfigService, InvalidWeatherForecastConfigStub>();
    //            });
    //        })
    //        .CreateClient(new WebApplicationFactoryClientOptions());

    //        var response = await client.GetAsync("/ticket");
    //        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    //    }

    //}
}
