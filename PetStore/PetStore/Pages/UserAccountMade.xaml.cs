﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PetStore.Objects;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for UserAccountMade.xaml
    /// </summary>
    public partial class UserAccountMadePage : Window
    {
        
        public void InitializeSignInOptionsPage(SignInOptionsPage signInOptions)
        {
            signInOptionsPage = signInOptions;
        }
        public UserAccountMadePage(HomePage home)
        {
            InitializeComponent();
            homePage = home;
        }
        public void InitializeCreateUserAccountPage(CreateUserAccountPage createUserAccount)
        {
            createUserAccountPage = createUserAccount;
        }
        public void InitializeSearchResultsPage(SearchResultsPage search)
        {
            searchPage = search;
        }
        public void InitializeItemPage(ItemPage item)
        {
            itemProduct = item;
        }
        public void InitializePaymentPage(PaymentPage payment)
        {
            paymentPage = payment;
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
        private CreateUserAccountPage createUserAccountPage;
        private ItemPage itemProduct;
        private PaymentPage paymentPage;
        private ShoppingCartPage shoppingCartPage;
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

        /// <summary>
        /// Press the Back to the Pet Store button to go to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToPetStore_Button_Click(object sender, RoutedEventArgs e)
        {
            homePage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
    }
}

