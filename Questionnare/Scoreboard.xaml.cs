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
            
            TotalAnswersTextBlock.Text = totalAnswers.ToString();
            CorrectAnswersTextBlock.Text = correctAnswers.ToString();
            IncorrectAnswersTextBlock.Text = incorrectAnswers.ToString();
            Time.Text = elapsedTime.ToString(@"mm\:ss");
            percentageBar.Value = correctAnswers;
        }
    }
}
