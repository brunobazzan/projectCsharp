using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_eveline
{
    class GravarConfiguracaoClasse
    {
        public string GravarConfig(string texto1, string texto2)
        {
            //grava o nome do servidor e a base de dados
            using (StreamWriter escritor1 = new StreamWriter(Application.StartupPath + @"\Servidor.txt"))
            {
               escritor1.WriteLine(texto1);    
            }
            using (StreamWriter escritor2 = new StreamWriter(Application.StartupPath + @"\NomeBase.txt"))
            {
                escritor2.WriteLine(texto2);
            }
            return texto1;
            return texto2;
        }
    }
}
