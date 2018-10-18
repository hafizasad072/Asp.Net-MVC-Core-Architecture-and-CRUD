# Asp.Net MVC Core Architecture
Asp.Net  MVC Core with Entity Framework Core, Multi Layered Architecture using Generic Repository, Unit of Work and Dependency Injection
The purpose of this Architecture is to provide a more advanced starting point for .NET Core MVC apps that already features a well defined work-flow, state management and design layout.

The template is designed to be easy to build upon and extend to suit your app.

# Description

## MVC-CoreWithEF-Core
This Layer contain Controller's of Application's to manage views also this layer contain Dependency Injection Configuration.views and content that help to create views like CSS, JavaScript, Bootstrap all front related plugin's.

## ServiceLayer
Service Layer Contain Interface And Concrete Classes That we can access in Controllers also we have UnitOfWork in  Service Layer.

## DataLayer
Data Layer Contain all logic of DB Data Manipulation and generic repository to perform CRUD operations. 

## 5 DB.Core
Core Layer Contains DB Model and Entity Class's of Database

## BO
Business Object Layer Contains all Business entities to show data on front end views.

## Util
This Layers Contains Common Functionality of applications Like Logs and Auto-mapper etc.
