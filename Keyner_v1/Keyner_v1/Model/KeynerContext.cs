using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Model
{
    class KeynerContext : DbContext
    {
        public KeynerContext() : base("KeynerContext")
        {

        }

        public DbSet<User> UserSet { get; set; }
        public DbSet<Test> TestSet { get; set; }
        public DbSet<Purchase> PurchaseSet { get; set; }
        public DbSet<Monster> MonsterSet { get; set; }
        public DbSet<Shop> ShopSet { get; set; }
        public DbSet<Statistic> StatisticSet { get; set; }
        public DbSet<MonsterLevel> MonsterLevelSet { get; set; }

    }
}
