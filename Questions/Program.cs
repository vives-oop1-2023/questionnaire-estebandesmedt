using System.Collections.Generic;
using scoreboard;

namespace Questions;

internal class Program
{
    static void Main(string[] args)
    {
        ScoreboardCl scoreboard1 = new ScoreboardCl();
        
        Playerscore Playerscore = new Playerscore();

        List<Playerscore> playerScores = scoreboard1.GetPlayerScores(@"..\..\..\..\Scoreboard\scores.txt");

        foreach (var playerScore in playerScores)
        {
            string name = playerScore.Name;
            int scored = playerScore.Score;

            Console.WriteLine($"Name: {name}, Score: {scored}");
        }



        Console.Write("What's your username?: ");
        string Playername = Console.ReadLine();


        Random random = new Random();
        string score = Convert.ToString(random.Next(0, 50));
        if (Playername == "" || Playername == " " || Playername == "  ")
        {
            int ran1 = random.Next(0, 1000);
            int ran2 = random.Next(0, 1000);

            Playername = $"User{score}{ran1 - ran2}";
        }
        scoreboard1.AddPlayerScore(Playername, score, @"..\..\..\..\Scoreboard\scores.txt");
        
        Console.WriteLine("Check the scores.txt file to see your changes");

        Question question = new Question("Who is the current president of the USA?", "medium", "Politics");
        Console.WriteLine(question.ToString());
        Console.WriteLine(question.GetDifficulty());
        Console.WriteLine(question.GetCategory());


        //Adding the Answers to the list
        question.Add(new Answer("Trump", false));
        question.Add(new Answer("Obama", false));
        question.Add(new Answer("Biden", true));
        question.Add(new Answer("Jaennine", false));

        //Testing the Showanswer(Shows correct answer) and countAnswers(Counts the amount of answers) methods
        question.showAnswer(); 
        Console.WriteLine($"The amount of answers: {question.countAnswers()}");

        //Tests the Get(Gives the answer on an index) method
        Console.Write($"Give a question index(0-{question.countAnswers() - 1}): ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(question.Get(x));

        //Randomize(shuffles the answers) and FindCorrectAnswerIndex(Gives the index of the correct answer, where the boolean isCorrect = true) are being tested
        question.Randomize();
        Console.WriteLine(question.FindCorrectAnswerIndex());
        question.showAnswer();
        Console.WriteLine($"The correct answer is: {question.Get(question.FindCorrectAnswerIndex())}");

        
    }
}