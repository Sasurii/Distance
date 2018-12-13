using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public static class Distance
    {
        public static int distance(int a, int b)
        {
            if (a >= b)
            {
                return(a - b);
            }
            else
            {
                return(b - a);
            }
        }
    }
}
