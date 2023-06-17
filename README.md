# Dr. Sillystringz's Factory Manager

#### A simple C# program built for Dr. Sillystringz's to manage their engineering team and machine inventory.

#### By Matthew Melito

## Technologies Used

* C#
* .NET6
* MySQL
* Asp.NetCore
* Entity Framework Core
* HTML
* CSS
* Linq

## Description

This C# application was designed and built to help factory managers keep track of their machines and manage the engineering staff that is responsible for maintaining them.


## Setup/Installation Requirements

#### Installing .NET and MySQL
1. Install .NET6 if you have not done so. Visit [this link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to download the recommended versions of both software packages.
2. Follow the installer prompts to install the software. Use the default settings.
3. In a terminal, install `dotnet-script` by entering the following command: `$ dotnet tool install -g dotnet-script`. You will also need to configure your environment to access this tool. See [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Install MySQL.  Follow the instructions at [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Cloning and Initial Setup

5. Clone project repository from https://github.com/mjmelito/Factory
6. Navigate to the project's root directory, Factory
7. Install the MySglConnector Package with the following terminal command: dotnet add package MYSqlConnector -v 2.2.0. Then enter 'dotnet restore'.
8. Within the Factory directory, add a file named 'appsettings.json and add the following code to the file:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
9. Be sure to add obj, bin, and appsettings.json to your .gitignore file and commit the file to GitHub to protect your Username and Password.

#### Add Migrations, Create Database, and Run Application
10. Navigate to the 'Factory' directory
11. Run the command "dotnet build"
12. Run the command "dotnet tool install --global dotnet-ef --version 6.0.0"
13. Run the command "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"
14. Run the command "dotnet ef migrations add Initial"
15. Run "dotnet ef database update" in your command line.
16. Then run the command "dotnet watch run"


## Known Bugs

* No known bugs or issues.

## This project uses the following license: MIT

Copyright (c) 2023 Matthew Melito