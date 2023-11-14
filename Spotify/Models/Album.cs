using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spotify.Models
{
    public class Album
    {

        [Key]
        public int IDAlbum { get; set; }

        [Required]
        public string NomeAlbum { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Duraco { get; set; }


        //[Key]
        //[ForeignKey("IDMusica")]
        //public ICollection<Musica> Musicas { get; set; }

        //[Key]
        //[ForeignKey("IDAlbum")]
        //public ICollection<Album> Albuns { get; set; }

    }
}