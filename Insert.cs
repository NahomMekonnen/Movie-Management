using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Management
{
    public partial class Insert : Form
    {
        string tableName;
        Movie movie= new Movie();
        DatabaseConnection d=new DatabaseConnection();
        public Insert()
        {
            InitializeComponent();
            customizeDesign();
        
        }
        public Insert(string tableName)
        {
            this.tableName = tableName;
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelSubMenu.Visible)
            {
                panelSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            tableName = "Movies";
        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            tableName = "Watchlist";
        }

        private void btnWatched_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            tableName = "Watched";
        }

      

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show(txtTitle.Text);
               
                 movie.Title = txtTitle.Text;
                 movie.Director = txtDirector.Text;
                 movie.Genre=txtGenre.Text;
                 movie.ReleaseDate = dateRelease.Value;
                 movie.Rating = (int)numRating.Value;
                 movie.Poster = Image.FromFile(txtPath.Text);
     
                 movie.ImagePath = txtPath.Text;
                MessageBox.Show(movie.ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception in insert button " + ex.Message);
            }
           
            d.InsertMovies(tableName, movie);

            Clear();
        }
        private void Clear()
        {
            txtTitle.Text = null;
            txtDirector.Text = null;
            txtPath.Text = null;
            txtGenre.Text = null;
            numRating.Value= 0;
            dateRelease.Value = DateTime.Now;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
    }
}
