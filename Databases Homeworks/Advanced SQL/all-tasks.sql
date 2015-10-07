USE [TelerikAcademy]
GO

/*
To connect to the TelerikAcademy database, just run "Create-TelerikAcademy-Database-SQL-Script.sql" located in the same folder as this file with SSMS.
Then just uncomment each of the tasks listed below to run the query.
Comments include:
-- single line comment

/* multiple
line
comment */

*/ 

----------------------------
-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. 
-- Use a nested SELECT statement.
----------------------------

/*
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)
*/

----------------------------
-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
----------------------------

/*
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary >= 
	(SELECT MIN(Salary) FROM Employees)
AND Salary <=
	(SELECT MIN(Salary) * 1.1 FROM Employees)
*/

----------------------------
-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
-- Use a nested SELECT statement.
----------------------------

/*
SELECT FirstName, LastName, Salary FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees
	WHERE DepartmentID = d.DepartmentID)
*/

----------------------------
-- 4. Write a SQL query to find the average salary in the department #1.
----------------------------

/*
SELECT AVG(Salary) FROM Employees
WHERE DepartmentID = 1
*/

----------------------------
-- 5. Write a SQL query to find the average salary in the "Sales" department.
----------------------------

/*
SELECT AVG(Salary) FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
*/

----------------------------
-- 6. Write a SQL query to find the number of employees in the "Sales" department.
----------------------------

/*
SELECT COUNT(*) FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
*/

----------------------------
-- 7. Write a SQL query to find the number of all employees that have manager.
----------------------------

/*
SELECT COUNT(*) FROM Employees
WHERE ManagerID IS NOT NULL
*/

----------------------------
-- 8. Write a SQL query to find the number of all employees that have no manager.
----------------------------

/*
SELECT COUNT(*) FROM Employees
WHERE ManagerID IS NULL
*/

----------------------------
-- 9. Write a SQL query to find all departments and the average salary for each of them.
----------------------------

/*
SELECT d.Name AS Department, AVG(Salary) AS [Average Salary] FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY [Average Salary] DESC
*/

----------------------------
-- 10. Write a SQL query to find the count of all employees in each department and for each town.
----------------------------

/*
SELECT d.Name AS Department, COUNT(*) AS [Number of employees] FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

SELECT t.Name AS Town, COUNT(*) AS [Number of employees] FROM Employees AS e
JOIN Addresses AS a
ON e.AddressID = a.AddressID
JOIN Towns AS t
ON a.TownID = t.TownID
GROUP BY t.Name
*/

----------------------------
-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
----------------------------

/*
SELECT m.FirstName, m.LastName, COUNT(*) AS [Number of employees] FROM Employees AS e
JOIN Employees AS m
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(*) = 5
ORDER BY m.FirstName
*/

----------------------------
-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
----------------------------

/*
SELECT e.FirstName + ' ' + e.LastName AS Employee, ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS Manager FROM Employees AS e
LEFT JOIN Employees AS m
ON e.ManagerID = m.EmployeeID
*/

----------------------------
-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
----------------------------

/*
SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees
WHERE LEN(LastName) = 5
*/

----------------------------
-- 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
-- Search in Google to find how to format dates in SQL Server.
----------------------------

-- SELECT CONVERT(VARCHAR, GETDATE(), 104) + ' ' + CONVERT(VARCHAR, GETDATE(), 114)

----------------------------
-- 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
-- Define the primary key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating usernames.
-- Define a check constraint to ensure the password is at least 5 characters long.
----------------------------

/*
CREATE TABLE Users (
  UserID int IDENTITY,
  Username nvarchar(100) NOT NULL UNIQUE,
  Pass nvarchar(60),
  FullName nvarchar(200),
  LastLogin smalldatetime,
  CONSTRAINT PK_Users PRIMARY KEY(UserID),
  CONSTRAINT [MinPasswordLengthConstraint] CHECK (LEN(Pass) >= 5)
)
GO
*/

----------------------------
-- 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
-- Test if the view works correctly.
----------------------------

/*
CREATE VIEW [Users from today] AS
SELECT Username FROM Users
WHERE CONVERT(VARCHAR(10), LastLogin, 102) 
    = CONVERT(VARCHAR(10), GETDATE(), 102)
GO
*/

----------------------------
-- 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
-- Define primary key and identity column.
----------------------------

/*
CREATE TABLE Groups (
  GroupID int IDENTITY,
  Name nvarchar(200) NOT NULL UNIQUE,
  CONSTRAINT PK_Groups PRIMARY KEY(GroupID)
)
GO
*/

