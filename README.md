# NotesAPI
- NotesAPI is a simple RESTful API for managing notes and their associated users. It provides basic CRUD (Create, Read, Update, and Delete) operations to manage notes and users.

## Table of Contents
- Installation
- Usage
--API Endpoints
--Sample Requests and Responses

## Installation
This API uses .NET and three different nuget packages:
Microsoft.EntityFrameworkCore,
Microsoft.EntityFrameworkCore.inMemory,
Pomelo.EntityFrameworkCore.MySql
Software required: MySQL Server, MySQL Workbench, Visual Studio, Postman
1. Clone the repo
2. Install all the packages required for this project
3. Make sure to change the User= and Password= within 'appsettings.json' to estiablish a proper connection to the server on your local machine
4. Build and run the project

## Usage
### API endpoints
The following endpoints are available for managing notes and users:
1. GET /api/Note: Fetch all notes.
2. GET /api/Note/{id}: Fetch a specific note by ID.
3. POST /api/Note: Create a new note.
4. PUT /api/Note/{id}: Update an existing note by ID.
5. DELETE /api/Note/{id}: Delete a note by ID.

### Sample Requests and Responses
- Fetch all notes
  Request:
