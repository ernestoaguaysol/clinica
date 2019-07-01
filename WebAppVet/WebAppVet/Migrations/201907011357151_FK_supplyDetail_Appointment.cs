namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_supplyDetail_Appointment : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SupplyDetails", "AppointmentId");
            AddForeignKey("dbo.SupplyDetails", "AppointmentId", "dbo.Appointments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplyDetails", "AppointmentId", "dbo.Appointments");
            DropIndex("dbo.SupplyDetails", new[] { "AppointmentId" });
        }
    }
}
