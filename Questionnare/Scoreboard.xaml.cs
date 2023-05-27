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
using scoreboard;

namespace Questionnare
{

    public partial class Scoreboard : Window
    {
        private int totalAnswers;
        private int correctAnswers;
        private int incorrectAnswers;
        private TimeSpan elapsedTime;
        private string Nickname;

        public Scoreboard(int total, int correct, TimeSpan elapsed, string nickname)
        {
            InitializeComponent();
            totalAnswers = total;
            correctAnswers = correct;
            incorrectAnswers = total - correct;
            elapsedTime = elapsed;
            double percentage = (double)correctAnswers / totalAnswers * 100;
            percentage = Math.Round(percentage, 2);
            string Scored = Convert.ToString(correctAnswers * 10);
            Nickname = nickname;



            TotalAnswersTextBlock.Text = totalAnswers.ToString();
            CorrectAnswersTextBlock.Text = correctAnswers.ToString();
            IncorrectAnswersTextBlock.Text = incorrectAnswers.ToString();
            Time.Text = elapsedTime.ToString(@"mm\:ss");
            percentageBar.Value = correctAnswers;
            PercentageBox.Text = $"{percentage:F2}";
            Score.Text = $"{Scored}";
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ScoreboardCl scoreboardCl = new ScoreboardCl();
            string Score1a = Convert.ToString(correctAnswers);
            scoreboardCl.AddPlayerScore(Nickname, Score1a, @"..\..\..\..\Scoreboard\scores.txt");

            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Close();
        }
    }
}
