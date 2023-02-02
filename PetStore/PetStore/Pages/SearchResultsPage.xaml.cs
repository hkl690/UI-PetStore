using System.Windows;
using System.Windows.Input;

namespace PetStore.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Window
    {
        public SearchResultsPage(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private MainWindow main;
        private void SelectButtonClicked(object sender, RoutedEventArgs e)
        {
            //Page_Control.SelectedIndex = 2;
        }
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Page_Control.SelectedIndex = 0;

            Visibility = Visibility.Hidden;
            main.HideHomePageWindow();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }        /// <summary>
                 /// This method takes out the word "Search" from the Search box as needed.
                 /// </summary>
                 /// <param name="sender"></param>
                 /// <param name="e"></param>
        private void RemoveSearchFromBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("Search")) SearchBox.Text = "";
        }

        /// <summary>
        /// If the Search Box has no content, display "Search".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSearchToBox(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Equals("")) SearchBox.Text = "Search";
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
                main.ItemResults.Clear();
                main.Visibility = Visibility.Hidden;
                this.Visibility = Visibility.Visible;

                foreach (Item item in main.Items)
                {
                    if (!((item.Species.ToLower().StartsWith(SearchBox.Text.ToLower())) || (item.Species.ToLower().Contains(" " + SearchBox.Text.ToLower())) || (item.Price.ToString().ToLower().Contains(SearchBox.Text.ToLower())) || (item.ItemName.ToLower().Contains(" " + SearchBox.Text.ToLower())) || (item.ItemName.ToLower().Contains(SearchBox.Text.ToLower() + " ")) || (item.Category.ToLower().Contains(SearchBox.Text.ToLower())))) continue;
                    // System.Diagnostics.Debug.WriteLine(item.Species + item.Price + item.ItemName + item.Category + item.Picture.ToString());
                    //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                    main.ItemResults.Add(item);
                }

                this.ResultGrid.ItemsSource = main.ItemResults;

            }
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
