namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "FullName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "FullName", c => c.String());
        }
    }
}
