# Basic .NET Core Web Application

This is a simple web application built using **ASP.NET Core MVC** that demonstrates basic web development concepts with the **MVC** (Model-View-Controller) architecture. The app includes a **View** and **Controller**, but does not yet interact with a database.

## Features
- Displays a basic webpage.
- Simple **View** and **Controller** interaction.
- Uses **ASP.NET Core MVC** for handling HTTP requests.

## Prerequisites
Before you begin, make sure you have the following installed:

- [.NET SDK (Version 6 or later)](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or another code editor of your choice.

## How the Application Works
Model: Represents the data structure (currently not used as no database is connected).<br>
View: The user interface of the application where users can interact with the data (e.g., displaying information).<br>
Controller: Handles the user input, processes data, and returns a response via a view. In this app, it handles routes like /Home/Privacy.<br>
### Pages Available:
Home/Index: Default page of the application.<br>
Home/Privacy: A privacy page with basic content.<br>
### Built With
ASP.NET Core MVC: The web framework used.
