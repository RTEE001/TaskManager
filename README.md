# Task Manager Project in C#:

A web application that allows users to schedule their tasks and sends them reminders via email of tasks for that day.


## Note:

The project is still in the works, and not all features have been implemented yet. For features currently available and those that will be available, [see](TODO.md)

## Requirements

- Visual studio/ Rider
- Dotnet SDK
- SendGrid API key 
- Google, Mircrosoft, Facebook and Twitter API key and ID for authentication with external providers

## Setting up

- Download the source code on your local machine
- Open the folder in your chosen IDE
- Run the following command to add your [SendGrid API key](https://sendgrid.com/)
```
dotnet user-secrets set SendGridKey <key>
```
- External auth API keys may be added in the [appsettings.json](/TaskManager/appsettings.json) file

## Running the project

- Build the project
- Click run
