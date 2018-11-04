using Keyner_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Controller
{
    class AutorizAndRegistr
    {
        KeynerContext keyCont;

        public AutorizAndRegistr()
        {
            keyCont = new KeynerContext();
        }

        public bool GetPass(int id, string p)
        {
            foreach (var item in keyCont.UserSet)
            {
                if (item.Id == id)
                {
                    if (item.Password == p)
                        return true;
                }
            }
            return false;
        }

        public void AddUser(string name, string pass, string pp, int group)
        {
            if (pp == pass)
            {
                User user = new User();
                user.Name = name;
                user.Password = pass;
                user.Id_Group = group;
                user.Id_Monster = 1;
                user.Money = 0;

                keyCont.UserSet.Add(user);
                keyCont.SaveChanges();
            }
        }



    }
}
