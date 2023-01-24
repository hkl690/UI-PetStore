using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

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

        public ObservableCollection<Item> ItemResults = new ObservableCollection<Item>();

        /// <summary>
        /// Adding all items to the Item Collection and then initializing
        /// </summary>
        public MainWindow()
        {
            // Dog items
            items.Add(new Item("Dog", 6.99, "Dog Treat", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Dog Treat.png")));
            items.Add(new Item("Dog", 14.99, "Dry Dog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Dry Dog Food.png")));
            items.Add(new Item("Dog", 2.99, "Wet Dog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Wet Dog Food.png")));
            items.Add(new Item("Dog", 8.99, "Dog Brush", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Brush.png")));
            items.Add(new Item("Dog", 8.99, "Dog Car Seat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Car Seat.png")));
            items.Add(new Item("Dog", 29.99, "Dog Carrier", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Carrier.png")));
            items.Add(new Item("Dog", 4.99, "Dog Collar", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Collar.png")));
            items.Add(new Item("Dog", 8.99, "Dog Flea Medication", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Flea Med.jpg")));
            items.Add(new Item("Dog", 9.99, "Dog Harness", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Harness.jpg")));
            items.Add(new Item("Dog", 49.99, "Dog House", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog House.jpg")));
            items.Add(new Item("Dog", 6.99, "Dog Leash", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Leash.png")));
            items.Add(new Item("Dog", 59.99, "Dog Stroller", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Stroller.png")));
            items.Add(new Item("Dog", 5.99, "Dog Training Pads", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Training Pad.png")));
            items.Add(new Item("Dog", 14.99, "Dog Water Fountain", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Water Fountain.png")));
            items.Add(new Item("Dog", 14.99, "Pet Stain Remover", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Pet Stain Remover.png")));

            // Cat items
            items.Add(new Item("Cat", 3.99, "Cat Treat", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Cat Treat.png")));
            items.Add(new Item("Cat", 9.99, "Cat Dry Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Dry Cat Food.png")));
            items.Add(new Item("Cat", 14.99, "Cat Wet Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Wet Cat Food.png")));
            items.Add(new Item("Cat", 3.99, "Cat Brush", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Brush.png")));
            items.Add(new Item("Cat", 29.99, "Cat Carrier", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Carrier.png")));
            items.Add(new Item("Cat", 4.99, "Cat Collar", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Collar.png")));
            items.Add(new Item("Cat", 8.99, "Cat Flea Medication", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Flea Med.png")));
            items.Add(new Item("Cat", 9.99, "Cat Flea Harness", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Harness.png")));
            items.Add(new Item("Cat", 14.99, "Cat Litter Box", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Litter Box.png")));
            items.Add(new Item("Cat", 8.99, "Cat Litter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Litter.png")));
            items.Add(new Item("Cat", 24.99, "Cat Scratcher", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Scratcher.png")));
            items.Add(new Item("Cat", 49.99, "Cat Tree", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Tree.png")));
            items.Add(new Item("Cat", 14.99, "Cat Water Fountain", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Water Fountain.png")));

            // Small Animal items
            items.Add(new Item("Small Animal", 5.99, "Bird Food Crickets", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Bird Food Crickets.png")));
            items.Add(new Item("Small Animal", 4.99, "Bird Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Bird Food.png")));
            items.Add(new Item("Small Animal", 5.99, "Guinea Pig Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Guinea Pig Food.png")));
            items.Add(new Item("Small Animal", 6.99, "Hamster and Gerbil Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Hamster and Gerbil Food.png")));
            items.Add(new Item("Small Animal", 7.99, "Hedgehog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Hedgehog Food.png")));
            items.Add(new Item("Small Animal", 4.99, "Mouse and Rat Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Mouse and Rat Food.png")));
            items.Add(new Item("Small Animal", 7.99, "Rabbit Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Rabbit Food.png")));
            items.Add(new Item("Small Animal", 9.99, "Bed", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bed.png")));
            items.Add(new Item("Small Animal", 5.99, "Bedding", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bedding.png")));
            items.Add(new Item("Small Animal", 99.99, "Bird Habitat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bird Habitat.png")));
            items.Add(new Item("Small Animal", 19.99, "Heating Pad", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Heating Pad.png")));
            items.Add(new Item("Small Animal", 6.99, "Water Bottle", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Water Bottle.png")));

            // Fish items
            items.Add(new Item("Fish", 7.99, "Fish Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Food\\Fish Food.png")));
            items.Add(new Item("Fish", 9.99, "Pond Fish Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Food\\Pond Fish Food.png")));
            items.Add(new Item("Fish", 9.99, "Fish Aquarium Filter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Supplies\\Fish Aquarium Filter.png")));
            items.Add(new Item("Fish", 9.99, "Fish Aquarium Starter Kit", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Supplies\\Fish Aquarium Starter Kit.png")));

            // Reptile items
            items.Add(new Item("Reptile", 9.99, "Reptile Food Crickets", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Crickets.png")));
            items.Add(new Item("Reptile", 8.99, "Reptile Food Dried Insects", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Dried Insects.png")));
            items.Add(new Item("Reptile", 19.99, "Reptile Food Frozen Mice", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Frozen Mice.png")));
            items.Add(new Item("Reptile", 8.99, "Reptile Food Omnivore", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Omnivore.png")));
            items.Add(new Item("Reptile", 8.99, "Turtle Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Turtle Food.png")));
            items.Add(new Item("Reptile", 9.99, "Reptile Bedding", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Bedding.png")));
            items.Add(new Item("Reptile", 9.99, "Reptile Habitat Filter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Filter.png")));
            items.Add(new Item("Reptile", 14.95, "Reptile Habitat Sand", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Sand.png")));
            items.Add(new Item("Reptile", 9.99, "Reptile Habitat Soil", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Soil.png")));
            items.Add(new Item("Reptile", 99.99, "Reptile Habitat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat.png")));
            items.Add(new Item("Reptile", 8.99, "Reptile Heat Light", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Heat Light.png")));

            InitializeComponent();
            SearchBox.Text = "Search";/*
             DataContext = new List<Item>
             {
             //    new Item("Test1", 0.98, "Test2", "Test3")
             };*/
        }

        /// <summary>
        /// Clicking on the Dog image will bring up all the Dog items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            ResultGrid.ItemsSource = null;
            ItemResults.Clear();

            //SearchResults.Text = string.Empty;
            foreach (Item item in items)
            {
                if (!(item.Species.ToLower().Contains("Dog".ToLower()))) continue;
                // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;

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

            // ?????   List<Item> Items = new List<Item>();


            //ItemsSource.Columns.Add(new Item("Test1", 0.99, "Test2", "Test3", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Dog.jfif"))); */
        }

        /// <summary>
        /// Clicking on the Cat image will bring up all of the Cat items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CatButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            foreach (Item item in items)
            {
                if (!(item.Species.ToLower().Contains("Cat".ToLower()))) continue;
                // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                // SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;
        

        }

        /// <summary>
        /// Clicking on the Fish image will bring up all the Fish items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            foreach (Item item in items)
            {
                if (!(item.Species.ToLower().Contains("Fish".ToLower()))) continue;
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;
        
        }

        /// <summary>
        /// Clicking on the Small Animals image will bring up all the Small Animals items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            foreach (Item item in items)
            {
                if (!(item.Species.ToLower().Contains("Small Animal".ToLower()))) continue;
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Reptile image will bring up all the Reptile items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReptileButton_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            foreach (Item item in items)
            {
                if (!(item.Species.ToLower().Contains("Reptile".ToLower()))) continue;
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;
        
    }

        /// <summary>
        /// This method takes out the word "Search" from the Search box as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSearchFromBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("Search")) SearchBox.Text = "";
        }

        /// <summary>
        /// If the Search Box has no content, display "Search".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSearchToBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("")) SearchBox.Text = "Search";
        }

        /// <summary>
        /// This method will use the "Enter" key after entering words in the
        /// Search box to retrieve the search results. 
        /// All characters will be compared in lowercase.
        /// Earlier results will be cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                // SearchBox.Text = "You entered: " + SearchBox.Text;
                // Next need to go to the search results page...
                Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                ItemResults.Clear();
                foreach (Item item in items)
                {
                    if (!((item.Species.ToLower().StartsWith(SearchBox.Text.ToLower())) || (item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower())) || (item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower())) || (item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower())) || (item.ItemName.ToLower().Contains(SearchBox.Text.ToLower() + " ")) || (item.Category.ToLower().Contains(SearchBox.Text.ToLower())))) continue;
                    // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                    //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                    ItemResults.Add(item);
                }

                ResultGrid.ItemsSource = ItemResults;
            
        }
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void SearchResults_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        /// <summary>
        /// The View All Items button will display all of the store's items.
        /// Earlier results will be cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAll_Click(object sender, RoutedEventArgs e)
        {
            Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            foreach (Item item in items)
            {
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            ResultGrid.ItemsSource = ItemResults;
        
    }
        /// <summary>
        /// When the Pet Store logo is clicked on by the mouse, it goes to the Home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Page_Control.SelectedIndex = 0;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
    }

/* Using this reference website:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/