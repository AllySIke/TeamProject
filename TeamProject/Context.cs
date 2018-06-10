using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.UserData;

namespace TeamProject
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Hieroglyph> Hieroglyphs { get; set; }

        public Context() : base("localbase")
        {

        }
    }
}
