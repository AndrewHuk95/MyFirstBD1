using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    static class AgeGenerator
    {
        const int MinAge = 10;
        const int MaxAge = 100;
        static Random random = new Random();
        public static int CreateAge()
        {
            return random.Next(MinAge, MaxAge);
        }

    }
}
