using PetStore.Objects;
using PetStore.Pages;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace PetStore
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public ObservableCollection<Item> ItemResults = new();
        
        private readonly ItemPage itemPage;
        private readonly SearchResultsPage searchResultsPage;
        private readonly SignInOptionsPage signInOptionsPage;
        private readonly CreateUserAccountPage createUserAccountPage;
        private readonly UserAccountMadePage userAccountMadePage;
        private readonly PaymentPage paymentPage;
        private readonly ShoppingCartPage shoppingCartPage;
        private readonly ReviewOrderPage reviewOrderPage;
        private readonly ReceiptPage receiptPage;

        
        public HomePage()
        {
            #region Adding all items to the collection
            // Adding all items to the Item Collection and then initializing

            // Dog 15 items    
            Items.Add(new Item("Dog", 6.99, "Dog Treat", "Food", "Satisfy your dog's need to chew with\nthis great-tasting treat that also helps\nsupport his teeth.", "\\Images\\Dog\\Food\\Dog Treat.png"));
            Items.Add(new Item("Dog", 14.99, "Dry Dog Food", "Food", "Every bite of this dog food is packed\nwith nutrients! Perfect for dogs of \nevery size.", "\\Images\\Dog\\Food\\Dry Dog Food.png"));
            Items.Add(new Item("Dog", 12.99, "Wet Dog Food", "Food", "Delicious wet food for your dog with \nall nutrients needed for your dog to \nbe at their best.", "\\Images\\Dog\\Food\\Wet Dog Food.png"));
            Items.Add(new Item("Dog", 8.99, "Dog Brush", "Supplies", "Get rid of shedding fur from the source \nwith this dual-sided dog hair brush.", "\\Images\\Dog\\Supplies\\Dog Brush.png"));
            Items.Add(new Item("Dog", 19.99, "Dog Car Seat", "Supplies", "Make sure your pet stays safe on the\nroad with this comfortable car seat.", "\\Images\\Dog\\Supplies\\Dog Car Seat.png"));
            Items.Add(new Item("Dog", 29.99, "Dog Carrier", "Supplies", "This Dog Carrier will ensure you can\nsafely bring your pet anywhere\nyou go.", "\\Images\\Dog\\Supplies\\Dog Carrier.png"));
            Items.Add(new Item("Dog", 4.99, "Dog Collar", "Supplies", "Upgrade your dog’s fashion with these \ncollars that come in 12 different \ncolors.", "\\Images\\Dog\\Supplies\\Dog Collar.png"));
            Items.Add(new Item("Dog", 8.99, "Dog Flea Medication", "Supplies", "Protect your dog from fleas for up to \n12 months with this effective flea \nmedication.", "\\Images\\Dog\\Supplies\\Dog Flea Med.jpg"));
            Items.Add(new Item("Dog", 9.99, "Dog Harness", "Supplies", "Safely walk your dog with this \ncomfortable Dog Harness in red.", "\\Images\\Dog\\Supplies\\Dog Harness.jpg"));
            Items.Add(new Item("Dog", 49.99, "Dog House", "Supplies", "This Dog House protects your dog\nfrom the elements and a place to rest.", "\\Images\\Dog\\Supplies\\Dog House.jpg"));
            Items.Add(new Item("Dog", 6.99, "Dog Leash", "Supplies", "Walk your dog with ease using this\nretractable leash.", "\\Images\\Dog\\Supplies\\Dog Leash.png"));
            Items.Add(new Item("Dog", 59.99, "Dog Stroller", "Supplies", "Stroll your pooch around anywhere with\nthis smooth dog stroller.", "\\Images\\Dog\\Supplies\\Dog Stroller.png"));
            Items.Add(new Item("Dog", 5.99, "Dog Training Pads", "Supplies", "Keep your house clean while \ntraining your puppy using these \ntraining pads.", "\\Images\\Dog\\Supplies\\Dog Training Pad.png"));
            Items.Add(new Item("Dog", 14.99, "Dog Water Fountain", "Supplies", "This water fountain makes sure \nyour dog always has access to \nfresh water when they need it.", "\\Images\\Dog\\Supplies\\Dog Water Fountain.png"));
            Items.Add(new Item("Dog", 14.99, "Pet Stain Remover", "Supplies", "Clean up hard to clean pet messes \nwith Oxi Clean pet stain remover.", "\\Images\\Dog\\Supplies\\Pet Stain Remover.png"));

            // Cat 13 items
            Items.Add(new Item("Cat", 3.99, "Cat Treat", "Food", "Satisfy your kitty’s cravings with these \nhealthy snacks.", "\\Images\\Cat\\Food\\Cat Treat.png"));
            Items.Add(new Item("Cat", 9.99, "Cat Dry Food", "Food", "Fill your cat’s food bowl with this\nnutritious dry food.", "\\Images\\Cat\\Food\\Dry Cat Food.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Wet Food", "Food", "This wet food is alluring for cats of all \nages and easy to mix into a healthy diet.", "\\Images\\Cat\\Food\\Wet Cat Food.png"));
            Items.Add(new Item("Cat", 3.99, "Cat Brush", "Supplies", "Get rid of your cat’s winter coat with\nthis ergonomic cat brush.", "\\Images\\Cat\\Supplies\\Cat Brush.png"));
            Items.Add(new Item("Cat", 29.99, "Cat Carrier", "Supplies", "Keep your cat in this safe and \ncomfortable carrier to bring them \nanywhere you need.", "\\Images\\Cat\\Supplies\\Cat Carrier.png"));
            Items.Add(new Item("Cat", 4.99, "Cat Collar", "Supplies", "Provide safety and style to your \nfeline with this colorful cat collar.", "\\Images\\Cat\\Supplies\\Cat Collar.png"));
            Items.Add(new Item("Cat", 8.99, "Cat Flea Medication", "Supplies", "Protect your kitty from fleas with \nthis vet recommended flea \nmedication.", "\\Images\\Cat\\Supplies\\Cat Flea Med.png"));
            Items.Add(new Item("Cat", 9.99, "Cat Harness", "Supplies", "Find the perfect fit for your cat walking \nneeds with this cute cat \nharness.", "\\Images\\Cat\\Supplies\\Cat Harness.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Litter Box", "Supplies", "Give your cat a place to go with this \nclosed style, easy cleanup litterbox.", "\\Images\\Cat\\Supplies\\Cat Litter Box.png"));
            Items.Add(new Item("Cat", 8.99, "Cat Litter", "Supplies", "Keep your kitty’s restroom fresh with \nTidy Cats cat litter.", "\\Images\\Cat\\Supplies\\Cat Litter.png"));
            Items.Add(new Item("Cat", 24.99, "Cat Scratcher", "Supplies", "Let your cat rest and relax with this \nfun and durable cat scratcher.", "\\Images\\Cat\\Supplies\\Cat Scratcher.png"));
            Items.Add(new Item("Cat", 49.99, "Cat Tree", "Supplies", "Give your cat a place to rest, exercise, \nand play on with this tall cat tree.", "\\Images\\Cat\\Supplies\\Cat Tree.png"));
            Items.Add(new Item("Cat", 14.99, "Cat Water Fountain", "Supplies", "Quench your cat’s thirst anytime \nwith this recycling cat water \nfountain.", "\\Images\\Cat\\Supplies\\Cat Water Fountain.png"));

            // Small Animal 12 items
            Items.Add(new Item("Small Animal", 5.99, "Bird Food Crickets", "Food", "Satisfy your hungry bird with these \ndelicious crickets.", "\\Images\\Small Animal\\Food\\Bird Food Crickets.png"));
            Items.Add(new Item("Small Animal", 4.99, "Bird Food", "Food", "Bird food with a variety of nuts and \ndried fruits.", "\\Images\\Small Animal\\Food\\Bird Food.png"));
            Items.Add(new Item("Small Animal", 5.99, "Guinea Pig Food", "Food", "Keep your guinea pig satisfied with\nthis nutritious blend.", "\\Images\\Small Animal\\Food\\Guinea Pig Food.png"));
            Items.Add(new Item("Small Animal", 6.99, "Hamster and Gerbil Food", "Food", "Hamster and gerbil food \npacked with vitamins needed \nfor a healthy coat.", "\\Images\\Small Animal\\Food\\Hamster and Gerbil Food.png"));
            Items.Add(new Item("Small Animal", 7.99, "Hedgehog Food", "Food", "Keep your hedgehog fast and healthy\nwith this delicious food.", "\\Images\\Small Animal\\Food\\Hedgehog Food.png"));
            Items.Add(new Item("Small Animal", 4.99, "Mouse and Rat Food", "Food", "Smaller rodent food filled with \ndifferent types of food.", "\\Images\\Small Animal\\Food\\Mouse and Rat Food.png"));
            Items.Add(new Item("Small Animal", 7.99, "Rabbit Food", "Food", "Rabbit food hopping with nutrients and \nvitamins for your rabbit friend.", "\\Images\\Small Animal\\Food\\Rabbit Food.png"));
            Items.Add(new Item("Small Animal", 9.99, "Bed", "Supplies", "Give your small pet friend a place to \nsleep with this comfortable bed.", "\\Images\\Small Animal\\Supplies\\Bed.png"));
            Items.Add(new Item("Small Animal", 5.99, "Bedding", "Supplies", "Clean and fresh bedding for small \nanimals.", "\\Images\\Small Animal\\Supplies\\Bedding.png"));
            Items.Add(new Item("Small Animal", 99.99, "Bird Habitat", "Supplies", "A tweeter's favorite place to sleep \nand rest.", "\\Images\\Small Animal\\Supplies\\Bird Habitat.png"));
            Items.Add(new Item("Small Animal", 19.99, "Heating Pad", "Supplies", "Warm up your small animals while they \ngrow with this convenient heading pad.", "\\Images\\Small Animal\\Supplies\\Heating Pad.png"));
            Items.Add(new Item("Small Animal", 6.99, "Water Bottle", "Supplies", "Quench your small pet friend’s thirst\nwith this in-cage water bottle.", "\\Images\\Small Animal\\Supplies\\Water Bottle.png"));

            // Fish 4 items
            Items.Add(new Item("Fish", 7.99, "Fish Food", "Food", "Fish food to keep your fish satisfied and \ngrowing healthily.", "\\Images\\Fish\\Food\\Fish Food.png"));
            Items.Add(new Item("Fish", 9.99, "Pond Fish Food", "Food", "Fish food for pond fish of all sizes,\nmulticolored for fish to easily see.", "\\Images\\Fish\\Food\\Pond Fish Food.png"));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Filter", "Supplies", "Keep your tank clean with this \nquiet-flow aquarium filter.", "\\Images\\Fish\\Supplies\\Fish Aquarium Filter.png"));
            Items.Add(new Item("Fish", 9.99, "Fish Aquarium Starter Kit", "Supplies", "Get started on your fish \nkeeping journey with this \nstarter kit.", "\\Images\\Fish\\Supplies\\Fish Aquarium Starter Kit.png"));

            // Reptile 11 items
            Items.Add(new Item("Reptile", 9.99, "Reptile Food Crickets", "Food", "Reptile food composed of \ndried crickets.", "\\Images\\Reptile\\Food\\Reptile Food Crickets.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Dried Insects", "Food", "Keep your reptile full with \nthis blend of dried insects.", "\\Images\\Reptile\\Food\\Reptile Food Dried Insects.png"));
            Items.Add(new Item("Reptile", 19.99, "Reptile Food Frozen Mice", "Food", "Frozen mice simulates \nnatural prey while \nretaining nutritious value.", "\\Images\\Reptile\\Food\\Reptile Food Frozen Mice.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Food Omnivore", "Food", "Food for omnivorous reptiles \nblended for nutrition and taste.", "\\Images\\Reptile\\Food\\Reptile Food Omnivore.png"));
            Items.Add(new Item("Reptile", 8.99, "Turtle Food", "Food", "Fast acting food for you slow moving \nturtle pet.", "\\Images\\Reptile\\Food\\Turtle Food.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Bedding", "Supplies", "Clean and safe reptile bedding.", "\\Images\\Reptile\\Supplies\\Reptile Bedding.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Filter", "Supplies", "Simulate a reptile's natural \nenvironment with this reptile \nhabitat filter.", "\\Images\\Reptile\\Supplies\\Reptile Habitat Filter.png"));
            Items.Add(new Item("Reptile", 14.95, "Reptile Habitat Sand", "Supplies", "Aid heat absorption and natural \ndigging behavior with this sand.", "\\Images\\Reptile\\Supplies\\Reptile Habitat Sand.png"));
            Items.Add(new Item("Reptile", 9.99, "Reptile Habitat Soil", "Supplies", "Reptisoil reptile habitat soil for all \nkinds of reptile pets.", "\\Images\\Reptile\\Supplies\\Reptile Habitat Soil.png"));
            Items.Add(new Item("Reptile", 99.99, "Reptile Habitat", "Supplies", "Simulate your reptile’s natural \nenvironment with this habitat. \nSpace for heat lamps and a \nfilter.", "\\Images\\Reptile\\Supplies\\Reptile Habitat.png"));
            Items.Add(new Item("Reptile", 8.99, "Reptile Heat Light", "Supplies", "Keep your reptile friend warm with \nthis 100W heat light.", "\\Images\\Reptile\\Supplies\\Reptile Heat Light.png"));
            #endregion

            #region Initializing pages
            InitializeComponent();
            signInOptionsPage = new SignInOptionsPage(this);
            createUserAccountPage = new CreateUserAccountPage(this);
            userAccountMadePage = new UserAccountMadePage(this);
            searchResultsPage = new SearchResultsPage(this);
            itemPage = new ItemPage(this);
            paymentPage = new PaymentPage(this);
            shoppingCartPage = new ShoppingCartPage(this);
            reviewOrderPage = new ReviewOrderPage(this);
            receiptPage = new ReceiptPage(this);
            searchResultsPage.InitializeItemPage(itemPage);
            searchResultsPage.InitializeSignInOptionsPage(signInOptionsPage);
            searchResultsPage.InitializeCreateUserAccountPage(createUserAccountPage);
            searchResultsPage.InitializeUserAccountMadePage(userAccountMadePage);
            searchResultsPage.InitializePaymentPage(paymentPage);
            searchResultsPage.InitializeShoppingCartPage(shoppingCartPage);
            searchResultsPage.InitializeReviewOrderPage(reviewOrderPage);
            searchResultsPage.InitializeReceiptPage(receiptPage);
            itemPage.InitializeSignInOptionsPage(signInOptionsPage);
            itemPage.InitializeCreateUserAccountPage(createUserAccountPage);
            itemPage.InitializeUserAccountMadePage(userAccountMadePage);
            itemPage.InitializeSearchResultsPage(searchResultsPage);
            itemPage.InitializePaymentPage(paymentPage);
            itemPage.InitializeShoppingCartPage(shoppingCartPage);
            itemPage.InitializeReviewOrderPage(reviewOrderPage);
            itemPage.InitializeReceiptPage(receiptPage);
            paymentPage.InitializeSignInOptionsPage(signInOptionsPage);
            paymentPage.InitializeCreateUserAccountPage(createUserAccountPage);
            paymentPage.InitializeUserAccountMadePage(userAccountMadePage);
            paymentPage.InitializeSearchResultsPage(searchResultsPage);
            paymentPage.InitializeItemPage(itemPage);
            paymentPage.InitializeShoppingCartPage(shoppingCartPage);
            paymentPage.InitializeReviewOrderPage(reviewOrderPage);
            paymentPage.InitializeReceiptPage(receiptPage);
            signInOptionsPage.InitializeCreateUserAccountPage(createUserAccountPage);
            signInOptionsPage.InitializeUserAccountMadePage(userAccountMadePage);
            signInOptionsPage.InitializeSearchResultsPage(searchResultsPage);
            signInOptionsPage.InitializeItemPage(itemPage);
            signInOptionsPage.InitializePaymentPage(paymentPage);
            signInOptionsPage.InitializeShoppingCartPage(shoppingCartPage);
            signInOptionsPage.InitializeReviewOrderPage(reviewOrderPage);
            signInOptionsPage.InitializeReceiptPage(receiptPage);
            createUserAccountPage.InitializeSignInOptionsPage(signInOptionsPage);
            createUserAccountPage.InitializeUserAccountMadePage(userAccountMadePage);
            createUserAccountPage.InitializeSearchResultsPage(searchResultsPage);
            createUserAccountPage.InitializeItemPage(itemPage);
            createUserAccountPage.InitializePaymentPage(paymentPage);
            createUserAccountPage.InitializeShoppingCartPage(shoppingCartPage);
            createUserAccountPage.InitializeReviewOrderPage(reviewOrderPage);
            createUserAccountPage.InitializeReceiptPage(receiptPage);
            userAccountMadePage.InitializeSignInOptionsPage(signInOptionsPage);
            userAccountMadePage.InitializeSearchResultsPage(searchResultsPage);
            userAccountMadePage.InitializeItemPage(itemPage);
            userAccountMadePage.InitializeCreateUserAccountPage(createUserAccountPage);
            userAccountMadePage.InitializePaymentPage(paymentPage);
            userAccountMadePage.InitializeShoppingCartPage(shoppingCartPage);
            userAccountMadePage.InitializeReviewOrderPage(reviewOrderPage);
            userAccountMadePage.InitializeReceiptPage(receiptPage);
            reviewOrderPage.InitializeSignInOptionsPage(signInOptionsPage);
            reviewOrderPage.InitializeCreateUserAccountPage(createUserAccountPage);
            reviewOrderPage.InitializeUserAccountMadePage(userAccountMadePage);
            reviewOrderPage.InitializeSearchResultsPage(searchResultsPage);
            reviewOrderPage.InitializeItemPage(itemPage);
            reviewOrderPage.InitializePaymentPage(paymentPage);
            reviewOrderPage.InitializeShoppingCartPage(shoppingCartPage);            
            reviewOrderPage.InitializeReceiptPage(receiptPage);            
            receiptPage.InitializeSearchResultsPage(searchResultsPage);
            receiptPage.InitializeSignInOptionsPage(signInOptionsPage);
            receiptPage.InitializeItemPage(itemPage);
            receiptPage.InitializePaymentPage(paymentPage);
            receiptPage.InitializeShoppingCartPage(shoppingCartPage);
            receiptPage.InitializeCreateUserAccountPage(createUserAccountPage);
            receiptPage.InitializeUserAccountMadePage(userAccountMadePage);
            receiptPage.InitializeReviewOrderPage(reviewOrderPage);
            #endregion

            #region Visibility of pages
            itemPage.Visibility = Visibility.Hidden;
            shoppingCartPage.Visibility = Visibility.Hidden;
            searchResultsPage.Visibility = Visibility.Hidden;
            signInOptionsPage.Visibility = Visibility.Hidden;
            createUserAccountPage.Visibility = Visibility.Hidden;
            userAccountMadePage.Visibility = Visibility.Hidden;
            paymentPage.Visibility = Visibility.Hidden;
            reviewOrderPage.Visibility = Visibility.Hidden;
            receiptPage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
            #endregion

            SearchBox.Text = "Search";
            
        }

        #region HomePage Animal Button clicks
        /// <summary>
        /// Clicking on the Dog image will bring up all of the Dog items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DogButton_Click(object sender, RoutedEventArgs e)
        {
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Dog".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Cat image will bring up all of the Cat items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CatButton_Click(object sender, RoutedEventArgs e)
        {            
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Cat".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Fish image will bring up all the Fish items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishButton_Click(object sender, RoutedEventArgs e)
        {            
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Fish".ToLower()))
                {
                    continue;
                }
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Small Animals image will bring up all the Small Animals items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            // Page_Control.SelectedIndex = 1;
            // SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Small Animal".ToLower()))
                {
                    continue;
                }
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        /// <summary>
        /// Clicking on the Reptile image will bring up all the Reptile items
        /// and clear any earlier results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReptileButton_Click(object sender, RoutedEventArgs e)
        {
            // Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                if (!item.Species.ToLower().Contains("Reptile".ToLower()))
                {
                    continue;
                }
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }
            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }
        #endregion

        #region Searchbox logic
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
                // Page_Control.SelectedIndex = 1;
                //SearchResults.Text = string.Empty;
                ItemResults.Clear();
                searchResultsPage.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;

                foreach (Item item in Items)
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
                    ItemResults.Add(item);
                }
                searchResultsPage.ResultGrid.ItemsSource = ItemResults;
                
            }
        }
        #endregion

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void SearchResults_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        /// <summary>
        /// The View All Items button will display all of the store's items.
        /// Earlier results will be cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAll_Click(object sender, RoutedEventArgs e)
        {
            // Page_Control.SelectedIndex = 1;
            //SearchResults.Text = string.Empty;
            ItemResults.Clear();
            searchResultsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;

            foreach (Item item in Items)
            {
                //SearchResults.Text += item.Species + "\t" + item.Price + "\t" + item.ItemName + "\t" + item.Category + "\t" + item.Picture.ToString + Environment.NewLine + Environment.NewLine;
                ItemResults.Add(item);
            }

            searchResultsPage.ResultGrid.ItemsSource = ItemResults;
        }

        #region PetStore logo
        /// <summary>
        /// When the Pet Store logo is clicked on by the mouse, it goes to the Home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetStoreLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Page_Control.SelectedIndex = 0;

            searchResultsPage.Visibility = Visibility.Hidden;
            Visibility = Visibility.Visible;
        }
        #endregion

        
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {            
            signInOptionsPage.Visibility = Visibility.Visible;
            Visibility = Visibility.Hidden;
        }
        

        public void HideHomePageWindow()
        {
            Visibility = Visibility.Hidden;
        }
    }
}

/* Model View reference:
 https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
*/