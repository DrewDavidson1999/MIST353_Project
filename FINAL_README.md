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
`"ConnectionStrings": {"DefaultConnection": "Server=localhost;Database=WeatherDataDB;Trusted_Connection=True;MultipleActiveResultSets=true"}`
3. **Restore NuGet Packages:**
    - Go to the Tools menu and select NuGet Package Manager > Manage NuGet Packages for Solution.
    - Ensure all required packages are installed and updated.
4. **Build and Run the Application:**
    - Build the solution by selecting Build Solution from the Build menu, then click the `start` button.
5. **Verify the Application:**
    - The application should launch in your default web browser.
    - Navigate to different tabs from the home page such as the `Add Weather Forcast` page, and test that the API is working correctly.



