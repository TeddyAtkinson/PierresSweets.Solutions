# Pierre's Sweet and Savory Treats

### _This MVC application will allow an authorized user to advertise treats and their flavors_

### By Teddy Atkinson

## Technologies Used

* C#
* .NET 6
* ASP.NET Core
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

This is an MVC application that showcases the Authorization of user with login and registration. An authorized user is able to Create Read, Update, and Delete information and an unauthorized user is able to Read information with a Many to Many database Relationship hosted on mySQL.

## Setup/Installation Requirements


### Installation Requirements
* [.NET 6.0] must be installed for this project
* [MySQL] will be used for this project

### Setup Instructions
* Clone this repository to desired location using `git clone` command
* Navigate to PierresTreats.Solution/PierresTreats
* Create an `appsettings.json` file in PierresTreats.Solution/PierresTreats
  - Open `appsettings.json` and add the following code, changing [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] to your unique MySQL username and password, respectively:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

### Create and update database
* Navigate to PierresTreats.Solution/PierresTreats
* Run the command `dotnet restore` to install all necessary packages
* Run the command `dotnet ef database update`
  - This will use the already existing "Migrations" folder to create the database

### Running the application
* To run the application, navigate to PierresTreats.Solution/PierresTreats
  - Run the command `dotnet run`
  - If a host does not automatically show in your browser, enter, in your browser, the URL given in the console message when starting `dotnet run` from the previous step

## Known Bugs

None

## License

MIT License

Copyright & copy; 2023 Teddy Atkinson

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
