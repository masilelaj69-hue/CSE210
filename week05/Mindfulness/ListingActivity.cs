using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you are grateful for:",
        "List your personal strengths:",
        "List things that make you happy:",
        "List acts of kindness you did recently:"
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity helps you focus on positive things by listing them.");
    }

    public void Run()
    {
        DisplayStartMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\n" + prompt);
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");

        DisplayEndMessage();
    }
}