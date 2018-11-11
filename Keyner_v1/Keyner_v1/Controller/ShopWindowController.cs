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
        public List<MonsterItem> monsterList { get; set; }
        public Model.User CurrentUser { get; set; }

        public ShopWindowController()
        {
            monsterList = new List<MonsterItem>();
        }



    }

    public class MonsterItem
    {
        
        public BitmapImage Image { get; set; }
        public int Price { get; set; }
    }
}
