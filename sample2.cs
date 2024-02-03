using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample2
    {
        public static void Main(string[] args)
        {
             //impliclit tye casting//
            //int x = 40;
           // double y = x;
            
            //exclipt type casting//
            double x = 40.43;
            int y = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
