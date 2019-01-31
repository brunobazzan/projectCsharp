using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exemplo_Aula_02
{
    public static class Dados
    {
        public static void Gravar(Cliente cli)
        {
            string pastaMeusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nomeArquivo = "clientesProdutos.txt";
            string nomeCompleto = Path.Combine(pastaMeusDocs, nomeArquivo);
            using (var sw  = new StreamWriter(nomeCompleto, true, Encoding.UTF8))
            {
                sw.WriteLine(DateTime.Now.ToString("d"));
                sw.WriteLine(cli.Nome);
                sw.WriteLine(cli.Email);
                foreach(string p in cli.Produtos)
                {
                    sw.WriteLine(" - " + p);
                }
                sw.WriteLine("------------------------------------------");
                sw.Close();
            }
        }
    }
}
 