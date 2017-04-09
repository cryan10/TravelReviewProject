namespace TravelReviewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelID = c.Int(nullable: false, identity: true),
                        HotelLocation = c.String(),
                    })
                .PrimaryKey(t => t.HotelID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ReviewComment = c.String(),
                        HotelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .Index(t => t.HotelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "HotelID", "dbo.Hotels");
            DropIndex("dbo.Users", new[] { "HotelID" });
            DropTable("dbo.Users");
            DropTable("dbo.Hotels");
        }
    }
}
