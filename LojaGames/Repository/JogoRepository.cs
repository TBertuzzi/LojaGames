using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaGames.Entities;

namespace LojaGames.Repository
{
    public class JogoRepository
    {
        internal List<Jogo> ObterJogos()
        {
            List<Jogo> jogos = new List<Entities.Jogo>();

            Jogo jogo = new Jogo();
            jogo.Nome = "Mario Galaxy";
            jogo.Genero = "Aventura";
            jogo.Plataforma = "Nintendo WII";

            jogos.Add(jogo);

            jogo = new Jogo();
            jogo.Nome = "God of War III";
            jogo.Genero = "Ação/Aventura";
            jogo.Plataforma = "Playstation 3";

            jogos.Add(jogo);

            jogo = new Jogo();
            jogo.Nome = "Mario Kart 8 Deluxe";
            jogo.Genero = "Corrida";
            jogo.Plataforma = "Nintendo Switch";

            jogos.Add(jogo);

            return jogos;
        }

        internal Jogo ExisteJogo(Jogo jogo)
        {
            //Verifica se existe o jogo
            return null;
        }

        internal Jogo CadastrarNovoJogo(Jogo jogo)
        {
            //cadastra no Banco
            return jogo;
        }
    }
}