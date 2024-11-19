# Razor Pages and API Integration (Assignment 5) 
**The Razor Pages can be found in the main project solution under the Pages folder. Each Razor Page is organized into its own subfolder, corresponding to the API it integrates with.**

## Drew Davidson's Razor Page Documentation  
### Razor Page 1 - Get Current Weather by City 
- **Location**: `Pages/WeatherCurrent`
- Contains multiple `.cshtml` files for CRUD operations:
  - `Search.cshtml`: Main search page for viewing weather forcast data by specific city.
  - `Create.cshtml`: Allows an option for a user to create a new weather forcast entry, after they search for an existing forcast.
  - `Edit.cshtml`, `Details.cshtml`, `Delete.cshtml`: Supporting CRUD operation pages, that allow a user to modify existing weather forcasts after the initial search. 
- Description: This Razor page allows users to search for current weather conditions by a specific city. Users enter the city name in the search bar, and the page then displays all historical weather data for that location. The page will display detailed weather data including temperature, humidity, wind speed, weather description, and forecast date/time.
- API Used: `spGetCurrentWeatherByLocation` API, integrated using backend C#.
- Database Interaction: Pulls data from the `Ext_Weather_Current` table in the `WeatherDataDB` database.
- Functionality: Users enter a city name in the search bar on the page. Then the user's input is sent to the `GetWeatherByLocation` API, which retrieves all matching weather forecast information, including:
  - Temperature
  - Humidity
  - Wind Speed
  - A weather description
  - The date and time of the forecast
  - Displays all retrieved data in a structured table format for the user to view.

### Razor Page 2 - Add Weather Forcast 
- **Location**: `Pages/AddWeatherForcast` 
- Contains multiple `.cshtml` files for CRUD operations:
  - `Create.cshtml`: Main page for adding a new weather forecast.
  - `Edit.cshtml`, `Details.cshtml`, and `Delete.cshtml`: Supporting CRUD operation pages, that allow a user to modify existing weather forcasts. 
- Description: This Razor page allows users to add a new weather forecast for a specific region. Users can input details such as the region name, forecast date, temperature, and a brief weather description through an interactive form.
- API Used: `spAddWeatherForecast` API, integrated using backend C#.
- Database Interaction: Inserts data into the Ext_Weather_Forecasts table in the WeatherDataDB database.
- Functionality: Provides a user-friendly form for submitting new weather forecast information, including:
  - Region: The name of the region for the forecast.
  - Forecast Date: The date of the forecast.
  - Temperature: Expected temperature for the forecast.
  - Weather Description: A brief summary of the expected weather conditions.
- Once the user submits the new weather forcast, the data is sent to the `AddWeatherForecast` API, which validates and stores the forecast in the `ext_Weather_Forcasts` table in the database .
- The page will display a success message upon successful submission of a weather forcast from a user, or an error message.

## Joey Baumgart Razor Page Documentation  
### Razor Page 1 - Delete Location
- **Location**: `Pages/LDelete` 
- Description: The Location Delete Razor page is used to delete one of the loctions from the database. The Razor page displays the locations in the database and allows you to remove the specific location.
- API Used: `spPreLocAdd` API
- Database Interaction: This deletes locations by ID from the ext_Locations table in WeatherDataDB.
- Functionality:

### Razor Page 2 - Delete User
- **Location**: `Pages/UDelete` 
- Description: The User Delete Razor page is used to delete a user from the user table in the database. The Razor page allows you to view all the users in the database and delete one of the users from the page.
- API Used: `UDelete` API
- Database Interaction: This deletes users by ID from the ext_User table in the WeatherDataDB.
- Functionality:


## `put your name` Razor Page Documentation  
### Razor Page 1 - 
- **Location**: `Pages/` 
- Description: 
- API Used: `sp` 
- Database Interaction: 
- Functionality: 
