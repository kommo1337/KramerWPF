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


namespace KramerWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void two_Checked(object sender, RoutedEventArgs e)
        {
            TwoTeatrads.Visibility = Visibility.Visible;
            ThreTeatrads.Visibility = Visibility.Hidden;
        }

        private void three_Checked(object sender, RoutedEventArgs e)
        {
            ThreTeatrads.Visibility= Visibility.Visible;
            TwoTeatrads.Visibility = Visibility.Hidden;
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (two.IsChecked == true)
            {
               Answer.Text = Convert.ToString(Convert.ToDouble(Edit11.Text) * Convert.ToDouble(Edit22.Text) - (Convert.ToDouble(Edit21.Text) * Convert.ToDouble(Edit12.Text)));
            }
            else if (three.IsChecked == true)
            {
                Answer.Text =  Convert.ToString(Convert.ToDouble(Edit11.Text) * Convert.ToDouble(BigEdit22.Text) * Convert.ToDouble(BigEdit33.Text) +
                       Convert.ToDouble(BigEdit12.Text) * Convert.ToDouble(BigEdit23.Text) * Convert.ToDouble(BigEdit31.Text) +
                       Convert.ToDouble(BigEdit21.Text) * Convert.ToDouble(BigEdit32.Text) * Convert.ToDouble(BigEdit13.Text)
                     - (Convert.ToDouble(BigEdit31.Text) * Convert.ToDouble(BigEdit22.Text) * Convert.ToDouble(BigEdit13.Text) +
                       Convert.ToDouble(BigEdit21.Text) * Convert.ToDouble(BigEdit12.Text) * Convert.ToDouble(BigEdit33.Text) +
                       Convert.ToDouble(BigEdit32.Text) * Convert.ToDouble(BigEdit23.Text) * Convert.ToDouble(BigEdit11.Text)));
            }
        }
    }
}
