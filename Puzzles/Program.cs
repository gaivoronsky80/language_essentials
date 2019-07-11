using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
// Random Array
// Create a function called RandomArray() that returns an integer array
// Place 10 random integer values between 5-25 into the array
// Print the min and max values of the array
// Print the sum of all the values

        public static void RandomArray(){
            int[] RandomArray = new int[10];
            Random rand = new Random();
            for(int i = 0; i < RandomArray.Length; i++){
                RandomArray[i] = rand.Next(5,25);
            }
            int min = RandomArray[0];
            int max = RandomArray[0];
            int sum = 0;
            for(int i = 0; i < RandomArray.Length; i++){
                if(RandomArray[i] < min){
                    min = RandomArray[i];
                }
                else if(RandomArray[i] > max){
                    max = RandomArray[i];
                }
                sum += RandomArray[i];
            }
            foreach(var value in RandomArray){
                Console.WriteLine(value);
            }
            Console.WriteLine($"min: {min}, max: {max}, sum: {sum}");
        }

// Coin Flip
// Create a function called TossCoin() that returns a string
// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
// Create another function called TossMultipleCoins(int num) that returns a Double
// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss
        
        public static String TossCoin(){
            Random rand = new Random();
            int coin = rand.Next(0,2);
            Console.WriteLine("Tossing a Coin!");
            if(coin == 0){
                Console.WriteLine("Heads");
                return "Heads";
            }
            else {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static Double TossMultipleCoins(int num){
            int headCount = 0;
            int tailCount = 0;
            for(int i = 1; i <= num; i++){
                if(TossCoin() == "Heads"){
                    headCount ++;
                }
                else{
                    tailCount ++;
                }
            }
            Console.WriteLine($"Total Heads: {headCount}, total tails: {tailCount}, total toss: {headCount + tailCount}");
            if(headCount < tailCount){
                return ((Double)tailCount/(Double)headCount);
            }
            else{
                return ((Double)tailCount/(Double)headCount);
            }
        }

// Names
// Build a function Names that returns a list of strings.  In this function:
// Create an list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return an list that only includes names longer than 5 characters

        public static string[] Names()
        {
            string[] Names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"}; 
            Random rand = new Random();
            for(int i = 0; i < Names.Length; i++)
            {
                int idx = rand.Next(Names.Length);
                string temp = Names[idx];
                Names[idx] = Names[i];
                Names[i] = temp;
            }
            Console.WriteLine(Names);
            List<string> OverFive = new List<string>();
            foreach(var name in Names)
            {
                Console.WriteLine(name);
                if(name.Length > 5)
                {
                    OverFive.Add(name);
                }
            }
            foreach(var person in OverFive)
            {
                Console.WriteLine(person);
            }
            return OverFive.ToArray();
            
        }

        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }
    }
}
