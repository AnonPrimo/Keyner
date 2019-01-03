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

        public void PasswordChange(int idUser, string newpass)
        {
            using (context = new Model.KeynerContext())
            {
                Model.User user = context.UserSet.Find(idUser);
                user.Password = newpass;
                context.SaveChanges();
            }
        }
    }
}
