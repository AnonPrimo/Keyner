using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Controller
{
    

    class TestController
    {
        public string CurrentStr { get; set; }
        public int RepeatCount { get; set; }
       public static List<Char> collection = new List<Char>();

        public TestController()
        {
            myMethod();
        }

        public void myMethod()
        {
            CurrentStr = "а а а о о";
            RepeatCount = 3;

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
