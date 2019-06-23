namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Appointment_FK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceTypeId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeId, cascadeDelete: true)
                .Index(t => t.ServiceTypeId)
                .Index(t => new { t.PatientId, t.DoctorId, t.RoomId, t.Date }, unique: true, name: "IX_Appointment_Keywords");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Appointments", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.Appointments", "IX_Appointment_Keywords");
            DropIndex("dbo.Appointments", new[] { "ServiceTypeId" });
            DropTable("dbo.Appointments");
        }
    }
}
