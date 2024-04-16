using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_L4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Product[] movies = new Product[4];

        public MainWindow()
        {
            InitializeComponent();

            //Creating an instanc of our class
            //we have created a variable named movie 1 relating to an empty product




            //director satoshi kon

            //price -27.99

            // rating - r


            Product movie1 = new Product("Paprika","Satoshi Kon", "R", 27.99m);

            movies[0] = movie1;

            movie1._title = "Paprika";

            movie1._price = 27.99m;

            movie1._raiting = "R";

            movie1._director = "satoshi kon";


            Product rafaMovie = new Product("El dorado","R", "Mr HawkuyMan",14.99m);

            movies[1] = rafaMovie;

            rafaMovie._title = "El dorado";

            rafaMovie._price = 14.99m;

            rafaMovie._raiting = "R";

            rafaMovie._director = "Mr HawkuyMan";


            runDisplay.Text += "Title: " + movie1._title;

            runDisplay.Text += "Price: " + movie1._price;

            runDisplay.Text += "Director: " + movie1._director;

            runDisplay.Text += "Raiting: " + movie1._raiting;


            Product rafhaelMovie = new Product("Reel Steel", "PG-13", "hugh jackman", 17.99m);

            movies[2] = rafhaelMovie;
            {
                rafhaelMovie._title = "Reel Steel";
                rafhaelMovie._raiting= "PG-13";
                rafhaelMovie._director = "hugh jackman";
                rafhaelMovie._price = 17.99m;
            }

            movies[3] = new Product("robocop (89)", "Paul Verhoven", "R", 14.00m);
            for (int i = 0; i < movies.Length; i++)
            {
                Product selectedMovies = movies[i];
                DisplayMovie(selectedMovies);
            }    


        }

        public  void DisplayMovie(Product movie)
        {
         runDisplay.Text = "Title " + movie._title + "/n";
            runDisplay.Text = $"Director : { movie._director }/n";
            runDisplay.Text = $"Raiting: {movie._raiting}/n";
            runDisplay.Text = $"Price : {movie._price}/n";
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }//classes

    //in object orientedprogramming sre how we define what a collection of sdata and actions look like toi the computer
}