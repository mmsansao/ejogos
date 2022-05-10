using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //IActionResult representa os vários códigos HTTP 


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {

            // ViewBag = Reserva de espaço para armazenar informações para recueprar na VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();


            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {

            // criar um objeto equipe a partir do frontend
            // seria o IFormCollection
            Equipe novaEquipe = new Equipe();

            novaEquipe.idEquipe = int.Parse(form["IdEquipe"]); // a string do form é o que vai aparecer na página, vai voltar uma string que deve ser convertida em int
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            //chamar a função CRIAR passando um objeto do tipo Equipe
            equipeModel.Criar(novaEquipe);

            // ele deve então atualizar a viewbag com a equipe nova
            ViewBag.Equipes = equipeModel.LerEquipes();

            return LocalRedirect("~/Equipe");

        }
    }
}
