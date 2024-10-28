use WeatherDataDB
GO

-- Stored procedure to change user passwords
create or alter proc spChangePassword
@UserID int, --parameter for user id
@PasswordHash nvarchar(255) --parameter for user password
AS
BEGIN
	update ext_Users --updating the ext_users table
	set PasswordHash = @PasswordHash --setting the password to the new password
	where UserID = @UserID --where the user id matches the given user id
END
GO

/*
--changing user 3's password to 12345
exec spChangePassword 3, '12345'
GO
*/

-- Stored procedure to change the preferred location of a user
create or alter proc spChangePreferredLocation
	@UserID int, --parameter for User ID
	@Location nvarchar(50) --parameter for location
AS
BEGIN
	update ext_UserPreferredLocations --updating the user preferred location table
	set Location = @Location --setting the location to the new location
	where UserID = @UserID --where the user ID is the same value as the entered user ID
END
GO

/*
--changing user 2's preferred location to Waco
exec spChangePreferredLocation 2, "Waco"
GO
*/
