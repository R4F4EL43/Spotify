using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Spotify.Models {
    public class Conta {

        [Key]
        public int IdConta { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ImagemPerfil { get; set; }

        [Required]
        public DateTime DataNasc { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}