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

        public string ImagemPerfil { get; set; } = "https://cdn-icons-png.flaticon.com/512/17/17004.png";

        [Required]
        public DateTime DataNasc { get; set; }

        public string Descricao { get; set; } = "";
    }
}