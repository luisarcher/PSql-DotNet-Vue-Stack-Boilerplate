## Dockerized PostgreSQL + Vue Nuxt3 + DotNet 6.0 Stack for project jump-starting

This repository contains a starter stack for jump-starting projects using Docker, PostgreSQL, Vue Nuxt3, and DotNet 6.0.

### Prerequisites

- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)

### Setting up the stack

1. Clone this repository to your local machine.
2. Navigate to the root directory of the repository.
3. Run the following command to build and start the Docker containers (3):

docker-compose up -d

Alternatively, you can launch **start.bat** if you're on Windows.

4. The stack should now be up and running. You can check the status of the containers by running:

    docker-compose ps

## Stopping the stack

To stop the stack, simply run the following command from the root directory:

    docker-compose down

Alternatively, you can launch **stop.bat** if you're on Windows.

## Accessing the PostgreSQL database

You can access the PostgreSQL database by connecting to the following host and port:

    Host: localhost
    Port: 5432

You can use any PostgreSQL client, such as pgAdmin, to connect to the database. The default username and password for the database (psqldatabase) are psqladmin and psqlpasswd respectively.

## Accessing the Vue Nuxt3 application

The Vue Nuxt3 application is served at http://localhost:3000.
Accessing the DotNet 6.0 application

The DotNet 6.0 application is served at http://localhost:5001.

## Key notes

- NetCoreApp project file is at ./app/api/NetCoreApp
- app.sln is created at ./app/api
- Dockerfile is at ./app/api
(Apparently, visual studio looks for Dockerfile in the same directory of the .sln file, hence, the above structure. Visual Studio has not been used to create this project though)

- During the building of **frontend** App, source code files are copied to a /app folder. This is also mapped to a Volume on docker-compose file to allow Hot-reload during development.

- I have not applied this same principle for NetCoreApp Application as you cannot make use of Hot-reload, it needs to be compiled and published, so we can just rebuild the image. I am not sure if it's worth to create a volume, I am a noob, I will try it / think about creating a volume for .cs code.



## Todo

 - nginx container as the main entry point of the application on port 80.
 - pgadmin container
 - Auth container, JWT
 - Properly test PostgreSQL persistence using Entity. (Been a fan of database-first approach but seems like it isn't really the *way to go* anymore)
 - Play around with Vue and Nuxt3, maybe a **todo** app. With proper design principles.