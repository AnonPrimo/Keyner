﻿using Keyner_v1.Model;
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

        public List<Model.Group> GetGroupList()
        {
            using (keyCont = new KeynerContext())
            {
                return keyCont.GroupSet.ToList();
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
            using (keyCont = new KeynerContext())
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
        }

        public void AddUser(string name, string pass, int group)
        {
            using (keyCont = new KeynerContext())
            {
                User user = new User();
                user.Name = name;
                user.Password = pass;
                user.Id_Group = group;
                user.Id_Monster = keyCont.MonsterSet.Where(m => m.Name == "Monster1").ToList()[0].Id;
                user.Money = 500;

                keyCont.UserSet.Add(user);

                //Purchase purchase = new Purchase();
                //purchase.Id_Monster = user.Id_Monster;
                //purchase.Id_User = user.Id;
                //keyCont.PurchaseSet.Add(purchase);

                keyCont.SaveChanges();

                MakeFirstPurchase(user.Id, user.Id_Monster);
            }
        }

        //setting first user monster
        private void MakeFirstPurchase(int id_user, int id_monster)
        {
            using (keyCont = new KeynerContext())
            {
                Model.Purchase purchase = new Purchase();
                purchase.Id_Monster = id_monster;
                purchase.Id_User = id_user;

                keyCont.PurchaseSet.Add(purchase);
                keyCont.SaveChanges();
            }
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

        public bool CheckName(string name)
        {
            using (keyCont = new KeynerContext())
            {
                foreach (var item in keyCont.UserSet.ToList())
                {
                    if (item.Name == name)
                        return true;
                }
                return false;
            }
        }
    }
}
