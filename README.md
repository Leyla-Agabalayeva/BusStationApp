# BusStationApp

A simple **.NET 8 console application** for managing a bus station: registering buses and drivers, creating trips between cities, searching trips by destination, and viewing basic statistics. All data is kept in memory for the duration of the run — there is no database or file persistence.

## Tech Stack

- **.NET 8 / C# console app**
- **Docker** — a `Dockerfile` is included for containerized builds/runs

## Data Model

- **Bus** — `Id`, `Model`, `Seats`
- **Driver** — `Id`, `Name`, `Experience` (years)
- **Trip** — links a `Bus` and a `Driver` with `FromCity`, `ToCity`, `Date`, and `Price`

## Features (Console Menu)

1. **Add Bus** — register a new bus (model, seat count)
2. **Add Driver** — register a new driver (name, years of experience)
3. **Create Trip** — pick an existing bus and driver, then enter origin city, destination city, date/time, and price
4. **Show All Trips** — list every created trip with full bus and driver details
5. **Search trip by city (to city)** — filter trips by destination city (case-insensitive)
6. **Statistics** — total buses, total drivers, total trips, and (if any trips exist) max, min, and average trip price
7. **Exit**

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/Leyla-Agabalayeva/BusStationApp.git
   cd BusStationApp
   ```

2. **Run the app:**

   ```bash
   dotnet run
   ```

3. **(Optional) Run with Docker:**

   ```bash
   docker build -t busstationapp .
   docker run -it busstationapp
   ```

4. Use the on-screen numeric menu: add at least one bus and one driver before creating a trip.

## Project Structure

```
BusStationApp/
├── Program.cs   # Console menu, app entry point, and all operations
├── Bus.cs        # Bus model
├── Driver.cs     # Driver model
├── Trip.cs       # Trip model (links Bus + Driver + route info)
├── Dockerfile
└── BusStationApp.sln
```

## Notes

- Data is not persisted — all buses, drivers, and trips are lost when the app exits.
- Trip creation requires at least one bus and one driver to already be registered.

## Author

[Leyla Agabalayeva](https://github.com/Leyla-Agabalayeva)
