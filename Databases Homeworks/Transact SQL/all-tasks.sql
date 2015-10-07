/*
--------------------------------------
-- 1. Create a database with two tables: 
-- Persons(Id(PK), FirstName, LastName, SSN) and
-- Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.
--------------------------------------

--CREATE DATABASE Bank
--GO

USE Bank
GO

CREATE TABLE Persons(
	Id int NOT NULL IDENTITY PRIMARY KEY,
	FirstName nvarchar(150) NOT NULL,
	LastName nvarchar(150) NOT NULL,
	SSN nvarchar(11) NOT NULL
)
GO

CREATE TABLE Accounts(
	Id int NOT NULL IDENTITY PRIMARY KEY,
	PersonId int NOT NULL,
	Balance money DEFAULT 0
	CONSTRAINT FK_Persons_Accounts FOREIGN KEY (PersonId)
	REFERENCES Persons(Id)
)
GO

INSERT INTO Persons VALUES
('Georgi', 'Petrov', '123456789'),
('Petar', 'Ivanov', '567891234'),
('Dragan', 'Tsvetkov', '345612789')
GO

INSERT INTO Accounts VALUES
(3, 200),
(1, 1000),
(2, 0)
GO

CREATE PROC usp_SelectAllFullNames
AS
  SELECT FirstName + ' ' + LastName AS [Full Name]
  FROM Persons
GO

EXEC usp_SelectAllFullNames

--------------------------------------
-- 2. Create a stored procedure that accepts a number
-- as a parameter and returns all persons 
-- who have more money in their accounts than the supplied number.
--------------------------------------

CREATE PROC usp_PersonsWhoHaveMoreMoneyThan(@amount int = 0)
AS
	SELECT p.FirstName + ' ' + p.LastName AS [Full Name] FROM Persons AS p
	JOIN Accounts AS a
	ON a.PersonId = p.Id
	WHERE a.Balance > @amount
GO

EXEC usp_PersonsWhoHaveMoreMoneyThan 300

--------------------------------------
-- 3. Create a function that accepts as parameters – sum,
-- yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.
--------------------------------------

CREATE PROC usp_CalculateInterest
@sum money = 0,
@yearlyInterest money = 0,
@months int = 0,
@result int OUTPUT
AS
	SET @result = @sum + (@sum * @yearlyInterest * @months)
GO

DECLARE @newSum money
EXEC usp_CalculateInterest 1000, 0.03, 10, @newSum OUTPUT
SELECT 'The new sum after 10 months is: ', @newSum

--------------------------------------
-- 4. Create a stored procedure that uses the function from the previous
-- example to give an interest to a person's account for one month.
-- It should take the AccountId and the interest rate as parameters.
--------------------------------------

CREATE PROC usp_UpdateInterest
@accountId int,
@yearlyInterest money = 0
AS
	UPDATE a
	SET a.Balance = (a.Balance + (a.Balance * @yearlyInterest))
	FROM Accounts AS a
	WHERE a.Id = @accountId
GO


-- Test Balance Update
------------------------
DECLARE @updateID int = 2

SELECT Balance AS [Balance Before Update] FROM Accounts
WHERE Id = @updateID

EXEC usp_UpdateInterest @updateID, 0.03

SELECT Balance AS [Balance After Update] FROM Accounts
WHERE Id = @updateID

--------------------------------------
-- 5. Add two more stored procedures WithdrawMoney(AccountId, money)
-- and DepositMoney(AccountId, money) that operate in transactions.
--------------------------------------

CREATE PROC usp_WithdrawMoney
@accountId int,
@amount money = 0
AS
	BEGIN TRAN
		UPDATE a
		SET a.Balance = a.Balance - @amount
		FROM Accounts AS a
		WHERE a.Id = @accountId
	COMMIT TRAN
GO

CREATE PROC usp_DepositMoney
@accountId int,
@amount money = 0
AS
	BEGIN TRAN
		UPDATE a
		SET a.Balance = a.Balance + @amount
		FROM Accounts AS a
		WHERE a.Id = @accountId
	COMMIT TRAN
GO

-- Test Money Withdrawal
------------------------
DECLARE @withdrawID int = 1

SELECT Balance AS [Balance Before Update] FROM Accounts
WHERE Id = @withdrawID

EXEC usp_WithdrawMoney @withdrawID, 200

SELECT Balance AS [Balance After Update] FROM Accounts
WHERE Id = @withdrawID

-- Test Money Deposit
------------------------
DECLARE @depositID int = 1

SELECT Balance AS [Balance Before Update] FROM Accounts
WHERE Id = @depositID

EXEC usp_DepositMoney @depositID, 300

SELECT Balance AS [Balance After Update] FROM Accounts
WHERE Id = @depositID

--------------------------------------
-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry into the
-- Logs table every time the sum on an account changes.
--------------------------------------

CREATE TABLE Logs(
	LogID int NOT NULL IDENTITY PRIMARY KEY,
	AccountID int,
	OldSum money,
	NewSum money,
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY (AccountID)
	REFERENCES Accounts(Id)
)
GO


CREATE TRIGGER TR_AccountsUpdate ON Accounts FOR UPDATE
AS
    INSERT INTO Logs(AccountID, OldSum, NewSum)
	SELECT i.Id, d.Balance, i.Balance
	FROM inserted AS i
	JOIN deleted AS d
		ON i.Id = d.Id
GO

UPDATE Accounts
SET Balance = Balance + 100
WHERE Id = 3

--------------------------------------
-- 7. Define a function in the database TelerikAcademy that
-- returns all Employee's names (first or middle or last name)
-- and all town's names that are comprised of given set of letters.
-- Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
--------------------------------------

USE TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName (@nameToCheck NVARCHAR(50),@letters NVARCHAR(50)) RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i,1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO

CREATE FUNCTION ufn_CheckIfNameConsistsOfLetters (@searchString NVARCHAR(200)) 
RETURNS @T TABLE (Name nvarchar(200))
AS
BEGIN

DECLARE employeeCursor CURSOR READ_ONLY FOR
	(SELECT e.FirstName, e.LastName, t.Name FROM Employees e
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID=t.TownID)

OPEN employeeCursor

DECLARE @firstName NVARCHAR(200), 
@lastName NVARCHAR(200), 
@town NVARCHAR(200)

DECLARE @tempTable TABLE (Name nvarchar(200))

FETCH NEXT FROM employeeCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
        DECLARE @i INT = 1
		DECLARE @match nvarchar(200) = NULL
		DECLARE @currentChar NVARCHAR(1)
		IF (dbo.ufn_CheckName(@firstName, @searchString) = 1)
			BEGIN
				SET @match = @firstName
			END
		IF (dbo.ufn_CheckName(@lastName, @searchString) = 1)
			BEGIN
				SET @match = @lastName
			END
		IF (dbo.ufn_CheckName(@town, @searchString) = 1)
			BEGIN
				SET @match = @town
			END

		IF @match IS NOT NULL
			INSERT INTO @tempTable
			VALUES (@match)
	FETCH NEXT FROM employeeCursor INTO @firstName, @lastName, @town
  END

CLOSE employeeCursor
DEALLOCATE employeeCursor

INSERT INTO @T
SELECT DISTINCT Name FROM @tempTable

RETURN
END
GO

SELECT * FROM ufn_CheckIfNameConsistsOfLetters('oistmiahf')


--------------------------------------
-- 8. Define a function in the database TelerikAcademy that
-- returns all Employee's names (first or middle or last name)
-- and all town's names that are comprised of given set of letters.
-- Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
--------------------------------------

USE TelerikAcademy
GO

DECLARE employeeCursor CURSOR READ_ONLY FOR
    SELECT 
		emp1.FirstName + ' ' + emp1.LastName AS [First Employee], 
		t1.Name AS Town, 
		emp2.FirstName + ' ' + emp2.LastName AS [Second Employee]
    FROM Employees emp1, Employees emp2, Addresses a1, Towns t1, Addresses a2, Towns t2
	WHERE 
		emp1.AddressID = a1.AddressID AND 
		a1.TownID = t1.TownID AND 
		emp2.AddressID = a2.AddressID AND 
		a2.TownID = t2.TownID AND 
		t1.TownID = t2.TownID AND 
		emp1.EmployeeID != emp2.EmployeeID
    ORDER BY [First Employee], [Second Employee]

OPEN employeeCursor

DECLARE @firstEmployee nvarchar(200), 
	    @secondEmployee nvarchar(200), 
        @townName nvarchar(100)
FETCH NEXT FROM employeeCursor INTO @firstEmployee, @townName, @secondEmployee

WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @firstEmployee + ' and ' + @secondEmployee + ' both live in ' + @townName;

		FETCH NEXT FROM employeeCursor 
		INTO @firstEmployee, @townName, @secondEmployee
	END

CLOSE employeeCursor
DEALLOCATE employeeCursor
*/