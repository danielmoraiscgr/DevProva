using DevProva.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevProva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
           Pessoa pessoa = new Pessoa();
           
           pessoa.Nome = "Daniel Morais Borges";
           pessoa.Idade = 49;

           return pessoa.VerificarNumeroPrimo(pessoa);

        }
    }
}
