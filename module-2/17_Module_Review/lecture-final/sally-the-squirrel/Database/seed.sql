USE master
GO

IF DB_ID('sallythesquirrel') IS NOT NULL
BEGIN
	ALTER DATABASE sallythesquirrel SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE sallythesquirrel;
END

CREATE DATABASE sallythesquirrel
GO

USE sallythesquirrel
GO

CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE questions (
	question_id int IDENTITY(1,1) NOT NULL,
	user_id int NOT NULL,
	question nvarchar(max) NOT NULL,
	answer nvarchar(max),
	CONSTRAINT PK_questions PRIMARY KEY (question_id)
)
