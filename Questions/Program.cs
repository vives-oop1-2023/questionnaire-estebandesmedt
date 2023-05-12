using System.Collections.Generic;

namespace Questions;

internal class Program
{
    static void Main(string[] args)
    {
        Question question = new Question("Who is the current president of the USA?");
        Console.WriteLine(question.ToString());

        question.Add(new Answer("Trump", false));
        question.Add(new Answer("Obama", false));
        question.Add(new Answer("Biden", true));
        question.Add(new Answer("Jaennine", false));

        question.showAnswer();
        Console.WriteLine($"The amount of answers: {question.CountAnswers()}");

        Console.Write($"Give a question index(0-{question.CountAnswers()-1}): ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(question.Get(x)); 

        List<string> answerOptions = question.GetAnswerOptions();
        question.Randomize(answerOptions);
        question.showAnswer();

    }
}