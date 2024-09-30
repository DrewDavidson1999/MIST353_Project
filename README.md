# SampleProject

OverView

This project is a weather data website tailored for farmers, offering real-time and long-term weather forecasts, historical weather trends, and farm management tips. 
The website's core functionality includes a U.S. weather map that allows users to search by location and access data specific to their region. 
The platform is designed to assist farmers in making informed decisions about crop management, planting, and harvesting by leveraging accurate, localized weather information.
The homepage will have a quick search of for your location and give quick data for the week. -Drew
The historical page will show records by region with visual graphs or charts -Joey
The seasonal page will show long term forecasts with monitoring of different data for farmers. -Nathan
The farm tips will allow users to show specific recommendations and other tips. -Sami

Current Phase: The project is in the initial development phase, where the core structure of the website is being built.
Key features under development include the interactive weather map, a system for querying real-time and historical data, and basic visualizations for trends. 
The front-end design is focused on usability and mobile-friendliness, while the back-end is setting up data fetching mechanisms from weather APIs.

Future Enhancements
Mobile Optimization: Improve the interface for better mobile usability, allowing farmers to access weather data on the go.
User Accounts: Enable user profiles to save locations, set weather alerts, and receive personalized recommendations.
Advanced Visualizations: Add interactive charts and graphs for more in-depth data analysis.
Enhanced API Integration: Incorporate multiple weather APIs for more detailed, localized weather data.

Nathan Stryker 
**Webpage Research** 
http://farmerweather.com/ Farmer Weather has an interactive radar map that I would like to implement on my page. 
I think having this on the page would definitely make the page look better. When creating a website like this, we are obviously 
expecting people from all over the United States to use it, so having a radar map of the entire USA would allow for anyone anywhere to 
quickly see radar for their area. After looking at the radar map, they would then be able to see the weather data for their specific state/region.

**GitHub Repository Research**
The GitHub Repository I found in my research was climate-change-data created by Kkulma.
This repository contains a lot of open projects about climate data, including Climate Change AI that I think could be incorporated on our webpage.
The item that really drew my attention to this repository, though, was the APIs; specifically, Open-Meteo API.
Open-Meteo API is a weather and climate API that includes forecasts, historical weather data, and climate data.
By incorporating some code from the Climate Change AI and using the Open-Meteo API, we can implement up-to-date forecasts and historical data where necessary.

**Individual Contributions**
I did the seasonal data page. On my page, I have seasonal data for different regions, and I prompt the user to select the region they live in.
I prefer this compared to presenting information based on user geolocation because they have the freedom to search for any region's data easily.
As we move forward with the project, I want to do every state's seasonal data, because that can give an even bigger insight to users of the website on normal farming conditions for them.
I included regional tables with the season, average temperature during that season, and crops typically planted in that region and season.
I also made the buttons that show and hide regional information based on the button selected.
Additionally, I included a background picture of farmers driving farming equipment with a cloudy sky, which I thought played into the theme of farmer forecasting well.
The table text is also a dark green color to represent farming as a whole, as green seems to be a common color associated with farming.
Moving forward, I also want to find a way to more effectively use my buttons so I do not have huge blocks of code under each function. 
Also when all tables show, the green color at the bottom is hard to read due to the color of the background picture, but I think it is worth it because once a region is selected the text is easily read.

**AI Usage and Other Resources**
I asked ChatGPT for the specific JavaScript to make my buttons perform in the way I wanted them to. 
Specifically, I asked "How can I hide and show these tables in HTML." It presented me with a partial solution that I can now build off of to implement more tables and more buttons in a simple and effective way.
I also used W3Schools to figure out how to do the formatting for my tables and table data.
I used Google's AI to find the information for my table data.

Samantha Wilson Webpage Research Farms.com is a practical website designed for agricultural professionals, offering weather forecasts 
and farming advice in a user-friendly format. The site uses a clean layout with easy navigation, featuring weather tools that provide location-based 
forecasts and alerts. It integrates Bootstrap components for a responsive design, though it remains simple in functionality without advanced frontend frameworks. 
The focus is on providing essential resources, such as crop management tips and custom weather alerts, which makes it well-suited for its target audience of farmers looking to optimize their operations based on weather conditions.

GitHub Repository Research The Farm-AI GitHub repository is a mobile application designed to support farmers by providing real-time 
weather updates and farm management tips. The app integrates a weather API to offer tailored forecasts, rain predictions, and crop 
recommendations based on the specific climate and location of a farm. Additionally, it includes educational resources on farming 
techniques and crop care. The README is well-structured, clearly outlining the app’s features, technologies used, and how users can 
access and contribute to the project. It provides detailed insights into how machine learning is used for predictions, making the repository 
an excellent resource for those interested in combining weather data with agricultural advice.

