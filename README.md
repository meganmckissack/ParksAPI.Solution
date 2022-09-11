#### By _**Megan McKissack**_

## Description
A ASP.NET Core REST API to serve usable endpoints for state and national park data.

## Technologies Used

- _C#_
- _.NET 5_
- _ASP.NET Core_
- _MySQL_
- _Entity Framework Core_
- _REST API_
- _Swagger_

## Setup/Installation Requirements
### File and package installation

- using your terminal, clone or download this repository to your computer
- Open files in your favorite text editor or IDE
- cd into the ParksAPI.Solution/ParksAPI folder and run the command `dotnet restore` to install the necessary packages to run the program

### Database Setup

- to connect the app to the database you'll need to have [MySQL](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) installed.

### Generating the database connection to feed the API

- in your local repository, create a `appsettings.json` in the main project folder `ParksAPI` to store your database login so that app can connect to the database and retrieve/add information and then add this code to the file:

        { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USER-ID];pwd=[YOUR-PASSWORD-HERE];" } }

- In your terminal use the command `dotnet ef migrations add Initial` to create your first datbase migration, initializing and populating the tables and settings with the seeded data
- Then use the command `dotnet ef database update` to sent the migration information to MySQL, you can press refesh in the Administration menu in MySQL Workbench to verify the new database and tables.
- also update your `.gitignore` file with `*/appsettings.json` so that you don't accidently make your database login information public if you push your projected to a remote repository



### Interacting with the API

- To connect to the API, navigate to the `ParksAPI` folder and use the command `dotnet run` to start your local server 

    #### To view and test API endpoints

      1. You can and navigate to [http://localhost:5000/api/parks](http://localhost:5000/api/parks) in your web browser to see the api response or use a web-base tool like [Postman](https://www.postman.com/) to test api calls and responses.

      2. You can also view the api documentation and test api call methods by navigating to [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html) in your browser.

## API Enpoints Documentation

[http://localhost:5000/api/parks](http://localhost:5000/api/parks)

Endpoints

    GET /api/Parks - returns the full list of parks
    GET /api/Parks/type
    GET /api/Parks/city
    GET /api/Parks/state
    GET /api/Parks/feature

    POST /api/Parks/{id} - Create an new park instance in the database/api
    GET /api/Parks/{id} - query a specific park based on it's id
    PUT /api/Parks/{id} - edit a specific park's information
    DELETE /api/Parks/{id} - delete a specific park

Query Enpoint Example

/api/Parks/type

    example: http://localhost:5000/api/parks/type=state


Response:

    {
        "parkId": 1,
        "parkName": "Bullards Beach",
        "type": "State",
        "city": "Coos Bay",
        "state": "Oregon",
        "feature": "yurts"
    },
    {
        "parkId": 2,
        "parkName": "Cottonwood Canyon",
        "type": "State",
        "city": "The Dalles",
        "state": "Oregon",
        "feature": "fishing"
    },
    {
        "parkId": 3,
        "parkName": "Fort Stevens State Park",
        "type": "State",
        "city": "Astoria",
        "state": "Oregon",
        "feature": "swimming"
    }
    




## Known Bugs

_not getting error messages from model validators_

## License

_MIT_

Copyright (c) _September 10, 2022_ _Megan McKissack_
