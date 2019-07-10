namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_WorkDay_DoctorId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkDays", "DoctorId", c => c.Int(nullable: false));
            CreateIndex("dbo.WorkDays", "DoctorId");
            AddForeignKey("dbo.WorkDays", "DoctorId", "dbo.Doctors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkDays", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.WorkDays", new[] { "DoctorId" });
            DropColumn("dbo.WorkDays", "DoctorId");
        }
    }
}
