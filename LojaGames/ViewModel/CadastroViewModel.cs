using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaGames.ViewModel
{
    public class CadastroViewModel
    {

        [Required]
        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} Deve possuir no maximo {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Required]
        [Display(Name = "Plataforma")]
        public string Plataforma { get; set; }

        [Required]
        [Display(Name = "Classificação")]
        public string Classificacao { get; set; }



    }
}