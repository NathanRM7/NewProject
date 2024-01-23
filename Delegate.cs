using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPp
{
   public class Example 
    {
        public delegate int callExample(int a);

        public int checkType(callExample a)
        {
            return a(5)*5;
        }

    }
}
