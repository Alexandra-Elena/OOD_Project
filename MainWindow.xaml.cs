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

namespace Project_MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        private void btnStop_Copy_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
