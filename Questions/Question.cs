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
         /* public bool GetAnswer(bool Answer.answers())
          {
            foreach (Answer answ in answers)
            {
                if (bool == true)
                {
                    return answ;
                }
                else
                {
                    return 0;
                }
            } */
                
          } 
    }
}
