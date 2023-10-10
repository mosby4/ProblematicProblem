using System;
using System.Collections.Generic;
using System.Threading;


bool cont = true;
string userResponse;
Random rng;
List<string> activities = new List<string>()
        { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
do
{
    Console.WriteLine("Hello, welcome to the random activity generator! Would you like to generate a random activity? yes/no: ");
    userResponse = Console.ReadLine().ToLower();

    rng = new Random();

    Console.WriteLine();
    while (string.IsNullOrEmpty(userResponse))
    {
        Console.WriteLine("I'm sorry, lets try again. Would you like to generate a random activity?");
        Console.WriteLine("Please provide a yes or no answer.");
        userResponse = Console.ReadLine().ToLower();
        Thread.Sleep(1000);
        Console.Clear();
    }
    if (userResponse == "yes")
    {
        Console.WriteLine("Ok cool.");
        Console.WriteLine();
    }
    if (userResponse == "no")
    {
        Console.WriteLine("Ok Thank you for visiting the fun factory.");
        Console.ReadLine();
        Thread.Sleep(1000);
        Console.Clear();
    }
} while (userResponse == "no");

Console.Write("We are going to need your information first! What is your name? ");
string userName = Console.ReadLine();
while (string.IsNullOrEmpty(userName))
{
    Console.WriteLine("Name can't be empty! Input your name once more");
    userName = Console.ReadLine();
}

Console.WriteLine($"Hi, {userName}!");
Console.WriteLine();

Console.Write("What is your age? ");
var userAge = Console.ReadLine();

while (string.IsNullOrEmpty(userAge))
{
    Console.WriteLine("We need a response.");
    userAge = Console.ReadLine();
    //newAge = int.Parse(Console.ReadLine());

}

Console.WriteLine();


Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
bool seeList = (Console.ReadLine().ToLower() == "sure" ? true : false);

if (seeList)
{
    foreach (string activity in activities)
    {
        Console.Write($"{activity} ");
        Thread.Sleep(350);
    }
    Console.WriteLine();
    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
    bool addToList = (Console.ReadLine().ToLower() == "yes" ? true : false);
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
            Thread.Sleep(350);

        }


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
    for (int i = 0; i < 10; i++)
    {
        Console.Write(". ");
        Thread.Sleep(500);
    }

    Console.WriteLine();
    int randomNumber = rng.Next(activities.Count);
    string randomActivity = activities[randomNumber];
    int customerAge = 0;
    int.TryParse(userAge, out customerAge);

    if (customerAge < 21 && randomActivity == "Wine Tasting")
    {
        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
        Thread.Sleep(500);
        Console.WriteLine("Picking something else!");
        activities.Remove(randomActivity);

    }
    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
    var finalResponse = Console.ReadLine().ToLower();

    if (finalResponse == "redo")
    {
        Console.WriteLine("Ok lets start over.");
        Thread.Sleep(500);
        Console.Clear();
    }

    if (finalResponse == "keep")
    {
        Console.WriteLine("Great! Enjoy your activity.");
        Console.WriteLine();
        break;
    }

}

