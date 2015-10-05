USE [TelerikAcademy]

/* 1. What is SQL? What is DML? What is DDL? Recite the most important SQL commands.

SQL (Structured Query Language) is a standard interactive and programming language for getting information from and updating a database.

A data manipulation language (DML) is a family of syntax elements similar to a computer programming language used for selecting, inserting, deleting and updating data in a database.
Performing read-only queries of data is sometimes also considered a component of DML.

A data definition language or data description language (DDL) is a syntax similar to a computer programming language for defining data structures, especially database schemas.

Here are some of the most important SQL commands:

SELECT - extracts data from a database
UPDATE - updates data in a database
DELETE - deletes data from a database
INSERT INTO - inserts new data into a database
CREATE DATABASE - creates a new database
ALTER DATABASE - modifies a database
CREATE TABLE - creates a new table
ALTER TABLE - modifies a table
DROP TABLE - deletes a table
CREATE INDEX - creates an index (search key)
DROP INDEX - deletes an index

*/

/* 2. What is Transact-SQL (T-SQL)?

Transact-SQL (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL. 
T-SQL expands on the SQL standard to include procedural programming, local variables, various support functions for string processing, date processing, mathematics, etc. and changes to the DELETE and UPDATE statements.

*/

/* 3. Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.

To connect to the TelerikAcademy database, just run "Create-TelerikAcademy-Database-SQL-Script.sql" located in the same folder as this file with SSMS.
Then just uncomment each of the tasks listed below to run the query.
Comments include:
-- single line comment

/* multiple
line
comment */

*/

-- 4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT * FROM Departments

----------------------------
-- 5. Write a SQL query to find all department names.

--SELECT Name FROM Departments

----------------------------
-- 6. Write a SQL query to find the salary of each employee.

--SELECT Salary FROM Employees

----------------------------
-- 7. Write a SQL to find the full name of each employee.

--SELECT FirstName + ' ' + LastName AS 'Full Name' FROM Employees

----------------------------
/* 8. Write a SQL query to find the email addresses of each employee (by his first and last name).
Consider that the mail domain is telerik.com.
Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses". */

--SELECT FirstName + '.' + LastName + '@telerik.com' AS 'Full Email Addresses' FROM Employees

----------------------------
-- 9. Write a SQL query to find all different employee salaries.

--SELECT DISTINCT Salary FROM Employees

----------------------------
-- 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

--SELECT * FROM Employees
--WHERE JobTitle = 'Sales Representative'

----------------------------
-- 11. Write a SQL query to find the names of all employees whose first name starts with "SA".

--SELECT FirstName, LastName FROM Employees
--WHERE FirstName LIKE 'Sa%'

----------------------------
-- 12. Write a SQL query to find the names of all employees whose last name contains "ei".

--SELECT FirstName, LastName FROM Employees
--WHERE LastName LIKE '%ei%'

----------------------------
-- 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

--SELECT Salary FROM Employees
--WHERE Salary BETWEEN 20000 AND 30000

----------------------------
-- 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

--SELECT FirstName, LastName FROM Employees
--WHERE Salary IN (25000, 14000, 12500, 23600)

----------------------------
-- 15. Write a SQL query to find all employees that do not have manager.

--SELECT * FROM Employees
--WHERE ManagerID IS NULL

----------------------------
-- 16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

--SELECT * FROM Employees
--WHERE Salary > 50000
--ORDER BY Salary DESC

----------------------------
-- 17. Write a SQL query to find the top 5 best paid employees.

--SELECT TOP 5 * FROM Employees
--ORDER BY Salary DESC

----------------------------
-- 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.

--SELECT * FROM Employees AS e
--INNER JOIN Addresses AS a
--ON e.AddressID = a.AddressID

----------------------------
-- 19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

--SELECT * FROM Employees AS e, Addresses AS a
--WHERE e.AddressID = a.AddressID

----------------------------
-- 20. Write a SQL query to find all employees along with their manager.

--SELECT * FROM Employees AS e
--JOIN Employees AS m
--ON e.ManagerID = m.EmployeeID

----------------------------
-- 21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

--SELECT * FROM Employees AS e
--JOIN Employees AS m
--ON e.ManagerID = m.EmployeeID
--JOIN Addresses AS a
--ON m.AddressID = a.AddressID

----------------------------
-- 22. Write a SQL query to find all departments and all town names as a single list. Use UNION.

--SELECT Name FROM Departments
--UNION
--SELECT Name FROM Towns

----------------------------
-- 23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager.
-- Use right outer join. Rewrite the query to use left outer join.

-- LEFT OUTER JOIN

--SELECT * FROM Employees AS e
--LEFT OUTER JOIN Employees m
--ON e.ManagerID = m.EmployeeID

-- RIGHT OUTER JOIN

--SELECT * FROM Employees AS m
--RIGHT OUTER JOIN Employees e
--ON m.EmployeeID = e.ManagerID

----------------------------
-- 24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

/*SELECT * FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance')
AND (e.HireDate >= '2003-01-01 00:00:00'
AND e.HireDate < '2005-01-01 00:00:00')*/