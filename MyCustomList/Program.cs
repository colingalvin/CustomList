﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<char> list = new CustomList<char>();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
        }
    }
}
