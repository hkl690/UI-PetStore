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
using System.Drawing;
using System.IO;

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
             DataContext = new List<Item>
             {
             //    new Item("Test1", 0.98, "Test2", "Test3")
             };
        }

        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            Product_Grid.Items.Add(new Item("Test1", 0.99, "Test2", "Test3", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory()+"\\Images\\Dog\\Dog.jfif")));
            Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Species", Binding = new Binding("Species") });
            Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
            Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Item Name", Binding = new Binding("ItemName") });
            Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Category", Binding = new Binding("Category") });
            /*
                    Page_Control.SelectedIndex = 1;

                    Product_Grid.Items.Add(new Item("Test1", 0.99, "Test2", "Test3", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory()+"\\Images\\Dog\\Dog.jfif")));
                    Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Species", Binding = new Binding("Species") });
                    Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
                    Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Item Name", Binding = new Binding("ItemName") });
                    Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Category", Binding = new Binding("Category") });
                    Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Picture", Binding = new Binding("Picture") });

                    /*
                    DataGridTextColumn textColumn1 = new DataGridTextColumn();
                    textColumn1.Header = "Picture";
                    textColumn1.Binding = new Binding("Picture");
                    DataTemplate.Add(textColumn1);  */

            List<Item> Items = new List<Item>();
            //ItemsSource.Columns.Add(new Item("Test1", 0.99, "Test2", "Test3", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif"))); */
        }
        private void CatButton_Click(object sender, RoutedEventArgs e)
        {
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
/* Using this website:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/