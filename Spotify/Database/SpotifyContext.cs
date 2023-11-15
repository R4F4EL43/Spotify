using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Spotify.Database
{
    public class SpotifyContext : DbContext
    {
        public DbSet<Musica> Musica { get; set; }
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artista> Artistas { get; set; }

        public SpotifyContext()
        {
            this.Database.Connection.ConnectionString = "Server=PAULA_MARQUES; Database=Projeto-Spotify; Trusted_Connection=True;";
            //this.Database.Connection.ConnectionString = "Server=SINF113\\SQLEXPRESS; Database=Projeto-Spotify; User Id=sa; Password=SQLEXPRESS_;";
        }

        public System.Data.Entity.DbSet<Spotify.Models.Conta> Contas { get; set; }
    }
}