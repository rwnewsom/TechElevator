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

-- TODO: Table definitions go here...

COMMIT TRANSACTION;

-- TODO: Insert statements go here...
