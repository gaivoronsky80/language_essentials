using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> things = new List<object>();
            things.Add(7);
            things.Add(28);
            things.Add(-1);
            things.Add(true);
            things.Add("chair");
            Console.WriteLine(things[2]);
            Console.WriteLine($"We currently have {things.Count} things.");

            int sum = 0;
            foreach (var item in things){
                Console.WriteLine(item);
                if(item is int){
                    int itemInt = (int)item;
                    sum += itemInt;
                }
            }
            Console.WriteLine(sum);
        }
    }
}