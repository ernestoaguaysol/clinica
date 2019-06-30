namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_SaleAndAppointment_Billing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Billings", "SaleId", c => c.Int(nullable: false));
            AddColumn("dbo.Billings", "AppointmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "Billing_Id", c => c.Int());
            AddColumn("dbo.Sales", "Billing_Id", c => c.Int());
            CreateIndex("dbo.Appointments", "Billing_Id");
            CreateIndex("dbo.Sales", "Billing_Id");
            AddForeignKey("dbo.Appointments", "Billing_Id", "dbo.Billings", "Id");
            AddForeignKey("dbo.Sales", "Billing_Id", "dbo.Billings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "Billing_Id", "dbo.Billings");
            DropForeignKey("dbo.Appointments", "Billing_Id", "dbo.Billings");
            DropIndex("dbo.Sales", new[] { "Billing_Id" });
            DropIndex("dbo.Appointments", new[] { "Billing_Id" });
            DropColumn("dbo.Sales", "Billing_Id");
            DropColumn("dbo.Appointments", "Billing_Id");
            DropColumn("dbo.Billings", "AppointmentId");
            DropColumn("dbo.Billings", "SaleId");
        }
    }
}
