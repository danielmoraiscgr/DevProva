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
        public double Get()
        {
            CalculoBhaskara calculo = new CalculoBhaskara();
            return calculo.ResultadoCalculoBhaskara(2, 2, 1); 
        }
        


    }
}
