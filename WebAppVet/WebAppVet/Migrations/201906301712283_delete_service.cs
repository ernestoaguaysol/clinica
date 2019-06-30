namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_service : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SupplyDetails", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Services", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Services", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes");
            DropIndex("dbo.SupplyDetails", new[] { "ServiceId" });
            DropIndex("dbo.Appointments", new[] { "ServiceTypeId" });
            DropIndex("dbo.Services", new[] { "ServiceTypeId" });
            DropIndex("dbo.Services", new[] { "PatientId" });
            DropIndex("dbo.Services", new[] { "DoctorId" });
            AddColumn("dbo.SupplyDetails", "AppointmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "ServiceType", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "State", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "Description", c => c.String(maxLength: 250));
            DropColumn("dbo.SupplyDetails", "ServiceId");
            DropColumn("dbo.Appointments", "ServiceTypeId");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceTypeId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(maxLength: 250),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Appointments", "ServiceTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.SupplyDetails", "ServiceId", c => c.Int(nullable: false));
            DropColumn("dbo.Appointments", "Description");
            DropColumn("dbo.Appointments", "State");
            DropColumn("dbo.Appointments", "ServiceType");
            DropColumn("dbo.SupplyDetails", "AppointmentId");
            CreateIndex("dbo.Services", "DoctorId");
            CreateIndex("dbo.Services", "PatientId");
            CreateIndex("dbo.Services", "ServiceTypeId");
            CreateIndex("dbo.Appointments", "ServiceTypeId");
            CreateIndex("dbo.SupplyDetails", "ServiceId");
            AddForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "ServiceTypeId", "dbo.ServiceTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Services", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Services", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SupplyDetails", "ServiceId", "dbo.Services", "Id", cascadeDelete: true);
        }
    }
}
