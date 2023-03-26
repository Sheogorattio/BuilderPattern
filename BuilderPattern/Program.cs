﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Director().makeDaewoo(new Builder()).ToString());
            Console.ReadKey();
        }
    }
}
