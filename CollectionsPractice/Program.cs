using System;
using System.Collections.Generic; //Generic Lists

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(numArray);
            string[] strArray = new string[] { "Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(strArray);
            bool[] boolArray = {true,false,true,false,true,false,true,false,true,false};
            Console.WriteLine(boolArray);

            //List of Flavors
            List<string> ice_creams = new List<string>();
            ice_creams.Add("Kivi");
            ice_creams.Add("Cherry");
            ice_creams.Add("Strawbery");
            ice_creams.Add("Mango");
            ice_creams.Add("Chocolate");
            Console.WriteLine(ice_creams[3]);
            Console.WriteLine($"We currently know of {ice_creams.Count} ice creams in store");
            ice_creams.Remove("Kivi");
            Console.WriteLine($"We currently know of {ice_creams.Count} ice creams in store");

            //User Info Dictionary
            Dictionary<string,string> profile = new Dictionary<string,string>();
            Random rand = new Random();
            for(int i = 0; i < strArray.Length; i++){
                profile.Add(strArray[i], ice_creams[rand.Next(0,3)]);
            }
            foreach(var entry in profile){
                Console.WriteLine(entry.Key + " likes " + entry.Value + " flavore");
            }

        }
    }
}
