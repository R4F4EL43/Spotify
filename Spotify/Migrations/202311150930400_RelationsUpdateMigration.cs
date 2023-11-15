namespace Spotify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationsUpdateMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Musicas", "Artist_IDArtista", "dbo.Artistas");
            DropIndex("dbo.Musicas", new[] { "Artist_IDArtista" });
            AlterColumn("dbo.Musicas", "Artist_IDArtista", c => c.Int(nullable: false));
            CreateIndex("dbo.Musicas", "Artist_IDArtista");
            AddForeignKey("dbo.Musicas", "Artist_IDArtista", "dbo.Artistas", "IDArtista", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musicas", "Artist_IDArtista", "dbo.Artistas");
            DropIndex("dbo.Musicas", new[] { "Artist_IDArtista" });
            AlterColumn("dbo.Musicas", "Artist_IDArtista", c => c.Int());
            CreateIndex("dbo.Musicas", "Artist_IDArtista");
            AddForeignKey("dbo.Musicas", "Artist_IDArtista", "dbo.Artistas", "IDArtista");
        }
    }
}
