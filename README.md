# Album Management System

An Album Management System built using ASP.NET Core MVC and Entity Framework Core. This system allows users to create, edit, view, and delete album records with additional fields such as manager information.

## Features

- Create new albums with details including album number, type, artist information, album name, price, and whether it's local.
- Edit existing albums and update all fields.
- View a list of all albums.
- Delete albums.
- Manage album details with additional manager information.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

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
    ```

2. **Set up the database:**

    Drop and recreate the database to ensure it matches the current schema.

    ```bash
    dotnet ef database drop
    dotnet ef database update
    ```

3. **Build the project:**

    ```bash
    dotnet build
    ```

4. **Run the application:**

    ```bash
    dotnet run
    ```

5. **Access the application:**

    Open your browser and navigate to `https://localhost:7280` or `http://localhost:5019`.

## Usage

- **Create Album:** Navigate to the Create page, fill in the album details, and click 'Create'.
- **Edit Album:** From the Album List page, click 'Edit' next to the album you want to edit, update the details, and click 'Save'.
- **View Albums:** The home page lists all albums with options to edit or delete each one.
- **Delete Album:** From the Album List page, click 'Delete' next to the album you want to delete, confirm the deletion.

## Project Structure

- **Controllers**
  - `TblAlbumController.cs`: Handles the HTTP requests and responses.
- **Models**
  - `TblAlbum.cs`: Defines the structure of the Album entity.
- **Views**
  - Contains the Razor views for creating, editing, and listing albums.
- **Data**
  - `DemoDbContext.cs`: Sets up the database context.
  - `SeedData.cs`: Handles initial data seeding.
- **Migrations**
  - Contains the EF Core migrations for setting up the database schema.

## Contributing

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a pull request.

## Acknowledgements

- ASP.NET Core
- Entity Framework Core
- SQLite
- Bootstrap

## Additional Notes

This project is based on an assignment to create an album management system with additional fields using model binding.

### Assignment Requirements:

1. **Create the MVC Project:**

    ```bash
    dotnet new mvc -n ProjeKlasoru
    cd ProjeKlasoru
    code .
    ```

2. **Install necessary packages:**

    Ensure that EF Core and other required packages are installed:

    ```bash
    dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.0
    ```

3. **Database setup:**

    Create and apply the initial migration to set up the database schema:

    ```bash
    dotnet ef migrations add InitialCreate
    dotnet build
    dotnet ef database update
    dotnet run
    ```

4. **Reset and seed the database:**

    To reset the database and seed it with initial data:

    ```bash
    dotnet ef database drop
    dotnet ef database update
    dotnet build
    dotnet run
    ```

5. **Project setup and configuration:**

    The project was configured and a `DemoDbContext` class was created to connect with SQLite.

6. **Database operations:**

    Database connection and operations were verified to be working correctly.

7. **SeedData for initial data:**

    The `SeedData` class was used to populate the database with initial data.

By following these instructions and additional notes, you should be able to set up and run the Album Management System project successfully.
