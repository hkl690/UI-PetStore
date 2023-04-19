using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PetStore.Objects;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for CreateUserAccount.xaml
    /// </summary>
    public partial class CreateUserAccountPage : Window
    {
        public string customerFirstName = String.Empty;
        public string customerLastName = String.Empty;
        public string customerEmail = String.Empty;
        public string customerPassword = String.Empty;

        public void InitializeSignInOptionsPage(SignInOptionsPage signInOptions)
        {
            signInOptionsPage = signInOptions;
        }
        public CreateUserAccountPage(HomePage home)
        {
            InitializeComponent();
            homePage = home;
        }
        public void InitializeUserAccountMadePage(UserAccountMadePage userAccountMade)
        {
            userAccountMadePage = userAccountMade;
        }
        public void InitializeSearchResultsPage(SearchResultsPage search)
        {
            searchPage = search;
        }
        public void InitializeItemPage(ItemPage item)
        {
            itemProduct = item;
        }
        public void InitializeBuyNowPage(BuyNowPage buyNow)
        {
            buyNowPage = buyNow;
        }
        public void InitializeShoppingCartPage(ShoppingCartPage shoppingCart)
        {
            shoppingCartPage = shoppingCart;
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
        private UserAccountMadePage userAccountMadePage;
        private ItemPage itemProduct;
        private BuyNowPage buyNowPage;
        private ShoppingCartPage shoppingCartPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;

        #region Searchbox
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
        #endregion

        #region PetStoreLogo
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
        
        #region Textbox Displays
        /// <summary>
        /// If the firstName textbox has no content, display "First Name"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (firstName.Text.Equals(""))
            {
                firstName.Text = "First Name";
            }
        }

        /// <summary>
        /// This method takes out the words "First Name" from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstName.Text.Equals("First Name"))
            {
                firstName.Text = "";
            }
        }

        /// <summary>
        /// This method displays "Last Name" in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (lastName.Text.Equals(""))
            {
                lastName.Text = "Last Name";
            }
        }

        /// <summary>
        /// This method takes out the words "Last Name" from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastName.Text.Equals("Last Name"))
            {
                lastName.Text = "";
            }
        }

        /// <summary>
        /// This method displays "Email" in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text.Equals(""))
            {
                email.Text = "Email";
            }
        }

        /// <summary>
        /// This method takes out the word "Email" from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text.Equals("Email"))
            {
                email.Text = "";
            }
        }

        /// <summary>
        /// This method displays "Password" in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text.Equals(""))
            {
                password.Text = "Password";
            }
        }

        /// <summary>
        /// This method takes out the word "Password" from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text.Equals("Password"))
            {
                password.Text = "";
            }
        }
        #endregion

        /// <summary>
        /// Press the Submit button, save Customer data
        /// this will also clear the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            customerFirstName = firstName.Text;
            customerLastName = lastName.Text;
            customerEmail = email.Text;
            customerPassword = password.Text;
            if ("First Name".Equals(customerFirstName))
            {
                MessageBox.Show("Error: Please fill in your first name.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            } else if ("Last Name".Equals(customerLastName))
            {
                MessageBox.Show("Error: Please fill in your last name.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if ("Email".Equals(customerEmail))
            {
                MessageBox.Show("Error: Please fill in your email.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if( "Password".Equals(customerPassword))
            {
                MessageBox.Show("Error: Please fill in your password.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            List<string> existingEmails = new List<string>();

            if(File.Exists("userAccounts.csv"))
            {
                foreach (string line in File.ReadAllLines("userAccounts.csv"))
                {
                    string[] userLine = line.Split(',');
                    existingEmails.Add((string)userLine.GetValue(2));
                }

                if (existingEmails.Contains(customerEmail))
                {
                    MessageBox.Show("Error: The provided email already exists.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            File.AppendAllText("userAccounts.csv", $"{customerFirstName},{customerLastName},{customerEmail},{customerPassword}\n");
            firstName.Text = "";
            lastName.Text = "";
            email.Text = "";
            password.Text = "";
            firstName.Text = "First Name";
            lastName.Text = "Last Name";
            email.Text = "Email";
            password.Text = "Password";
            // Pressing submit will take them to the UserAccountMadePage
            userAccountMadePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}

