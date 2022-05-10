using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{
    public class Equipe : EquipeBase, IEquipe
    {

        //Herança
        // Quero que equipe tenha os mesmos métodos que EquipeBase


        public int idEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }


        private const string caminhobd = "Database/Equipe.csv";

        public Equipe()
        {
            //método da classe de herança EquipeDatabase
            CriarPastaOuArquivo(caminhobd);
        }


        // criar uma funcao que vai receber o objeto EQUIPE e vai retornar no formato CSV (string)

        private string Preparar(Equipe e)
        {
           // montar a string
            return $"{e.idEquipe};{e.Nome};{e.Imagem}";  

        }


        public void Criar(Equipe novaEquipe)
        {

            // cria a string em um array
            string[] equipe_texto = {Preparar(novaEquipe)};

            //aqui vamos adicionar uma nova linha 
            // caminho do arquivo, string em formato array
            File.AppendAllLines(caminhobd, equipe_texto);

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();  

            // Ler todas as linhas do aquivo csv, armazenar em um array;
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }


            return listaEquipes;


        }
    }
}
