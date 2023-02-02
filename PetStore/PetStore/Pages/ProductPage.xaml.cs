using System.Windows;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Window
    {
        public ProductPage(HomePage mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private readonly HomePage main;
    }

}
