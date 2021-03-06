﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyner_v1.Model;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Keyner_v1.Controller
{


    class TestController
    {
        public string CurrentStr { get; set; }
        public int RepeatCount { get; set; }
        public static List<Char> collection = new List<Char>();
        public Test currentTest;

        KeynerContext context;

        string text;

        public TestController(int test_id)
        {
            GetCurrentTest(test_id);
            //myMethod();

        }

        private void GetCurrentTest(int id)
        {
            using (context = new KeynerContext())
            {
                currentTest = context.TestSet.Find(id);
            }
        }

        public string GetText()
        {
            collection.Clear();
            using (context = new KeynerContext())
            {
                text = currentTest.Text;
            }
                //RepeatCount = 3;
                //for (int i = 0; i < RepeatCount; i++)
                //{
                for (int j = 0; j < text.Length; j++)
                {
                    collection.Add(text[j]);
                }
                //}
                return text;
            
        }

        public void myMethod()
        {
            collection.Clear();
            //CurrentStr = "а а а о о";
            //RepeatCount = 3;
            foreach (var item in context.TestSet)
            {

                CurrentStr = item.Text.ToString();
                RepeatCount = 3;
                break;
            }

            for (int i = 0; i < RepeatCount; i++)
            {
                for (int j = 0; j < CurrentStr.Length; j++)
                {
                    collection.Add(CurrentStr[j]);
                }
            }
        }

        ///finishTime!!!!     ще не проходили тест - створюємо статистику
        public void FillNewStatistic(int id_user, int time, bool is_passed, int mistakes, int mark)
        {
            Statistic statistic = new Statistic();
            
            statistic.Id_User = id_user;
            statistic.Id_Test = currentTest.Id;
            statistic.Time = time;
            statistic.Mark = mark;
            statistic.IsPassed = is_passed;
            statistic.CountMistakes = mistakes;
            ///найкращий час в пройденому тесті
            if (is_passed)
            {
                BesTime(time);
                SetUserMoney(id_user, mark);
            }
            using (context = new KeynerContext())
            {
                context.StatisticSet.Add(statistic);
                context.SaveChanges();
            }
        }

        ///якщо тест вже існує апдейтимо його статистику 
        public void UpdateStatisctic(int id_user, int time, int mistakes, int mark, bool is_passed)
        {
            Statistic statistic;
            using (context = new KeynerContext())
            {
                statistic = context.StatisticSet.Where(s => s.Id_User == id_user && s.Id_Test == currentTest.Id).ToList()[0];

                if (!statistic.IsPassed && is_passed)
                {
                    //якщо тест був не пройденний і ми його пройшли
                    statistic.IsPassed = is_passed;
                    statistic.Time = time;
                    statistic.Mark = mark;
                    statistic.CountMistakes = mistakes;
                    context.SaveChanges();

                    BesTime(time);
                    SetUserMoney(id_user, mark);
                }
                else if (time <= statistic.Time && mistakes <= statistic.CountMistakes && mark >= statistic.Mark)
                {
                    statistic.Time = time;
                    statistic.Mark = mark;
                    statistic.CountMistakes = mistakes;
                    context.SaveChanges();

                    ///найкращий час в пройденому тесті
                    if (is_passed)
                        BesTime(time);
                }
            }
        }
        
        ///найкращий час в тесті
        private void BesTime(int time)
        {
            if (currentTest.BestTime > time || currentTest.BestTime == 0)
            {
                using (context = new KeynerContext())
                {
                    context.TestSet.Where(t => t.Id == currentTest.Id).First().BestTime = time;
                    context.SaveChanges();
                }
            }
        }

        public int GetMoney(int mark)
        {
            switch (mark)
            {
                case 1:
                    return 100;
                case 2:
                    return 200;
                case 3:
                    return 300;
                default:
                    return 0;
            }
        }

        private void SetUserMoney(int id_us, int mark)
        {
            using (context = new KeynerContext())
            {
                User user = context.UserSet.Find(id_us);
                user.Money += GetMoney(mark);

                context.SaveChanges();
            }
        }

        public BitmapImage GetMonster(int id_user, int mood)
        {
            BitmapImage im = new BitmapImage();
            User user;
            MonsterLevel currentMonster;

            using (context = new KeynerContext())
            {
                user = context.UserSet.Find(id_user);
                currentMonster = context.MonsterLevelSet.Where(m => m.Id_Monster == user.Id_Monster).ToList()[0];
                
            }
            switch (mood)
            {
                case 1:
                    return ImageConvert.Convert(currentMonster.HappyImage);
                case 2:
                    return ImageConvert.Convert(currentMonster.NeutralImage);
                case 3:
                    return ImageConvert.Convert(currentMonster.ReadyImage);
                case 4:
                    return ImageConvert.Convert(currentMonster.SadImage);
                default:
                    return ImageConvert.Convert(currentMonster.NeutralImage);
            }
        }

        public int GetSpeed(int id_user, int finishTime)
        {
            int time = finishTime;
            int count = 1;
            List<Statistic> statistic;

            using (context = new KeynerContext())
            { statistic = context.StatisticSet.Where(s => s.Id_User == id_user && s.Id_Test == currentTest.Id).ToList(); }

            foreach (var item in statistic)
            {
                time += item.Time;
                count++;
            }
            return time / count;
        }
    }
}
