USE WeatherDataDB

GO

--Add Weather Locations

create proc spPreLocAdd
@LocationID int
@City nvarchar(100)
@State nvarchar(100)
@Country nvarchar(100)
AS
BEGIN
	Insert into ext_Locations(LocationID, City, State, Country)
	Values(@LocationID, @City, @State, @Country)
END
GO


--Delete Weather Locations

create proc spPreLocDelete
@LocationID int
AS
BEGIN
	Delete from ext_Locations
	Where LocationID = @LocationID
END
GO

execute spPreLocAdd @LocationID = 1, @City = 'Morgantown', @State = 'West Virginia',@Country =  'United States'

GO

execute spPreLocDelete 1

GO