Webpage The Farm Tips page is a modern and user-friendly web application designed to provide useful agricultural advice in a clean and 
visually appealing format. It features a simple layout centered on the screen, enhancing readability and accessibility. The page includes a 
table displaying various farming tips along with their respective categories, allowing users to quickly identify relevant information. A 
prominent button invites users to receive a random tip, which is displayed in a bold, eye-catching format below the button. The design uses 
a soft color palette and subtle shadow effects to create a welcoming atmosphere.


Drew Davidson 
**Documenting Individual Contributions:**
I created the WeatherDataHomePage.cshtml page of our prototype. For my WeatherDataHomePage I implemented a backround image for the web page based off farm landscape. Following I created a bold header for the top of the page reading "Weather for Farmers".
Directly below my first header I added a second header with text directing the user to "Search for weather conditions below!", I added a seagreen backround to the text. Next I added a card to hold the search bar for users to search for weather by their city name.
Next I added a card to hold hypothetical weather data from a certain location, in the future the goal is to have the user find their current location when accessing website, then the weather data will autoload into this card. 
Next I added a "find my location" button for the user to find their current location based of longitude and latitude, I am still trying to attempt to have the location of the user displayed by name of their city. I made the all the text yellow pertaining to the get your location button.

**Research and Findings:**
For this project I researched multiple repositories, I found ways to implement search bars that look more aestheticly pleasing, instead of carrying a 90's look. As well make the button for the searh bar to have a cleaner design.
Additionally I found a method to implement the "get your location" feature. This is to fetch the users current location, I was only able to find examples of cordinate locations, I am still working on getting location to appear as a city. 
Reguarding researching a website I chose a weather data based website, during inspecting the HTML code of this website I learned a lot of useful information. First I found a section of HTML code for making a hamburger menu, and implemeting 
list items into the menu utilizing href to direct the user to other pages of the site. Additionally I discovered how to utilize the logo theme of a website as a list item with a correlated theme hyperlink to redirect the user to the home screen. 

**Reflection on Resources:**
For this assignment the resources that I used included Github repositories, W3Schools, ChatGPT, and inspecting website for their HTML code. I found inspecting websites and GitHub repositories to be the most helpful resource 
during this assignment. I feel inspecting a website is one of the most beneficial ways to learn HTML, following along with the code displayed and the layout of the website. I did not use ChatGPT to write me code from scratch, 
I feel that ChatGPT has flawed methods of coding that results in errors. I did use ChatGPT to help me revise code that I had, such as look for errors or revise code that was not working correctly. 
W3Schools was very helpful in understanding core HTML concepts, format, and finding information for any questions that I had. 

GitHub Repository Resources Used: (https://github.com/Akuien/SimpleWeatherApp/blob/main/index.html) (https://github.com/shivang21007/Weather-forcast/blob/main/index.html)
Website Inspected: (https://openweathermap.org/)
Other Resources: (ChatGPT.com) (W3Schools.com)

Joey Baumgart Individual Contributions: Created a webpage with titles and a background, used an API to gather data, and used a button to display the data from the API. Added to the readme and did website and repository research.

This website has historical data and provides a useful API. The API collects several useful variables relating to temperature and climate. This API is the one I am implementing into my web page since it gives good results back.
https://open-meteo.com/

This is GitHub repository contains data sets and APIs related to weather and climate change. The APIs can be used for data in multiple climate fields. The ReadMe lists several APIs to use and their descriptions of what they are and how they can be used.
https://github.com/KKulma/climate-change-data

For this assignment I used w3schools and the class repository to look at and implement code. I did not use ChatGPT at all. I also used the open API I found and postman to generate the API.


**ASSIGNMENT 3**

**Statement:** 
At our company Weather Data for Farmers, we are working to combine our front-end code using HTML and JavaScript with our back-end code in SQL Server to build a user-friendly web application. Our plan is to integrate our weather databases with a simple interface that allows farmers to access real-time weather forecasts, view historical weather trends, and manage their preferred locations for weather data. Our goal is to create a web application tool that allows farmers to make informed decisions, to help improve their day-to-day operations and crop management.

**Procedures**
1. Procedure to get the current weather by location
2. Procedure to add a Preferred Location for a User
3. Procedure to remove a Preferred Location for a User
4. Procedure to add a new weather forcast
5. Procedure to get historical weather data for a location
6. 
7. 
8. 

**References:**










