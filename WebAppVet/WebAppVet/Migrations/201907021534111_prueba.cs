namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "DocumentNumber", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Clients", "Document");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Document", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Clients", "DocumentNumber");
        }
    }
}
