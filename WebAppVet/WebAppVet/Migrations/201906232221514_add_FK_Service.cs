namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FK_Service : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "ServiceTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "PatientId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "DoctorId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "Price", c => c.Double(nullable: false));
            CreateIndex("dbo.Services", "ServiceTypeId");
            CreateIndex("dbo.Services", "PatientId");
            CreateIndex("dbo.Services", "DoctorId");
            AddForeignKey("dbo.Services", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Services", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Services", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Name", c => c.String());
            DropForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Services", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Services", "PatientId", "dbo.Patients");
            DropIndex("dbo.Services", new[] { "DoctorId" });
            DropIndex("dbo.Services", new[] { "PatientId" });
            DropIndex("dbo.Services", new[] { "ServiceTypeId" });
            DropColumn("dbo.Services", "Price");
            DropColumn("dbo.Services", "DoctorId");
            DropColumn("dbo.Services", "PatientId");
            DropColumn("dbo.Services", "ServiceTypeId");
        }
    }
}
