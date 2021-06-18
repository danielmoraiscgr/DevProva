using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevProva.Models
{
    public class Pessoa : IPessoa
    {
      
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string VerificarNumeroPrimo(Pessoa p)
        {
            string Resposta = "Primo";
            for (double i = 2; i < p.Idade; i++)
            {
                if (p.Idade % i == 0)
                {
                    Resposta = "Não primo";
                }
                if (p.Idade == 1)
                {
                    Resposta = "Não primo";
                }
            }
            return Resposta;
        }
    }
}
