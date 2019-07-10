namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_WorkDay_1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorkDays", "Day");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkDays", "Day", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
