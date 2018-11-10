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

        public TestController()
        {
            myMethod();
        }

        public void myMethod()
        {
            CurrentStr = "a а а а а а а о о о о о о о о";
            RepeatCount = 3;
        }
        
    }
}
