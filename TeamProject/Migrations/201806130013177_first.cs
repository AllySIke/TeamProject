namespace TeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favourites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserMail = c.String(),
                        Hieroglyph = c.String(),
                        TaskOneRight = c.Boolean(nullable: false),
                        TaskTwoRight = c.Boolean(nullable: false),
                        TaskThreeRight = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hieroglyphs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChineseWord = c.String(),
                        Pinyin = c.String(),
                        Translation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Hieroglyphs");
            DropTable("dbo.Favourites");
        }
    }
}
