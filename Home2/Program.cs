﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine("This is branch");
        }
    }
}