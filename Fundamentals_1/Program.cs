using System;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 255; i++){
            Console.WriteLine(i);
            }
            for(int j = 1; j <= 100; j++){
                if(j%5 == 0 && j%3 == 0){
                    Console.WriteLine(j);
                }
            }
            for(int k = 1; k <= 100; k++){
                if(k%3 == 0 && k%5 == 0){
                    Console.WriteLine("FizzBizz");
                }
                else if(k%3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(k%5 == 0){
                    Console.WriteLine("Bizz");
                }

            }
        }
    }
}
