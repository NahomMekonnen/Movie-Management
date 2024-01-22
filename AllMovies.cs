using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace Movie_Management
{
    public class DrawOnParentEventArgs : EventArgs
    {
       public string movieName {  get; set; }
        public string tableName { get; set; }
        public DrawOnParentEventArgs(string movieName)
        {
            this.movieName = movieName;

        }
    }

    public partial class AllMovies : Form
    {
        public event EventHandler<DrawOnParentEventArgs> DrawOnParentRequest;

        public string tableName;
        DatabaseConnection d= new DatabaseConnection();
        public AllMovies(string tableName)
        {
            InitializeComponent();
            customizeDesign();
            d.RetrieveMovies(tableName);
   
            AddMovieToUI(d.Movies);

            this.tableName = tableName;
            this.Text = tableName;
        }

        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelSubMenu.Visible)
            {
                panelSubMenu.Visible = false;
            }
        }
        public void showSubMenu(Panel panelSubMenu)
        {
            if (panelSubMenu.Visible == false)
            {
                hideSubMenu();
                panelSubMenu.Visible = true;
            }
            else{ 
                panelSubMenu.Visible = false;
            }
        }

        private void AddMovieToUI(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                    //Create panel
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlMovie{0}", movie.Id);
            panel.BackColor = Color.FromArgb(34, 33, 74);
            panel.Size = new Size(200, 215);
            panel.Margin = new Padding(10);
            panel.Tag = movie.Id;

            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbMovieImage{0}", movie.Id);
            picBox.Size = new Size(120, 168);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
     
           
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;

            //Create title label
            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblMovieTitle{0}", movie.Id);
                labelTitle.Text = movie.Title;
            labelTitle.Location = new Point(12, 175);
            labelTitle.ForeColor = Color.Gainsboro;
            labelTitle.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitle.AutoSize = true;
            labelTitle.Tag = movie.Id;
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelTitle.Click += new EventHandler(label_Click);


                //Create year label
                Label labelYear;
            labelYear = new Label();
            labelYear.Name = String.Format("LblMovieYear{0}", movie.Id);
            labelYear.Text = movie.ReleaseDate.Year.ToString();
            labelYear.Location = new Point(12, 195);
            labelYear.ForeColor = Color.Green;
            labelYear.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labelYear.Tag = movie.Id;


            //Add controls to panel 
            panel.Controls.Add(picBox);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labelYear);



            panelMovies.Controls.Add(panel);
            }
        
        }
        private void label_Click(object sender, EventArgs e)
        {
            string name = ((Label)sender).Text;
            string table = tableName;
            Form parentform = (Form)this.Parent.Parent;

            MovieWindow movie = new MovieWindow(name,tableName);
            parentform.Hide();
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText=txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                
                List<Movie> matchingMovies = new List<Movie>();
                foreach (var movie in d.Movies)
                {
              
                    if (movie.Title.Contains(searchText))
                    {
                       
                        matchingMovies.Add(movie);
                    }

                }

                panelMovies.Controls.Clear();
                AddMovieToUI(matchingMovies);


            
            }
            else
            {
                panelMovies.Controls.Clear();
                //  panelMovies.Controls.Clear();
                AddMovieToUI(d.Movies);

            }
        }

       
        private void RearrangeMovies(List<Movie> movies, string criteria)
        {
             panelMovies.Controls.Clear();
            if (criteria == "Director")
            {
                movies = movies.OrderBy(obj => obj.Director).ToList();
        

            }
            else if (criteria == "Genre")
            {
                movies = movies.OrderBy(obj => obj.Genre).ToList();
           
            }
            else if (criteria == "Rating")
            {
                movies = movies.OrderByDescending(obj => obj.Rating).ToList();
               

            }
            else if(criteria == "Title")
            {
                movies = movies.OrderBy(obj => obj.Title).ToList();
              

            }
            else if(criteria == "Release Date")
            {
               
                movies = movies.OrderByDescending(obj => obj.ReleaseDate).ToList();
              
            }
            AddMovieToUI(movies);

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btnReleaseDate_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            RearrangeMovies(d.Movies, btnReleaseDate.Text);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            RearrangeMovies(d.Movies,btnGenre.Text);
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            RearrangeMovies(d.Movies, btnRating.Text);
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            RearrangeMovies(d.Movies, btnDirector.Text);
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            RearrangeMovies(d.Movies, btnTitle.Text);
        }
    }
    }
  
