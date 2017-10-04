using LojaGames.Entities;
using LojaGames.Models;
using LojaGames.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaGames.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Loja loja = new Loja();

            if(Session["Jogos"] == null)
            {
                Session["Jogos"] = loja.ObterJogos();
            }

            var viewModel = new JogoViewModel
            {
                Jogos = Session["Jogos"] as List<Jogo>
            };

            return View(viewModel);
          
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(CadastroViewModel cadastro)
        {
            if (ModelState.IsValid)
            {
                Loja loja = new Loja();

                var novoJogo = loja.CadastrarNovoJogo(cadastro);

                var jogos = Session["Jogos"] as List<Jogo>;
                jogos.Add(novoJogo);

                Session["Jogos"] = jogos;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Preencha Corretamente todos os campos.");
            }
            return View();
        }
        
    }
}