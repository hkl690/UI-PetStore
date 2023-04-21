using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using PetStore.Objects;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for ShoppingCartPage.xaml
    /// </summary>
    public partial class ShoppingCartPage : Window
    {
        /// <summary>
        /// The HomePage is being passed in to the Search Results page
        /// </summary>
        /// <param name="homePage"></param>
        public ShoppingCartPage(HomePage home)
        {
            InitializeComponent();
            this.homePage = home;
        }
        public void InitializeSearchResultsPage(SearchResultsPage search)
        {
            searchPage = search;
        }
        public void InitializeItemPage(ItemPage item)
        {
            itemProduct = item;
        }
        public void InitializeSignInOptionsPage(SignInOptionsPage signInOptions)
        {
            signInOptionsPage = signInOptions;
        }
        public void InitializeCreateUserAccountPage(CreateUserAccountPage createUserAccount)
        {
            createUserAccountPage = createUserAccount;
        }
        public void InitializeUserAccountMadePage(UserAccountMadePage userAccountMade)
        {
            userAccountMadePage = userAccountMade;
        }
        public void InitializePaymentPage(PaymentPage payment)
        {
            paymentPage = payment;
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
        private SignInOptionsPage signInOptionsPage;
        private CreateUserAccountPage createUserAccountPage;
        private UserAccountMadePage userAccountMadePage;
        private PaymentPage paymentPage;
        private ShoppingCartPage shoppingCartPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;
        public ObservableCollection<Item> ShoppingCartItems { get; set; }
        

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
            signInOptionsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        #endregion

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

        // see the ItemPage code for setting the ShoppingCart list
        // Note that the Payment page has another list to Review the order,
        // which might be affected
        private ObservableCollection<Item> setHomepageItems;

        public ObservableCollection<Item> SetHomepageItems
        {
            get => setHomepageItems;
            set
            {
                ShoppingCartItems = value;
                setHomepageItems = value;
            }
        }
    }
}