----------------------------
-- 18. Write a SQL statement to add a column GroupID to the table Users.
-- Fill some data in this new column and as well in the `Groups table.
-- Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
----------------------------

/*
ALTER TABLE Users
	ADD GroupID int,
	CONSTRAINT FK_Users_Groups
	  FOREIGN KEY (GroupID)
	  REFERENCES Groups(GroupID)
*/

----------------------------
-- 19. Write SQL statements to insert several records in the Users and Groups tables.
----------------------------

/*
INSERT INTO Users VALUES
('Gosho', 'qwerty', 'Georgi Petrov', DATEADD(day, -1, GETDATE()), 2),
('Pesho', 'qwerty', 'Petar Petrov', GETDATE(), 1)

INSERT INTO Groups VALUES
('Students Academy'),
('Algo Academy'),
('Kids Academy')
*/

----------------------------
-- 20. Write SQL statements to update some of the records in the Users and Groups tables.
----------------------------

/*
UPDATE Users 
SET Username = 'Ivan', FullName = 'Ivanov Ivanov'
WHERE Username = 'Gosho'

UPDATE Groups 
SET Name = 'Exam preparation'
WHERE Name = 'Kids Academy'
*/

----------------------------
-- 21. Write SQL statements to delete some of the records from the Users and Groups tables.
----------------------------

/*
DELETE FROM Users
WHERE Username = 'Ivan'

DELETE FROM Groups
WHERE Name = 'Algo Academy'
*/

----------------------------
-- 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
-- Combine the first and last names as a full name.
-- For username use the first letter of the first name + the last name (in lowercase).
-- Use the same for the password, and NULL for last login time.
----------------------------

/*
INSERT INTO Users
SELECT 
LOWER(FirstName) + '' + LOWER(LastName) AS Username,
LOWER(FirstName) + '' + LOWER(LastName) AS Pass,
FirstName + ' ' + LastName AS FullName,
NULL AS LastLogin, 
NULL AS GroupID
FROM Employees
*/

----------------------------
-- 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
----------------------------

/*
UPDATE u
SET Pass = NULL
FROM Users u
INNER JOIN Users u2
ON u.UserID = u2.UserID
WHERE CONVERT(varchar(10), u2.LastLogin, 102) < CONVERT(datetime, '2010.10.03', 102)
*/

----------------------------
-- 24. Write a SQL statement that deletes all users without passwords (NULL password).
----------------------------

/*
DELETE FROM u
FROM Users u
INNER JOIN Users u2
ON u.UserID = u2.UserID
WHERE u2.Pass IS NULL
*/

----------------------------
-- 25. Write a SQL query to display the average employee salary by department and job title.
----------------------------

/*
SELECT d.Name, JobTitle, 
  AVG(Salary) as [Average Salary]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, JobTitle
*/

----------------------------
-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
----------------------------

/*
SELECT d.Name, JobTitle, 
  MIN(Salary) as [Min Salary]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, JobTitle
*/

----------------------------
-- 27. Write a SQL query to display the town where maximal number of employees work.
----------------------------

/*
SELECT TOP 1 t.Name AS Town, COUNT(*) AS [Number of employees] FROM Employees AS e
JOIN Addresses AS a
ON e.AddressID = a.AddressID
JOIN Towns AS t
ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Number of employees] DESC
*/

----------------------------
-- 28. Write a SQL query to display the number of managers from each town.
----------------------------

/*
SELECT t.Name AS [Town], COUNT(DISTINCT e.ManagerID) AS [No. of Managers]
FROM Employees e, Employees m, Addresses a, Towns t
WHERE 
e.ManagerID = m.EmployeeID AND
m.AddressID = a.AddressID AND
a.TownID = t.TownID
GROUP BY t.Name
*/

----------------------------
-- 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
-- Don't forget to define identity, primary key and appropriate foreign key.
-- Issue few SQL statements to insert, update and delete of some data in the table.
-- Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
-- For each change keep the old record data, the new record data and the command (insert / update / delete).
----------------------------

/*
CREATE TABLE WorkHours (
    WorkReportID int IDENTITY,
    EmployeeId Int NOT NULL,
    Date DATETIME NOT NULL,
    Task nvarchar(300) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(300),
    CONSTRAINT PK_WorkHours PRIMARY KEY(WorkReportID),
    CONSTRAINT FK_WorkHours_Employees
        FOREIGN KEY (EmployeeID)
        REFERENCES Employees(EmployeeID)
) 
GO

INSERT INTO WorkHours VALUES 
(1, GETDATE(), 'Walk the dog', 1, 'Homework about advanced SQL'),
(2, GETDATE(), 'Attend lecture', 4, 'Go to Telerik Academy'),
(3, GETDATE(), 'Do homework', 3, 'HW')

UPDATE WorkHours
SET Date = '2015-10-07 18:00'
WHERE Task = 'Attend lecture'

DELETE FROM WorkHours
WHERE Hours < 2

CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    Date DATETIME NOT NULL,
    Task nvarchar(300) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(300),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

CREATE TRIGGER TR_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, Date, Task, Hours, Comments, Action)
SELECT WorkReportId, EmployeeID, Date, Task, Hours, Comments, 'Insert'
FROM inserted
GO

CREATE TRIGGER TR_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, Date, Task, [Hours], Comments, [Action])
SELECT WorkReportId, EmployeeID, Date, Task, [Hours], Comments, 'Delete'
FROM deleted
GO

CREATE TRIGGER TR_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, Date, Task, [Hours], Comments, [Action])
SELECT WorkReportId, EmployeeID, Date, Task, [Hours], Comments, 'InsertUpdate'
FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, Date, Task, [Hours], Comments, [Action])
SELECT WorkReportId, EmployeeID, Date, Task, [Hours], Comments, 'DeleteUpdate'
FROM deleted
GO

DELETE FROM WorkHoursLogs
WHERE WorkLogId = 1

INSERT INTO WorkHours(EmployeeId, Date, Task, Hours)
VALUES (3, GETDATE(), 'New Task', 4)

UPDATE WorkHours
SET Comments = 'Updated work hours'
WHERE EmployeeId = 2
*/

----------------------------
-- 30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the other tables.
-- At the end rollback the transaction.
----------------------------

/*
BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO

DELETE FROM e 
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

ROLLBACK TRAN
*/

----------------------------
-- 31. Start a database transaction and drop the table EmployeesProjects.
-- Now how you could restore back the lost table data?
----------------------------

/*
BEGIN TRAN

DROP TABLE EmployeesProjects

ROLLBACK TRAN
*/

----------------------------
-- 32. Find how to use temporary tables in SQL Server.
-- Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.
----------------------------

/*
BEGIN TRANSACTION

SELECT * 
INTO #TempEmployeesProjects
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * 
INTO EmployeesProjects
FROM #TempEmployeesProjects

DROP TABLE #TempEmployeesProjects

ROLLBACK TRANSACTION
*/