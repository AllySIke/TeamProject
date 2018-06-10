namespace TeamProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamProject.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamProject.Context context)
        {
            context.Hieroglyphs.AddOrUpdate(
                new Hieroglyph()
                {
                    ChineseWord = "Œ“",
                    Pinyin = "w®Ø",
                    Translation = "me"
                });


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
