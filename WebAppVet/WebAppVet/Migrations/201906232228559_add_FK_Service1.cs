namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_Service1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Description", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Description");
        }
    }
}
