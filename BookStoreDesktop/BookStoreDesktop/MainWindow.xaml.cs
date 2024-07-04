using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStoreDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Book> books;

        private Dictionary<TextBox, string> _tbText = new Dictionary<TextBox, string>();
        private bool _saved = true;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                List<Book> deserialized = Serializer.Deserialize("lib.json");
                if (deserialized != null) {
                    books = deserialized;
                    
                }
                else
                {
                    books = new List<Book>();
                }
            }
            catch
            {
                books = new List<Book>();
            }
            foreach (Book book in books)
            {
                lb.Items.Add($"{book.Title}, {book.Author}");
            }
            tbTitle.Opacity = 0;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (tbTitle != null && tbAuthor != null && tbYear != null && tbQuantity != null
                && tbPrice != null)
            {
                try
                {
                    Book b = new Book();
                    b.Title = tbTitle.Text;
                    b.Author = tbAuthor.Text;
                    b.Year = Convert.ToInt32(tbYear.Text);
                    b.Quantity = Convert.ToInt32(tbQuantity.Text);
                    b.Price = Convert.ToDouble(tbPrice.Text);
                    books.Add(b);
                    _saved = false;
                }
                catch
                {
                    MessageBox.Show("Check your values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Serializer.Serialize(books);
                var messageSuccess = MessageBox.Show("Success", "New Message", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
                _saved = true;
            }
            catch
            {
                var messageSuccess = MessageBox.Show("Failure", "New Message",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {



        }

        private void tabNewBook_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation fadeInAnimation = new DoubleAnimation();
            fadeInAnimation.From = 0;
            fadeInAnimation.To = 1;
            fadeInAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));

            Storyboard fadeInStoryBoard = new Storyboard();
            fadeInStoryBoard.Children.Add(fadeInAnimation);
            Storyboard.SetTarget(fadeInAnimation, tbTitle);
            Storyboard.SetTargetProperty(fadeInAnimation, new PropertyPath(TextBox.OpacityProperty));
            fadeInStoryBoard.Begin();
        }

        private void tb_gotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!_tbText.Values.Contains(tb.Text))
            {
                _tbText.Add(tb, tb.Text);
            }
            tb.Text = "";
        }

        private void tb_lostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (_tbText.Keys.Contains(tb)) 
            {
                if (_tbText.TryGetValue(tb, out string value))
                {
                    tb.Text = value;
                }
            } 
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_saved)
            {
            }
        }
    }
}