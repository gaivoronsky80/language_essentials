using System;
using System.Collections.Generic;

namespace Basic_13
{
    public class Program
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i <= 255; i++){
            Console.WriteLine(i);
            }
        }
        public static void PrintOdds(){
            for(int i = 1; i <= 255; i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
        public static void LoopArray(int[] numbers){
            foreach(var idx in numbers){
                Console.WriteLine(idx);
            }
        }
        public static int FindMax(int[] numbers){
            int max = numbers[0];
            foreach(var idx in numbers){
                if(idx > max){
                    max = idx;
                }
                return max;
            }
        }
        public static void GetAverage(int[] numbers){
            int sum = 0;
            foreach(var idx in numbers){
                sum += idx;
                double avg = sum / numbers.Length;
                Console.WriteLine(avg);
            }
        }
        public static int[] OddArray(){
            List <int> oddArray = new List <int>();
            for(var i = 1; i <= 255; i++){
                if(i%2!=0){
                    oddArray.Add(i);
                }
            }
            return oddArray.ToArray();
        }
        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            foreach(int num in numbers){
                if(num < y){
                    count ++;
                }
                return count;
            }
        }
        public static void SquareArrayValues(int[] numbers){
            int i = 0;
            while(i < numbers.Length){
                numbers[i] = numbers[i] * numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers){
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach(int num in numbers){
                if(num < min){
                    min = num;
                }
                else if(num > max){
                    max = num;
                }
                sum += num;
            }
            int avg = sum / numbers.Length;
            Console.WriteLine($"min: {min}, max: {max}, avg: {avg}");
        }
        public static void ShiftValues(int[] numbers){
            for(int i = numbers.Length-1; i > 0; i--){
                int temp = numbers[i];
                if(i == numbers.Length-1){
                    numbers[i] = 0;
                }
                numbers[i-1] = numbers[i];
            }
        }
        public static object[] NumToString(int[] numbers){
            List<object> numTostring = new List<object>;
            foreach(var num in numbers){
                if(num < 0){
                    numTostring.Add("Dojo");
                }
                else {
                    numTostring.Add(num);
                }
            }
            return numTostring.ToArray();
        }
        public static void Main(string[] args)
        {
            int[] numbers = {1,3,-5,7,-9,13};
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(numbers);
            FindMax(numbers);
            GetAverage(numbers);
            OddArray();
            GreaterThanY(numbers,3);
            SquareArrayValues(numbers);
            EliminateNegatives(numbers);
            MinMaxAverage(numbers);
            ShiftValues(numbers);
            NumToString(numbers);
        }
    }
}
