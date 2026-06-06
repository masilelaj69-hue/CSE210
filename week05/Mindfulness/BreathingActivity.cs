using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity helps you relax by guiding you through slow breathing in and out.");
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("\nBreathe out...");
            ShowCountdown(4);
        }

        DisplayEndMessage();
    }
}