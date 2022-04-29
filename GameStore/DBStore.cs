using System.Data.Entity;
using GameStore.Model;

namespace GameStore
{
    class DBStore : DbContext
    {
        public DBStore()
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
