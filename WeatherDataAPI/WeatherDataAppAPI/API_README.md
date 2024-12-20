# Weather Application API Documentation

## Description of 8 Pages
### Drew Davidson's 2 pages:
1. The first page will use the GetWeatherByLocation API to enable users to view current weather data for a specified city. Users can enter a city name to retrieve up-to-date weather information from the ext_Weather_Current table in the WeatherDataDB. This page will display detailed weather metrics, including temperature, humidity, wind speed, and a brief weather description.
2. The second page will use the AddWeatherForecast API to allow users to submit a new weather forecast for a specific region. The API takes parameters like region, forecast date, temperature, and a brief weather description to insert forecast data into the ext_Weather_Forecasts table in the WeatherDataDB.

### Samantha Wilson's 2 pages: 
3. This page allows new users to register for access to the Farmers Weather Platform. Here, users can sign up by providing a unique username, email, and a secure password. Once registered, users can log in to access personalized weather updates, forecasts, and other agricultural information.
4. This page would enable users to add a new location (city, state, and country) to their profile or to track weather updates for specific areas. Using the InsertLocation API, the page would store the provided location information in the database, allowing users to customize the weather data they receive.

### Joseph Baumgart's 2 pages:
5. The **GetWeatherAdd** API inserts a new location into the _extLocations table. The API asks for a city, state, and LocationID. The LocationID autoincriments so it is not truly necessary. The API is based off spPreLocAdd.
6. The **GetWeatherDelete** API deletes a location by primary key from the _extLocations table. The API asks for a key and then it removes that from the table. The API is based off spPreLocDelete.

### Nathan Stryker's 2 pages:
7. This page will simply allow the user to change their password. 
8. This page will display preferred location information. This is different from the home page as it will show more specific/detailed information on the preferred location of the user.
----------------------------------------------------------------------------------------------------------------------------------------

## **Drew Davidson APIs**
### 1. GetWeatherByLocation API
#### Purpose:
The **GetWeatherByLocation** API allows users to retrieve the current weather data for a specified city. This API pulls weather data from the `ext_Weather_Current` table from the WeatherDataDB based on the city input. This Web APi provides detailed weather information to users of the web application.
### Inputs:
-**City**: Name of City for which the weather data is requested.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Sacramento`
####
### Example Curl Request:
```
curl -X 'GET' \
  'https://localhost:7085/api/WeatherByLocation/GetWeatherByCity/Sacramento' \
  -H 'accept: text/plain'
```
### Example Request URL:
```
https://localhost:7085/api/WeatherByLocation/GetWeatherByCity/Sacramento
```
### Outputs:
#### Success (200 OK):
```
  **location**: Name of the city (`string`).
  **temperature**: Current temperature (`double`).
  **humidity**: Current humidity in percentage (`int`).
  **windSpeed**: Current wind speed (`double`).
  **weatherDescription**: Brief description of the weather (`string`).
  **dateTime**: Date and time when the data was retrieved (`DateTime`).
```
#### Example Success Response:
```
[
  {
    "location": "Sacramento",
    "temperature": 75.5,
    "humidity": 60,
    "windSpeed": 10.2,
    "weatherDescription": "Clear Sky",
    "dateTime": "2024-09-30T17:10:40.67"
  }
]
```
### 2. AddWeatherForcast API
#### Purpose:
The AddWeatherForecast API allows users to add a new weather forecast for a specified region. This API inserts forecast data into the `ext_Weather_Forecasts` table in the `WeatherDataDB` based on the input parameters. This enables users to add future weather forecasts to the database.
### Inputs:
- **City**: Name of city for which the weather data is requested.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Los Angeles`
- **ForcastDate**: Date of weather forcasted
  - Type: `DateTime`
  - Required: Yes
  - Description: The date should be passed in the JSON body to specify when the forecast applies.
  - Example: `2024-09-30`
- **temperature**: Forecasted temperature for the specified date.
  - Type: `double`
  - Required: Yes
  - Description: Forecasted temperature should be included in the JSON body as part of the request payload.
  - Example: `65.3`
- **weatherDescription**: Brief description of the forecasted weather.
  - Type: `string`
  - Required: Yes
  - Description: Weather description should be provided in the JSON body to offer details about forecasted conditions.
  - Example: `Rainy`
### Example Curl Request:
```
curl -X 'POST' \
  'https://localhost:7085/api/WeatherByLocation/AddWeatherForecast' \
  -H 'accept: application/json' \
  -H 'Content-Type: application/json' \
  -d '{
        "region": "Los Angeles",
        "forecastDate": "2024-09-30",
        "temperature": 65.3,
        "weatherDescription": "Rainy"
      }'
```
### Example Request URL:
```
https://localhost:7085/api/WeatherByLocation/AddWeatherForecast
```
### Outputs:
#### Success (200 OK):
```
    "Weather forecast added successfully."
```
#### Example Success Response:
```
"Weather forecast added successfully."
```
### `WeatherByLocationController.cs`
- **Type**: Controller
- **Purpose**: Handles API endpoints for both `GetWeatherByLocation` and `AddWeatherForecast` APIs.
- **Includes**:
  - **Endpoints**:
    - `GET /api/WeatherByLocation/GetWeatherByCity/{city}`: Retrieves current weather data for the specified city.
    - `POST /api/WeatherByLocation/AddWeatherForecast`: Adds a new weather forecast for a specified region.
  - **Methods**:
    - `GetWeatherByCity`: Retrieves weather data by city.
    - `AddWeatherForecast`: Adds a forecast to the database based on the provided JSON data.
### `WeatherRepository.cs`
- **Type**: Repository
- **Purpose**: Contains methods for database access to fetch and insert weather data. Used by both `GetWeatherByLocation` and `AddWeatherForecast` APIs.
- **Includes**:
  - **Methods**:
    - `GetCurrentWeatherByCity`: Queries the database to retrieve current weather data for a specified city.
    - `AddWeatherForecast`: Calls the stored procedure `spAddWeatherForecast` to insert a new forecast into the `ext_Weather_Forecasts` table.
### `IWeatherData.cs`
- **Type**: Interface
- **Purpose**: Serves as the data model for current weather information, used by both APIs to structure weather data.
- **Includes**:
  - **Properties**:
    - `Location`: `string` - Name of the city.
    - `Temperature`: `double` - Current temperature.
    - `Humidity`: `int` - Humidity percentage.
    - `WindSpeed`: `double` - Wind speed.
    - `WeatherDescription`: `string` - Brief description of the weather.
    - `DateTime`: `DateTime` - Timestamp of the recorded weather data. 
### Page Outline:
- Page 3 will be the `GetWeatherByLocation` page. This page will allow users to input a city name and retrieve current weather data from the database. The page will display the following weather information for the specified city: location, temperature, humidity, wind speed, weather description, and the date/time the data was recorded. 
- Page 4 will be the `AddWeatherForecast` page. This page will enable users to input forecast details and add a new weather forecast to the database using the AddWeatherForecast API. The page will have an interactive form where users can enter the region, forecast date, temperature, and a brief weather description. 
 
## Samantha Wilsons APIs
### 1. InsertNewUser API
### Page 1. This page allows new users to register for access to the Farmers Weather Platform. Here, users can sign up by providing a unique username, email, and a secure password. Once registered, users can log in to access personalized weather updates, forecasts, and other agricultural information.
#### Purpose:
The **InsertNewUser** API allows users to register a new user in the system. This API stores user information in the database and returns the details of the newly created user. It is designed to facilitate user registration for the web application.
### Inputs:
- **Username**:The desired username for the new user.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter.
Example: john_doe

- **email**: The email address of the new user.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter.
Example: john@example.com

- **passwordHash**: The hashed password for the new user.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter. Ensure the password is securely hashed before sending.
Example: 1234
### Example Curl Request:
```
curl -X 'POST' \
  'https://localhost:7085/api/NewUser/InsertNewUser/john_doe/john%40example.com/1234' \
  -H 'accept: */*' \
  -d ''
```
### Example Request URL:
```
https://localhost:7085/api/NewUser/InsertNewUser/john_doe/john%40example.com/1234

```
### Outputs:
#### Success (201 Created):
```
    **userName**: The username of the new user (string).
    **email**: The email address of the new user (string).
```
#### Example Success Response:
```
{
  "userName": "john_doe",
  "email": "john@example.com",
}

```
### 2. InsertLocation API
### Page 2. This page would enable users to add a new location (city, state, and country) to their profile or to track weather updates for specific areas. Using the InsertLocation API, the page would store the provided location information in the database, allowing users to customize the weather data they receive.
#### Purpose:
The **InsertLocation** API allows users to add a new location to the system. This API stores location information in the database and returns the details of the newly added location. It is designed to facilitate location registration for the web application.
### Inputs:
- **city**: The name of the city to be added.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter.
Example: Sacramento

- **state**: The state where the city is located.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter.
Example: California

