namespace Movie_Management
{
    partial class AllMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnTitle = new FontAwesome.Sharp.IconButton();
            this.btnGenre = new FontAwesome.Sharp.IconButton();
            this.btnRating = new FontAwesome.Sharp.IconButton();
            this.btnDirector = new FontAwesome.Sharp.IconButton();
            this.btnReleaseDate = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(288, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(578, 37);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.txtSearch);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(959, 56);
            this.panelTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie Name: ";
            // 
            // panelMovies
            // 
            this.panelMovies.AutoScroll = true;
            this.panelMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovies.Location = new System.Drawing.Point(211, 56);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(748, 564);
            this.panelMovies.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panelSubMenu);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 564);
            this.panel1.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFilter.IconColor = System.Drawing.Color.Black;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(211, 59);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "FIlter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSubMenu.Controls.Add(this.btnTitle);
            this.panelSubMenu.Controls.Add(this.btnGenre);
            this.panelSubMenu.Controls.Add(this.btnRating);
            this.panelSubMenu.Controls.Add(this.btnDirector);
            this.panelSubMenu.Controls.Add(this.btnReleaseDate);
            this.panelSubMenu.Location = new System.Drawing.Point(0, 55);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(208, 342);
            this.panelSubMenu.TabIndex = 10;
            // 
            // btnTitle
            // 
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTitle.IconColor = System.Drawing.Color.Black;
            this.btnTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTitle.Location = new System.Drawing.Point(-9, 235);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTitle.Size = new System.Drawing.Size(220, 54);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.Text = "Title";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenre.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenre.IconColor = System.Drawing.Color.Black;
            this.btnGenre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenre.Location = new System.Drawing.Point(-12, 70);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGenre.Size = new System.Drawing.Size(220, 54);
            this.btnGenre.TabIndex = 1;
            this.btnGenre.Text = "Genre";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnRating
            // 
            this.btnRating.FlatAppearance.BorderSize = 0;
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRating.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRating.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRating.IconColor = System.Drawing.Color.Black;
            this.btnRating.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRating.Location = new System.Drawing.Point(-6, 121);
            this.btnRating.Name = "btnRating";
            this.btnRating.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRating.Size = new System.Drawing.Size(220, 54);
            this.btnRating.TabIndex = 2;
            this.btnRating.Text = "Rating";
            this.btnRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.FlatAppearance.BorderSize = 0;
            this.btnDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirector.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirector.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDirector.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDirector.IconColor = System.Drawing.Color.Black;
            this.btnDirector.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDirector.Location = new System.Drawing.Point(-9, 175);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDirector.Size = new System.Drawing.Size(220, 54);
            this.btnDirector.TabIndex = 0;
            this.btnDirector.Text = "Director";
            this.btnDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirector.UseVisualStyleBackColor = true;
            this.btnDirector.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // btnReleaseDate
            // 
            this.btnReleaseDate.FlatAppearance.BorderSize = 0;
            this.btnReleaseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDate.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReleaseDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReleaseDate.IconColor = System.Drawing.Color.Black;
            this.btnReleaseDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReleaseDate.Location = new System.Drawing.Point(-12, 10);
            this.btnReleaseDate.Name = "btnReleaseDate";
            this.btnReleaseDate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReleaseDate.Size = new System.Drawing.Size(220, 54);
            this.btnReleaseDate.TabIndex = 3;
            this.btnReleaseDate.Text = "Release Date";
            this.btnReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDate.UseVisualStyleBackColor = true;
            this.btnReleaseDate.Click += new System.EventHandler(this.btnReleaseDate_Click);
            // 
            // AllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 620);
            this.Controls.Add(this.panelMovies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "AllMovies";
            this.Text = "AllMovies";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelMovies;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton btnTitle;
        private FontAwesome.Sharp.IconButton btnGenre;
        private FontAwesome.Sharp.IconButton btnRating;
        private FontAwesome.Sharp.IconButton btnDirector;
        private FontAwesome.Sharp.IconButton btnReleaseDate;
    }
}