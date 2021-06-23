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
	last_name			nvarchar(64)	not null,
	first_name			nvarchar(64)	not null,
	gender				nvarchar(64)	not null, 
	date_of_birth		datetime		not null,
	date_of_hire		datetime		not null,
	department_number	int				null, --some employees are generalists

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

--this table removed as employees can belong to multiple projects, pk generated from multiple fks
--CREATE TABLE department_employee
--(
	--department_number int,
	--employee_id int,
	--CONSTRAINT dep_emp PRIMARY KEY (department_number, employee_id),
	--CONSTRAINT fk_department_employee_employee FOREIGN KEY (employee_id) references employee(employee_id),
	--CONSTRAINT fk_department_employee_department FOREIGN KEY (department_number) references department(department_number)
--);

INSERT INTO project (project_name, start_date)
VALUES('DAMOCLES Orbital Strike Array', '2020-06-13')

INSERT INTO project (project_name, start_date)
VALUES('Syzygy-class Extermination Drone', '2021-05-10')

INSERT INTO project (project_name, start_date)
VALUES('GreyGoo quasi sentient nanoswarm', '1999-06-13')

INSERT INTO project (project_name, start_date)
VALUES('Allied Mastercomputer', '1978-06-13')

INSERT INTO department(name)
VALUES('Kinetic Concepts')

INSERT INTO department(name)
VALUES('Lethal Automata')

INSERT INTO department(name)
VALUES('Artificial Intelligence')

--SELECT * FROM department

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Scientist Supremer', 'Tarleton', 'George', 'Male', '1967-01-01','1997-06-01', 3)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Scientist Supreme', 'Rappaccini', 'Monica', 'Female', '1972-03-15','2003-09-01', 2)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Intern', 'Rappaccini', 'Carmilla', 'Female', '2004-08-30','2020-06-01', 2)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Drone', 'Garoldson', 'Garfield', 'Male', '1978-07-25','2006-05-01', 3)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Sr Consulting Scientist', 'Sanchez', 'Rick', 'Male', '1943-02-21','2020-02-01', 1)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_number)
VALUES('Assistant', 'Smith', 'Mortimer', 'Male', '2007-05-12','2020-02-01', 1)

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES('Chief Squancher', 'Squanchy', 'Squanch', 'Squanch', '1980-01-01','2020-02-01')

INSERT INTO employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire)
VALUES('Security Chief', 'Michael', 'Krombopulos', 'Gromflomite', '1988-01-01','2020-02-01')

--SELECT * FROM employee
--SELECT * FROM project

--assign employees to projects

INSERT INTO project_employee(project_number, employee_id)
VALUES(1,5)
INSERT INTO project_employee(project_number, employee_id)
VALUES(1,6)

--M.O.D.O.K has an atrophied hand in EVERY project at AIM2(I mean BenevolentCorp)
INSERT INTO project_employee(project_number, employee_id)
VALUES(4,1)
INSERT INTO project_employee(project_number, employee_id)
VALUES(3,1)
INSERT INTO project_employee(project_number, employee_id)
VALUES(2,1)
INSERT INTO project_employee(project_number, employee_id)
VALUES(1,1)
INSERT INTO project_employee(project_number, employee_id)
VALUES(4,4)
INSERT INTO project_employee(project_number, employee_id)
VALUES(2,2)
INSERT INTO project_employee(project_number, employee_id)
VALUES(2,3)
INSERT INTO project_employee(project_number, employee_id)
VALUES(3,7)


COMMIT TRANSACTION;


--TESTING JOIN TABLE
--SELECT
	--last_name,
	--first_name,
	--project_name
--FROM
	--employee e
	--INNER JOIN project_employee pe ON e.employee_id = pe.employee_id
	--INNER JOIN project p ON pe.project_number = p.project_number