# Assignment5 Documentation
## Home Page
The home page provides a welcome to the user. It shows an image of an airplane to let the viewers know what to expect. There is also a paragraph that was AI-generated to welcome the users to the website. Lastly, there are functional buttons that lead to other pages in the application. When it comes to style, it is all centered and has a blue-greyish theme.  Ella Southwell created this page.
## Search Page
The search page is where users can search for hotel pages. When the user is brought to this page, they will be prompted to search for a hotel by coordinates. The search from the coordinates will find a hotel within that area. Ella Southwell created this page using the spHotelSearchByRadius API.
## Climate Page
The climate page gives users the ability to check weather information. It uses the weather forecast API. The web page has a sky image background and a container storing weather information. Ella Southwell created this page and used the WeatherForecast API. 
## Review Page
The review page gives the users the option to leave a review as they feel. They do not here but this option is there so we can hear back from our customers and so that others, when booking, can use their feedback when booking. There is a place for your name, email, and a section to leave the comment at. This uses the review API in order to do so.
## Ratings Page

## Hotel Information Page

## Destination Page
This page gives users a list of destinations they might be interested in. Its purpose is to spark interest in the user to travel. Its design uses the list to list popular places inside and outside the United States. The page also uses slideshows to show different images of popular places to spark viewers' interest. Ella Southwell created this page.

## Room Availability Page 
This page integrates two APIs. On this page users can look up their hotel and the specific dates that they desire to stay to see if it is available for their liking. Users can stay for a range of just one night or seven, whatever their liking is they can stay for as many days as desired. They just put in the hotel in the top search bar, and then the dates they want in the search bar below it and hit the submit button. This will then show if that is available.

## References
References used in creating our application include the class lectures, W3Schools, and ChatGPT. 
ChatGPT Promotes: 
"Help me correct the code for syntax errors," followed by the code that needed fixing.
"Give me ideas on what I can add to make my web application more appealing."

# Final Documentation
## Deployment guide
The first step in running the travel site application is to clone the repository [(https://github.com/BrookeMesinere4/Assignment-3-MIST-353.git)]. Once the repository is cloned into your blank VM, you will open SQL Studio—once that is open, they will need to open the files  TravelDatabaseCreation.sql and TravelDatabaseDate.sql. Once you open the files, run it. Then, a database will be created. The next step would be to open the file TreyZontekSPS.sql and hit run. This creates the stored procedures for the application. You would want to do this step again for the files EllaSouthwellSPs.sql and BrookeMesinereSPs.sql. Next, you want to clone the repository [(https://github.com/ems00023/Assignment5.git)] to your blank VM. When complete, you want to open the project in visual studios. Then, ensure the start is configured to run both MIST353GroupProjectFranticFrogFirms and TravelSiteApplication. Once these steps are completed, the travel application should be up and running.
### Errors
In order to avoid errors, make sure to follow this guide closely and that everything is downloaded correctly in order to work successfully.
If you happen to run into an error, please refer back to this documentation. If you still are facing issues, please reach out to get the issue resolved. 

## API documentation
### WeatherForecast 
The weather forecast API generates the predicted weather forecast for a destination over five days. It gives the degree of weather in Celsius as well as Fahrenheit and summarizes what is to be expected. As of now, there are no inputs, but in the future, there will be an input of the destination the user wants to look at. The output would then be the weather forecast for that specific destination. The user can access this API by clicking on the "Go to Climate Page" button on the home page. Once the button is clicked, you will be brought to the forecasting page with the weather information. Ella Southwell implemented this API into the application.

### spHotelSearchByRadius
The Hotel Search By Radius API gives the user hotel coordinates. The user inputs the longitude and latitude. Once they are typed into the search button, the output would be the hotel within that radius. A user can access this API by clicking on the button "Go to Search Page" on the home page. Once the button is clicked, they will be brought to a page with a search bar to enter the required information and hit search. Ella Southwell implemented this API into the application.

### hotel review
The Hotel Review API allows users to leave a review as they please. The user puts in their name, email, and the comment they want to leave whether it be a good or bad review. The inputs are the information that they provide to the website. The outputs are the reviews and comments that the user leaves in order for other users to look at and use to make decisions when they are booking. Brooke Mesinere implemented this API into the application.

### hotel comments
What the API does.
What are the inputs.
	What are the outputs.
	How to use it.

### hotel info
The Api allows the user to search hotels and see all details stored for the hotel. Such as Type, Address, Phone Number, Email, etc.

### hotel room avail
The Hotel Room Availability API allows the user to put in the desired dates that they want to stay into the website to see if they are available. The user goes to the hotel room availability page from the search page, and will then put in the hotel in the top search bar, the dates desired into the search bar below, and then hit submit. Once they do this it will pop up with the dates available that they want, or it will pop up with nothing meaning that those desired dates that they want are not available. The inputs are the hotel and dates the user wants. The outputs are the dates and hotel given back if it is availble for those desired dates and hotel. Brooke Mesinere implemented this API.

## General description 
This application is designed to give users a new way to plan their travels. By making this application more focused on weather and climate, users can find the destinations they wish to visit based on their climate. It gives users access to hotel and climate information, making travel planning easier. The main hope of this application is to make travel easier.
## Developer documentation
As of now, this application is in the early stages of development. In the future, we plan to make this application more user-friendly by making it easier to use. Things we plan to do in the future include having an interactive destination page and adding search criteria for hotel features. Not all of our API's are prefected yet, but we continue to improve our design and make them more functional. 



