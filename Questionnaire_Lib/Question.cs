using System;
using System.Collections.Generic;
using System.Linq;
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
        public string ImageUrl { get; set; }

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
            string a = $"{Text}";
            return a;
        }
        public int CountAnswers()
        {
            int length = answers.Count();
            return length;
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

        public void Randomize(List<string> answerOptions)
        {
            int lastIndex = answerOptions.Count - 1;
            while (lastIndex > 0)
            {
                string tempValue = answerOptions[lastIndex];
                int randomIndex = new Random().Next(0, lastIndex);
                answerOptions[lastIndex] = answerOptions[randomIndex];
                answerOptions[randomIndex] = tempValue;
                lastIndex--;
            }
        }

        public int CheckAnswer(string selectedAnswer)
        {
            int correctAnswerIndex = -1;

            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].Text == selectedAnswer && answers[i].IsCorrect)
                {
                    correctAnswerIndex = i;
                    break;
                }
            }

            return correctAnswerIndex;
        }

        public List<string> GetAnswerOptions()
        {
            List<string> answerOptions = new List<string>();
            foreach (Answer answer in answers)
            {
                answerOptions.Add(answer.Text);
            }
            return answerOptions;
        }

    }
}
