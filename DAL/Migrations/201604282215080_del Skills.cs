namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delSkills : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Skills", "User_UserID", "dbo.Users");
            DropIndex("dbo.Skills", new[] { "User_UserID" });
            DropTable("dbo.Skills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID);
            
            CreateIndex("dbo.Skills", "User_UserID");
            AddForeignKey("dbo.Skills", "User_UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
