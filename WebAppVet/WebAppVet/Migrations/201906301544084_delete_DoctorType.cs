namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_DoctorType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "DoctorType", c => c.Int(nullable: false));
            DropTable("dbo.DoctorTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DoctorTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Doctors", "DoctorType");
        }
    }
}
