using System.Collections.Generic;

namespace Questions;

internal class Program
{
    static void Main(string[] args)
    {
        Question question = new Question("Who is the current president of the USA?");
        Console.WriteLine(question.ToString());

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


    }
}