namespace Crowdsourcing.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        PhoneNumber = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                        SubscriptionDate = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Pseudo = c.String(nullable: false, maxLength: 25),
                        EnterpriseName = c.String(nullable: false, maxLength: 25),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                        SubscriptionDate = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Pseudo = c.String(nullable: false, maxLength: 25),
                        ManagerId = c.Int(),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Managers", t => t.ManagerId)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        ManagerId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Managers", t => t.ManagerId)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        ManagerId = c.Int(nullable: false),
                        ProjectName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        LogoUrl = c.String(),
                        WelcomeText = c.String(),
                        TemplateColor = c.String(),
                        FormatText = c.String(),
                    })
                .PrimaryKey(t => t.ManagerId)
                .ForeignKey("dbo.Managers", t => t.ManagerId)
                .Index(t => t.ManagerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Templates", "ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Products", "ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Members", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Templates", new[] { "ManagerId" });
            DropIndex("dbo.Products", new[] { "ManagerId" });
            DropIndex("dbo.Members", new[] { "ManagerId" });
            DropTable("dbo.Templates");
            DropTable("dbo.Products");
            DropTable("dbo.Members");
            DropTable("dbo.Managers");
        }
    }
}
