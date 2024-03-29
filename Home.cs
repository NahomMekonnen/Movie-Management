﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
namespace Movie_Management
{   
    public partial class Home : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string tableName;

        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);  
            panelMenu.Controls.Add(leftBorderBtn);

            // Removing titleBar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(37, 194, 68);
            public static Color color5 = Color.FromArgb(173, 19, 2);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn=(IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign=ContentAlignment.MiddleRight;
                //Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildFormIcon.IconChar = currentBtn.IconChar;
                iconCurrentChildFormIcon.IconColor = color;
                
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null) 
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }

        }
    

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm!= null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None; 
            childForm.Dock=DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitleChildForm.Text = childForm.Text;

        }
       

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildFormIcon.IconChar = IconChar.Home;
            iconCurrentChildFormIcon.IconColor = Color.MediumPurple;

            lblTitleChildForm.Text = "Home";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAllMovies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AllMovies("Movies"));
            tableName = "Movies";
        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AllMovies("Watchlist"));
            tableName = "Watchlist";
        }

        private void btnWatched_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new AllMovies("Watched"));
            tableName = "Watched";
        }
        
        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Insert());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string warning = "Are you sure you want to log out? ";
            ActivateButton(sender, RGBColors.color5);
            ConfirmationDialog confirm = new ConfirmationDialog(warning);
            DialogResult result = confirm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Visible = true;
            }
            

        }

        private void btnReleaseDate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllMovies(tableName));

        }
    }
}
