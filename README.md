# Album Management System

An Album Management System built using ASP.NET Core MVC and Entity Framework Core. This system allows users to create, edit, view, and delete album records with additional fields such as manager information.

## Features

- Create new albums with details including album number, type, artist information, album name, price, and whether it's local.
- Edit existing albums and update all fields.
- View a list of all albums.
- Delete albums.
- Manage album details with additional manager information.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Git](https://git-scm.com/)
- [GitHub Desktop](https://desktop.github.com/) (optional)
- [SQLite](https://www.sqlite.org/download.html)
- [Visual Studio Code](https://code.visualstudio.com/) or any other code editor


### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your-username/album-management-system.git
   cd album-management-system


Set up the database:
Drop and recreate the database to ensure it matches the current schema.
dotnet ef database drop
dotnet ef database update

Build the project:
dotnet build

Run the application:
dotnet run

Access the application:
Open your browser and navigate to https://localhost:7280 or http://localhost:5019.


Usage
Create Album: Navigate to the Create page, fill in the album details, and click 'Create'.
Edit Album: From the Album List page, click 'Edit' next to the album you want to edit, update the details, and click 'Save'.
View Albums: The home page lists all albums with options to edit or delete each one.
Delete Album: From the Album List page, click 'Delete' next to the album you want to delete, confirm the deletion.

Project Structure
Controllers: Contains the TblAlbumController.cs which handles the HTTP requests and responses.
Models: Contains the TblAlbum.cs which defines the structure of the Album entity.
Views: Contains the Razor views for creating, editing, and listing albums.
Data: Contains the DemoDbContext.cs which sets up the database context and SeedData.cs for initial data seeding.
Migrations: Contains the EF Core migrations for setting up the database schema.

Contributing
Fork the repository
Create your feature branch (git checkout -b feature/AmazingFeature)
Commit your changes (git commit -m 'Add some AmazingFeature')
Push to the branch (git push origin feature/AmazingFeature)
Open a pull request

Acknowledgements
ASP.NET Core
Entity Framework Core
SQLite
Bootstrap

Additional Notes
This project is based on an assignment to create an album management system with additional fields using model binding.

Assignment Requirements:
Create the MVC Project:
dotnet new mvc -n ProjeKlasoru
cd ProjeKlasoru
code .

Install necessary packages:
Ensure that EF Core and other required packages are installed:
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.0

Database setup:
Create and apply the initial migration to set up the database schema:
dotnet ef migrations add InitialCreate
dotnet build 
dotnet ef database update 
dotnet run

Reset and seed the database:
To reset the database and seed it with initial data:
dotnet ef database drop
dotnet ef database update
dotnet build
dotnet run

Project setup and configuration:
The project was configured and a DemoDbContext class was created to connect with SQLite.

Database operations:
Database connection and operations were verified to be working correctly.

SeedData for initial data:
The SeedData class was used to populate the database with initial data.


By following these instructions and additional notes, you should be able to set up and run the Album Management System project successfully.















