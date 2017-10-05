using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LojaGames.Entities
{
    public class Jogo
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _genero;
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        private string _plataforma;
        public string Plataforma
        {
            get { return _plataforma; }
            set { _plataforma = value; }
        }

        private string _classificacao;

        public string Classificacao
        {
            get { return _classificacao; }
            set { _classificacao = value; }
        }


    }
}