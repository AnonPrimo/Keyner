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
        public int CurrentLevel { get; set; }
        Model.KeynerContext context;
        public List<MonsterItem> monsterList { get; set; }
        public Model.User CurrentUser { get; set; }

        public ShopWindowController()
        {
            context = new Model.KeynerContext();
            monsterList = new List<MonsterItem>();
            CurrentLevel = context.MonsterLevelSet CurrentUser.
        }

        private void getMonsters()
        {
            foreach(var item in context.MonsterSet)
            {
                monsterList.Add(new MonsterItem());
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
