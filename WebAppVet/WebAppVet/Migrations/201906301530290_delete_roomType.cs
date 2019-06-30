namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_roomType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "RoomTypeId", "dbo.RoomTypes");
            DropIndex("dbo.Rooms", new[] { "RoomTypeId" });
            AddColumn("dbo.Rooms", "RoomType", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "RoomTypeId");
            DropTable("dbo.RoomTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rooms", "RoomTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "RoomType");
            CreateIndex("dbo.Rooms", "RoomTypeId");
            AddForeignKey("dbo.Rooms", "RoomTypeId", "dbo.RoomTypes", "Id", cascadeDelete: true);
        }
    }
}
