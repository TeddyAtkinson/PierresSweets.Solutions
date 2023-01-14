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
      "DefaultConnection": "Server=localhost;Port=3306;database=erica-marroquin;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
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

[MIT License](https://opensource.org/licenses/MIT)