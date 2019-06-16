namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "Surname", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "Document", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Clients", "TypeDocument", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Phone", c => c.String(maxLength: 50));
            AddColumn("dbo.Clients", "MobilePhone", c => c.String(maxLength: 50));
            AddColumn("dbo.Clients", "Address", c => c.String(maxLength: 50));
            AddColumn("dbo.Clients", "UserName", c => c.String(maxLength: 50));
            DropColumn("dbo.Clients", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "FullName", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.Clients", "UserName");
            DropColumn("dbo.Clients", "Address");
            DropColumn("dbo.Clients", "MobilePhone");
            DropColumn("dbo.Clients", "Phone");
            DropColumn("dbo.Clients", "TypeDocument");
            DropColumn("dbo.Clients", "Document");
            DropColumn("dbo.Clients", "Surname");
            DropColumn("dbo.Clients", "Name");
        }
    }
}
