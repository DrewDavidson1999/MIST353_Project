USE WeatherDataDB
GO

-- Stored Procedure #1: Procedure to Get Current Weather by Specific Location
CREATE OR ALTER PROCEDURE spGetCurrentWeatherByLocation
    @City NVARCHAR(255) -- Input parameter for city name 
AS
BEGIN
    SELECT Location, Temperature, Humidity, WindSpeed, WeatherDescription, DateTime ---- Selecting column details for the specified location
    FROM ext_Weather_Current -- Getting data from the ext_Weather_Current table
    WHERE Location = @City; -- Filter location results by input
END
GO

/*
EXEC spGetCurrentWeatherByLocation @City = 'Sacramento';
GO
*/


-- Stored Procedure #2: Stored Procedure to Add New Weather Forecast
CREATE OR ALTER PROCEDURE spAddWeatherForecast 
    @Region NVARCHAR(255), -- Parameter for region
    @ForecastDate DATE, -- Parameter for ForcastDate 
    @Temperature FLOAT, -- Parameter for Temperature 
    @WeatherDescription NVARCHAR(255) -- Parameter for WeatherDescription
AS
BEGIN
	-- Inserting weather forecast details into the ext_Weather_Forecasts table
    INSERT INTO ext_Weather_Forecasts (Region, ForecastDate, Temperature, WeatherDescription) 
    VALUES (@Region, @ForecastDate, @Temperature, @WeatherDescription); -- Inserting parameter values into the specific columns
END
GO

-- Add a weather forcast
/*
EXEC spAddWeatherForecast 
    @Region = 'Los Angeles', 
    @ForecastDate = '2024-09-30', 
    @Temperature = 65.3, 
    @WeatherDescription = 'Rainy';
GO
*/


