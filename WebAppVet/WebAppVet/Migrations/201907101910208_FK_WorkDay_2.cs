namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_WorkDay_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkDays", "Day", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkDays", "Day");
        }
    }
}
