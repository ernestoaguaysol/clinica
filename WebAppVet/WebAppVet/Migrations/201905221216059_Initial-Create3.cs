namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Rooms", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Rooms", "Location", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Location", c => c.String());
            AlterColumn("dbo.Rooms", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
        }
    }
}
