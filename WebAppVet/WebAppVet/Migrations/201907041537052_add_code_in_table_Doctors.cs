namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_code_in_table_Doctors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Code", c => c.Int(nullable: false));
            AlterColumn("dbo.Doctors", "Email", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Doctors", "Code", unique: true);
            CreateIndex("dbo.Doctors", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Doctors", new[] { "Email" });
            DropIndex("dbo.Doctors", new[] { "Code" });
            AlterColumn("dbo.Doctors", "Email", c => c.String());
            DropColumn("dbo.Doctors", "Code");
        }
    }
}
