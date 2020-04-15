using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProject
{
    public class MyClass
    {
        public double power(int x, int y)
        {
            double power = 1;
            for (int i = 1; i <= y; i++)
                power *= x;
            return power;
        }
    }
}
