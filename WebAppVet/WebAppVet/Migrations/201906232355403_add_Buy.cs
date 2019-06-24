namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Buy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Date");
        }
    }
}
