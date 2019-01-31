using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca_eveline
{
    class LeitorConfiguracao
    {
        public string leitorServidor(string server)
        {
            StreamReader servidor = new StreamReader(Application.StartupPath + @"\Servidor.txt");
                string dados = "";
                server = servidor.ReadToEnd();
                dados = server;
                return dados;
            
        }

        public string leitorBaseDados(string baseDados)
        {
            using (StreamReader servidor = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
            {
               return baseDados = servidor.ReadToEnd();
            }
           
        }

    }
}
