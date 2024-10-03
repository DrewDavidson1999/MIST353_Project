# **Company Statement**
At our company Weather Data for Farmers, we are working to combine our front-end code using HTML and JavaScript with our back-end code in SQL Server to build a user-friendly web application. Our plan is to integrate our weather databases with a simple interface that allows farmers to access real-time weather forecasts, view historical weather trends, and manage their preferred locations for weather data. Our goal is to create a web application tool that allows farmers to make informed decisions, to help improve their day-to-day operations and crop management.

# **Procedures**

**spGetCurrentWeatherByLocation**
- Action: Get the current weather by specific location.
- Parameters:
  - @City NVARCHAR(255)

**spPreLocAdd**
- Action: Procedure to add a Preferred Location for a User
- Parameters:
  - @LocationID int
  - @City nvarchar(100)
  - @State nvarchar(100)
  - @Country nvarchar(100)

**spPreLocDelete**
- Action: Procedure to remove a Preferred Location for a User
- Parameters:
  - @LocationID int

**spAddWeatherForecast**
- Action: Add a new weather forcast.
- Parameters
  - @Region NVARCHAR(100)
  - @ForecastDate DATE
  - @Temperature FLOAT
  - @WeatherDescription NVARCHAR(255)

**spChangePassword**
- Action: Changing the user's password
- Parameters
  - @UserID int
  - @PasswordHash nvarchar(255)


**spChangePreferredLocation**
- Action: Changing a user's preferred location
- Parameters
  - @UserID int
  - @Location nvarchar(50)

**Stored Procedure Name Here**
- Action: 
- Parameters
  - 
 
**Stored Procedure Name Here**
- Action: 
- Parameters
  -  

# **References:**

### Drew Davidson 
1. I used the stored procedure SQL files stored in ecampus from class. (VehicleAppSP2.sql) (VehicleAppSP3.sql) (VehicleAppSP4.sql)
2. I used ChatGPT to create mock table data, for the tables in the WeatherDataDB.sql file. All though there were formating errors that I had    to correct.
       ChatGPT Promt: Generate me data for these tables using SQL Server

### Joey Baumgart 
1. I used W3Schools as a source for lookig at their stored proc examples.

### Nathan Stryker
1. I used ChatGPT to find the word for updating in a stored procedure
     Prompt: "creating a stored procedure to update a user password in sql"
2. I used the Class Collaborate videos to get the right format
