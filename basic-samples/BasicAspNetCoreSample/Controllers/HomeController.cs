using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace BasicAspNetCoreSample.Controllers
{
    [Route("api/home")]
    public class HomeController : AbpController
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello Abp !";
        }
    }
}