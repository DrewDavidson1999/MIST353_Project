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

## Samantha Wilson's Razor Page Documentation  
### Razor Page 1 - Add User
- **Location**: `Pages/User`
- Description: Developed a CRUD Razor Page allowing users to be added to the system. The page is accessible via the navigation bar, which provides a direct link to the "Add New User" interface.
- Database Interaction: This page integrates with the database to insert new records, including a username, email, and hashed password for security.
- Functionality: - Input fields for username, email, and password.
  - Form submission validates inputs and ensures data integrity.
  - On successful submission, new user data is stored in the database.
  - Error handling is implemented to alert users of invalid inputs or database issues.
 
### Razor Page  - Add Location
- **Location**: `Pages/Location`
- Description: Created a CRUD Razor Page to manage locations. This page allows users to add new locations to the system through a simple, user-friendly interface accessible via the navigation bar.
- Database Interaction: Inserts new location records into the database, including location name, address, and additional details.
- Functionality: - Provides input fields for entering location details such as name, address, and relevant metadata.
  - Handles form submissions by validating inputs and invoking the stored procedure.
  - Displays error messages for incomplete or invalid entries.

## Joey Baumgart Razor Page Documentation  
### Razor Page 1 - Delete Location
- **Location**: `Pages/LDelete` 
- Description: The Location Delete Razor page is used to delete one of the locations from the database. The Razor page displays the locations in the database and allows you to remove the specific location.
- API Used: `spPreLocAdd` API
- Database Interaction: This deletes locations by ID from the ext_Locations table in WeatherDataDB.
- Functionality: The users can easily delete a location from the database and can easily access the page from the home page of the application. The API also displays an error message that will let the user know if the ID does not exist.
  - LocationID is used to delete all data for that datarow in the ext_Locations table corresponding to the LocationID.

### Razor Page 2 - Delete User
- **Location**: `Pages/UDelete` 
- Description: The User Delete Razor page is used to delete a user from the user table in the database. The Razor page allows you to view all the users in the database and delete one of the users from the page.
- API Used: `UDelete` API
- Database Interaction: This deletes users by ID from the ext_User table in the WeatherDataDB.
- Functionality: The users can easily delete a user from the database and can easily access the page from the home page of the application. The API also displays an error message that will let the user know if the ID does not exist.
  - UserID is used to delete all data for that datarow in the ext_User table corresponding to the UserID.
 
## Nathan Stryker's Razor Page Documentation  
### Razor Page 1 - Edit Password
- **Location**: `Pages/Password`
- Contains multiple `.cshtml` files for CRUD operations:
  - `Create.cshtml`: Allows an option for a user to create a new account for themselves
  - `Edit.cshtml`, `Details.cshtml`, `Delete.cshtml`: Supporting CRUD operation pages, that allow a user to modify their password, view it, or delete their account
- Description: This Razor page allows users to see their account information while having the primary function of editing their password. However, they are also able to delete and view their account information from this page.
- API Used: `spChangePassword` API, integrated using backend C#.
- Database Interaction: Pulls data from the `Ext_Users` table in the `WeatherDataDB` database.
- Functionality: Users enter into the index of users and find themselves, and go into their account and edit their password, and it then updates it in the database
  - Username
  - User Email
  - Password
  - Displays all retrieved data in a structured table format for the user to view.

### Razor Page 2 - Edit Preferred Location
- **Location**: `Pages/PreferredLocUpdate`
- Contains multiple `.cshtml` files for CRUD operations:
  - `Create.cshtml`: Allows an option for a user to create a preferred location for themselves
  - `Edit.cshtml`, `Details.cshtml`, `Delete.cshtml`: Supporting CRUD operation pages, that allow a user to modify their preferred location, delete it, or view it
- API Used: `spChangePreferredLocation` API, integrated using backend C#.
- Database Interaction: Pulls data from the `Ext_UserPreferredLocations` table in the `WeatherDataDB` database.
- Functionality: Users enter in their user id and their preferred location, and it updates it in the database.
  - User ID
  - Preferred Location
  - Displays all retrieved data in a structured table format for the user to view.