- **country**: The country where the city is located.
Type: string
Required: Yes
Description: This value should be passed as a URL path parameter.
Example: USA
### Example Curl Request:
```
curl -X 'POST' \
  'https://localhost:7085/api/InsertLocation/Sacramento%20/California/USA' \
  -H 'accept: */*' \
  -d ''
```
### Example Request URL:
```
https://localhost:7085/api/InsertLocation/Sacramento%20/California/USA

```
### Outputs:
#### Success (201 Created):
```
    **city**: The name of the city (string).
    **state**: The state where the city is located (string).
    **country**: The country where the city is located (string).
   
```
#### Example Success Response:
```
{
  "city": "Sacramento",
  "state": "California",
  "country": "USA",
  
}
```
=======
## **Joseph Baumgart APIs**
### 1. GetWeatherAdd API
#### Purpose:
The **GetWeatherAdd** API inserts a new location into the _extLocations table. The API asks for a city, state, and LocationID. The LocationID autoincriments so it is not truly necessary. The API is based off spPreLocAdd.
### Inputs:
- **city**: Name of city being added.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Centreville`
- **state**: Name of state being added.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Virginia`
- **country**: Name of country being added.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `USA`
- **locationID**: Name of locationID being added.
  - **Type**: `int`
  - **Required**: No
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `99`
### Example Curl Request:
```
curl -X 'GET' \
  'https://localhost:7085/api/WeatherDataAdd/99?city=centreville&state=virginia&country=USA' \
  -H 'accept: text/plain'
```
### Example Request URL:
```
https://localhost:7085/api/WeatherDataAdd/99?city=centreville&state=virginia&country=USA
```
### Outputs:
#### Success (200 OK):
```
  [
  {
    "locationID": 99,
    "city": "centreville",
    "state": "virginia",
    "country": "USA"
  }
]
```
### 2. GetWeatherDelete API
#### Purpose:
The **GetWeatherDelete** API deletes a location by primary key from the _extLocations table. The API asks for a key and then it removes that from the table. The API is based off spPreLocDelete.
### Inputs:
- **locationID**: Name of locationID being added.
  - **Type**: `int`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `99`
### Example Curl Request:
```
curl -X 'DELETE' \
  'https://localhost:7085/api/UDelete/8' \
  -H 'accept: text/plain'
```
### Example Request URL:
```
https://localhost:7085/api/UDelete/8
```
### Outputs:
#### Success (200 OK):
```
  [
  {
    "userID": 8
  }
]
```
Pages 5 and 6 will be the historical data and the add and delete location APIs. The historical data will provide data used from the API I found back in assignment two. The APIs will both be on the sam epage and will aloow you to add and delete locations from the database. Both pages will have visuals. The historical data page will have an interactive button for the data. The API for add and delete location will display on the same page (paage 6).


>>>>>>> 85992f6430bc6c0cb870c42f5bbdee16612b7a91

## **Nathan Stryker APIs**
### 1. ChangePassword API
### Page 7: This page will simply allow the user to change their password. 
#### Purpose:
The **ChangePW** API allows users to change their password. This API updates user data from the `ext_Users` table from the WeatherDataDB based on the userid and password input. This API accepts the input from the users in order for them to update their password to whatever they would like to.
### Inputs:
-**UserID**: ID of the user changing their password.
  - **Type**: `int`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `1`
-**PasswordHash**: Password of the user
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
    
####
### Example Curl Request:
```
curl -X 'PUT' \
  'https://localhost:7085/api/ChangePW/UpdatePassword' \
  -d '{"current_password": "old_password", "new_password": "1234"}'
```
### Example Request URL:
```
https://localhost:7085/api/ChangePW/UpdatePassword
```
### Outputs:
#### Success (200 OK):
```
 "message": "Password updated successfully"
```
#### Example Success Response:
```
[
  {
    "message": "Password updated successfully"
  }
]
```
### 2. ChangePreferredLocation API
### Page 8: This page will display preferred location information. This is different from the home page as it will show more specific/detailed information on the preferred location of the user.
#### Purpose:
The ChangePreferredLocation API allows users to update their preferred location. This API updates preferred location data into the `ext_UserPreferredLocations` table in the `WeatherDataDB` based on the input parameters. This enables users to change their preferred location so they can see the info they want on our website.
### Inputs:
- **UserID**: ID of the user changing their preferred location.
  - **Type**: `int`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `235`
- **Location**: The new preferred location
  - Type: `string`
  - Required: Yes
  - Description: This value should be passes as a URL path parameter.
  - Example: `San Antonio`

### Example Curl Request:
```
curl -X 'PUT' \
  'https://localhost:7085/api/ChangePreferredLocation/UpdatePreferredLocation'
  -H 'Content-Type: application/json' \
  -d '{
        "location": "San Antonio, TX"
      }'
```
### Example Request URL:
```
https://localhost:7085/api/ChangePreferredLocation/UpdatePreferredLocation
```
### Outputs:
#### Success (200 OK):
```
    "Preferred Location updated successfully!"
```
#### Example Success Response:
```
"Preferred Location updated successfully!"
```
### Sources
-**ChatGPT**: I used ChatGPT for my Curl info, asking it to write me Curl requests and responses based on the function of my API. I also used it for a simple formatting issue in one of my APIs.

## README.md file for Assignment 5: Razor Pages
[View Razor Pages README](https://github.com/DrewDavidson1999/MIST353_Project/blob/master/SampleProject/Pages/README.md)

