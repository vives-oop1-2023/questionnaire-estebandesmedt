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
using System.Windows.Shapes;

namespace Questionnare
{
    public partial class Scoreboard : Window
    {
        private int totalAnswers;
        private int correctAnswers;
        private int incorrectAnswers;
        private TimeSpan elapsedTime;

        public Scoreboard(int total, int correct, TimeSpan elapsed)
        {
            InitializeComponent();
            totalAnswers = total;
            correctAnswers = correct;
            incorrectAnswers = total - correct;
            elapsedTime = elapsed;
            double percentage = (double)correctAnswers / totalAnswers * 100;
            percentage = Math.Round(percentage, 2);
            int ScoreCorrect = correctAnswers * 10;
            int Scored = (ScoreCorrect / (incorrectAnswers + 1)) + 3;


            TotalAnswersTextBlock.Text = totalAnswers.ToString();
            CorrectAnswersTextBlock.Text = correctAnswers.ToString();
            IncorrectAnswersTextBlock.Text = incorrectAnswers.ToString();
            Time.Text = elapsedTime.ToString(@"mm\:ss");
            percentageBar.Value = correctAnswers;
            PercentageBox.Text = $"{percentage:F2}";
            Score.Text = $"{Scored}";
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
