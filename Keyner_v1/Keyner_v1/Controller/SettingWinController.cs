using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Controller
{
    class SettingWinController
    {
        Model.KeynerContext context;

        public bool CurrentPassCheck(int idUser, string pass)
        {
            using (context = new Model.KeynerContext())
            {
                Model.User user = context.UserSet.Find(idUser);
                if (user.Password == pass)
                    return true;
                else
                    return false;
            }
        }

        public string GetPass(int id)
        {
            using (context = new Model.KeynerContext())
            {
                Model.User user = context.UserSet.Find(id);
                return user.Password;
            }
        }

        public void PasswordChange(int idUser, string newpass)
        {
            using (context = new Model.KeynerContext())
            {
                Model.User user = context.UserSet.Find(idUser);
                user.Password = newpass;
                context.SaveChanges();
            }
        }

        public void DeleteUserInfo(int id)
        {
            using (context = new Model.KeynerContext())
            {
                context.StatisticSet.RemoveRange(context.StatisticSet.Where(s => s.Id_User == id));
                context.PurchaseSet.RemoveRange(context.PurchaseSet.Where(p => p.Id_User == id));

                Model.User user = context.UserSet.Find(id);
                user.Money = 500;
                user.Id_Monster = context.MonsterSet.Where(m => m.Name == "Monster1").First().Id;

                context.SaveChanges();
            }
        }

    }
}
