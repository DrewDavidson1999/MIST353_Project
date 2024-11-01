# Weather Application API Documentation

## Drew Davidson APIs
### 1. GetWeatherByLocation API
#### Purpose:
The **GetWeatherByLocation** API allows users to retrieve the current weather data for a specified city. This API pulls weather data from the `ext_Weather_Current` table from the WeatherDataDB based on the city input. This Web APi provides detailed weather information to users of the web application.
### Inputs:
- **city**: Name of city for which the weather data is requested.
  - **Type**: `string`
  - **Required**: Yes
  - **Description**: This value should be passed as a URL path parameter.
  - **Example**: `Sacramento`
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

### 2. 
## Samantha Wilsons APIs
### 1. InsertNewUser API
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
Example: Password123
### Example Curl Request:
```
curl -X 'POST' \
  'https://localhost:7085/api/NewUser/InsertNewUser/john_doe/john@example.com/hashed_password_value' \
  -H 'accept: application/json'

```
### Example Request URL:
```
https://localhost:7085/api/NewUser/InsertNewUser/john_doe/john@example.com/hashed_password_value

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
  'https://localhost:7085/api/Location/InsertLocation/Sacramento/California/USA' \
  -H 'accept: application/json'

```
### Example Request URL:
```
https://localhost:7085/api/Location/InsertLocation/Sacramento/California/USA

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