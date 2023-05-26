using Questions;
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
using TriviaApiLibrary;

namespace Questionnare
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private int maxQuestion = 12;
        Question question1;
        public Login()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(nickname.Text, maxQuestion);
            main.Show();
            this.Close();
        }

        private void nickname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }

    }    
}

