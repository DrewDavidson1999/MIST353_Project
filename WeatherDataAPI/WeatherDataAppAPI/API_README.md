# Weather Application API Documentation

## Drew Davidson APIs
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
  - Type: 'DateTime'
  - Required: Yes
  - Description: The date should be passed in the JSON body to specify when the forecast applies.
  - Example: '2024-09-30'
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

## Joseph Baumgart APIs
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
  [
  {
    "locationID": 99
  }
]
```
