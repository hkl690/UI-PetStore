using System.Windows;
using System.Windows.Input;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Window
    {
        /// <summary>
        /// The homePage is being passed in to the Search Results page
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

        private readonly HomePage homePage;

        private ItemPage itemProduct;

        private SignInPage signInPage;

        /// <summary>
        /// Press the Select button from the Search Results page to select a product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButtonClicked(object sender, RoutedEventArgs e)
        {
            //Page_Control.SelectedIndex = 2;
            itemProduct.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;

        }

        /// <summary>
        /// Click on the PetStore logo to go back to the homePage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Page_Control.SelectedIndex = 0;

            homePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Press the Sign in button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            signInPage.Visibility = Visibility.Visible;
            Visibility=Visibility.Hidden;
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
                homePage.ItemResults.Clear();
                Visibility = Visibility.Visible;
                homePage.Visibility = Visibility.Hidden;

                foreach (Item item in homePage.Items)
                {
                    if (!(item.Species.ToLower().StartsWith(SearchBox.Text.ToLower()) || item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(SearchBox.Text.ToLower()) || item.Category.ToLower().Contains(SearchBox.Text.ToLower())))
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
    }
}
