using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dependency_Injection_IoC_Ornek_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly INumGenerater2 numGenerater2;

        public TestController(INumGenerater2 numGenerater2 )
        {
            this.numGenerater2 = numGenerater2;
        }

        [HttpGet]
        public string Get() 
        {
            int re1 = numGenerater2.GetNumGeneratorRandomNumber();
            int re2 = numGenerater2.RandomValue;
            return $"Rendom1 = {re1}, Rendom2 ={re2}";
        }

    }
}
