using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        static int Points(int levels)
        {
           if (levels == 1)
                {return 1;}
           else
           {
               return levels + Points(levels - 1);
           }
        }
    }
}