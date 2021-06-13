-- Replace the contents of this file with your create database script!
USE master;
GO

DROP DATABASE IF EXISTS BenevolentCorp;

CREATE DATABASE BenevolentCorp;
GO

USE BenevolentCorp
GO

BEGIN TRANSACTION;

CREATE TABLE department
(
department_number		int				identity(1,1),
name					nvarchar(64)	not null,
CONSTRAINT pk_department PRIMARY KEY (department_number)
);

CREATE TABLE project
(
project_number			int				identity(1,1),
project_name			nvarchar(64)	not null,
start_date				datetime		not null,
CONSTRAINT pk_project PRIMARY KEY (project_number)
);

CREATE TABLE employee
(
	employee_id			int				identity(1,1),
	job_title			nvarchar(64)	not null,
	last_name			nvarchar		not null,
	first_name			nvarchar		not null,
	gender				int				not null,
	date_of_birth		datetime		not null,
	date_of_hire		datetime		not null,
	department_number	int				not null,

	CONSTRAINT pk_employee PRIMARY KEY (employee_id),
	CONSTRAINT fk_employee_department FOREIGN KEY (department_number) references department (department_number)
);

--associative entities

CREATE TABLE project_employee
(
	project_number int,
	employee_id int,
	CONSTRAINT proj_emp PRIMARY KEY (project_number, employee_id),
	CONSTRAINT fk_project_employee_project FOREIGN KEY (project_number) references project(project_number),
	CONSTRAINT fk_project_employee_employee FOREIGN KEY (employee_id) references employee(employee_id)
);

CREATE TABLE department_employee
(
	department_number int,
	employee_id int,
	CONSTRAINT dep_emp PRIMARY KEY (department_number, employee_id),
	CONSTRAINT fk_department_employee_employee FOREIGN KEY (employee_id) references employee(employee_id),
	CONSTRAINT fk_department_employee_department FOREIGN KEY (department_number) references department(department_number)
);

INSERT INTO project (project_name, start_date)
VALUES('DAMOCLES Orbital Strike Array', '2020-06-13')

INSERT INTO project (project_name, start_date)
VALUES('Syzygy-class Extermination Drone', '2021-05-10')

INSERT INTO project (project_name, start_date)
VALUES('GreyGoo quasi sentient nanoswarm', '1999-06-13')

INSERT INTO project (project_name, start_date)
VALUES('Allied Mastercomputer', '1978-06-13')

SELECT * FROM project