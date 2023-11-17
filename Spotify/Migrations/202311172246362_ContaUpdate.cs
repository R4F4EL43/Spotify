namespace Spotify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContaUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contas", "ImagemPerfil", c => c.String());
            AlterColumn("dbo.Contas", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contas", "Descricao", c => c.String(nullable: false));
            AlterColumn("dbo.Contas", "ImagemPerfil", c => c.String(nullable: false));
        }
    }
}
