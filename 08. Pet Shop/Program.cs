using System;
using System.Reflection.Metadata;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dog = 2.50;
            int cat = 4;
            int opakDogs = int.Parse(Console.ReadLine());
            int opakCats = int.Parse(Console.ReadLine());
            double rezult = opakDogs * 2.5 + opakCats * 4;
            Console.WriteLine(rezult  +  " lv.");

        }
    }
}
