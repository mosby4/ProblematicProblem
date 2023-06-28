using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class program
    {

        static bool cont = true;
        static List<string> activities = new List<string>()
        { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! Would you like to generate a random activity? yes/no: ");
            var userResponse = Console.ReadLine().ToLower();

            Random rng = new Random();
            
            Console.WriteLine();
            if (userResponse == "yes")
            {
                Console.WriteLine("Ok cool.");
                Console.WriteLine();
            }
            if (userResponse == "no")
            {
                Console.WriteLine("Ok Thank you for visiting the fun factory.");
                Console.ReadLine();
            }
           

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            while (string.IsNullOrEmpty(userName ))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                userName = Console.ReadLine();
            }

            Console.WriteLine($"Hi, {userName }!");
            Console.WriteLine();

            Console.Write("What is your age? ");
            var userAge = Console.ReadLine();
            while (string.IsNullOrEmpty(userAge))
            {            
                Console.WriteLine("We need a response.");
                var newAge = int.Parse(Console.ReadLine());
                
            }

                Console.WriteLine();
             
            
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList = ( Console.ReadLine().ToLower() == "sure"? true : false );

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList =(Console.ReadLine().ToLower() == "yes"? true : false);
                Console.WriteLine();
                if (addToList == false)
                {
                    Console.WriteLine($"ok {userName} we will pick from are current activites");
                }

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    //string addToList = bool.Parse(Console.ReadLine());
                }
            }

            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
              if (userAge > 21 && randomActivity == "Wine Tasting")
              {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                   
              }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity }! Is this ok or do you want to grab another activity? Keep/Redo: ");
              Console.WriteLine();
                cont = (Console.ReadLine().ToLower() == "redo"? true : false);


            }
        }
    }
}
    
