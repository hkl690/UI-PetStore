using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for ItemPage.xaml
    /// </summary>
    public partial class ItemPage : Window
    {
        /// <summary>
        /// Initialize and display the Item that was selected
        /// </summary>
        /// <param name="homePage"></param>
        /// <param name="searchResultsPage"></param>
        public ItemPage(HomePage homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }
                
        public void InitializeSearchResultsPage(SearchResultsPage search)
        {
            searchPage = search;
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

        private HomePage homePage;
        private SearchResultsPage searchPage;
        private SignInPage signInPage;
        private BuyNowPage buyNowPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;

        #region SearchBox
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
                // Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                homePage.ItemResults.Clear();
                searchPage.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;

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
                searchPage.ResultGrid.ItemsSource = homePage.ItemResults;
                
            }
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
#endregion SearchBox

        #region PetStoreLogo
        /// <summary>
        /// Click on the PetStore logo to go back to the homePage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            homePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        #endregion

        #region SignIn button
        /// <summary>
        /// Press the Sign in button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            signInPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        #endregion

        #region Buy Now button
        /// <summary>
        /// Press the Buy Now button from the ItemPage to switch to the BuyNowPage
        /// and then the ItemPage will be hidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            homePage.ItemResults.Clear();
//           getting complicated, might come back to it later 
//           if (signInPage.customerEmail.Equals(String.Empty))
//           {
//               signInPage.Visibility = Visibility.Visible;                
//               Visibility = Visibility.Hidden;
//            }
//           else
//            {
                buyNowPage.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;
//            }
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
                homePage.ItemResults.Add(item);
            }
            ItemGrid.ItemsSource = homePage.ItemResults;            
        }

        /// <summary>
        /// This method opens the Item Page
        /// (mainly when selected from the SearchResultsPage)
        /// </summary>
        /// <param name="item"></param>
        internal void OpenItemPage(Item? item)
        {
            buyNowPage.setCurrentItem(item);
            Visibility = Visibility.Visible;
            searchPage.Visibility = Visibility.Hidden;
            List<Item> itemList = new List<Item>();
            itemList.Add(item);
            ItemGrid.ItemsSource = itemList.AsEnumerable();
        }
        #endregion
    }
}