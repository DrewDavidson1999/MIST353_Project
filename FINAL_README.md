# Weather Data for Farmers Application 

## Deployment Guide 
### **Cloning the Database to SQL Server Management Studio**
1. **Software Requirements**
   - Microsoft SQL Server (with Management Studio)
   - Visual Studio 2022
   - Github (for cloneing the repository)
2. **Cloning the Database**
   - Open a web browser and go to the GitHub repository for the application: https://github.com/DrewDavidson1999/MIST353_Project
   - Click the green "Code" button and copy the HTTPS URL (https://github.com/DrewDavidson1999/MIST353_Project.git)
3. **Download the Repository**
   - On your VM, open a terminal or Git Bash.
   - Navigate to the folder where you want to clone the project: `cd path/to/your/folder`
   - Run the following command to clone the repository: `git clone https://github.com/DrewDavidson1999/MIST353_Project.git`
   - Once cloned, navigate into the project folder: `cd MIST353_Project/SampleProject/SQL`
4. **Open SQL Server Management Studio (SSMS):**
   - Launch SQL Server Management Studio.
   - Connect to your SQL Server instance.
5. **Create a New Database:**
   - In SSMS, right-click on Databases in the Object Explorer and select New Database.
   - Name the database WeatherDataDB.
6. **Run SQL Scripts to Populate the Database:**
   - Inside the cloned folder, navigate to the SQL directory `(MIST353_Project/SampleProject/SQL)`.
   - You will find multiple SQL scripts for creating tables, stored procedures, and inserting sample data.
   - Open each script in SSMS:
     - Right-click on your newly created `WeatherDataDB` database and select New Query.
     - Copy and paste the SQL code from each script (e.g., `CreateTables.sql`, `InsertSampleData.sql`) and run them in order by clicking Execute.
7. **Verify the Database:**
   - In the Object Explorer, refresh the database.
   - Expand Tables to verify that all necessary tables (e.g., `ext_Weather_Current`, `ext_Weather_Forecasts`) are present.
   - Expand **Programmability > Stored Procedures** to ensure that stored procedures (e.g., `spGetCurrentWeatherByLocation`, `spAddWeatherForecast`) are successfully created.
### **Cloning the Visual Studio Code Project**
1. **Clone the Repository:**
   - Open Visual Studio, and from the Start Window, select Clone a Repository.
   - Enter the same GitHub repository URL used in the database setup: https://github.com/DrewDavidson1999/MIST353_Project.git
   - Choose a local folder where you want the project files to be stored, and click `Clone`.
   - After cloning, Visual Studio should automatically open the solution. If not, navigate to the cloned folder, locate the solution file and double-click to open it.
2. **Update Connection String:**
    - In Visual Studio, open the appsettings.json file located in the root of the project.
    - Update the connection string to match your SQL Server instance. For example:
`"ConnectionStrings": { "DefaultConnection": "Data Source=labH7SR1J;Initial Catalog=WeatherDataDB;Integrated Security =True;TrustServerCertificate=True;" }`
    - Make sure that the `Data Source =` is set to your correct server name (e.g., `Data Source=labH7SR1J`)
3. **Restore NuGet Packages:**
    - Go to the Tools menu and select NuGet Package Manager > Manage NuGet Packages for Solution.
    - Ensure all required packages are installed and updated.
4. **Build and Run the Application:**
    - Build the solution by selecting Build Solution from the Build menu, then click the `start` button.
5. **Verify the Application:**
    - The application should launch in your default web browser.
    - Navigate to different tabs from the home page such as the `Add Weather Forcast` page, and test that the API is working correctly.
### **Pitfalls to Avoid When Setting Up the Application:**
1. **Incorrect SQL Server Configuration:**
   - Ensure SQL Server is installed and running on your VM.
   - Verify that the connection string in the `appsettings.json` file points to your SQL Server instance and the `WeatherDataDB` database.
   - Ensure you have the correct permissions to create databases, tables, and execute stored procedures.
2. **Order of SQL Script Execution:**
   - If SQL scripts are executed out of order, you might encounter errors like missing tables or stored procedures.
   - Follow the sequence:
     - `CreateTables.sql`: Sets up the required tables.
     - `InsertSampleData.sql`: Populates the tables with initial data.
     - `CreateStoredProcedures.sql`: Adds the stored procedures.
3. **Missing NuGet Packages:**
   - After cloning the repository, restore all NuGet packages in Visual Studio to avoid missing dependencies.
   - Use **Tools > NuGet Package Manager > Manage NuGet Packages** for Solution and install any missing packages.
4. **Connection String Errors:**
   - A common error is an incorrect connection string, also make sure it includes the correct Data Source. Example Below: 
`"ConnectionStrings": { "DefaultConnection": "Data Source=labH7SR1J;Initial Catalog=WeatherDataDB;Integrated Security =True;TrustServerCertificate=True;" }`
### **Where to Go for Help if You Encounter Errors**
1. **SQL Server Issues:**
   - Review Microsoft SQL Server documentation: https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16
   - Use SSMS error messages for debugging.
2. **Visual Studio Errors:**
   - Check the Error List panel in Visual Studio for detailed error information.
   - Refer to Microsoft's Visual Studio documentation: https://learn.microsoft.com/en-us/visualstudio/?view=vs-2022
3. **GitHub Repository:**
   - Check the repository's Issues section for solutions if you're cloning an updated version.
4. **Stack Overflow:**
   - Post questions or search for similar issues: https://stackoverflow.com/
5. *W3 Schools*
   - Visit https://www.w3schools.com/ for any other questions or errors. 
## **API Documentation** 
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



