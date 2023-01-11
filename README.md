## Dockerized PostgreSQL + Vue Nuxt3 + DotNet 7.0 Stack for project jump-starting

This repository contains a starter stack for jump-starting projects using Docker, PostgreSQL, Vue Nuxt3 + TailwindCSS, and DotNet 7.0.

TODO: I will slowly add more and more basic core features and code examples. I am not a web developer, but I will read read read, so I want to garantee that I will cover the best best best best practices. I will add a couple of comments at the end of this readme.

### Prerequisites

- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)

### Setting up the stack

1. Clone this repository to your local machine.
2. Navigate to the root directory of the repository.
3. Run the following command to build and start the Docker containers (3):

    docker-compose up -d

Alternatively, you can launch **docker-compose.full.up.bat** if you're on Windows.

4. The stack should now be up and running. You can check the status of the containers by running:

    docker-compose ps

## Stopping the stack

To stop the stack, simply run the following command from the root directory:

    docker-compose down

Alternatively, you can launch **docker-compose.full.down.bat** if you're on Windows.

## Accessing the PostgreSQL database

You can access the PostgreSQL database by connecting to the following host and port:

    Host: localhost
    Port: 5432

You can use any PostgreSQL client, such as pgAdmin, to connect to the database. The default username and password for the database (psqldatabase) are psqladmin and psqlpasswd respectively.

**Update 10/01/2023:** I have added a container containing just pgAdmin:latest that connects to postgres container to manage the database.

    Admin: admin@admin.com
    Password: psqlpasswd

## Accessing the Vue Nuxt3 application

The Vue Nuxt3 application is served at http://localhost:3000.
Accessing the DotNet 7.0 application

The DotNet 7.0 application is served at http://localhost:5001.

## Key notes

- NetCoreApp project file is at ./app/api/NetCoreApp
- app.sln is created at ./app/api
- Dockerfile is at ./app/api
(Apparently, visual studio looks for Dockerfile in the same directory of the .sln file, hence, the above structure. Visual Studio has not been used to create this project though)

- During the building of **frontend** App, source code files are copied to a /app folder. This is also mapped to a Volume on docker-compose file to allow Hot-reload during development.

- I have not applied this same principle for NetCoreApp Application as you cannot make use of Hot-reload, it needs to be compiled and published, so we can just rebuild the image. I am not sure if it's worth to create a volume, I am a noob, I will try it / think about creating a volume for .cs code.


## Todo

 - nginx container as the main entry point of the application on port 80.
 - ~~pgadmin container~~
 - Auth container, JWT
 - Properly test PostgreSQL persistence using Entity. (Been a fan of database-first approach but seems like it isn't really the *way to go* anymore)
 - Play around with Vue and Nuxt3, maybe ~~a **todo** app~~ (I will do a Cat app based on the principles described here: https://tom-collings.medium.com/controller-service-repository-16e29a4684e5 with proper design principles.
 - Investigate how to properly do TDD and setup the testing process
 - Maybe automate some stuff with Jenkins or github actions / workflow
 

 ## Notes of my learning process
 - Key notes above are more important than these notes.
 - I wanted to use the Vuetify UI kit, but feeling the tailwindCSS more.
 - Seems like both Nuxt3 and NetCore supports hot-reload. I could use it locally but struggled using it with docker, something to investigate later.