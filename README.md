# LoggingDemo

## Purpose and Goals

**LoggingDemo** is a minimal ASP.NET Core Web API project designed to demonstrate how to set up structured logging using [Serilog](https://serilog.net/) in a .NET backend application. The project shows how to configure multiple log sinks (console and [Seq](https://datalust.co/seq)), enrich log events with context, and use dependency injection for logging within controllers. The sample endpoint (`WeatherForecast`) is included to generate log entries and illustrate basic API interaction.

---

## Technologies, Frameworks, and Tools

- **ASP.NET Core**  
  Foundation for building robust web APIs, leveraging dependency injection and modular configuration.
- **Serilog**  
  A popular structured logging library for .NET, chosen for its flexibility, structured data support, and wide ecosystem of sinks.
- **Seq**  
  A local log server which collects, visualizes, and allows querying structured log events.
- **Microsoft.Extensions.Logging**  
  Used for injecting loggers into controllers using standard .NET logging abstractions.

---

## Project Structure and Architecture

```
LoggingDemo/
  ├── Controllers/
  │     └── WeatherForecastController.cs
  ├── WeatherForecast.cs
  └── Program.cs
```

- **Program.cs**  
  Sets up the application, configures the logging pipeline (Serilog), registers services, and starts the web host.
- **Controllers/WeatherForecastController.cs**  
  Implements a sample API controller that handles HTTP GET requests, logs an informational message, and returns random weather data.
- **WeatherForecast.cs**  
  Simple model defining the weather forecast response.

There is no separate frontend—the project is backend-only.

---

## Key Features

- **Structured Logging with Serilog**  
  Logs are enriched with contextual data and written to both the console and a Seq server.
- **Sample API Endpoint**  
  The `/WeatherForecast` endpoint returns random weather data and logs each request with a timestamp.
- **Dependency Injection**  
  Loggers are injected into controllers via constructor, following best .NET practices.
- **Minimal and Modern API Setup**  
  Uses the latest idiomatic ASP.NET Core application style.

---

## How Components Interact

- The application is configured in `Program.cs`, where logging and controllers are registered.
- Controllers (like `WeatherForecastController`) use dependency injection to receive loggers.
- When a request is made to `/WeatherForecast`, the controller logs the event, and Serilog routes the log entries to the configured sinks (console and Seq).

---

## Noteworthy Patterns and Practices

- **Dependency Injection** for logger services in controllers.
- **Separation of Concerns**: Logging is configured centrally; controllers focus on request handling.
- **Structured Logging**: Log statements use structured data (e.g., `{Time}`) to improve searchability and analysis in log servers.
- **Minimal API Bootstrapping**: Uses ASP.NET Core's modern, concise startup approach.

---

## Potential Improvements

- **Robust Error Handling**: Demonstrate exception and error logging.
- **Configurable Settings**: Move log sink URLs and settings to configuration files or environment variables.
- **Testing**: Add unit and integration tests.
- **Documentation**: Expand README with usage instructions and API docs.
- **Multiple Endpoints**: Add more endpoints to demonstrate broader logging scenarios.
- **Frontend**: (Optional) Add a simple frontend interface or API client.

---

## Getting Started (For New Developers)

1. **Clone the repository**
2. **Install prerequisites**: [.NET SDK](https://dotnet.microsoft.com/download), [Seq](https://datalust.co/seq) (optional, if you want to view logs in Seq)
3. **Run Seq**: Start Seq locally at `http://localhost:5341`
4. **Run the application**
    ```sh
    dotnet run
    ```
5. **Test the API**
    - Make a GET request to `/WeatherForecast`
    - Observe logs in the console and in the Seq web UI

---

## Simple Explanation

This project is a basic ASP.NET Core Web API that demonstrates how to configure and use structured logging with Serilog. It logs each API request both to the console and to a local Seq server, helping you learn how to capture and analyze logs in .NET web projects.
