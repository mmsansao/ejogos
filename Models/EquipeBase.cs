using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {

        public void CriarPastaOuArquivo(string caminho)
        {

            // nome de uma pasta / nomedoarquivo.csv
            string pasta = caminho.Split('/')[0];

            // Se o diretório não existir, criar a pasta
            if (!Directory.Exists(pasta))
            {

                Directory.CreateDirectory(pasta);

            }


            // se o arquivo não existe, criar arquivo
            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }


        }


    }
}
