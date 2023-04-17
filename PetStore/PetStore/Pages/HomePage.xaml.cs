﻿using PetStore.Objects;
using PetStore.Pages;
using System;
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
        private readonly SignInOptionsPage signInOptionsPage;
        private readonly CreateUserAccountPage createUserAccountPage;
        private readonly UserAccountMadePage userAccountMadePage;
        private readonly BuyNowPage buyNowPage;
        private readonly ReviewOrderPage reviewOrderPage;
        private readonly ReceiptPage receiptPage;

        
        public HomePage()
        {
            #region Adding all items to the collection
            // Adding all items to the Item Collection and then initializing

            // Dog 15 items            
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Dog", 6.99, "Dog Treat", "Food", "Satisy your dog's need to chew with\nthis great-tasting treat that also helps\nsupport his teeth.", "\\Images\\Dog\\Food\\Dog Treat.png"));
            Items.Add(new Item("Dog", 14.99, "Dry Dog Food", "Food", "", "\\Images\\Dog\\Food\\Dry Dog Food.png"));
            Items.Add(new Item("Dog", 2.99, "Wet Dog Food", "Food", "", "\\Images\\Dog\\Food\\Wet Dog Food.png"));
            Items.Add(new Item("Dog", 8.99, "Dog Brush", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Brush.png"));
            Items.Add(new Item("Dog", 8.99, "Dog Car Seat", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Car Seat.png"));
            Items.Add(new Item("Dog", 29.99, "Dog Carrier", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Carrier.png"));
            Items.Add(new Item("Dog", 4.99, "Dog Collar", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Collar.png"));
            Items.Add(new Item("Dog", 8.99, "Dog Flea Medication", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Flea Med.jpg"));
            Items.Add(new Item("Dog", 9.99, "Dog Harness", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Harness.jpg"));
            Items.Add(new Item("Dog", 49.99, "Dog House", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog House.jpg"));
            Items.Add(new Item("Dog", 6.99, "Dog Leash", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Leash.png"));
            Items.Add(new Item("Dog", 59.99, "Dog Stroller", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Stroller.png"));
            Items.Add(new Item("Dog", 5.99, "Dog Training Pads", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Training Pad.png"));
            Items.Add(new Item("Dog", 14.99, "Dog Water Fountain", "Supplies", "", "\\Images\\Dog\\Supplies\\Dog Water Fountain.png"));
            Items.Add(new Item("Dog", 14.99, "Pet Stain Remover", "Supplies", "", "\\Images\\Dog\\Supplies\\Pet Stain Remover.png"));

            // Cat 13 items
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Cat", 3.99, "Cat Treat", "Food", "", "\\Images\\Cat\\Food\\Cat Treat.png"));
            Items.Add(new Item("Cat", 9.99, "Cat Dry Food", "Food", "", "\\Images\\Cat\\Food\\Dry Cat Food.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Wet Food", "Food", "", "\\Images\\Cat\\Food\\Wet Cat Food.png"));
            Items.Add(new Item("Cat", 3.99, "Cat Brush", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Brush.png"));
            Items.Add(new Item("Cat", 29.99, "Cat Carrier", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Carrier.png"));
            Items.Add(new Item("Cat", 4.99, "Cat Collar", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Collar.png"));
            Items.Add(new Item("Cat", 8.99, "Cat Flea Medication", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Flea Med.png"));
            Items.Add(new Item("Cat", 9.99, "Cat Harness", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Harness.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Litter Box", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Litter Box.png"));
            Items.Add(new Item("Cat", 8.99, "Cat Litter", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Litter.png"));
            Items.Add(new Item("Cat", 24.99, "Cat Scratcher", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Scratcher.png"));
            Items.Add(new Item("Cat", 49.99, "Cat Tree", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Tree.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Water Fountain", "Supplies", "", "\\Images\\Cat\\Supplies\\Cat Water Fountain.png"));

            // Small Animal 12 items
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Small Animal", 5.99, "Bird Food Crickets", "Food", "", "\\Images\\Small Animal\\Food\\Bird Food Crickets.png"));
            Items.Add(new Item("Small Animal", 4.99, "Bird Food", "Food", "", "\\Images\\Small Animal\\Food\\Bird Food.png"));
            Items.Add(new Item("Small Animal", 5.99, "Guinea Pig Food", "Food", "", "\\Images\\Small Animal\\Food\\Guinea Pig Food.png"));
            Items.Add(new Item("Small Animal", 6.99, "Hamster and Gerbil Food", "Food", "", "\\Images\\Small Animal\\Food\\Hamster and Gerbil Food.png"));
            Items.Add(new Item("Small Animal", 7.99, "Hedgehog Food", "Food", "", "\\Images\\Small Animal\\Food\\Hedgehog Food.png"));
            Items.Add(new Item("Small Animal", 4.99, "Mouse and Rat Food", "Food", "", "\\Images\\Small Animal\\Food\\Mouse and Rat Food.png"));
            Items.Add(new Item("Small Animal", 7.99, "Rabbit Food", "Food", "", "\\Images\\Small Animal\\Food\\Rabbit Food.png"));
            Items.Add(new Item("Small Animal", 9.99, "Bed", "Supplies", "", "\\Images\\Small Animal\\Supplies\\Bed.png"));
            Items.Add(new Item("Small Animal", 5.99, "Bedding", "Supplies", "", "\\Images\\Small Animal\\Supplies\\Bedding.png"));
            Items.Add(new Item("Small Animal", 99.99, "Bird Habitat", "Supplies", "", "\\Images\\Small Animal\\Supplies\\Bird Habitat.png"));
            Items.Add(new Item("Small Animal", 19.99, "Heating Pad", "Supplies", "", "\\Images\\Small Animal\\Supplies\\Heating Pad.png"));
            Items.Add(new Item("Small Animal", 6.99, "Water Bottle", "Supplies", "", "\\Images\\Small Animal\\Supplies\\Water Bottle.png"));

            // Fish 4 items
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Fish", 7.99, "Fish Food", "Food", "", "\\Images\\Fish\\Food\\Fish Food.png"));
            Items.Add(new Item("Fish", 9.99, "Pond Fish Food", "Food", "", "\\Images\\Fish\\Food\\Pond Fish Food.png"));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Filter", "Supplies", "", "\\Images\\Fish\\Supplies\\Fish Aquarium Filter.png"));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Starter Kit", "Supplies", "", "\\Images\\Fish\\Supplies\\Fish Aquarium Starter Kit.png"));

            // Reptile 11 items
            // Descriptions are empty strings for now, still need to write those
            Items.Add(new Item("Reptile", 9.99, "Reptile Food Crickets", "Food", "", "\\Images\\Reptile\\Food\\Reptile Food Crickets.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Dried Insects", "Food", "", "\\Images\\Reptile\\Food\\Reptile Food Dried Insects.png"));
            Items.Add(new Item("Reptile", 19.99, "Reptile Food Frozen Mice", "Food", "", "\\Images\\Reptile\\Food\\Reptile Food Frozen Mice.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Omnivore", "Food", "", "\\Images\\Reptile\\Food\\Reptile Food Omnivore.png"));
            Items.Add(new Item("Reptile", 8.99, "Turtle Food", "Food", "", "\\Images\\Reptile\\Food\\Turtle Food.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Bedding", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Bedding.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Filter", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Habitat Filter.png"));
            Items.Add(new Item("Reptile", 14.95, "Reptile Habitat Sand", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Habitat Sand.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Soil", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Habitat Soil.png"));
            Items.Add(new Item("Reptile", 99.99, "Reptile Habitat", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Habitat.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Heat Light", "Supplies", "", "\\Images\\Reptile\\Supplies\\Reptile Heat Light.png"));
            #endregion

            #region Initializing pages
            InitializeComponent();
            signInOptionsPage = new SignInOptionsPage(this);
            createUserAccountPage = new CreateUserAccountPage(this);
            userAccountMadePage = new UserAccountMadePage(this);
            searchResultsPage = new SearchResultsPage(this);
            itemPage = new ItemPage(this);
            buyNowPage = new BuyNowPage(this);
            reviewOrderPage = new ReviewOrderPage(this);
            receiptPage = new ReceiptPage(this);
            searchResultsPage.InitializeItemPage(itemPage);
            searchResultsPage.InitializeSignInOptionsPage(signInOptionsPage);
            searchResultsPage.InitializeCreateUserAccountPage(createUserAccountPage);
            searchResultsPage.InitializeUserAccountMadePage(userAccountMadePage);
            searchResultsPage.InitializeBuyNowPage(buyNowPage);
            searchResultsPage.InitializeReviewOrderPage(reviewOrderPage);
            searchResultsPage.InitializeReceiptPage(receiptPage);
            itemPage.InitializeSignInOptionsPage(signInOptionsPage);
            itemPage.InitializeCreateUserAccountPage(createUserAccountPage);
            itemPage.InitializeUserAccountMadePage(userAccountMadePage);
            itemPage.InitializeSearchResultsPage(searchResultsPage);
            itemPage.InitializeBuyNowPage(buyNowPage);
            itemPage.InitializeReviewOrderPage(reviewOrderPage);
            itemPage.InitializeReceiptPage(receiptPage);
            buyNowPage.InitializeSignInOptionsPage(signInOptionsPage);
            buyNowPage.InitializeCreateUserAccountPage(createUserAccountPage);
            buyNowPage.InitializeUserAccountMadePage(userAccountMadePage);
            buyNowPage.InitializeSearchResultsPage(searchResultsPage);
            buyNowPage.InitializeItemPage(itemPage);
            buyNowPage.InitializeReviewOrderPage(reviewOrderPage);
            buyNowPage.InitializeReceiptPage(receiptPage);
            signInOptionsPage.InitializeCreateUserAccountPage(createUserAccountPage);
            signInOptionsPage.InitializeUserAccountMadePage(userAccountMadePage);
            signInOptionsPage.InitializeSearchResultsPage(searchResultsPage);
            signInOptionsPage.InitializeItemPage(itemPage);
            signInOptionsPage.InitializeReviewOrderPage(reviewOrderPage);
            signInOptionsPage.InitializeReceiptPage(receiptPage);
            createUserAccountPage.InitializeSignInOptionsPage(signInOptionsPage);
            createUserAccountPage.InitializeUserAccountMadePage(userAccountMadePage);
            createUserAccountPage.InitializeSearchResultsPage(searchResultsPage);
            createUserAccountPage.InitializeItemPage(itemPage);
            createUserAccountPage.InitializeBuyNowPage(buyNowPage);
            createUserAccountPage.InitializeReviewOrderPage(reviewOrderPage);
            createUserAccountPage.InitializeReceiptPage(receiptPage);
            userAccountMadePage.InitializeSignInOptionsPage(signInOptionsPage);
            userAccountMadePage.InitializeSearchResultsPage(searchResultsPage);
            userAccountMadePage.InitializeItemPage(itemPage);
            userAccountMadePage.InitializeCreateUserAccountPage(createUserAccountPage);
            userAccountMadePage.InitializeBuyNowPage(buyNowPage);
            userAccountMadePage.InitializeReviewOrderPage(reviewOrderPage);
            userAccountMadePage.InitializeReceiptPage(receiptPage);
            reviewOrderPage.InitializeSignInOptionsPage(signInOptionsPage);
            reviewOrderPage.InitializeCreateUserAccountPage(createUserAccountPage);
            reviewOrderPage.InitializeUserAccountMadePage(userAccountMadePage);
            reviewOrderPage.InitializeItemPage(itemPage);
            reviewOrderPage.InitializeSearchResultsPage(searchResultsPage);
            reviewOrderPage.InitializeReceiptPage(receiptPage);
            reviewOrderPage.InitializeBuyNowPage(buyNowPage);
            receiptPage.InitializeSearchResultsPage(searchResultsPage);
            receiptPage.InitializeSignInOptionsPage(signInOptionsPage);
            receiptPage.InitializeItemPage(itemPage);
            receiptPage.InitializeBuyNowPage(buyNowPage);
            receiptPage.InitializeCreateUserAccountPage(createUserAccountPage);
            receiptPage.InitializeUserAccountMadePage(userAccountMadePage);
            receiptPage.InitializeReviewOrderPage(reviewOrderPage);
            #endregion

            #region Visibility of pages
            itemPage.Visibility = Visibility.Hidden;
            searchResultsPage.Visibility = Visibility.Hidden;
            signInOptionsPage.Visibility = Visibility.Hidden;
            createUserAccountPage.Visibility = Visibility.Hidden;
            userAccountMadePage.Visibility = Visibility.Hidden;
            buyNowPage.Visibility = Visibility.Hidden;
            reviewOrderPage.Visibility = Visibility.Hidden;
            receiptPage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
            #endregion

            SearchBox.Text = "Search";
        }

        #region HomePage Animal Button clicks
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
        #endregion

        #region Search box logic
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
                // Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                ItemResults.Clear();
                searchResultsPage.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;

                foreach (Item item in Items)
                {
                    if (!(item.Species.ToLower().StartsWith(SearchBox.Text.ToLower()) 
                        || item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower()) 
                        || item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower()) 
                        || item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower()) 
                        || item.ItemName.ToLower().Contains(SearchBox.Text.ToLower()) 
                        || item.Category.ToLower().Contains(SearchBox.Text.ToLower())))
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
        #endregion

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

        #region PetStore logo
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
        #endregion

        
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {            
            signInOptionsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        

        public void HideHomePageWindow()
        {
            Visibility = Visibility.Hidden;
        }
    }
}

/* Model View reference:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/