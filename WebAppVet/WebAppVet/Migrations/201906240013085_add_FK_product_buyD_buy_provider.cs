namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_product_buyD_buy_provider : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyDetails", "BuyId", c => c.Int(nullable: false));
            AddColumn("dbo.BuyDetails", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.Buys", "ProviderId", c => c.Int(nullable: false));
            CreateIndex("dbo.BuyDetails", "BuyId");
            CreateIndex("dbo.BuyDetails", "ProductId");
            CreateIndex("dbo.Buys", "ProviderId");
            AddForeignKey("dbo.BuyDetails", "BuyId", "dbo.Buys", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BuyDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Buys", "ProviderId", "dbo.Providers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buys", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.BuyDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.BuyDetails", "BuyId", "dbo.Buys");
            DropIndex("dbo.Buys", new[] { "ProviderId" });
            DropIndex("dbo.BuyDetails", new[] { "ProductId" });
            DropIndex("dbo.BuyDetails", new[] { "BuyId" });
            DropColumn("dbo.Buys", "ProviderId");
            DropColumn("dbo.BuyDetails", "ProductId");
            DropColumn("dbo.BuyDetails", "BuyId");
        }
    }
}
