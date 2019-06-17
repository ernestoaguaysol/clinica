namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Patients", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Patients", "SpeciesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Patients", "SpeciesId");
            AddForeignKey("dbo.Patients", "SpeciesId", "dbo.Species", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "SpeciesId", "dbo.Species");
            DropIndex("dbo.Patients", new[] { "SpeciesId" });
            DropColumn("dbo.Patients", "SpeciesId");
            DropColumn("dbo.Patients", "Birthdate");
            DropTable("dbo.Species");
        }
    }
}
