using System;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
namespace BasicConsoleSample
{
    public class AppModule : AbpModule
    {
        #region DI 1
        // public override void ConfigureServices(ServiceConfigurationContext context)
        // {
        //     context.Services.AddTransient<HelloAbpService>();
        //     base.ConfigureServices(context);
        // }
        #endregion
    }
}