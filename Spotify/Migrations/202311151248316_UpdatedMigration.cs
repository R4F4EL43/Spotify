namespace Spotify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        IdConta = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ImagemPerfil = c.String(nullable: false),
                        DataNasc = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdConta);
            
            AddColumn("dbo.Artistas", "NomeArtistico", c => c.String(nullable: false));
            AddColumn("dbo.Artistas", "Conta_IdConta", c => c.Int(nullable: false));
            CreateIndex("dbo.Artistas", "Conta_IdConta");
            AddForeignKey("dbo.Artistas", "Conta_IdConta", "dbo.Contas", "IdConta", cascadeDelete: true);
            DropColumn("dbo.Artistas", "NomeArtista");
            DropColumn("dbo.Artistas", "ImagemPerfil");
            DropColumn("dbo.Artistas", "DataNasc");
            DropColumn("dbo.Artistas", "Descricao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artistas", "Descricao", c => c.String(nullable: false));
            AddColumn("dbo.Artistas", "DataNasc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Artistas", "ImagemPerfil", c => c.String(nullable: false));
            AddColumn("dbo.Artistas", "NomeArtista", c => c.String(nullable: false));
            DropForeignKey("dbo.Artistas", "Conta_IdConta", "dbo.Contas");
            DropIndex("dbo.Artistas", new[] { "Conta_IdConta" });
            DropColumn("dbo.Artistas", "Conta_IdConta");
            DropColumn("dbo.Artistas", "NomeArtistico");
            DropTable("dbo.Contas");
        }
    }
}
