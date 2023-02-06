﻿using System.Windows;
using System.Windows.Input;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Window
    {
        /// <summary>
        /// The HomePage is being passed in to the Search Results page
        /// </summary>
        /// <param name="homePage"></param>
        public SearchResultsPage(HomePage home)
        {
            InitializeComponent();
            homePage = home;
        }

        public void InitializeItemPage(ItemPage item)
        {
            itemProduct = item;
        }

        public void InitializeSignInPage(SignInPage signIn)
        {
            signInPage = signIn;
        }

        public void InitializeBuyNowPage(BuyNowPage buyNow)
        {
            buyNowPage = buyNow;
        }

        public void InitializeReviewOrderPage(ReviewOrderPage reviewOrder)
        {
            reviewOrderPage = reviewOrder;
        }
        public void InitializeReceiptPage(ReceiptPage receipt)
        {
            receiptPage = receipt;
        }

        private readonly HomePage homePage;
        private SearchResultsPage searchPage;
        private ItemPage itemProduct;
        private SignInPage signInPage;
        private BuyNowPage buyNowPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;


        /// <summary>
        /// Press the Select button from the Search Results page to select an item
        /// and then the SearchResultsPage will be hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButtonClicked(object sender, RoutedEventArgs e)
        {
            itemProduct.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
            Item item = (Item)ResultGrid.Items.GetItemAt(0);
        }

        #region PetStore logo
        /// <summary>
        /// Click on the PetStore logo to go back to the homePage,
        /// and then the SearchResultsPage will be hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            homePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        #endregion

        #region Sign In button
        /// <summary>
        /// Press the Sign In button, then the Home Page will be hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            signInPage.Visibility = Visibility.Visible;
            Visibility=Visibility.Hidden;
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
        /// This method will press the "Enter" key after entering words in the
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
                homePage.ItemResults.Clear();
                Visibility = Visibility.Visible;
                homePage.Visibility = Visibility.Hidden;

                foreach (Item item in homePage.Items)
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
                    homePage.ItemResults.Add(item);
                }
                ResultGrid.ItemsSource = homePage.ItemResults;                
            
            }
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
        #endregion

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            Item item = ResultGrid.SelectedItem as Item;
            itemProduct.OpenItemPage(item);
        }
    }
}
