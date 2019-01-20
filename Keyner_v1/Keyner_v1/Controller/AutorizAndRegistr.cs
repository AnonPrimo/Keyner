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
        //View.Autorization autor;

        public AutorizAndRegistr()
        {
            //keyCont = new KeynerContext();
            //autor = new View.Autorization();
        }

        public bool GetPass(int id, string p)
        {
            using(keyCont = new KeynerContext())
            {
                Model.User user = keyCont.UserSet.Find(id);
                if (user.Password == p)
                    return true;
                else
                    return false;
            }
        }

        public int GetIdUserTest(string name, string pass, View.Autorization viv)
        {
            foreach (var item in viv.user)
            {
                if (item.Name == name)
                {
                    if (item.Password == pass)
                        return item.Id;
                }
            }
            return 0;
        }


        public int GetIdUser(string name, string pass)
        {
            foreach (var item in keyCont.UserSet)
            {
                if (item.Name == name)
                {
                    if (item.Password == pass)
                        return item.Id;
                }
            }
            return 0;
        }

        public void AddUser(string name, string pass, int group)
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


        public void AddUserTest(string name, string pass, int group, List<Model.User> us)
        {
            User user = new User();
            user.Name = name;
            user.Password = pass;
            user.Id_Group = group;
            user.Id_Monster = 1;
            user.Money = 0;

            us.Add(user);
        }

        public bool GetPassTest(int id, string p, View.Autorization viv)
        {
            foreach (var item in viv.user)
            {
                if (item.Id == id)
                {
                    if (item.Password == p)
                        return true;
                }
            }
            return false;
        }

    }
}
