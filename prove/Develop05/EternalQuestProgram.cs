using System;
using System.Collections.Generic;

public class EternalQuestProgram
{
    private List<Goal> _goals = new List<Goal>();

    public void CreateSimpleGoal(string name, int points)
    {
        _goals.Add(new SimpleGoal(name, points));
    }

    public void CreateEternalGoal(string name, int pointsPerEvent)
    {
        _goals.Add(new EternalGoal(name, pointsPerEvent));
    }

    public void CreateChecklistGoal(string name, int pointsPerEvent, int totalRequired, int bonusPoints)
    {
        _goals.Add(new ChecklistGoal(name, pointsPerEvent, totalRequired, bonusPoints));
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            Console.WriteLine($"Event recorded for goal: {goalName}");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void ShowGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalStatus());
        }
    }

    public int GetTotalScore()
    {
        int totalScore = 0;
        foreach (Goal goal in _goals)
        {
            totalScore += goal.PointsEarned;
        }
        return totalScore;
    }

    public void SaveGoals(string fileName)
    {
        // Logic to save to a file
    }

    public void LoadGoals(string fileName)
    {
        // Logic to load from a file
    }

    public void ShowTotalPoints()
    {
        Console.WriteLine($"You have {GetTotalScore()} points.");
    }

    // Method to assign points for different types of goals
    public int AssignPointsForGoal(string goalType)
    {
        // Logic to assign points based on goal type
        // You can customize this logic based on your requirements
        switch (goalType)
        {
            case "Simple":
                return 100; 
            case "Eternal":
                return 50; // Example points for an eternal goal
            case "Checklist":
                return 200; // Example points for a checklist goal
            default:
                return 0;
        }
    }
}
