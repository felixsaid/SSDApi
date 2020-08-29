namespace SSDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        ChildrenId = c.Int(nullable: false, identity: true),
                        ChildrenNumber = c.Int(nullable: false),
                        UsserId = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ChildrenId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        phone = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Households",
                c => new
                    {
                        HouseholdId = c.Int(nullable: false, identity: true),
                        HeadName = c.String(),
                        FuncionalToilet = c.Boolean(nullable: false),
                        UsserId = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.HouseholdId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Households", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Children", "User_UserId", "dbo.Users");
            DropIndex("dbo.Households", new[] { "User_UserId" });
            DropIndex("dbo.Children", new[] { "User_UserId" });
            DropTable("dbo.Households");
            DropTable("dbo.Users");
            DropTable("dbo.Children");
        }
    }
}
