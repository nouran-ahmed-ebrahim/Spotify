namespace Spotify11
{
    partial class Form1
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SongsList = new System.Windows.Forms.ListView();
            this.SongName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistList = new System.Windows.Forms.ListView();
            this.addToFavBtn = new System.Windows.Forms.Button();
            this.AddToArtistBtn = new System.Windows.Forms.Button();
            this.ArtistNameCln = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(70, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(380, 24);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Image = global::Spotify11.Properties.Resources.searchIcon;
            this.searchBtn.Location = new System.Drawing.Point(546, 45);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(54, 49);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SongsList
            // 
            this.SongsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SongName,
            this.song_Category});
            this.SongsList.HideSelection = false;
            this.SongsList.Location = new System.Drawing.Point(70, 143);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(530, 299);
            this.SongsList.TabIndex = 2;
            this.SongsList.UseCompatibleStateImageBehavior = false;
            this.SongsList.View = System.Windows.Forms.View.Details;
            // 
            // SongName
            // 
            this.SongName.Text = "SongName";
            this.SongName.Width = 100;
            // 
            // song_Category
            // 
            this.song_Category.Text = "song_Category";
            this.song_Category.Width = 160;
            // 
            // artistList
            // 
            this.artistList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArtistNameCln});
            this.artistList.HideSelection = false;
            this.artistList.Location = new System.Drawing.Point(70, 474);
            this.artistList.Name = "artistList";
            this.artistList.Size = new System.Drawing.Size(530, 150);
            this.artistList.TabIndex = 3;
            this.artistList.UseCompatibleStateImageBehavior = false;
            this.artistList.View = System.Windows.Forms.View.Details;
            // 
            // addToFavBtn
            // 
            this.addToFavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFavBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFavBtn.Location = new System.Drawing.Point(788, 248);
            this.addToFavBtn.Name = "addToFavBtn";
            this.addToFavBtn.Size = new System.Drawing.Size(194, 60);
            this.addToFavBtn.TabIndex = 5;
            this.addToFavBtn.Text = "Add To Favorite List";
            this.addToFavBtn.UseVisualStyleBackColor = true;
            // 
            // AddToArtistBtn
            // 
            this.AddToArtistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToArtistBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToArtistBtn.Location = new System.Drawing.Point(788, 513);
            this.AddToArtistBtn.Name = "AddToArtistBtn";
            this.AddToArtistBtn.Size = new System.Drawing.Size(194, 59);
            this.AddToArtistBtn.TabIndex = 6;
            this.AddToArtistBtn.Text = "Add To Artist List";
            this.AddToArtistBtn.UseVisualStyleBackColor = true;
            // 
            // ArtistNameCln
            // 
            this.ArtistNameCln.Text = "Artist_Name";
            this.ArtistNameCln.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 784);
            this.Controls.Add(this.AddToArtistBtn);
            this.Controls.Add(this.addToFavBtn);
            this.Controls.Add(this.artistList);
            this.Controls.Add(this.SongsList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView SongsList;
        private System.Windows.Forms.ListView artistList;
        private System.Windows.Forms.Button addToFavBtn;
        private System.Windows.Forms.Button AddToArtistBtn;
        private System.Windows.Forms.ColumnHeader SongName;
        private System.Windows.Forms.ColumnHeader song_Category;
        private System.Windows.Forms.ColumnHeader ArtistNameCln;
    }
}

