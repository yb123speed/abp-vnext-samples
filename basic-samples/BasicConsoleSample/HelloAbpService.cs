using System;
using Volo.Abp.DependencyInjection;
namespace BasicConsoleSample
{
    #region DI 1
    // public class HelloAbpService
    // {
    //     public void SayHello()
    //     {
    //         Console.WriteLine("Hello,Abp!");
    //     }
    // }
    #endregion

    #region DI 2
    public class HelloAbpService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello,Abp!");
        }
    }
    #endregion
}