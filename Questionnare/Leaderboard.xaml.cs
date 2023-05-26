using scoreboard;
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
    /// <summary>
    /// Interaction logic for Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
        
        public Leaderboard()
        {
            InitializeComponent();

            ScoreboardCl scoreboard1 = new ScoreboardCl();
            Playerscore Playerscore = new Playerscore();

            List<Playerscore> playerScores = scoreboard1.GetPlayerScores();

            foreach (var playerScore in playerScores)
            {
                string name = playerScore.Name;
                int scored = playerScore.Score;
            }

            // Sort the player scores in descending order by score
            playerScores.Sort((x, y) => y.Score.CompareTo(x.Score));

            // Iterate over the sorted player scores and update the text blocks
            for (int i = 0; i < playerScores.Count && i < 5; i++)
            {
                string name = playerScores[i].Name;
                int score = playerScores[i].Score;

                First.Text = $"1. {playerScores[0].Name}: {playerScores[0].Score}";
                Second.Text = $"2. {playerScores[1].Name}: {playerScores[1].Score}";
                Third.Text = $"3. {playerScores[2].Name}: {playerScores[2].Score}";
                fourth.Text = $"4. {playerScores[3].Name}: {playerScores[3].Score}";
                Fifth.Text = $"5. {playerScores[4].Name}: {playerScores[4].Score}";

            }
        }
        /*
         * ScoreboardCl scoreboard1 = new ScoreboardCl();
        
        Playerscore Playerscore = new Playerscore();

        List<Playerscore> playerScores = scoreboard1.GetPlayerScores();

        foreach (var playerScore in playerScores)
        {
            string name = playerScore.Name;
            int scored = playerScore.Score;

            Console.WriteLine($"Name: {name}, Score: {scored}");
        }*/

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
