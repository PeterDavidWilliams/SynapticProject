CREATE TABLE [dbo].[Playlist]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [SongId] INT NOT NULL, 
    CONSTRAINT [FK_Playlist_ToSong] FOREIGN KEY ([SongId]) REFERENCES [Song]([Id])
)
