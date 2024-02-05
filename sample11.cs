using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample11
    {
        public static void Main()
        {
            double cartValue = 0;
        start:
            Console.WriteLine("select Item:");
            Console.WriteLine("1.Oneplus\n2.Iphone13 Pro\n3.Samsung\n4.Oppo\n5.Realme");
            int itemchoice = Convert.ToInt32(Console.ReadLine());

            switch (itemchoice)
            {
                case 1:
                    cartValue = cartValue + 45000;
                    break;
                case 2:
                    cartValue = cartValue + 78000;
                    break;
                case 3:
                    cartValue = cartValue + 30000;
                    break;
                case 4:
                    cartValue = cartValue + 18000;
                    break;
                case 5:
                    cartValue= cartValue + 23000;
                    break;
                default:
                    Console.WriteLine("Enter only product range from 1-5");
                    goto start;
            }
            Console.WriteLine(cartValue);

        }
    }
    }

