using System;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;

namespace BasicConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var application = AbpApplicationFactory.Create<AppModule>())
            {
                application.Initialize();
                var service = application.ServiceProvider.GetService<HelloAbpService>();
                service.SayHello();
                application.Shutdown();
            }
        }
    }
}
