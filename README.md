# NotesAPI
- NotesAPI is a simple RESTful API for managing notes and their associated users. It provides basic CRUD (Create, Read, Update, and Delete) operations to manage notes and users. This project follows the MVC architecture pattern

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
- Request:
![Screenshot 2023-04-26 at 5 33 33 PM](https://user-images.githubusercontent.com/49046183/234708503-f5050010-78ed-4653-8931-4e4350c45f70.png)
- Response:

![Screenshot 2023-04-26 at 5 44 01 PM](https://user-images.githubusercontent.com/49046183/234709677-3a774969-4dd6-4fef-925e-b3dd139a4c8c.png)

- Fetch a specific note by ID
- Request:
![Screenshot 2023-04-26 at 5 45 50 PM](https://user-images.githubusercontent.com/49046183/234709972-c773b002-d346-473c-b66a-d37519507fd6.png)
- Response:

![Screenshot 2023-04-26 at 5 47 59 PM](https://user-images.githubusercontent.com/49046183/234710372-87c48717-e933-461e-afd0-08f3e5e042ad.png)

- Create a new note and response

![Screenshot 2023-04-26 at 5 58 30 PM](https://user-images.githubusercontent.com/49046183/234712445-23396e87-ede3-4345-b4ac-0a2e8e5bd224.png)

- Update an existing note by ID
![Screenshot 2023-04-26 at 5 58 30 PM](https://user-images.githubusercontent.com/49046183/234713185-36e588f1-8ba7-47ab-9ce6-54a194c14a38.png)
![Screenshot 2023-04-26 at 6 03 34 PM](https://user-images.githubusercontent.com/49046183/234713320-bddb3b1a-893e-4bb1-bdae-e3c1615450d1.png)

- Delete a note by ID
![Screenshot 2023-04-26 at 6 06 13 PM](https://user-images.githubusercontent.com/49046183/234713644-0fd9c75a-a190-4a08-a430-3cdb79cb3dde.png)
![Screenshot 2023-04-26 at 6 06 36 PM](https://user-images.githubusercontent.com/49046183/234713685-2d88a40a-6b51-4ef2-8a94-e237381ad739.png)

### SQL commands for this project
![Screenshot 2023-04-26 at 6 19 45 PM](https://user-images.githubusercontent.com/49046183/234715347-cb80c352-0377-4c3d-a810-bf9ac141152d.png)

# CHANGES
- I wanted to make an Account Management API at first, but then I've realized that it will never be as useful as google chrome's autofill feature. So I changed it to a simpler NotesAPI.

