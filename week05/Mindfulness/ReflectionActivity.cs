using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Think of a time you helped someone.",
        "Think of a time you showed strength.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this experience special?",
        "What would you do differently next time?"
    };

    public ReflectionActivity()
    {
        SetName("Reflection Activity");
        SetDescription("This activity helps you reflect on meaningful life experiences.");
    }

    public void Run()
    {
        DisplayStartMessage();

        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(5);
        }

        DisplayEndMessage();
    }
}