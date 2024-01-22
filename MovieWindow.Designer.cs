namespace Movie_Management
{
    partial class MovieWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieWindow));
            this.panelTaskBar = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnPress = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.btnPress2 = new FontAwesome.Sharp.IconButton();
            this.panelTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelDescription.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskBar
            // 
            this.panelTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTaskBar.Controls.Add(this.btnBack);
            this.panelTaskBar.Controls.Add(this.btnClose);
            this.panelTaskBar.Controls.Add(this.btnHome);
            this.panelTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskBar.Location = new System.Drawing.Point(0, 0);
            this.panelTaskBar.Name = "panelTaskBar";
            this.panelTaskBar.Size = new System.Drawing.Size(1197, 71);
            this.panelTaskBar.TabIndex = 1;
            this.panelTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnBack.IconColor = System.Drawing.Color.LightGray;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 25;
            this.btnBack.Location = new System.Drawing.Point(1083, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.LightGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1137, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, -3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 74);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.lblReleaseDate);
            this.panelDescription.Controls.Add(this.lblRate);
            this.panelDescription.Controls.Add(this.lblDirector);
            this.panelDescription.Controls.Add(this.lblGenre);
            this.panelDescription.Controls.Add(this.txtDescription);
            this.panelDescription.Controls.Add(this.panelFooter);
            this.panelDescription.Controls.Add(this.lblTitle);
            this.panelDescription.Location = new System.Drawing.Point(453, 68);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(744, 589);
            this.panelDescription.TabIndex = 2;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDirector.Location = new System.Drawing.Point(12, 326);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(111, 27);
            this.lblDirector.TabIndex = 24;
            this.lblDirector.Text = "Director:  ";
            this.lblDirector.Click += new System.EventHandler(this.lblDirector_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGenre.Location = new System.Drawing.Point(392, 326);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(90, 27);
            this.lblGenre.TabIndex = 23;
            this.lblGenre.Text = "Genre:  ";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescription.Location = new System.Drawing.Point(27, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(686, 199);
            this.txtDescription.TabIndex = 22;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnPress2);
            this.panelFooter.Controls.Add(this.btnPress);
            this.panelFooter.Controls.Add(this.label1);
            this.panelFooter.Controls.Add(this.rate);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 403);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(744, 186);
            this.panelFooter.TabIndex = 21;
            // 
            // btnPress
            // 
            this.btnPress.FlatAppearance.BorderSize = 0;
            this.btnPress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPress.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPress.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPress.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPress.IconColor = System.Drawing.Color.Black;
            this.btnPress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPress.Location = new System.Drawing.Point(3, 10);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(232, 79);
            this.btnPress.TabIndex = 22;
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(288, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rate the movie: ";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(489, 104);
            this.rate.Margin = new System.Windows.Forms.Padding(4);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(251, 78);
            this.rate.TabIndex = 20;
            this.rate.Paint += new System.Windows.Forms.PaintEventHandler(this.rate_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(58, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 52);
            this.lblTitle.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox.Location = new System.Drawing.Point(43, 68);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(346, 589);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRate.Location = new System.Drawing.Point(12, 373);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(76, 27);
            this.lblRate.TabIndex = 25;
            this.lblRate.Text = "Rate:  ";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReleaseDate.Location = new System.Drawing.Point(307, 373);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(175, 27);
            this.lblReleaseDate.TabIndex = 26;
            this.lblReleaseDate.Text = "Date Released:  ";
            this.lblReleaseDate.Click += new System.EventHandler(this.lblReleaseDate_Click);
            // 
            // btnPress2
            // 
            this.btnPress2.FlatAppearance.BorderSize = 0;
            this.btnPress2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPress2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPress2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPress2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPress2.IconColor = System.Drawing.Color.Black;
            this.btnPress2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPress2.Location = new System.Drawing.Point(3, 104);
            this.btnPress2.Name = "btnPress2";
            this.btnPress2.Size = new System.Drawing.Size(232, 79);
            this.btnPress2.TabIndex = 23;
            this.btnPress2.UseVisualStyleBackColor = true;
            this.btnPress2.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1197, 658);
            this.Controls.Add(this.panelTaskBar);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.panelDescription);
            this.Name = "MovieWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieWindow";
            this.panelTaskBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panelTaskBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rate;
        private FontAwesome.Sharp.IconButton btnPress;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRate;
        private FontAwesome.Sharp.IconButton btnPress2;
    }
}