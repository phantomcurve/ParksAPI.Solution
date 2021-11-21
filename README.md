# Travel API

#### A backend-only API app for connecting to national and state parks.

#### By Tim Roth

## Description

This Epicodus project creates a C# API web app that is connected to a database to allow the advanced user to make API calls to the database and receive the expected result.

## User Functionality and Documentation

1. Full CRUD functionality for Parks
2. Swagger UI implemented to allow user to test endpoints from their browser instead of being forced to use something like Postman
3. Endpoints for both the Swagger UI and Postman include:
GET /api/parks ( example: http://localhost:5000/api/Parks?National=true&api-version=1.0)
GET /api/parks/{id} (example: http://localhost:5000/api/Parks/3?api-version=1.0)
POST /api/parks
PUT /api/parks/{id}
DELETE /api/parks/{id}

These are accessed with base url `http://localhost:5000` using both Postman and the Swagger UI (see links below!)

## Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | false| Return matches by name.
| Location | string | none | false | Return matches by location (check note below for comma separated locations such `Portland, OR`). 
| National | bool | none | false | Return all parks marked as **National** |
| State | bool | none | false | Return all parks marked as **Local** |

## Sample JSON response
GET=> http://localhost:5000/api/Parks/1?api-version=1.0
```
[
  {
  "parkId": 1,
  "name": "Crater Lake National Park",
  "location": "Oregon",
  "national": true,
  "state": false
  }
]
```

## Technologies Used

* C#
* ASP.NET&#8203; Core
* MySQL Workbench
* Markdown // Dillinger
* VS Code
* Terminal
* Github
* Entity
* Postman
* [Swagger](https://swagger.io/tools/swagger-ui/)

## Setup/Installation Requirements

### Prerequisites

* [.NET](https://dotnet.microsoft.com/)
* A code editor–we prefer [VS Code](https://code.visualstudio.com/)
* [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)
* [Postman](https://www.postman.com/)

### Installation

#### To View
1. Open terminal on your machine
2. Clone the repository: `git clone https://github.com/phantomcurve/ParksAPI.Solution`
3. Navigate to the `/ParksAPI` directory
4. Open with your preferred text editor to view the code

### appsettings.json configuration

1. Navigate to `/ParksAPI` directory in VSCode
2. Create a file in this directory called `appsettings.json`
3. In this file add the following: 
``{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=ParksAPI;uid=root;pwd=[YOUR PASSWORD HERE & DELETE THESE SQUARE BRACKETS!];"
  }
}``

### Run the Program – using .NET EF Core Code-First Setup

1. Make sure you have navigated to the `/ParksAPI` directory
2. Make sure you have the MySql Workbench application open and that the server is running
3. Run `dotnet restore`
4. Run `dotnet build`
5. Run `dotnet ef database update`
6. Start the program with `dotnet run`
7. To see the beauty of Swagger in action, open http://localhost:5000/ in your preferred browser


### Manual MySQL and MySQL Workbench Configuration (if you like working harder, not smarter)
1. Download and install [MySQL](https://dev.mysql.com/downloads/file/?id=484914) by selecting `No thanks, just start my download`
2. Follow along with Installer until reaching `Configuration` page
3. Select `Use Legacy Password Encryption`
4. Set password as desired 
5. Click `Finish`
6. Open Terminal and enter command `echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`
7. Type `source ~/.bash_profile` to verify successful MySQL installation
8. Download and install [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)
6. Open MySQL Workbench and select Administration tab in upper left of navigator window
7. Select `Data Import/Restore` 
8. Select `Import from Self-Contained File`
9. Navigate to `ParksAPI.Solution` folder and select `tim_roth.sql`
10. With the `Default Schema to be Imported To` dropdown menu, select `New`
11. Name your new schema `ParksAPI` and click `ok`
12. Click `Start Import` at bottom right of navigator window

## Known Bugs

* Versioning has yet to be fully fleshed out, and as of now, there is only a v1!

## Contact Information

* Tim Roth [timdroth@gmail.com](mailto:timdroth@gmail.com)

## License

* MIT License 
Copyright (C) [2021] [Tim Roth]
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.