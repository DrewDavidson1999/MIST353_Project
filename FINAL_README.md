# Weather Data for Farmers Application 

## Deployment Guide 
1. **Software Requirements**
   - Microsoft SQL Server (with Management Studio)
   - Visual Studio 2022
   - Github (for cloneing the repository)
2. **Cloning the Database to SQL Server Management Studio**
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




