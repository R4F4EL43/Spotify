namespace Spotify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musicas", "Album_IDAlbum", c => c.Int());
            CreateIndex("dbo.Musicas", "Album_IDAlbum");
            AddForeignKey("dbo.Musicas", "Album_IDAlbum", "dbo.Albums", "IDAlbum");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musicas", "Album_IDAlbum", "dbo.Albums");
            DropIndex("dbo.Musicas", new[] { "Album_IDAlbum" });
            DropColumn("dbo.Musicas", "Album_IDAlbum");
        }
    }
}
