namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_sales1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SaleDetails", "SaleId");
            AddForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales");
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
        }
    }
}
