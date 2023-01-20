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

namespace PetStore
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

        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Dog Clicked");
        }
        private void CatButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Cat Clicked");
        }

        private void FishButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SmallAnimalButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReptileButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
