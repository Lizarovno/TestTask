namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewSkills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "User_UserID", "dbo.Users");
            DropIndex("dbo.Skills", new[] { "User_UserID" });
            DropTable("dbo.Skills");
        }
    }
}
