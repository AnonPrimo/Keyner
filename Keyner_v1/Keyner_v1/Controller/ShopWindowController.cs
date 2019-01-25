using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                SetMonsterImage(item);
                if (bought.Contains(item))
                    item.IsBought = true;
            }

            return monsters;
        }

        //get list of all certain monster images by monsterID
        public List<Model.MonsterLevel> MonsterImage(int id)
        {
            using (context = new Model.KeynerContext())
            {
                var list = context.MonsterLevelSet.Where(m => m.Id_Monster == id);

                return list.ToList();
            }
        }

        //filling image in monsterItem instance
        public void SetMonsterImage(MonsterItem mitem)
        {
            List<Model.MonsterLevel> tmp = MonsterImage(mitem.Id_Monster);

            Model.MonsterLevel mlevel = tmp[Index];
            mitem.Image = mlevel.NeutralImage;
        }

        public bool BuyMonster(int id_monster)
        {
            try
            {
                using(context = new Model.KeynerContext())
                {
                    Model.Purchase p = new Model.Purchase();
                    p.Id_Monster = id_monster;
                    p.Id_User = CurrentUser.Id;
                    context.PurchaseSet.Add(p);
                    context.SaveChanges();
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
                    context.UserSet.Find(CurrentUser.Id).Money -= money;
                    context.SaveChanges();

                    CurrentUser = context.UserSet.Find(CurrentUser.Id);
                    return true;
                }
            }
            catch { return false; }
        }

        public void SetMainMonster(int idMon)
        {
            using (context = new Model.KeynerContext())
            {
                Model.User user = context.UserSet.Find(CurrentUser.Id);
                user.Id_Monster = idMon;
                CurrentUser = user;
                context.SaveChanges();
            }
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
