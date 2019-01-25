using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyner_v1.Model;

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

            context = new KeynerContext();
            currentTest = context.TestSet.Find(test_id);
            //myMethod();

        }

        public string GetText()
        {
            collection.Clear();
            text = currentTest.Text;
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

        ///time!!!!     ще не проходили тест - створюємо статистику
        public void FillNewStatistic(int id_user, int time, bool is_passed, int mistakes, int mark)
        {
            Statistic statistic = new Statistic();
            
            statistic.Id_User = id_user;
            statistic.Id_Test = currentTest.Id;
            statistic.Time = time;
            statistic.Mark = mark;
            statistic.IsPassed = is_passed;
            statistic.CountMistakes = mistakes;
            ///найкращий час в тесті
            BesTime(time);

            context.StatisticSet.Add(statistic);
            context.SaveChanges();

        }

        ///якщо тест вже існує апдейтимо його статистику 
        public void UpdateStatisctic(int time, int mistakes, int mark)
        {
            Statistic statistic = context.StatisticSet.Find(currentTest.Id);

            if(time <= statistic.Time && mistakes <= statistic.CountMistakes && mark >= statistic.Mark)
            {
                statistic.Time = time;
                statistic.Mark = mark;
                statistic.CountMistakes = mistakes;

                ///найкращий час в тесті
                BesTime(time);

                context.SaveChanges();
            }
        }


        ///фігня
        /*
        private bool TestCheck(int id_us, int id_test)
        {
            return context.StatisticSet.Where(st => st.Id_User == id_us && st.Id_Test == id_test).ToList().Count == 1;
        }
        */

            ///найкращий час в тесті
        private void BesTime(int time)
        {
            if (currentTest.BestTime > time)
            {
                context.TestSet.Where(t => t.Id == currentTest.Id).First().BestTime = time;
                context.SaveChanges();
            }

        }
    }
}
