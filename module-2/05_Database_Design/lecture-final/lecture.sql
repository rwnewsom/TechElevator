-- Switch to the system (aka master) database
USE master;
GO

-- Delete the ArtGallery Database (IF EXISTS)
DROP DATABASE IF EXISTS ArtGallery;

-- Create a new ArtGallery Database
CREATE DATABASE ArtGallery;
GO

-- Switch to the ArtGallery Database
USE ArtGallery
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

CREATE TABLE artist
(
	id			int					IDENTITY(1,1),
	name		nvarchar(100)		NOT NULL,

	CONSTRAINT pk_artist PRIMARY KEY (id)
);

CREATE TABLE painting
(
	id			int					IDENTITY(1,1),
	artist_id	int					NULL, -- May have artists who are unknown on paintings
	title		nvarchar(64)		NOT NULL,

	CONSTRAINT pk_painting PRIMARY KEY (id),
	CONSTRAINT fk_painting_artist FOREIGN KEY (artist_id) REFERENCES artist (id)
);

CREATE TABLE [dbo].[purchase](
	[customer_id] [int] NOT NULL,
	[painting_id] [int] NOT NULL,
	[price] [money] NOT NULL,
	[purchase_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_purchase] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC,
	[painting_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[customer](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

COMMIT TRANSACTION;

-- TODO: Insert statements go here...
INSERT INTO artist (name) VALUES ('Banksy'), ('Van Gogh')

--SELECT * FROM artist

--INSERT INTO artist (name) VALUES (null)