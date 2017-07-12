using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{

            //Console.WriteLine(number);
            //}

            //use the Count property
            //Console.WriteLine(favNumbers.Count);

            //List<string> books = new List<string> { "Cat in the Hat", "Toad and frog", "Green Eggs and Ham" };
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton hears a Who");

            //List<string> animals = new List<string>();
            //animals.Add("Pig");
            //animals.Add("Horse");
            //animals.Add("Cow");
            //animals.Add("Chicken");
            //animals.Add("Dog");

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);

            //}

            //List<bool> boolList = new List<bool> { true, false, false, true, false };
            //foreach (bool day in boolList)
            //    if (day == true)
            //    {

            //        Console.WriteLine("Better bring an umbrella");

            //    }
            //else

            //{
            //        Console.WriteLine("No rain enjoy the sun");
            //}
            
            List<string> favefoods = new List<string>() { "Steak", "Fish", "katsudon", "Ice Cream","Nachos" };
            if (favefoods.Contains("fish"))
            {
                Console.WriteLine("i like fish, too");
            }


        }
        
    }
}
