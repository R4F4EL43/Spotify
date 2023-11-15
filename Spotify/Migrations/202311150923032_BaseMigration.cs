namespace Spotify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        IDAlbum = c.Int(nullable: false, identity: true),
                        NomeAlbum = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Duraco = c.Int(nullable: false),
                        Artist_IDArtista = c.Int(),
                    })
                .PrimaryKey(t => t.IDAlbum)
                .ForeignKey("dbo.Artistas", t => t.Artist_IDArtista)
                .Index(t => t.Artist_IDArtista);
            
            CreateTable(
                "dbo.Artistas",
                c => new
                    {
                        IDArtista = c.Int(nullable: false, identity: true),
                        NomeArtista = c.String(nullable: false),
                        ImagemPerfil = c.String(nullable: false),
                        DataNasc = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false),
                        Verificado = c.Boolean(nullable: false),
                        Streams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDArtista);
            
            CreateTable(
                "dbo.Musicas",
                c => new
                    {
                        IDMusica = c.Int(nullable: false, identity: true),
                        NomeMusica = c.String(nullable: false),
                        Letra = c.String(nullable: false),
                        Duracao = c.Int(nullable: false),
                        ImageURL = c.String(nullable: false),
                        Artist_IDArtista = c.Int(),
                    })
                .PrimaryKey(t => t.IDMusica)
                .ForeignKey("dbo.Artistas", t => t.Artist_IDArtista)
                .Index(t => t.Artist_IDArtista);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musicas", "Artist_IDArtista", "dbo.Artistas");
            DropForeignKey("dbo.Albums", "Artist_IDArtista", "dbo.Artistas");
            DropIndex("dbo.Musicas", new[] { "Artist_IDArtista" });
            DropIndex("dbo.Albums", new[] { "Artist_IDArtista" });
            DropTable("dbo.Musicas");
            DropTable("dbo.Artistas");
            DropTable("dbo.Albums");
        }
    }
}
