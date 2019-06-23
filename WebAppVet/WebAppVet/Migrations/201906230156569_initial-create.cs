namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Document = c.String(nullable: false, maxLength: 50),
                        TypeDocument = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        MobilePhone = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        SpeciesId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Species", t => t.SpeciesId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.SpeciesId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomTypeId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Location = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeId, cascadeDelete: true)
                .Index(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.RoomTypes",
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
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "SpeciesId", "dbo.Species");
            DropForeignKey("dbo.Rooms", "RoomTypeId", "dbo.RoomTypes");
            DropForeignKey("dbo.Patients", "ClientId", "dbo.Clients");
            DropIndex("dbo.Rooms", new[] { "RoomTypeId" });
            DropIndex("dbo.Patients", new[] { "SpeciesId" });
            DropIndex("dbo.Patients", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "Email" });
            DropTable("dbo.Species");
            DropTable("dbo.Services");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
            DropTable("dbo.Doctors");
            DropTable("dbo.Patients");
            DropTable("dbo.Clients");
        }
    }
}
