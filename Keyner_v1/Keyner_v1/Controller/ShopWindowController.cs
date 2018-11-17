using System;
using System.Collections.Generic;
using System.Linq;

namespace Keyner_v1.Controller
{
    public class ShopWindowController
    {
        Model.KeynerContext context;
        public int Index { get; set; }
        public Model.User CurrentUser { get; set; }

        public ShopWindowController()
        {
            Index = 0;
        }

        public List<MonsterItem> getUserMonsters()
        {
            using (context = new Model.KeynerContext())
            {
                return context.PurchaseSet.Where(p => p.Id_User == CurrentUser.Id).Join(
                    context.MonsterSet, p => p.Id_Monster, m => m.Id, (p, m) => new MonsterItem
                    {
                        Id_Monster = m.Id
                    }).ToList();
            }
        }

        public List<MonsterItem> getAllMonsters()
        {
            using (context = new Model.KeynerContext())
            {
                return context.MonsterSet.Join(context.ShopSet, m => m.Id, s => s.Id_Monster,
                                (m, s) => new MonsterItem
                                {
                                    Id_Monster = m.Id,
                                    Name = m.Name,
                                    Price = s.Cost,
                                }).ToList();
            }
        }

        //list of monsterItems
        public List<MonsterItem> getMonsterItems()
        {
            //list of all monsters in db
            List<MonsterItem> monsters = getAllMonsters();

            //list of CurrentUser`s bought monster(s)
            List<MonsterItem> bought = getUserMonsters();

            foreach (MonsterItem item in monsters.ToList())
            {
                if (bought.Contains(item))
                    item.IsBought = true;
            }

            return monsters;
        }

        private List<Model.MonsterLevel> MonsterImage(int id)
        {
            using (context = new Model.KeynerContext())
            {
                var list = context.MonsterLevelSet.Where(m => m.Id_Monster == id);

                return list.ToList();
            }
        }

        public List<byte[]> getListOfMonsterImages()
        {
            List<byte[]> list = new List<byte[]>();
            using (context = new Model.KeynerContext())
            {
                foreach (var item in context.MonsterSet)
                {
                    list.Add(MonsterImage(item.Id)[Index].NeutralImage);
                }
            }
            return list;
        }

        public bool BuyMonster(int id_monster)
        {
            try
            {
                using(context = new Model.KeynerContext())
                {
                    context.Database.ExecuteSqlCommand("insert into Purchases (Id_Monster, Id_User) values ({0}, {1})", id_monster, CurrentUser.Id);
                }
                return true;
            }
            catch { return false; }
        }

        public bool payForMonster(int money)
        {
            try
            {
                using (context = new Model.KeynerContext())
                {
                    context.Database.ExecuteSqlCommand("update Users set Money = {0} where Id = {1}", money, CurrentUser.Id);

                    CurrentUser.Money = context.UserSet.Find(CurrentUser.Id).Money;
                    return true;
                }
            }
            catch { return false; }
        }
    }

    public class MonsterItem : IEquatable<MonsterItem>
    {
        public int Id_Monster { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public int Price { get; set; }
        public bool IsBought { get; set; }

        public bool Equals(MonsterItem other)
        {
            return (Id_Monster == other.Id_Monster);
        }
    }
}
