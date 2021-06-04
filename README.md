# Dr. Sillystringz's Factory

#### Learning project for Epicodus course for database practice with many-to-many relationships

#### By Shanen Cross

## Technologies Used

* C#
* .NET 5 SDK
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* HTML
* CSS
* Bootstrap

## Description

A Learning projecting for Epicodus class. Purpose is to practice using databases with ASP.NET Core MVC and Entity Framework Core. Uses a many-to-many database relationship.

MVC web application for a factory owned by "Dr. Sillystringz", where certain engineers are licensed to repair certain machines. An engineer can have licenses for many machines, and a machine can have many engineers licensed to repair it.

The website should fulfill the following "user stories":
* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

## Setup/Installation Requirements

### Installing Prerequisites
* Install git
* Install the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* Install [MySQL](https://dev.mysql.com/downloads/mysql/) and create a server with a password of your choosing

### Creating Database
* Enter the following in the terminal, replacing \[PASSWORD\] with the password you selected during your MySQL setup: 
```
mysql -uroot -p[PASSWORD]
```
* Enter the following command for MySQL into the terminal (for Epicodus, instructions were to use my name for the database name):
```
[Temp: Fill this out once I have determined database models]
```

### Installing Application
* Use ```git clone``` to download this repository to a local directory
* Navigate to this local directory in your terminal
* Navigate to the ```/Factory``` folder in your terminal
* Enter ```dotnet restore``` to install packages
* Enter ```touch appsettings.json``` to create an appsettings file.
* Open appsettings.json with a text editor and enter the following, replacing \[PASSWORD\] with your chosen server password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=shanen_cross;uid=root;pwd=[PASSWORD];"
  }
}
```
* Enter ```dotnet run``` to build and run the application; or alternatively, use ```dotnet watch run``` to make the server refresh whenever a file is saved
* The terminal will output that it is "Now listening on" a certain URL. For me this is ```http://localhost:5000```, but it could be different.
* Navigate in your web browser to whatever URL is displayed. This will show the home page.

## Known Bugs

None.

## License

[MIT](LICENSE)

Copyright (c) 2021 Shanen Cross
