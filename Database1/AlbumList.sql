CREATE TABLE [dbo].[AlbumList]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [SongId] INT NOT NULL, 
    [AlbumId] INT NOT NULL, 
    CONSTRAINT [FK_AlbumList_ToAlbum] FOREIGN KEY ([AlbumId]) REFERENCES [Album]([Id]), 
    CONSTRAINT [FK_AlbumList_ToSong] FOREIGN KEY ([SongId]) REFERENCES [Song]([Id])
	
)
