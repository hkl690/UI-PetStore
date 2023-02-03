using PetStore.Pages;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace PetStore
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public ObservableCollection<Item> ItemResults = new();
        private readonly ItemPage itemPage;
        private readonly SearchResultsPage searchResultsPage;
        private readonly SignInPage signInPage;

        /// <summary>
        /// Adding all items to the Item Collection and then initializing
        /// </summary>
        public HomePage()
        {
            // Dog items
            // Images aren't working
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Dog", 6.99, "Dog Treat", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Dog Treat.png"), ""));
            Items.Add(new Item("Dog", 14.99, "Dry Dog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Dry Dog Food.png"), ""));
            Items.Add(new Item("Dog", 2.99, "Wet Dog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Food\\Wet Dog Food.png"), ""));
            Items.Add(new Item("Dog", 8.99, "Dog Brush", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Brush.png"), ""));
            Items.Add(new Item("Dog", 8.99, "Dog Car Seat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Car Seat.png"), ""));
            Items.Add(new Item("Dog", 29.99, "Dog Carrier", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Carrier.png"), ""));
            Items.Add(new Item("Dog", 4.99, "Dog Collar", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Collar.png"), ""));
            Items.Add(new Item("Dog", 8.99, "Dog Flea Medication", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Flea Med.jpg"), ""));
            Items.Add(new Item("Dog", 9.99, "Dog Harness", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Harness.jpg"), ""));
            Items.Add(new Item("Dog", 49.99, "Dog House", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog House.jpg"), ""));
            Items.Add(new Item("Dog", 6.99, "Dog Leash", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Leash.png"), ""));
            Items.Add(new Item("Dog", 59.99, "Dog Stroller", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Stroller.png"), ""));
            Items.Add(new Item("Dog", 5.99, "Dog Training Pads", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Training Pad.png"), ""));
            Items.Add(new Item("Dog", 14.99, "Dog Water Fountain", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Dog Water Fountain.png"), ""));
            Items.Add(new Item("Dog", 14.99, "Pet Stain Remover", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Dog\\Supplies\\Pet Stain Remover.png"), ""));

            // Cat items
            // Images aren't working
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Cat", 3.99, "Cat Treat", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Cat Treat.png"), ""));
            Items.Add(new Item("Cat", 9.99, "Cat Dry Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Dry Cat Food.png"), ""));
            Items.Add(new Item("Cat", 14.99, "Cat Wet Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Food\\Wet Cat Food.png"), ""));
            Items.Add(new Item("Cat", 3.99, "Cat Brush", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Brush.png"), ""));
            Items.Add(new Item("Cat", 29.99, "Cat Carrier", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Carrier.png"), ""));
            Items.Add(new Item("Cat", 4.99, "Cat Collar", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Collar.png"), ""));
            Items.Add(new Item("Cat", 8.99, "Cat Flea Medication", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Flea Med.png"), ""));
            Items.Add(new Item("Cat", 9.99, "Cat Flea Harness", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Harness.png"), ""));
            Items.Add(new Item("Cat", 14.99, "Cat Litter Box", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Litter Box.png"), ""));
            Items.Add(new Item("Cat", 8.99, "Cat Litter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Litter.png"), ""));
            Items.Add(new Item("Cat", 24.99, "Cat Scratcher", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Scratcher.png"), ""));
            Items.Add(new Item("Cat", 49.99, "Cat Tree", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Tree.png"), ""));
            Items.Add(new Item("Cat", 14.99, "Cat Water Fountain", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Cat\\Supplies\\Cat Water Fountain.png"), ""));

            // Small Animal items
            // Images aren't working
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Small Animal", 5.99, "Bird Food Crickets", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Bird Food Crickets.png"), ""));
            Items.Add(new Item("Small Animal", 4.99, "Bird Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Bird Food.png"), ""));
            Items.Add(new Item("Small Animal", 5.99, "Guinea Pig Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Guinea Pig Food.png"), ""));
            Items.Add(new Item("Small Animal", 6.99, "Hamster and Gerbil Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Hamster and Gerbil Food.png"), ""));
            Items.Add(new Item("Small Animal", 7.99, "Hedgehog Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Hedgehog Food.png"), ""));
            Items.Add(new Item("Small Animal", 4.99, "Mouse and Rat Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Mouse and Rat Food.png"), ""));
            Items.Add(new Item("Small Animal", 7.99, "Rabbit Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Food\\Rabbit Food.png"), ""));
            Items.Add(new Item("Small Animal", 9.99, "Bed", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bed.png"), ""));
            Items.Add(new Item("Small Animal", 5.99, "Bedding", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bedding.png"), ""));
            Items.Add(new Item("Small Animal", 99.99, "Bird Habitat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Bird Habitat.png"), ""));
            Items.Add(new Item("Small Animal", 19.99, "Heating Pad", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Heating Pad.png"), ""));
            Items.Add(new Item("Small Animal", 6.99, "Water Bottle", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Small Animal\\Supplies\\Water Bottle.png"), ""));

            // Fish items
            // Images aren't working
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Fish", 7.99, "Fish Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Food\\Fish Food.png"), ""));
            Items.Add(new Item("Fish", 9.99, "Pond Fish Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Food\\Pond Fish Food.png"), ""));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Filter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Supplies\\Fish Aquarium Filter.png"), ""));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Starter Kit", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Fish\\Supplies\\Fish Aquarium Starter Kit.png"), ""));

            // Reptile items
            // Images aren't working
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Reptile", 9.99, "Reptile Food Crickets", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Crickets.png"), ""));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Dried Insects", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Dried Insects.png"), ""));
            Items.Add(new Item("Reptile", 19.99, "Reptile Food Frozen Mice", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Frozen Mice.png"), ""));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Omnivore", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Reptile Food Omnivore.png"), ""));
            Items.Add(new Item("Reptile", 8.99, "Turtle Food", "Food", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Food\\Turtle Food.png"), ""));
            Items.Add(new Item("Reptile", 9.99, "Reptile Bedding", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Bedding.png"), ""));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Filter", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Filter.png"), ""));
            Items.Add(new Item("Reptile", 14.95, "Reptile Habitat Sand", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Sand.png"), ""));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Soil", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat Soil.png"), ""));
            Items.Add(new Item("Reptile", 99.99, "Reptile Habitat", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Habitat.png"), ""));
            Items.Add(new Item("Reptile", 8.99, "Reptile Heat Light", "Supplies", System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Reptile\\Supplies\\Reptile Heat Light.png"), ""));


            InitializeComponent();
            signInPage = new SignInPage(this);
            searchResultsPage = new SearchResultsPage(this);
            itemPage = new ItemPage(this);
            searchResultsPage.InitializeItemPage(itemPage);
            searchResultsPage.InitializeSignInPage(signInPage);
            itemPage.InitializeSignInPage(signInPage);
            itemPage.InitializeSearchResultsPage(searchResultsPage);
            signInPage.InitializeSearchResultsPage(searchResultsPage);
            signInPage.InitializeItemPage(itemPage);
            itemPage.Visibility = Visibility.Hidden;
            searchResultsPage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
            SearchBox.Text = "Search";
        }

        /// <summary>
        /// Clicking on the Dog image will bring up all of the Dog items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Dog".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Cat image will bring up all of the Cat items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CatButton_Click(object sender, RoutedEventArgs e)
        {            
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Cat".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Fish image will bring up all the Fish items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishButton_Click(object sender, RoutedEventArgs e)
        {            
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Fish".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Small Animals image will bring up all the Small Animals items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            // Page_Control.SelectedIndex = 1;
            // SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Small Animal".ToLower()))
                {
                    continue;
                }
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Reptile image will bring up all the Reptile items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReptileButton_Click(object sender, RoutedEventArgs e)
        {
            // Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Reptile".ToLower()))
                {
                    continue;
                }
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// This method takes out the word "Search" from the Search box as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSearchFromBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("Search"))
            {
                SearchBox.Text = "";
            }
        }

        /// <summary>
        /// If the Search Box has no content, display "Search".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSearchToBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals(""))
            {
                SearchBox.Text = "Search";
            }
        }

        /// <summary>
        /// This method will use the "Enter" key after entering words in the
        /// Search box to retrieve the searchPage results. 
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
                // Next need to go to the searchPage results page...
                // Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                ItemResults.Clear();
                searchResultsPage.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;

                foreach (Item item in Items)
                {
                    if (!(item.Species.ToLower().StartsWith(SearchBox.Text.ToLower()) || item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(SearchBox.Text.ToLower()) || item.Category.ToLower().Contains(SearchBox.Text.ToLower())))
                    {
                        continue;
                    }
                    // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                    //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                    ItemResults.Add(item);
                }
                searchResultsPage.ResultGrid.ItemsSource = ItemResults;
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
            // Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// When the Pet Store logo is clicked on by the mouse, it goes to the Home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Page_Control.SelectedIndex = 0;

            searchResultsPage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {            
            signInPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }

        public void HideHomePageWindow()
        {
            Visibility = Visibility.Hidden;
        }



    }
}

/* Using this reference website:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/