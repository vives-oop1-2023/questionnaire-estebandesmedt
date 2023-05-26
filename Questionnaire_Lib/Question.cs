using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Questions
{
    public class Question
    {
        List<Answer> answers = new List<Answer>();


        public string Text { get; set; }
        // public string ImageUrl { get; set; }

        public Question()
        {
            Text = "";
        }
        public Question(string question)
        {
            Text = question;
        }
        public void Add(Answer answ)
        {
            answers.Add(answ);
        }
        public override string ToString()
        {
            return $"{Text}";
        }
        public int countAnswers()
        {
            return answers.Count();
        }

        public void showAnswer()
        {
            foreach (Answer answ in answers)
            {
                Console.WriteLine(answ);
            }
        }

        public Answer Get(int index)
        {
            return answers[index];
        }

        public void Randomize()
        {
            int lastIndex = answers.Count - 1;
            Random random = new Random();

            while (lastIndex > 0)
            {
                int randomIndex = random.Next(0, lastIndex + 1);
                Answer tempValue = answers[lastIndex];
                answers[lastIndex] = answers[randomIndex];
                answers[randomIndex] = tempValue;
                lastIndex--;
            }
        }

        public int FindCorrectAnswerIndex()
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].IsCorrect)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
