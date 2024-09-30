USE WeatherDataDB
GO

/*
-- Procedure to Get Current Weather by Specific Location
CREATE OR ALTER PROCEDURE spGetCurrentWeatherByLocation
    @City NVARCHAR(100)
AS
BEGIN
    SELECT Location, Temperature, Humidity, WindSpeed, WeatherDescription, DateTime
    FROM ext_Weather_Current
    WHERE Location = @City;
END
GO

EXEC spGetCurrentWeatherByLocation @City = 'Sacramento';
GO
*/

/*
-- Stored Procedure to Add New Weather Forecast
CREATE OR ALTER PROCEDURE spAddWeatherForecast
    @Region NVARCHAR(100),
    @ForecastDate DATE,
    @Temperature FLOAT,
    @WeatherDescription NVARCHAR(255)
AS
BEGIN
    INSERT INTO ext_Weather_Forecasts (Region, ForecastDate, Temperature, WeatherDescription)
    VALUES (@Region, @ForecastDate, @Temperature, @WeatherDescription);
END
GO

EXEC spAddWeatherForecast 
    @Region = 'Los Angeles', 
    @ForecastDate = '2024-09-30', 
    @Temperature = 65.3, 
    @WeatherDescription = 'Rainy';
GO
/*