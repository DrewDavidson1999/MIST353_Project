# Weather Application API Documentation

## Drew Davidson
### 1. GetWeatherByLocation API
#### Purpose:
The **GetWeatherByLocation** API allows users to retrieve the current weather data for a specified city. This API pulls weather data from the `ext_Weather_Current` table from the WeatherDataDB based on the city input. This Web APi provides detailed weather information to users of the web application.
### Inputs:
- **city**: Name of city for which the weather data is requested.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Sacramento`
### Example Request URL:
- https://localhost:7085/api/WeatherByLocation/GetWeatherByCity/Sacramento
### Outputs:
#### Success (200 OK):
- **Response Body (JSON)**: When successful, the API returns a JSON array with the following fields:
  - **location**: Name of the city (`string`).
  - **temperature**: Current temperature (`double`).
  - **humidity**: Current humidity in percentage (`int`).
  - **windSpeed**: Current wind speed (`double`).
  - **weatherDescription**: Brief description of the weather (`string`).
  - **dateTime**: Date and time when the data was retrieved (`DateTime`).

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

### 2. 
