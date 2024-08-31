using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_IoC_Ornek_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly INumGenerator _numGenerator;
        private readonly INumGenerater2 _numGenerater2;

        public WeatherForecastController(/*INumGenerator numGenerator*/ INumGenerater2 numGenerater2)
        {
            //this._numGenerator = numGenerator;
            _numGenerater2 = numGenerater2;
        }

        [HttpGet]
        public string Get()
        {

            //int number = _numGenerator.GetRandomNumber();
            //int number = _numGenerator.RandomValue;

            int rendom2 = _numGenerater2.GetNumGeneratorRandomNumber();
            int rendom1 = _numGenerater2.RandomValue;

            return $"Rendom1 = {rendom1}, Rendom2 ={rendom2}";
        }
    }
}
