# CrazyMusiciansApi
Crazy Musicians API
The Crazy Musicians API allows you to manage fun and unique musician data. Users can retrieve, add, update, and delete musician information through various API operations.

## Features
List all musicians.
Search musicians by name.
Add a new musician.
Update an existing musician.
Delete a musician.

## API Endpoints
GET /api/crazymusicians: Retrieves all musicians.
GET /api/crazymusicians/{id}: Retrieves a specific musician by ID.
POST /api/crazymusicians: Adds a new musician.
PUT /api/crazymusicians/{id}: Updates an existing musician.
PATCH /api/crazymusicians/{id}: Updates the name of a musician.
DELETE /api/crazymusicians/{id}: Deletes a musician.

## Setup
### Clone the repository:


git clone [Project Repository]https://github.com/SefaSsarac/CrazyMusiciansApi.git

### Install the required packages:
dotnet restore

### Run the project:
dotnet run

## Technologies Used
ASP.NET Core: The primary framework used to build the web API.
C#: The programming language for development.
Entity Framework Core: ORM used for database operations (to be added).
Swagger: For API documentation and testing (optional).

## Contributing
If you'd like to contribute, feel free to submit a pull request.
