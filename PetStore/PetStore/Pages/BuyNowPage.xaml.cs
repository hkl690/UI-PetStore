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
using System.Windows.Shapes;
using PetStore.Objects;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for BuyNowPage.xaml
    /// </summary>
    public partial class BuyNowPage : Window
    {
        /// <summary>
        /// Let the HomePage know BuyNowPage is initialized
        /// </summary>
        /// <param name="homePage"></param>
        public BuyNowPage(HomePage homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        public void InitializeSearchResultsPage(SearchResultsPage search)
        {
            searchPage = search;
        }

        public void InitializeSignInOptionsPage(SignInOptionsPage signInOptions)
        {
            signInOptionsPage = signInOptions;
        }

        public void InitializeCreateUserAccountPage(CreateUserAccountPage createUserAccount)
        {
            createUserAccountPage = createUserAccount;
        }

        public void InitializeItemPage(ItemPage item)
        {
            itemPage = item;
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
        private SignInOptionsPage signInOptionsPage;
        private CreateUserAccountPage createUserAccountPage;
        private ItemPage itemPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;
        private Item currentItem;

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
            signInOptionsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        #endregion

        /// <summary>
        /// This method puts the current item to be purchased into a list
        /// to display on the Review Order Page.
        /// </summary>
        /// <param name="itemPurchased"></param>
        public void setCurrentItem(Item itemPurchased)
        {
            currentItem = itemPurchased;
            List<Item> itemList = new List<Item>();
            itemList.Add(currentItem);
            reviewOrderPage.ReviewOrderGrid.ItemsSource = itemList.AsEnumerable();
        }

        private void ReviewOrderButton_Click(object sender, RoutedEventArgs e)
        {           
            reviewOrderPage.Visibility = Visibility.Visible;
            Visibility=Visibility.Hidden;
        }
    }
}