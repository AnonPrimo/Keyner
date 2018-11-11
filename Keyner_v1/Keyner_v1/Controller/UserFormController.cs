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
            //fillUserTests();
            //test
            fillUserLocal();
        }

        public Model.User getUser(int id)
        {
            //return db.UserSet.Find(id);

            //test
            return new Model.User() { Name = "Lastname Firstname"};
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

        private void fillUserTests()
        {
            //list of all tests
            foreach(var item in db.TestSet)
            {
                UserTest.Add(new UserTests() { TestName = "Тест №"+item.Id, BestTime = item.BestTime});
            }

            List<Model.Statistic> tmp = getUserTests();
            for(int i = 0; i < tmp.Count; i++)
            {
                UserTest[i].Mark = SetMarkStar(tmp[i].Mark);
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
                    Mark = SetMarkStar(i),
                    Mistakes = i + (i << 5),
                    IsPassed = false
                });
            }
        }

        //mark images
        private BitmapImage SetMarkStar(int mark)
        {
            BitmapImage im;
            switch (mark){
                case 1:
                    im = new BitmapImage(new Uri("/Pictures/gold_star1.png", UriKind.Relative));
                    break;
                case 2:
                    im = new BitmapImage(new Uri("/Pictures/gold_star2.png", UriKind.Relative));
                    break;
                case 3:
                    im = new BitmapImage(new Uri("/Pictures/gold_star3.png", UriKind.Relative));
                    break;
                default:
                    im = new BitmapImage(new Uri("/Pictures/grey_star3.png", UriKind.Relative));
                    break;
            }
            return im;
        }

        //get byte array from db
        private byte[] getMonsterImageByteArray()
        {
            return db.MonsterLevelSet.Find(CurrentUser.Id_Monster).NeutralImage??null;
        }

        //test
        private byte[] getMonsterImageTest()
        {
            return null;
        }

        //convert byte array to bitmap image
        public bool getMonsterImage(ref BitmapImage image)
        {
            //var imageData = getMonsterImageByteArray();

            //test
            var imageData = getMonsterImageTest();

            if (imageData == null || imageData.Length == 0) return false;

            image = ImageConvert.Convert(imageData);
            return true;
        }

        class ImageConvert
        {
            public static BitmapImage Convert(byte[] array)
            {
                BitmapImage image = new BitmapImage();
                using (var mem = new MemoryStream(array))
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
                return image;
            }
        }
    }

    class UserTests
    {
        public string TestName { get; set; }
        public int BestTime { get; set; }
        public BitmapImage Mark { get; set; }
        public int Time { get; set; }
        public int Mistakes { get; set; }
        public bool IsPassed { get; set; }
    }
}
