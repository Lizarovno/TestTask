namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        EducationID = c.Int(nullable: false, identity: true),
                        Institution = c.String(nullable: false),
                        Specialty = c.String(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        Diplome_ImageID = c.Int(),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EducationID)
                .ForeignKey("dbo.SavedImages", t => t.Diplome_ImageID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Diplome_ImageID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.SavedImages",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false),
                        Project_ProjectID = c.Int(),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID)
                .Index(t => t.Project_ProjectID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        FamilyName = c.String(nullable: false),
                        Patronymic = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        AboutMe = c.String(),
                        Phone = c.String(),
                        Skype = c.String(),
                        Address = c.String(),
                        Avatar_ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.SavedImages", t => t.Avatar_ImageID)
                .Index(t => t.Avatar_ImageID);
            
            CreateTable(
                "dbo.Expiriences",
                c => new
                    {
                        ExpID = c.Int(nullable: false, identity: true),
                        Company = c.String(nullable: false),
                        Post = c.String(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Descriotion = c.String(),
                        ProjectURL = c.String(),
                        Avatar_ImageID = c.Int(),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.SavedImages", t => t.Avatar_ImageID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Avatar_ImageID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.String(nullable: false, maxLength: 128),
                        SkillName = c.String(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Educations", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Skills", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Projects", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.SavedImages", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Projects", "Avatar_ImageID", "dbo.SavedImages");
            DropForeignKey("dbo.Expiriences", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "Avatar_ImageID", "dbo.SavedImages");
            DropForeignKey("dbo.Educations", "Diplome_ImageID", "dbo.SavedImages");
            DropIndex("dbo.Skills", new[] { "User_UserID" });
            DropIndex("dbo.Projects", new[] { "User_UserID" });
            DropIndex("dbo.Projects", new[] { "Avatar_ImageID" });
            DropIndex("dbo.Expiriences", new[] { "User_UserID" });
            DropIndex("dbo.Users", new[] { "Avatar_ImageID" });
            DropIndex("dbo.SavedImages", new[] { "Project_ProjectID" });
            DropIndex("dbo.Educations", new[] { "User_UserID" });
            DropIndex("dbo.Educations", new[] { "Diplome_ImageID" });
            DropTable("dbo.Skills");
            DropTable("dbo.Projects");
            DropTable("dbo.Expiriences");
            DropTable("dbo.Users");
            DropTable("dbo.SavedImages");
            DropTable("dbo.Educations");
        }
    }
}
