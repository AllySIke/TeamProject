namespace TeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetterIGuess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favourites", "TaskOneRight", c => c.Int(nullable: false));
            AddColumn("dbo.Favourites", "TaskTwoRight", c => c.Int(nullable: false));
            AddColumn("dbo.Favourites", "TaskThreeRight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Favourites", "TaskThreeRight");
            DropColumn("dbo.Favourites", "TaskTwoRight");
            DropColumn("dbo.Favourites", "TaskOneRight");
        }
    }
}
