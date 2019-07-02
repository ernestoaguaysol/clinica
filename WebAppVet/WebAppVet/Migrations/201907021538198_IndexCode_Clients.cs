namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndexCode_Clients : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Code", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clients", new[] { "Code" });
            DropColumn("dbo.Clients", "Code");
        }
    }
}
