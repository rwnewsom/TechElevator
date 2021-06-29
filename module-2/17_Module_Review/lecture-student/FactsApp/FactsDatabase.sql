USE master
GO

IF DB_ID('factsdb') IS NOT NULL
BEGIN
	ALTER DATABASE factsdb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE factsdb;
END

CREATE DATABASE factsdb
GO

USE factsdb
GO

CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	role varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE facts (
	id int IDENTITY(1,1) NOT NULL,
	quote  nvarchar(max) NOT NULL,
	CONSTRAINT PK_facts PRIMARY KEY (id)
)
GO

-- Add Chuck user to Users table with a password of 'me'
INSERT INTO users (username, password_hash, salt, role)
VALUES ('chuck', 'VutlrjEWS16UTNMDnrAey0QFVYw=', 'igCo5LCi0rM=', 'admin')
GO

-- Reference SQL

-- SELECT id, quote FROM facts ORDER BY question

-- UPDATE facts SET quote = @factText WHERE id = @factId

-- DELETE FROM facts WHERE id = @factId

-- INSERT INTO facts (quote) VALUES (@factText)