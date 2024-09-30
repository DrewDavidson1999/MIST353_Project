-- Creating WeatherData Database
Create Database WeatherDataDB
GO

-- Use the WeatherData database
USE WeatherDataDB
GO

-- Creating Table for Users 
CREATE TABLE [ext_Users] (
  [UserID] int PRIMARY KEY IDENTITY(1,1),
  [UserName] nvarchar(100) NOT NULL,
  [Email] nvarchar(255) NOT NULL,
  [PasswordHash] nvarchar(255) NOT NULL
)
GO

-- Creating Table for Locations
CREATE TABLE [ext_Locations] (
  [LocationID] int PRIMARY KEY IDENTITY(1,1),
  [City] nvarchar(100) NOT NULL,
  [State] nvarchar(100) NOT NULL,
  [Country] nvarchar(100) NOT NULL
)
GO

-- Creating Table for Current Weather Data
CREATE TABLE [ext_Weather_Current] (
  [WeatherID] int PRIMARY KEY IDENTITY(1,1),
  [Location] nvarchar(50) NOT NULL,
  [Temperature] float NOT NULL,
  [Humidity] int NOT NULL,
  [WindSpeed] float NOT NULL,
  [WeatherDescription] nvarchar(255) NOT NULL,
  [DateTime] datetime NOT NULL
)
GO

-- Creating Table for Historical Weather Data
CREATE TABLE [ext_Weather_Historical] (
  [WeatherID] int PRIMARY KEY IDENTITY(1,1),
  [Location] nvarchar(50) NOT NULL,
  [Temperature] float NOT NULL,
  [Humidity] int NOT NULL,
  [WindSpeed] float NOT NULL,
  [WeatherDescription] nvarchar(255) NOT NULL,
  [DateTime] datetime NOT NULL
)
GO

-- Creating Table for Weather Forecasts
CREATE TABLE [ext_Weather_Forecasts] (
  [ForecastID] int PRIMARY KEY IDENTITY(1,1),
  [Region] nvarchar(50) NOT NULL,
  [ForecastDate] date NOT NULL,
  [Temperature] float NOT NULL,
  [WeatherDescription] nvarchar(255) NOT NULL
)
GO

-- Creating Table for User Preferred Locations
CREATE TABLE [ext_UserPreferredLocations] (
  [UserID] int NOT NULL,
  [Location] nvarchar(50) NOT NULL,
  PRIMARY KEY ([UserID], [Location])
)
GO
