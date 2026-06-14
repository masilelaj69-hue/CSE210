using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]));

                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]));

                _goals.Add(g);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[6]),
                    int.Parse(parts[4]));

                _goals.Add(g);
            }
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
    }
}