﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiv.Mpg123.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string decoder in Mpg123.Decoders)
            {
                Console.WriteLine(decoder);
            }

            Console.ReadLine();
        }
    }
}
