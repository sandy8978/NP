﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample19
    {
        public static void Main()
        {
            string[,] strArray = new string[2, 4] { { "C#.Net", "VB.Net", "J#.Net", "F#.Net" }, { "HTML", "CSS", "Javascript", "Bootstrap" } };
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine(strArray[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
