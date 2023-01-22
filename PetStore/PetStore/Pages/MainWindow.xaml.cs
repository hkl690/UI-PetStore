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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices;

namespace PetStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Item> items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items
        {
            get { return items; }
        }
        


        public MainWindow()
        {
            items.Add(new Item("Cat", 3.99, "Cat Brush", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif")));
            items.Add(new Item("Cat", 29.99, "Cat Carrier", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif")));
            items.Add(new Item("Cat", 4.99, "Cat Collar", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif")));
            items.Add(new Item("Cat", 8.99, "Cat Flea Medication", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif")));
          
                InitializeComponent();
            SearchBox.Text = "Search";/*
             DataContext = new List<Item>
             {
             //    new Item("Test1", 0.98, "Test2", "Test3")
             };*/
        }

        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 2;
            foreach (var item in items)
            {
                if (!item.ItemName.Contains(SearchBox.Text)) continue;
                System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
            }
            
            /* Product_Grid.Items.Add(new Item("Test1", 0.99, "Test2", "Test3", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory()+"\\Images\\Dog\\Dog.jfif")));
             Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Species", Binding = new Binding("Species") });
             Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
             Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Item Name", Binding = new Binding("ItemName") });
             Product_Grid.Columns.Add(new DataGridTextColumn { Header = "Category", Binding = new Binding("Category") });
            */ /*
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

        private void RemoveSearchFromBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("Search")) SearchBox.Text = "";
        }

        private void AddSearchToBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("")) SearchBox.Text = "Search";
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                // SearchBox.Text = "You entered: " + SearchBox.Text;
                // Next need to go to the search results page...
                Page_Control.SelectedIndex = 1;
                SearchResults.Text = string.Empty;
                foreach (Item item in items)
                {
                    if (!(item.Species.ToLower().Contains(SearchBox.Text.ToLower()) || item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(SearchBox.Text.ToLower()) || (item.Category.ToLower().Contains(SearchBox.Text.ToLower())))) continue;
                    // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                    SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                }
            }
        }
    }
}
/* Using this website:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/