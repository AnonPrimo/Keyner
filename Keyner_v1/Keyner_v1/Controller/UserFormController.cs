using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Keyner_v1.Controller
{
    class UserFormController
    {
        Model.KeynerContext db;
        public Model.User CurrentUser { get; set; }
        public List<UserTests> UserTest { get; set; }

        public UserFormController(int id)
        {
            db = new Model.KeynerContext();
            CurrentUser = getUser(id);
            UserTest = new List<UserTests>();
            //fillUser();
            fillUserLocal();
        }

        public Model.User getUser(int id)
        {
            //return db.UserSet.Find(id);


            //test
            return new Model.User();
        }


        //user tests
        public List<Model.Statistic> getUserTests()
        {
            List<Model.Statistic> stat = new List<Model.Statistic>();

            foreach(var item in db.StatisticSet)
            {
                if (item.Id_User == CurrentUser.Id)
                    stat.Add(item);
            }

            return stat;
        }

        private void fillUser()
        {
            //list of all tests
            foreach(var item in db.TestSet)
            {
                UserTest.Add(new UserTests() { TestName = "Тест №"+item.Id, BestTime = item.BestTime});
            }

            List<Model.Statistic> tmp = getUserTests();
            for(int i = 0; i < tmp.Count; i++)
            {
                UserTest[i].Mark = tmp[i].Mark;
                UserTest[i].Mistakes = tmp[i].CountMistakes;
                UserTest[i].Time = tmp[i].Time;
                UserTest[i].IsPassed = tmp[i].IsPassed;
           }
        }

        //test
        private void fillUserLocal()
        {
          
            for (int i = 0; i < 5; i++)
            {
                UserTest.Add(new UserTests()
                {
                    TestName = "TestName" + i,
                    BestTime = DateTime.Now.Minute,
                    Mark = i * i ^ 4,
                    Mistakes = i + (i << 5),
                    IsPassed = false
                });
            }
        }

        private byte[] getMonsterImageByteArray()
        {
            foreach(var item in db.MonsterLevelSet)
            {
                if (item.Id_Monster == CurrentUser.Id_Monster)
                    return item.Image;
            }
            return null;
        }

        public bool getMonsterImage(ref BitmapImage image)
        {
            var imageData = getMonsterImageByteArray();
            if (imageData == null || imageData.Length == 0) return false;

            image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return true;
        }

    }

    class UserTests
    {
        public string TestName { get; set; }
        public int BestTime { get; set; }
        public int Mark { get; set; }
        public int Time { get; set; }
        public int Mistakes { get; set; }
        public bool IsPassed { get; set; }
    }
}
