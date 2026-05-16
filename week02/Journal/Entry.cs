using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string ResponseText { get; set; }

    public Entry(string date, string promptText, string responseText)
    {
        Date = date;
        PromptText = promptText;
        ResponseText = responseText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {ResponseText}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{Date}|{PromptText}|{ResponseText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');

        return new Entry(parts[0], parts[1], parts[2]);
    }
}