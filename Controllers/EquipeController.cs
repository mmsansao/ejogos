using EJOGOS.Models;
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
    }
}
