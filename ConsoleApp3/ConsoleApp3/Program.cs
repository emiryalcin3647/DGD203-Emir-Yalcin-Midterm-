using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the 'Would You Rather - Fears and Risks' game!");
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nHello, {playerName}! Answer each question by typing 'A' or 'B'.");
        Console.WriteLine("At the end, you'll receive a personalized evaluation.");
        Console.WriteLine("Press Enter to start.");
        Console.ReadLine();

        var questions = new List<(string question, string optionA, string optionB)>
        {
            ("Would you rather explore an abandoned haunted house at midnight or spend a night alone in a dense forest full of unknown sounds?",
                "Explore the haunted house.",
                "Spend the night in the forest."),
            ("Would you rather skydive from a high altitude or swim with sharks in open water?",
                "Skydive.",
                "Swim with sharks."),
            ("Would you rather reveal your most embarrassing secret to a crowd of strangers or confront your biggest fear alone?",
                "Reveal my secret.",
                "Confront my fear."),
            ("Would you rather get lost in a massive underground cave or wander in an unknown city with no way to communicate?",
                "Get lost in the cave.",
                "Wander in the unknown city."),
            ("Would you rather live with the fear of being watched all the time or not trust anyone around you?",
                "Live with the fear of being watched.",
                "Not trust anyone.")
        };

        int riskTakerScore = 0;
        int cautiousScore = 0;

        foreach (var (question, optionA, optionB) in questions)
        {
            Console.WriteLine("\n" + question);
            Console.WriteLine("A) " + optionA);
            Console.WriteLine("B) " + optionB);
            Console.Write("Your answer (A or B): ");

            string answer;
            while ((answer = Console.ReadLine().ToUpper()) != "A" && answer != "B")
            {
                Console.Write("Please enter a valid choice (A or B): ");
            }

            if (answer == "A")
            {
                riskTakerScore++;
            }
            else
            {
                cautiousScore++;
            }
        }

        Console.WriteLine($"\nThank you, {playerName}! Evaluating your results...\n");

        if (riskTakerScore > cautiousScore)
        {
            Console.WriteLine($"{playerName}, you are bold and adventurous. You embrace new experiences and are not afraid to take risks.");
        }
        else if (cautiousScore > riskTakerScore)
        {
            Console.WriteLine($"{playerName}, you value safety and stability over taking risks. This makes you a careful and steady individual.");
        }
        else
        {
            Console.WriteLine($"{playerName}, you have a balanced approach, knowing when to take risks and when to be cautious.");
        }

        Console.WriteLine($"\nGame over, {playerName}! Thank you for playing.");
    }
}
