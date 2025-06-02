using System;

public class Program
{
    // Student grading oracle!
    public static string CalculateGrade(int score, int attendance)
    {
        // First, let's make sure not accidentally submit their score size.
        if (score < 0 || score > 100 || attendance < 0 || attendance > 100)
        {
            return "Invalid Input: Only Between 0 to 100";
        }

        // Navigating of conditions!
        if (score >= 90 && attendance >= 80)
        {
            return "A: You're a star! You aced it and showed up like a champ!";
        }
        else if (score >= 80 && attendance >= 70)
        {
            return "B: Solid effort! You're doing great, keep up the good work!";
        }
        else if (score >= 70 && attendance >= 60)
        {
            return "C: Not bad! You're hanging in there, like a cat on a curtain.";
        }
        else if (score >= 60 && attendance >= 50)
        {
            // Uh oh, almost there, but let's check that attendance...
            if (attendance < 50)
            {
                return "Incomplete: Your brain was present, but your physical form was often missing. See me after class!";
            }
            else
            {
                return "D: You passed... by the skin of your teeth! Maybe set an alarm next time?";
            }
        }
        else
        {
            // If you didn't score high enough, OR you skipped too many classes...
            if (score < 60 || attendance < 50)
            {
                return "F: Looks like the learning fairy missed you. Time to hit the books (and maybe set multiple alarms!).";
            }
            // This condition shouldn't ideally be reached due to the previous checks,
            // but it's good practice to have a final catch-all.
            else
            {
                return "Hmm, something unexpected happened in the grading logic. Maybe the grading oracle needs coffee.";
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Honest Student Grade Calculator!");
        Console.WriteLine("--------Yasir Maken QTS Doha Intern!-----------");



        // Enter the student score and attendence percentage.
        Console.WriteLine("\nTime for grade calculation!"); 
        Console.Write("Enter your score (0-100): "); // Score
        string scoreInput = Console.ReadLine();

        Console.Write("Enter your attendance percentage (0-100): ");
        string attendanceInput = Console.ReadLine(); // Attendence Percentage

        try
        {
            if (int.TryParse(scoreInput, out int userScore) && int.TryParse(attendanceInput, out int userAttendance)) // Keeps parameters as numbers
            {
                string finalGrade = CalculateGrade(userScore, userAttendance); // Pass the inputs score and attendes to calculate and hold the result in final grade
                Console.WriteLine($"\nYour final grade is: {finalGrade}"); // Print the final grade to the Console
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter whole numbers for score and attendance. No funny business!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}. Did you try to enter your essay instead of a number?");
        }

        Console.WriteLine("\nPress any key to exit and contemplate your academic fate...");
        Console.ReadKey();
    }

}