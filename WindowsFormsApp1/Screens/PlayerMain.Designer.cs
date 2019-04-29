namespace MusicPlayer
{
    partial class PlayerMain
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
            this.PlaylistsButton = new System.Windows.Forms.Button();
            this.SongSearchButton = new System.Windows.Forms.Button();
            this.AlbumsButton = new System.Windows.Forms.Button();
            this.SongsButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.CurrentlyPlayingLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.CurrentlyPlayingFieldLabel = new System.Windows.Forms.Label();
            this.ArtistFieldLabel = new System.Windows.Forms.Label();
            this.AlbumFieldLabel = new System.Windows.Forms.Label();
            this.SkipBackButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SkipForwardButton = new System.Windows.Forms.Button();
            this.MusicDisplayListBox = new System.Windows.Forms.ListBox();
            this.CreatePlaylistButton = new System.Windows.Forms.Button();
            this.SearchInputTextBox = new System.Windows.Forms.TextBox();
            this.SearchResultsListBox = new System.Windows.Forms.ListBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaylistsButton
            // 
            this.PlaylistsButton.Location = new System.Drawing.Point(59, 206);
            this.PlaylistsButton.Name = "PlaylistsButton";
            this.PlaylistsButton.Size = new System.Drawing.Size(197, 73);
            this.PlaylistsButton.TabIndex = 0;
            this.PlaylistsButton.Text = "Playlists";
            this.PlaylistsButton.UseVisualStyleBackColor = true;
            this.PlaylistsButton.Click += new System.EventHandler(this.PlaylistsButton_Click);
            // 
            // SongSearchButton
            // 
            this.SongSearchButton.Location = new System.Drawing.Point(583, 15);
            this.SongSearchButton.Name = "SongSearchButton";
            this.SongSearchButton.Size = new System.Drawing.Size(197, 73);
            this.SongSearchButton.TabIndex = 1;
            this.SongSearchButton.Text = "Song Search";
            this.SongSearchButton.UseVisualStyleBackColor = true;
            this.SongSearchButton.Click += new System.EventHandler(this.SongSearchButton_Click);
            // 
            // AlbumsButton
            // 
            this.AlbumsButton.Location = new System.Drawing.Point(59, 317);
            this.AlbumsButton.Name = "AlbumsButton";
            this.AlbumsButton.Size = new System.Drawing.Size(197, 73);
            this.AlbumsButton.TabIndex = 2;
            this.AlbumsButton.Text = "Albums";
            this.AlbumsButton.UseVisualStyleBackColor = true;
            this.AlbumsButton.Click += new System.EventHandler(this.AlbumsButton_Click);
            // 
            // SongsButton
            // 
            this.SongsButton.Location = new System.Drawing.Point(62, 423);
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.Size = new System.Drawing.Size(197, 73);
            this.SongsButton.TabIndex = 3;
            this.SongsButton.Text = "Songs";
            this.SongsButton.UseVisualStyleBackColor = true;
            this.SongsButton.Click += new System.EventHandler(this.SongsButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(336, 121);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(171, 62);
            this.ShuffleButton.TabIndex = 4;
            this.ShuffleButton.Text = "Shuffle songs";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // CurrentlyPlayingLabel
            // 
            this.CurrentlyPlayingLabel.AutoSize = true;
            this.CurrentlyPlayingLabel.Location = new System.Drawing.Point(59, 45);
            this.CurrentlyPlayingLabel.Name = "CurrentlyPlayingLabel";
            this.CurrentlyPlayingLabel.Size = new System.Drawing.Size(88, 13);
            this.CurrentlyPlayingLabel.TabIndex = 5;
            this.CurrentlyPlayingLabel.Text = "Currently Playing:";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(59, 71);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(33, 13);
            this.ArtistLabel.TabIndex = 6;
            this.ArtistLabel.Text = "Artist:";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(59, 98);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(39, 13);
            this.AlbumLabel.TabIndex = 7;
            this.AlbumLabel.Text = "Album:";
            // 
            // CurrentlyPlayingFieldLabel
            // 
            this.CurrentlyPlayingFieldLabel.AutoSize = true;
            this.CurrentlyPlayingFieldLabel.Location = new System.Drawing.Point(154, 45);
            this.CurrentlyPlayingFieldLabel.Name = "CurrentlyPlayingFieldLabel";
            this.CurrentlyPlayingFieldLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentlyPlayingFieldLabel.TabIndex = 8;
            // 
            // ArtistFieldLabel
            // 
            this.ArtistFieldLabel.AutoSize = true;
            this.ArtistFieldLabel.Location = new System.Drawing.Point(154, 71);
            this.ArtistFieldLabel.Name = "ArtistFieldLabel";
            this.ArtistFieldLabel.Size = new System.Drawing.Size(0, 13);
            this.ArtistFieldLabel.TabIndex = 9;
            // 
            // AlbumFieldLabel
            // 
            this.AlbumFieldLabel.AutoSize = true;
            this.AlbumFieldLabel.Location = new System.Drawing.Point(154, 98);
            this.AlbumFieldLabel.Name = "AlbumFieldLabel";
            this.AlbumFieldLabel.Size = new System.Drawing.Size(0, 13);
            this.AlbumFieldLabel.TabIndex = 10;
            // 
            // SkipBackButton
            // 
            this.SkipBackButton.Location = new System.Drawing.Point(62, 132);
            this.SkipBackButton.Name = "SkipBackButton";
            this.SkipBackButton.Size = new System.Drawing.Size(48, 41);
            this.SkipBackButton.TabIndex = 11;
            this.SkipBackButton.Text = "Back";
            this.SkipBackButton.UseVisualStyleBackColor = true;
            this.SkipBackButton.Click += new System.EventHandler(this.SkipBackButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(116, 132);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(48, 41);
            this.StopButton.TabIndex = 12;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(170, 132);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(48, 41);
            this.PlayButton.TabIndex = 13;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SkipForwardButton
            // 
            this.SkipForwardButton.Location = new System.Drawing.Point(224, 132);
            this.SkipForwardButton.Name = "SkipForwardButton";
            this.SkipForwardButton.Size = new System.Drawing.Size(48, 41);
            this.SkipForwardButton.TabIndex = 14;
            this.SkipForwardButton.Text = "Next";
            this.SkipForwardButton.UseVisualStyleBackColor = true;
            this.SkipForwardButton.Click += new System.EventHandler(this.SkipForwardButton_Click);
            // 
            // MusicDisplayListBox
            // 
            this.MusicDisplayListBox.FormattingEnabled = true;
            this.MusicDisplayListBox.Location = new System.Drawing.Point(289, 206);
            this.MusicDisplayListBox.Name = "MusicDisplayListBox";
            this.MusicDisplayListBox.Size = new System.Drawing.Size(257, 290);
            this.MusicDisplayListBox.TabIndex = 15;
            // 
            // CreatePlaylistButton
            // 
            this.CreatePlaylistButton.Location = new System.Drawing.Point(264, 530);
            this.CreatePlaylistButton.Name = "CreatePlaylistButton";
            this.CreatePlaylistButton.Size = new System.Drawing.Size(311, 32);
            this.CreatePlaylistButton.TabIndex = 16;
            this.CreatePlaylistButton.Text = "Create new playlist";
            this.CreatePlaylistButton.UseVisualStyleBackColor = true;
            this.CreatePlaylistButton.Click += new System.EventHandler(this.CreatePlaylistButton_Click);
            // 
            // SearchInputTextBox
            // 
            this.SearchInputTextBox.Location = new System.Drawing.Point(583, 107);
            this.SearchInputTextBox.Name = "SearchInputTextBox";
            this.SearchInputTextBox.Size = new System.Drawing.Size(197, 20);
            this.SearchInputTextBox.TabIndex = 17;
            // 
            // SearchResultsListBox
            // 
            this.SearchResultsListBox.FormattingEnabled = true;
            this.SearchResultsListBox.Location = new System.Drawing.Point(583, 165);
            this.SearchResultsListBox.Name = "SearchResultsListBox";
            this.SearchResultsListBox.Size = new System.Drawing.Size(197, 251);
            this.SearchResultsListBox.TabIndex = 18;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Location = new System.Drawing.Point(583, 441);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(197, 36);
            this.ClearSearchButton.TabIndex = 19;
            this.ClearSearchButton.Text = "Clear Search";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(625, 131);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 28);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PlayerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 587);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClearSearchButton);
            this.Controls.Add(this.SearchResultsListBox);
            this.Controls.Add(this.SearchInputTextBox);
            this.Controls.Add(this.CreatePlaylistButton);
            this.Controls.Add(this.MusicDisplayListBox);
            this.Controls.Add(this.SkipForwardButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SkipBackButton);
            this.Controls.Add(this.AlbumFieldLabel);
            this.Controls.Add(this.ArtistFieldLabel);
            this.Controls.Add(this.CurrentlyPlayingFieldLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.CurrentlyPlayingLabel);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.SongsButton);
            this.Controls.Add(this.AlbumsButton);
            this.Controls.Add(this.SongSearchButton);
            this.Controls.Add(this.PlaylistsButton);
            this.Name = "PlayerMain";
            this.Text = "PlayerMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlaylistsButton;
        private System.Windows.Forms.Button SongSearchButton;
        private System.Windows.Forms.Button AlbumsButton;
        private System.Windows.Forms.Button SongsButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Label CurrentlyPlayingLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label CurrentlyPlayingFieldLabel;
        private System.Windows.Forms.Label ArtistFieldLabel;
        private System.Windows.Forms.Label AlbumFieldLabel;
        private System.Windows.Forms.Button SkipBackButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SkipForwardButton;
        private System.Windows.Forms.ListBox MusicDisplayListBox;
        private System.Windows.Forms.Button CreatePlaylistButton;
        private System.Windows.Forms.TextBox SearchInputTextBox;
        private System.Windows.Forms.ListBox SearchResultsListBox;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Button SearchButton;
    }
}