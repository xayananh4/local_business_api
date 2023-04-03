# Local Business API
Names of contributors: By Viradeth Xay-ananh.  
ASP.NET Core Web API for local business and shops.

# Description 
A ASP.NET Core Web API that gets list of restaurant and shops.  User can update,edit and delete from both Restaurants and Shops databases.  User can generate access token for already created user in the db.  Performing a POST call in either swagger or POSTMAN.

## Technologies Used
* C#
* Dot Net 6.0
* Markup
* Git
* ASP.NET MVC
* CSS
* HTML5
* Microsoft EntityFramework Core
* Swagger
* JWT

# Complete setup/Installation instructions:
* Clone repository to your desktop 
* CD to the Directory: LocalBusinessApi
* While in the current directory [Factory]  
* Create appsettings.json file ![example for appsettings file](appsettings_image.png)
* Replace the following values shown in image with: 
* [securitykey]: your security key
* [YOUR-DB-NAME]: database included in project
* [YOUR-USER-HERE]: with your username
* [YOUR-PASSWORD-HERE]: with your password
* Create anohter file called: appsettings.Development.json ![example for appsettings development file](appsettings_development.png) 
* Enter in command: 'dotnet ef database update'
* Add the appsettings.json and appsettings.Development.json file to .gitignore.
* To view web application. Run commands: dotnet watch run 
* Open the browser, go to https://localhost:5001
# Further Exploration:
* Open browser to launch _https://localhost:5001/swagger
* Go to User Post section, click the 'Try it Out' button. 
* Replace the strings with "admin" and "password" to generate token. 
* Copy generated token, open Postman
* Make a GET call in Postman. 
* Enter http://localhost:5000/api/shops
* In the Headers options enter "Authorization" for the Key field. 
* In the value field enter: "bearer [Generated Token From Swagger]", Click Send

# Local Business API ENDPOINTS:
* GET - http://localhost:5000/api/Restaurants/ for all the restaurants
* GET - http://localhost:5000/api/Shops/ for all the shops 
* GET - http://localhost:5000/api/Restaurants{id} for a specific restaurant
* GET - http://localhost:5000/api/Restaurants{id} for a specific shop
* POST http://localhost:5000/api/Restaurants/ to create a new restaurant 
* POST http://localhost:5000/api/Shops/ to create a new shop
* PUT http://localhost:5000/api/Restaurants/{id} to update a restaurant 
* PUT http://localhost:5000/api/Shops/{id} update a shop
* DELETE http://localhost:5000/api/Restaurants/{id} delete a restaurant 
* DELETE http://localhost:5000/api/Shops/{id} delete a shop 

# Known bugs: 
No bugs 

## License

[MIT](https://opensource.org/licenses/MIT)  
Copyright (c) _03/31/2023_ _viradeth xay-ananh_