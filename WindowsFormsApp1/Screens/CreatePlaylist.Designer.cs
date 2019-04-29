namespace MusicPlayer.Screens
{
    partial class CreatePlaylist
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
            this.SongsListBox = new System.Windows.Forms.ListBox();
            this.PlaylistNameTextBox = new System.Windows.Forms.TextBox();
            this.PlaylistNameLabel = new System.Windows.Forms.Label();
            this.CreatePlaylistButton = new System.Windows.Forms.Button();
            this.SelectSongsLabel = new System.Windows.Forms.Label();
            this.NameErrorMessageLabel = new System.Windows.Forms.Label();
            this.SongListErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SongsListBox
            // 
            this.SongsListBox.FormattingEnabled = true;
            this.SongsListBox.Location = new System.Drawing.Point(60, 114);
            this.SongsListBox.Name = "SongsListBox";
            this.SongsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SongsListBox.Size = new System.Drawing.Size(368, 303);
            this.SongsListBox.TabIndex = 0;
            // 
            // PlaylistNameTextBox
            // 
            this.PlaylistNameTextBox.Location = new System.Drawing.Point(60, 51);
            this.PlaylistNameTextBox.Name = "PlaylistNameTextBox";
            this.PlaylistNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.PlaylistNameTextBox.TabIndex = 1;
            // 
            // PlaylistNameLabel
            // 
            this.PlaylistNameLabel.AutoSize = true;
            this.PlaylistNameLabel.Location = new System.Drawing.Point(64, 24);
            this.PlaylistNameLabel.Name = "PlaylistNameLabel";
            this.PlaylistNameLabel.Size = new System.Drawing.Size(118, 13);
            this.PlaylistNameLabel.TabIndex = 2;
            this.PlaylistNameLabel.Text = "Enter your playlist name";
            // 
            // CreatePlaylistButton
            // 
            this.CreatePlaylistButton.Location = new System.Drawing.Point(549, 127);
            this.CreatePlaylistButton.Name = "CreatePlaylistButton";
            this.CreatePlaylistButton.Size = new System.Drawing.Size(115, 122);
            this.CreatePlaylistButton.TabIndex = 3;
            this.CreatePlaylistButton.Text = "Create";
            this.CreatePlaylistButton.UseVisualStyleBackColor = true;
            this.CreatePlaylistButton.Click += new System.EventHandler(this.CreatePlaylistButton_Click);
            // 
            // SelectSongsLabel
            // 
            this.SelectSongsLabel.AutoSize = true;
            this.SelectSongsLabel.Location = new System.Drawing.Point(60, 95);
            this.SelectSongsLabel.Name = "SelectSongsLabel";
            this.SelectSongsLabel.Size = new System.Drawing.Size(240, 13);
            this.SelectSongsLabel.TabIndex = 4;
            this.SelectSongsLabel.Text = "Select all the songs you wish to add to the playlist";
            // 
            // NameErrorMessageLabel
            // 
            this.NameErrorMessageLabel.AutoSize = true;
            this.NameErrorMessageLabel.Location = new System.Drawing.Point(476, 51);
            this.NameErrorMessageLabel.Name = "NameErrorMessageLabel";
            this.NameErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.NameErrorMessageLabel.TabIndex = 5;
            // 
            // SongListErrorMessageLabel
            // 
            this.SongListErrorMessageLabel.AutoSize = true;
            this.SongListErrorMessageLabel.Location = new System.Drawing.Point(64, 420);
            this.SongListErrorMessageLabel.Name = "SongListErrorMessageLabel";
            this.SongListErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.SongListErrorMessageLabel.TabIndex = 6;
            // 
            // CreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SongListErrorMessageLabel);
            this.Controls.Add(this.NameErrorMessageLabel);
            this.Controls.Add(this.SelectSongsLabel);
            this.Controls.Add(this.CreatePlaylistButton);
            this.Controls.Add(this.PlaylistNameLabel);
            this.Controls.Add(this.PlaylistNameTextBox);
            this.Controls.Add(this.SongsListBox);
            this.Name = "CreatePlaylist";
            this.Text = "CreatePlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SongsListBox;
        private System.Windows.Forms.TextBox PlaylistNameTextBox;
        private System.Windows.Forms.Label PlaylistNameLabel;
        private System.Windows.Forms.Button CreatePlaylistButton;
        private System.Windows.Forms.Label SelectSongsLabel;
        private System.Windows.Forms.Label NameErrorMessageLabel;
        private System.Windows.Forms.Label SongListErrorMessageLabel;
    }
}