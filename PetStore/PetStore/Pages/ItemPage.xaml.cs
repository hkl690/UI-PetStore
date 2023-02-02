﻿using System.Windows;
using System.Windows.Input;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for ItemPage.xaml
    /// </summary>
    public partial class ItemPage : Window
    {
        /// <summary>
        /// Initialize and display the Item that was
        /// </summary>
        /// <param name="homePage"></param>
        /// <param name="searchResultsPage"></param>
        public ItemPage(HomePage homePage, SearchResultsPage searchResultsPage, SignInPage signInPage)
        {
            InitializeComponent();
            home = homePage;
            search = searchResultsPage;
            this.signIn = signInPage;
        }

        private HomePage home;

        private SearchResultsPage search;

        private SignInPage signIn;

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
        /// Search box to retrieve the search results. 
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
                // Next need to go to the search results page...
                // Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                home.ItemResults.Clear();
                search.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;

                foreach (Item item in home.Items)
                {
                    if (!(item.Species.ToLower().StartsWith(SearchBox.Text.ToLower()) || item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower()) || item.ItemName.ToLower().Contains(SearchBox.Text.ToLower()) || item.Category.ToLower().Contains(SearchBox.Text.ToLower())))
                    {
                        continue;
                    }
                    // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                    //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                    home.ItemResults.Add(item);
                }

                search.ResultGrid.ItemsSource = home.ItemResults;

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

            home.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Press the Sign in button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            signIn.Visibility = Visibility.Visible;
        }
    }
}