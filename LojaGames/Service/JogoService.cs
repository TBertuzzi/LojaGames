using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaGames.Entities;
using LojaGames.Repository;
using System.Web;

namespace LojaGames.Service
{
    public class JogoService
    {
        private JogoRepository _jogoRepository;

        public JogoService()
        {
            _jogoRepository = new Repository.JogoRepository();
        }
        internal List<Jogo> ObterJogos()
        {
            return _jogoRepository.ObterJogos();
        }

        internal Jogo CadastrarNovoJogo(Jogo jogo)
        {
            Jogo retorno = _jogoRepository.ExisteJogo(jogo);
            if (retorno == null)
            {
                retorno = _jogoRepository.CadastrarNovoJogo(jogo);
            }

            return retorno;
        }
    }
}