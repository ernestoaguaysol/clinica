namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_SupplyDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplyDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplyDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplyDetails", "ServiceId", "dbo.Services");
            DropIndex("dbo.SupplyDetails", new[] { "ServiceId" });
            DropIndex("dbo.SupplyDetails", new[] { "ProductId" });
            DropTable("dbo.SupplyDetails");
        }
    }
}
