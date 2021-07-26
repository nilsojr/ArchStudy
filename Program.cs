using System;
using System.Threading.Tasks;
using ArchStudy.Implementations;
using ArchStudy.Interfaces;
using ArchStudy.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArchStudy
{
    class Program
    {
        static Task Main(string[] args)
        {
            return CreateHostBuilder(args).Build().RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddHostedService<CustomerService>()
                        .AddScoped<ICustomerDataAccess, CustomerDataAccess>());
        }
    }
}
