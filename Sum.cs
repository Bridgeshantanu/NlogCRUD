using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNlog
{
    internal class Sum
    {
        Nlog nlog = new Nlog();
        public void Add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("a and b values are zero");
                nlog.LogError("a and b values are zero");
            }
            else
            {
                int c = a + b;
                Console.WriteLine("c=" + c);
                nlog.LogInfo("addition of" + a + "and" + b + "is=" + c);

            }
        }
    }
}
