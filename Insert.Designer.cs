namespace Movie_Management
{
    partial class Insert
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
            this.panelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnWatched = new FontAwesome.Sharp.IconButton();
            this.btnWatchlist = new FontAwesome.Sharp.IconButton();
            this.btnMovies = new FontAwesome.Sharp.IconButton();
            this.Values = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnAddTo = new FontAwesome.Sharp.IconButton();
            this.panelMovies.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.Values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMovies
            // 
            this.panelMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelMovies.Controls.Add(this.panelSubMenu);
            this.panelMovies.Controls.Add(this.Values);
            this.panelMovies.Location = new System.Drawing.Point(0, 56);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(959, 428);
            this.panelMovies.TabIndex = 4;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.AutoScroll = true;
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSubMenu.Controls.Add(this.btnWatched);
            this.panelSubMenu.Controls.Add(this.btnWatchlist);
            this.panelSubMenu.Controls.Add(this.btnMovies);
            this.panelSubMenu.Location = new System.Drawing.Point(3, 3);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(199, 175);
            this.panelSubMenu.TabIndex = 0;
            // 
            // btnWatched
            // 
            this.btnWatched.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWatched.FlatAppearance.BorderSize = 0;
            this.btnWatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatched.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatched.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWatched.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnWatched.IconColor = System.Drawing.Color.Black;
            this.btnWatched.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWatched.Location = new System.Drawing.Point(0, 108);
            this.btnWatched.Name = "btnWatched";
            this.btnWatched.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWatched.Size = new System.Drawing.Size(199, 54);
            this.btnWatched.TabIndex = 2;
            this.btnWatched.Text = "Watched Movies";
            this.btnWatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatched.UseVisualStyleBackColor = true;
            this.btnWatched.Click += new System.EventHandler(this.btnWatched_Click);
            // 
            // btnWatchlist
            // 
            this.btnWatchlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWatchlist.FlatAppearance.BorderSize = 0;
            this.btnWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchlist.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchlist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWatchlist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnWatchlist.IconColor = System.Drawing.Color.Black;
            this.btnWatchlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWatchlist.Location = new System.Drawing.Point(0, 54);
            this.btnWatchlist.Name = "btnWatchlist";
            this.btnWatchlist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWatchlist.Size = new System.Drawing.Size(199, 54);
            this.btnWatchlist.TabIndex = 1;
            this.btnWatchlist.Text = "Watchlist";
            this.btnWatchlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatchlist.UseVisualStyleBackColor = true;
            this.btnWatchlist.Click += new System.EventHandler(this.btnWatchlist_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMovies.IconColor = System.Drawing.Color.Black;
            this.btnMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovies.Location = new System.Drawing.Point(0, 0);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMovies.Size = new System.Drawing.Size(199, 54);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // Values
            // 
            this.Values.Controls.Add(this.txtPath);
            this.Values.Controls.Add(this.txtGenre);
            this.Values.Controls.Add(this.label6);
            this.Values.Controls.Add(this.btnClear);
            this.Values.Controls.Add(this.btnInsert);
            this.Values.Controls.Add(this.numRating);
            this.Values.Controls.Add(this.dateRelease);
            this.Values.Controls.Add(this.txtDirector);
            this.Values.Controls.Add(this.txtTitle);
            this.Values.Controls.Add(this.label5);
            this.Values.Controls.Add(this.label4);
            this.Values.Controls.Add(this.label3);
            this.Values.Controls.Add(this.label2);
            this.Values.Controls.Add(this.label1);
            this.Values.Dock = System.Windows.Forms.DockStyle.Top;
            this.Values.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Values.ForeColor = System.Drawing.Color.Gainsboro;
            this.Values.Location = new System.Drawing.Point(208, 3);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(739, 413);
            this.Values.TabIndex = 1;
            this.Values.TabStop = false;
            this.Values.Text = "Values";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(187, 288);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(516, 37);
            this.txtPath.TabIndex = 14;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(187, 138);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(516, 37);
            this.txtGenre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Genre";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(471, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 45);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(17, 349);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(232, 45);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert Movie";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(187, 234);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(193, 37);
            this.numRating.TabIndex = 8;
            this.numRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateRelease
            // 
            this.dateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRelease.Location = new System.Drawing.Point(187, 184);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(193, 37);
            this.dateRelease.TabIndex = 7;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(187, 90);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(516, 37);
            this.txtDirector.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(187, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(516, 37);
            this.txtTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poster";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelTitleBar.Controls.Add(this.btnAddTo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(959, 56);
            this.panelTitleBar.TabIndex = 3;
            // 
            // btnAddTo
            // 
            this.btnAddTo.FlatAppearance.BorderSize = 0;
            this.btnAddTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddTo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddTo.IconColor = System.Drawing.Color.Black;
            this.btnAddTo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTo.Location = new System.Drawing.Point(3, 16);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(127, 37);
            this.btnAddTo.TabIndex = 3;
            this.btnAddTo.Text = "Add To";
            this.btnAddTo.UseVisualStyleBackColor = true;
            this.btnAddTo.Click += new System.EventHandler(this.btnAddTo_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 484);
            this.Controls.Add(this.panelMovies);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "Insert";
            this.Text = "Insert";
            this.panelMovies.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.Values.ResumeLayout(false);
            this.Values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMovies;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton btnWatched;
        private FontAwesome.Sharp.IconButton btnWatchlist;
        private FontAwesome.Sharp.IconButton btnMovies;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnAddTo;
        private System.Windows.Forms.GroupBox Values;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPath;
    }
}