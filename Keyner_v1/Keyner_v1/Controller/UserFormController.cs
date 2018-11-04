using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
            CurrentUser = db.UserSet.Find(id);
            UserTest = new List<UserTests>();
            fillUserTest();
        }

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

        private void fillUserTest()
        {
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

        public byte[] getMonsterImage()
        {
            foreach(var item in db.MonsterLevelSet)
            {
                if (item.Id_Monster == CurrentUser.Id_Monster)
                    return item.Image;
            }
            return null;
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
