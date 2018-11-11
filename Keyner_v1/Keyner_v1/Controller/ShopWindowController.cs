using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Keyner_v1.Controller
{
    public class ShopWindowController
    {
        Model.KeynerContext context;
        public List<MonsterItem> monsterList { get; set; }
        public Model.User CurrentUser { get; set; }

        public ShopWindowController()
        {
            context = new Model.KeynerContext();
            monsterList = new List<MonsterItem>();
            fillMonsterList();
        }

        public List<Model.Monster> getMonsters()
        {
          return context.MonsterSet.ToList();
        }

        public List<Model.Monster> getUserMonsters()
        {
            return context.MonsterSet.Where(m=>m.Id == CurrentUser.Id_Monster).ToList();
        }

        private void fillMonsterList()
        {
            List<Model.Monster> user = getUserMonsters();
            List<Model.Monster> all = getMonsters();

            for(int i = 0; i < all.Count; i++)
            {
                monsterList.Add(new MonsterItem() { Name = all[i].Name });
                if (user.Contains(all[i]))
                    monsterList.Last().IsBought = true;
            }
        }

    }

    public class MonsterItem
    {
        public string Name { get; set; }
        public BitmapImage Image { get; set; }
        public int Price { get; set; }
        public bool IsBought { get; set; }
    }
}
