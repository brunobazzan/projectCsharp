using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Aula_02
{
   public class Cliente
    {
        public Cliente()
        {
            Produtos = new List<string>();
        }
        public string Nome { get; set; }
        public string Email { get; set;}
        public List<string> Produtos { get; set; }


    }
}
