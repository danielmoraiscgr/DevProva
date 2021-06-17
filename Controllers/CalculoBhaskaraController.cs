using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevProva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculoBhaskaraController : ControllerBase
    {

        [HttpGet]
        [Route("a={a:int},b={b:int},c={c:int}")]
        public double Get(int a, int b, int c)
        {
            CalculoBhaskara calculo = new CalculoBhaskara();
            return calculo.ResultadoCalculoBhaskara(a, b, c); 
        }
        


    }
}
