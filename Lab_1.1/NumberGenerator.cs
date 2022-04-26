using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1._1
{
    public class NumberGenerator
    {
        public int Generate()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
    }
}
