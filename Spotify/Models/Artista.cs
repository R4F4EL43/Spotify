using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spotify.Models
{
    public class Artista
    {
        [Key]
        public int IDArtista { get; set; }

        [Required]
        public string NomeArtista { get; set; }

        [Required]
        public string ImagemPerfil { get; set; }

        [Required]
        public DateTime DataNasc { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Verificado { get; set; }

        [Required]
        public int Streams { get; set; }

        public ICollection<Album> Albuns { get; set; }

        public ICollection<Musica> Musicas { get; set; }
    }
}