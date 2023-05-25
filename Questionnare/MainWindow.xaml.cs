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
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Windows.Threading;

namespace Questionnare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IQuestionHandler
    {
        private int ScoredisplayCount = 0;
        private int Score = 0;
        Question question1;
        public object question { get; private set; }
        private bool isFirstQuestion = true;
        private DispatcherTimer timer;
        private TimeSpan elapsedTime;


        public MainWindow(string nickname, int maxQuestion)
        {
            InitializeComponent();
            QuestionBox.IsReadOnly = true;
            NickNameBox.Text = $"Username: {nickname}";

            int AmOfQuestion = maxQuestion;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        public void ProcessQuestion(TriviaMultipleChoiceQuestion question)
        {
            if (isFirstQuestion)
            {
                isFirstQuestion = false;
                timer.Start();
            }
            question1 = new Question(question.Question.Text);

            question1.Text = question.Question.Text;
            question1.Add(new Answer(question.CorrectAnswer, true));
            question1.Add(new Answer(question.IncorrectAnswers[0], false));
            question1.Add(new Answer(question.IncorrectAnswers[1], false));
            question1.Add(new Answer(question.IncorrectAnswers[2], false));

            question1.Randomize();

            QuestionBox.Text = question1.Text;
            Answer1.Content = question1.Get(0);
            Answer2.Content = question1.Get(1);
            Answer3.Content = question1.Get(2);
            Answer4.Content = question1.Get(3);

            Answer1.Tag = question1.Get(0);
            Answer2.Tag = question1.Get(1);
            Answer3.Tag = question1.Get(2);
            Answer4.Tag = question1.Get(3);

            //TestBlock.Text = question1.FindCorrectAnswerIndex().ToString();
        }

        private async void NextButton_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            await TriviaApiRequester.RequestRandomQuestion(this);
            ScoreOnTwelf.Content = $"{Score}/{ScoredisplayCount}";

            if (ScoredisplayCount < 11)
            {
                NextButton.Content = "Next!";
                ScoredisplayCount++;
                Scoredisplay.Content = $"{ScoredisplayCount}/12";
            }
            else if (ScoredisplayCount == 11)
            {
                NextButton.Content = "Finish";
                ScoredisplayCount++;
                Scoredisplay.Content = $"{ScoredisplayCount}/12";
            }
            else if (ScoredisplayCount == 12)
            {
                Scoreboard scoreboard = new Scoreboard(ScoredisplayCount, Score, elapsedTime);
                timer.Stop();
                scoreboard.Show();
                this.Close();
            }
            
            //Reset of background color after answer
            Answer1.Background = default;
            Answer2.Background = default;
            Answer3.Background = default;
            Answer4.Background = default;

            //Reset of Border
            Answer1.BorderBrush = default;
            Answer2.BorderBrush = default;
            Answer3.BorderBrush = default;
            Answer4.BorderBrush = default;
        }

        private void QuestionBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            Answer answer = (Answer)((Button)sender).Tag;
            if (answer.IsCorrect)
            {
                Score++;
                ((Button)sender).Background = Brushes.Green;
                ((Button)sender).BorderBrush = Brushes.Black;
                DisableButtons();
            }
            else
            {
                ((Button)sender).Background = Brushes.Red;
                ((Button)sender).BorderBrush = Brushes.Black;
                DisableButtons();
                int i = question1.FindCorrectAnswerIndex();

                if (i == 0)
                {
                    Answer1.Background = Brushes.Green;
                    Answer1.BorderBrush = Brushes.Black;
                }
                else if (i == 1)
                {
                    Answer2.Background = Brushes.Green;
                    Answer2.BorderBrush = Brushes.Black;
                }
                else if (i == 2)
                {
                    Answer3.Background = Brushes.Green;
                    Answer3.BorderBrush = Brushes.Black;
                }
                else if (i == 3)
                {
                    Answer4.Background = Brushes.Green;
                    Answer4.BorderBrush = Brushes.Black;
                }
            }
            ScoreOnTwelf.Content = $"{Score}/{ScoredisplayCount}";
        }
        private void Scoredisplay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DisableButtons()
        {
            Answer1.IsEnabled = false;
            Answer2.IsEnabled = false;
            Answer3.IsEnabled = false;
            Answer4.IsEnabled = false;
        }

        private void EnableButtons()
        {
            Answer1.IsEnabled = true;
            Answer2.IsEnabled = true;
            Answer3.IsEnabled = true;
            Answer4.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
        }
    }
}
