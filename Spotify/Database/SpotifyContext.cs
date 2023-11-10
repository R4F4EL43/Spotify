using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Spotify.Database {
    public class SpotifyContext :DbContext
    {

        public SpotifyContext() {
            this.Database.Connection.ConnectionString = "Server=SINF113\\SQLEXPRESS; Database=Projeto-Spotify; User Id=sa; Password=SQLEXPRESS_;";
        } 
    }
}