namespace Questions
{
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

            Console.WriteLine(question.CountAnswers());
            question.showAnswer();

        }
    }
}