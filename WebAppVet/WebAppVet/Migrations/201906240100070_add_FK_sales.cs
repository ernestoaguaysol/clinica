namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_sales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleDetails", "SaleId", c => c.Int(nullable: false));
            AddColumn("dbo.SaleDetails", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.SaleDetails", "ProductId");
            CreateIndex("dbo.Sales", "ClientId");
            AddForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sales", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.Sales", new[] { "ClientId" });
            DropIndex("dbo.SaleDetails", new[] { "ProductId" });
            DropColumn("dbo.Sales", "ClientId");
            DropColumn("dbo.SaleDetails", "ProductId");
            DropColumn("dbo.SaleDetails", "SaleId");
        }
    }
}
