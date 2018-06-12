namespace TeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InProcess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favourites", "Hieroglyph_Id", c => c.Int());
            AddColumn("dbo.Favourites", "UserMail_Id", c => c.Int());
            AlterColumn("dbo.Favourites", "TaskOneRight", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Favourites", "TaskTwoRight", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Favourites", "TaskThreeRight", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Favourites", "Hieroglyph_Id");
            CreateIndex("dbo.Favourites", "UserMail_Id");
            AddForeignKey("dbo.Favourites", "Hieroglyph_Id", "dbo.Hieroglyphs", "Id");
            AddForeignKey("dbo.Favourites", "UserMail_Id", "dbo.Users", "Id");
            DropColumn("dbo.Favourites", "UserMail");
            DropColumn("dbo.Favourites", "Hieroglyph");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Favourites", "Hieroglyph", c => c.String());
            AddColumn("dbo.Favourites", "UserMail", c => c.String());
            DropForeignKey("dbo.Favourites", "UserMail_Id", "dbo.Users");
            DropForeignKey("dbo.Favourites", "Hieroglyph_Id", "dbo.Hieroglyphs");
            DropIndex("dbo.Favourites", new[] { "UserMail_Id" });
            DropIndex("dbo.Favourites", new[] { "Hieroglyph_Id" });
            AlterColumn("dbo.Favourites", "TaskThreeRight", c => c.Int(nullable: false));
            AlterColumn("dbo.Favourites", "TaskTwoRight", c => c.Int(nullable: false));
            AlterColumn("dbo.Favourites", "TaskOneRight", c => c.Int(nullable: false));
            DropColumn("dbo.Favourites", "UserMail_Id");
            DropColumn("dbo.Favourites", "Hieroglyph_Id");
        }
    }
}
