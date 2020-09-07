using System;

namespace ifproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string costume;
            string friend;
            string tabort;

            Console.WriteLine("What is your name?");


            name = Console.ReadLine();
            System.Console.WriteLine("Hello " + name);

            Console.ReadLine();


            Console.WriteLine("Welcome! You have been invited to the best halloween party ever.Everyone is invited, even you nerd.This is your chance to find the love of your life, so chose wisely.Firstly, what will you be at the party ? A zombie or a mumy?");

            costume = Console.ReadLine();

            if (costume == "zombie" || costume == "Zombie")
            {
                Console.WriteLine("Good choice!");
                Console.WriteLine("You see a witch and a zombie, who do you approach?")

                if (friend == "")
                {

                }

            }

        }

            else if (costume == "Mumy" || costume == "mumy")
            {
                Console.WriteLine("oh wow, risky, hehe, good for you");
            }

            else
            {
                Console.WriteLine("Sorry, I didnt get that, zombie or mumy?");
            }

Console.ReadLine();

        }
    }
}
