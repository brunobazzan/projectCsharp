using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca_Teste
{
    public class Gravar
    {
        public static void GravarCliente(Cliente cli)
        {
            //string para capturar o endereço do meus documentos 
            string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // nome do nosso arquivo 
            string bancoCliente = "ClientesCadastrados.txt";
            //combinação dos nomes  
            string nomeCompleto = Path.Combine(meusDocumentos, bancoCliente);
            //aqui é aonde vamos guardar nossos dados do nosso arquivo de texto
            using (var gravador = new StreamWriter(nomeCompleto, true, Encoding.UTF8))
            {
                gravador.WriteLine(cli.Documento + ";" + cli.Nome + ";" + cli.Endereço + ";" + cli.Email);
            }

        }
        public static void GravarLivro()
        {

        }
    }
}
