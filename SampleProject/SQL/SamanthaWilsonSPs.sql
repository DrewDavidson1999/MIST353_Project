use WeatherDataDB
GO

-- Stored Procedure to insert a new user
CREATE OR ALTER PROCEDURE InsertNewUser
  @UserName nvarchar(100),      
  @Email nvarchar(255),         
  @PasswordHash nvarchar(255)   
AS

BEGIN
  INSERT INTO ext_Users (UserName, Email, PasswordHash)
  VALUES (@UserName, @Email, @PasswordHash)
END
GO

--Added new user
/*
EXEC InsertNewUser 
@Username = 'Sami Wilson', 
@Email = 'Sami@example.com', 
@PasswordHash = 'hashedpassword'
*/


-- Stored Procedure to insert a new location
CREATE OR ALTER PROCEDURE InsertNewLocation
  @City nvarchar(100),     
  @State nvarchar(100),    
  @Country nvarchar(100)   
AS
BEGIN
  INSERT INTO ext_Locations (City, State, Country)
  VALUES (@City, @State, @Country)
END
GO

--Added new location
/*
EXEC InsertNewLocation 
@City = 'San Francisco', 
@State = 'California', 
@Country = 'USA';
*/