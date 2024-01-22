using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Management
{
    public partial class MovieWindow : Form
    {
        private string movieName,tableName;
        Movie movie=new Movie();
        DatabaseConnection d=new DatabaseConnection();
        public MovieWindow(string movieName,string tableName)
        {
            InitializeComponent();
            this.Visible= true;
            this.movieName = movieName;
            this.tableName = tableName;

            // Removing titleBar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            searchForMovie();
            DrawMovie();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
   
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
   
        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
       
        private void searchForMovie()
        {
            d.SearchMovie(movieName, tableName,movie);
    
        }

        private void DrawMovie()
        {
            picBox.Image = Image.FromFile(movie.ImagePath);
            picBox.SizeMode=PictureBoxSizeMode.StretchImage;
            lblTitle.Text=movie.Title;
            txtDescription.Text = movie.Description;
            lblDirector.Text += movie.Director;
            lblGenre.Text += movie.Genre;
            lblReleaseDate.Text += movie.ReleaseDate.ToString();
            lblRate.Text += movie.Rating;
            if (tableName == "Movies")
            {
                btnPress.Text = "Add To Watchlist";
                btnPress.Click += btnMovies_Click;
              
            }else if (tableName == "Watchlist")
            {
                btnPress.Text = "Add to Watched";
                btnPress.Click += btnWatchlist_Click;
            }
            else if (tableName == "Watched")
            {
                btnPress.Visible = false;
            }
            btnPress.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnPress.IconColor = Color.Gainsboro;
            btnPress.TextImageRelation = TextImageRelation.ImageBeforeText;
            

        }
        private void btnMovies_Click(object sender, EventArgs e)
        {
            d.InsertMovies("Watchlist", movie);
            

        }
        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            d.InsertMovies("Watched", movie);
            d.DeleteMovie(movieName, tableName);

        }


        private Image emptyStarImage;
        private Image filledStarImage;
        private static int starCount = 5;
        private int currentRating = 0;
        private PictureBox[] starImages = new PictureBox[starCount];

        private void rate_Paint(object sender, PaintEventArgs e)
        {
            // Load star images
            try
            {
             emptyStarImage = Image.FromFile(@"C:\Users\Nahom Mekonnen\Downloads\emtpyStar.png");
            filledStarImage = Image.FromFile(@"C:\Users\Nahom Mekonnen\Downloads\fullStar2.png");

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
           
            for (int i = 0; i < starCount; i++)
            {
                PictureBox star = new PictureBox();
                star.Image = emptyStarImage;  // Initially display empty stars
                star.Size = emptyStarImage.Size;
                star.Location = new Point(i * star.Width, 0);
                star.Click += StarClicked;
                star.MouseEnter += StarMouseEnter;
                star.MouseLeave += StarMouseLeave;
                rate.Controls.Add(star);
                starImages[i] = star;
            }

        }
        private void StarClicked(object sender, EventArgs e)
        {
            lblRate.Text = "Rate: ";
            int clickedIndex = Array.IndexOf(starImages, (PictureBox)sender);
            currentRating = clickedIndex + 1;
            UpdateStarImages();
            lblRate.Text+= currentRating.ToString();
            movie.Rating= currentRating;
            d.UpdateRate(tableName,movie);
            // Trigger event for rating change (implement this as needed)
            // ...
        }

        private void StarMouseEnter(object sender, EventArgs e)
        {
            int hoveredIndex = Array.IndexOf(starImages, (PictureBox)sender);
            UpdateStarImages(hoveredIndex + 1);
        }

        private void StarMouseLeave(object sender, EventArgs e)
        {
            UpdateStarImages();
        }

        private void UpdateStarImages(int hoverRating = 0)
        {
            for (int i = 0; i < starCount; i++)
            {
                starImages[i].Image = i < (hoverRating > 0 ? hoverRating : currentRating) ? filledStarImage : emptyStarImage;
            }
        }

        private void btnPress_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible= true;
            this.Hide();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          Application.Exit();
         
        }
    }
}
