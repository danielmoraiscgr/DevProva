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
        [Route("idade={idade:int}")]
        public string Get(string nome, int idade)
        {
           Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Daniel Morais";
            pessoa.Idade = idade;

           return pessoa.VerificarNumeroPrimo(pessoa);

        }
    }
}
