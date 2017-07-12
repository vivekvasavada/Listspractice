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

            //List<string> favefoods = new List<string>() { "Steak", "Fish", "katsudon", "Ice Cream","Nachos" };
            //if (favefoods.Contains("fish"))
            //{
            //    Console.WriteLine("i like fish, too");
            //}

            //List<int> numberslist = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            ////Console.WriteLine(numberslist.Contains(23));

            //Console.WriteLine(numberslist.Contains(77));

            //Console.WriteLine(numberslist.Contains(15));

            //numberslist.Remove(23);
            //numberslist.Remove(77);
            //numberslist.Remove(32);
            //numberslist.Remove(6);

            //Console.WriteLine(numberslist.Contains(23));

            //Console.WriteLine(numberslist.Contains(77));

            //Console.WriteLine(numberslist.Contains(15));

            //create list
            //not in list add it
            //inform the movie has been added on the way
            //if in list tell them on the way
            //able to add has many movies as they want

            List<string> movieList = new List<string>() {"All about Bob", "Alien", "Robocop" };
            Console.WriteLine("Please, enter a movie");
            string movieEntered = Console.ReadLine();


            if (movieList.Contains("All about Bob"))
                if (movieList.Contains("Alien"))
                    if (movieList.Contains("Robocop"))
                    {
                        Console.WriteLine("Your Movie is on it's way");
                    }

                    else
                    {
                        Console.WriteLine("Your movie is being ordered");
                    }


            
















        }

    }
}
