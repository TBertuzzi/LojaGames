using LojaGames.Entities;
using LojaGames.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaGames.ViewModel;

namespace LojaGames.Models
{
    public class Loja
    {
        private JogoService _jogoService;

        public Loja()
        {
            _jogoService = new JogoService();
        }
        public List<Jogo> ObterJogos()
        {
            return _jogoService.ObterJogos();
        }

        internal Jogo CadastrarNovoJogo(CadastroViewModel cadastro)
        {
            return _jogoService.CadastrarNovoJogo(cadastro.Cast<Jogo>());
        }
    }
}