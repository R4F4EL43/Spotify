using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spotify.Models
{
    public class Musica
    {
        [Key]
        public int IDMusica { get; set; }

        [Required]
        public Artista Artist { get; set; }
        
        public Album Album { get; set; }

        [Required]
        public string NomeMusica { get; set; }

        [Required]
        public string Letra { get; set; }

        [Required]
        public int Duracao { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}