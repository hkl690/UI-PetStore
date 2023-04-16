using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using PetStore.Objects;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for SignInOptions.xaml
    /// </summary>
    public partial class SignInOptionsPage : Window
    {
        public string customerFirstName = String.Empty;
        public string customerLastName = String.Empty;
        public string customerEmail = String.Empty;
        public string customerPassword = String.Empty;

        public SignInOptionsPage(HomePage home)
        {
            InitializeComponent();
            homePage = home;
        }        
        public void InitializeCreateUserAccountPage(CreateUserAccountPage createUserAccount)
        {
            createUserAccountPage = createUserAccount;
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
        private CreateUserAccountPage createUserAccountPage;
        private UserAccountMadePage userAccountMadePage;
        private ItemPage itemProduct;
        private BuyNowPage buyNowPage;
        private ReviewOrderPage reviewOrderPage;
        private ReceiptPage receiptPage;

        #region Header
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
            homePage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
        }
        #endregion

        #region Textbox Displays
        /*
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
*/
/*
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
*/
/*
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
*/
/*
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
*/
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
            //   customerFirstName = firstName.Text;
            //   customerLastName = lastName.Text;
            customerEmail = email.Text;
            customerPassword = password.Text;
            // check the csv file with userLine
            string[] userLine = new string[] { };
            if (!(File.Exists("userAccounts.csv")))
            {
                MessageBox.Show("Error: Please create an account.", "Invalid", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            if (File.Exists("userAccounts.csv"))
            {
                foreach (string line in File.ReadAllLines("userAccounts.csv"))
                {
                    userLine = line.Split(',');

                    if (userLine.GetValue(2).ToString().Equals(customerEmail) &&
                        userLine.GetValue(3).ToString().Equals(customerPassword))
                    {
                        break;
                    }
                    
                }
                if (userLine.GetValue(2).ToString().Equals("Email") &&
                    userLine.GetValue(3).ToString().Equals("Password"))
                {
                    MessageBox.Show("Sign in with your registered email and password.", "Invalid", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }

                if (!(userLine.GetValue(2).ToString().Equals(customerEmail) && userLine.GetValue(3).ToString().Equals(customerPassword)))
                {
                    MessageBox.Show("The provided email and password do not exist.", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }
            


            //   firstName.Text = "";
            //   lastName.Text = "";
            email.Text = "";
            password.Text = "";
         //   firstName.Text = "First Name";
         //   lastName.Text = "Last Name";
            email.Text = "Email";
            password.Text = "Password";
            homePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }

        // this might be useless now
        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // this might be useless now
        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private void CreateUserAccount_Click(object sender, RoutedEventArgs e)
        {
            createUserAccountPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
    }
}

