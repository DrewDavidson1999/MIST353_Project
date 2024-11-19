# Razor Pages and API Integration (Assignment 5) 

## Drew Davidson's Razor Page Documentation  
### Razor Page 1 - Get Current Weather by City 
- Description: This Razor page allows users to search for current weather conditions by a specific city. Users enter the city name in the search bar, and the page then displays all historical weather data for that location. The page will display detailed weather data including temperature, humidity, wind speed, weather description, and forecast date/time.
- API Used: `GetWeatherByLocation` API, integrated using backend C#.
- Database Interaction: Pulls data from the `Ext_Weather_Current` table in the `WeatherDataDB` database.
- Functionality: Users enter a city name in the search bar on the page. Then the user's input is sent to the `GetWeatherByLocation` API, which retrieves all matching weather forecast information, including:
  - Temperature
-- Humidity
-- Wind Speed
-- A weather description
-- The date and time of the forecast
-- Displays all retrieved data in a structured table format for the user to view.
