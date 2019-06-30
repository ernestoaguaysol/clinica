namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_CommercialInformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommercialInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuit = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        PostalCode = c.String(maxLength: 100),
                        City = c.String(maxLength: 100),
                        Country = c.String(maxLength: 100),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CommercialInformations");
        }
    }
}
