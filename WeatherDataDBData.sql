-- Use the WeatherDataDB database
USE WeatherDataDB
GO

-- Insert sample users into ext_Users
INSERT INTO [ext_Users] (UserName, Email, PasswordHash) VALUES 
('John Doe', 'john.doe@example.com', 'hashedpassword1'),
('Jane Smith', 'jane.smith@example.com', 'hashedpassword2'),
('Bill Johnson', 'bill.johnson@example.com', 'hashedpassword3'),
('Alice Brown', 'alice.brown@example.com', 'hashedpassword4'),
('Charlie Davis', 'charlie.davis@example.com', 'hashedpassword5');
GO

-- Insert sample locations into ext_Locations
INSERT INTO [ext_Locations] (City, State, Country) VALUES 
('Sacramento', 'California', 'USA'),
('Fresno', 'California', 'USA'),
('Modesto', 'California', 'USA'),
('San Francisco', 'California', 'USA'),
('Morgantown', 'West Virginia', 'USA'),
('Austin', 'Texas', 'USA'),
('Los Angeles', 'California', 'USA');
GO

-- Insert sample current weather data into ext_Weather_Current (Location is the city name)
INSERT INTO [ext_Weather_Current] (Location, Temperature, Humidity, WindSpeed, WeatherDescription, DateTime) VALUES 
('Sacramento', 75.5, 60, 10.2, 'Clear Sky', GETDATE()),
('Fresno', 80.0, 55, 8.1, 'Sunny', GETDATE()),
('Modesto', 78.4, 65, 9.5, 'Partly Cloudy', GETDATE()),
('San Francisco', 68.0, 70, 12.0, 'Foggy', GETDATE()),
('Morgantown', 85.0, 40, 15.5, 'Hot and Dry', GETDATE());
GO

-- Insert sample historical weather data into ext_Weather_Historical (Location is the city name)
INSERT INTO [ext_Weather_Historical] (Location, Temperature, Humidity, WindSpeed, WeatherDescription, DateTime) VALUES 
('Sacramento', 70.2, 62, 10.0, 'Clear Sky', '2023-09-01'),
('Fresno', 82.0, 50, 7.5, 'Sunny', '2023-09-02'),
('Modesto', 77.6, 68, 8.8, 'Cloudy', '2023-09-03'),
('San Francisco', 65.0, 75, 13.2, 'Foggy', '2023-09-04'),
('Morgantown', 88.0, 38, 16.0, 'Scorching', '2023-09-05');
GO

-- Insert sample weather forecasts into ext_Weather_Forecasts (Region is the city name)
INSERT INTO [ext_Weather_Forecasts] (Region, ForecastDate, Temperature, WeatherDescription) VALUES 
('Sacramento', '2023-10-01', 74.0, 'Sunny'),
('Fresno', '2023-10-02', 79.5, 'Clear Sky'),
('Modesto', '2023-10-03', 72.0, 'Partly Cloudy'),
('San Francisco', '2023-10-04', 65.5, 'Foggy'),
('Morgantown', '2023-10-05', 84.0, 'Hot and Dry');
GO

-- Insert sample preferred locations for users into ext_UserPreferredLocations (Location is the city name)
INSERT INTO [ext_UserPreferredLocations] (UserID, Location) VALUES 
(1, 'Sacramento'),
(2, 'Fresno'),
(3, 'Modesto'),
(4, 'San Francisco'),
(5, 'Morgantown');
GO
