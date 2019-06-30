namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ComertialInf_FK_Billing : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Billings", "CommercialInformationId");
            AddForeignKey("dbo.Billings", "CommercialInformationId", "dbo.CommercialInformations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Billings", "CommercialInformationId", "dbo.CommercialInformations");
            DropIndex("dbo.Billings", new[] { "CommercialInformationId" });
        }
    }
}
