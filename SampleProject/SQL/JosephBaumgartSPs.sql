USE WeatherDataDB

GO

--Add Weather Locations

create proc spPreLocAdd
@LocationID int,
@City nvarchar(100),
@State nvarchar(100),
@Country nvarchar(100)
AS
BEGIN
	Insert into ext_Locations(City, State, Country)
	Values(@City, @State, @Country)
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


execute spPreLocAdd @LocationID = 99, @City = 'Centreville', @State = 'Virginia',@Country =  'USA'

GO


execute spPreLocDelete 8

GO
