using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TriviaApiLibrary;
using Questionnare;
using Questions;
using System.Configuration;

namespace Questionnare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IQuestionHandler
    {
        private int ScoredisplayCount = 0;


        public MainWindow()
        {
            InitializeComponent();
            QuestionBox.IsReadOnly = true;
        }

        public void ProcessQuestion(TriviaMultipleChoiceQuestion question)
        {
            Question question1 = new Question(question.Question.Text);
            QuestionBox.Text = question.Question.Text;

            List<string> answerOptions = new List<string>
    {
        question.CorrectAnswer,
        question.IncorrectAnswers[0],
        question.IncorrectAnswers[1],
        question.IncorrectAnswers[2]
    };

            question1.Randomize(answerOptions);

            Answer1.Content = answerOptions[0];
            Answer2.Content = answerOptions[1];
            Answer3.Content = answerOptions[2];
            Answer4.Content = answerOptions[3];
        }


        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            TriviaApiRequester.RequestRandomQuestion(this);

            ScoredisplayCount++;
            Scoredisplay.Content = $"{ScoredisplayCount}/12";
        }

        private void QuestionBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Answer4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Scoredisplay_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
