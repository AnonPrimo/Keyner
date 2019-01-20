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

        KeynerContext context;

        string text;

        public TestController()
        {

            context = new KeynerContext();
            myMethod();

        }

        public string GetText(int test_id)
        {
            Model.Test test = context.TestSet.Where(x => test_id == x.Id).ToList()[0];
            text = test.Text;
            return text;
        }

        public void myMethod()
        {
            //CurrentStr = "а а а о о";
            //RepeatCount = 3;
            foreach (var item in context.TestSet)
            {

                CurrentStr = item.Text.ToString();
                RepeatCount = 3;
                break;
            }

            /*for (int i = 0; i < RepeatCount; i++)
            {
                for (int j = 0; j < CurrentStr.Length; j++)
                {
                    collection.Add(CurrentStr[j]);
                }
            }*/

            for (int i = 0; i < RepeatCount; i++)
            {
                for (int j = 0; j < CurrentStr.Length; j++)
                {
                    collection.Add(CurrentStr[j]);
                }
            }
        }

        //public List<Char> GetCollection()
        //{
        //    return collection;
        //}
    }
}
