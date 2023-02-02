using System.Windows;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Window
    {
        public ProductPage(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;
    }

}
