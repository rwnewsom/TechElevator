USE master
GO

-- Drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

-- Create Tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE bugs (
	bug_id int IDENTITY(1,1) NOT NULL,
	title nvarchar(120) NOT NULL,
	description nvarchar(MAX) NULL,
	isOpen bit NOT NULL,
	priority int NOT NULL,
	resolution nvarchar(MAX) NULL,
	CONSTRAINT PK_bug PRIMARY KEY (bug_id)
)

-- Populate default data for testing: user and admin with password of 'password'
-- These values should not be kept when going to Production
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');

-- Create some default test data for bugs
INSERT INTO bugs (title, description, isOpen, priority, resolution)
VALUES ('The website is down', 'We heard groaning metal', 1, 5, NULL),
('It needs a dark theme', 'Because everything needs one', 1, 2, NULL),
('The site does not let me do taxes', 'I want it to.', 0, 3, 'Will not fix. Go away.')

GO