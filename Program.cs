using System;

namespace BusStationApp
{
    internal class Program
    {
        static List<Bus> buses = new List<Bus>();
        static List<Driver> drivers = new List<Driver>();
        static List<Trip> trips = new List<Trip>();
        static int BusId = 1;
        static int DriverId = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Bus");
                Console.WriteLine("2. Add Driver");
                Console.WriteLine("3.Create Trip");
                Console.WriteLine("4.Show All Trips");
                Console.WriteLine("5.Search trip by city(to city)");
                Console.WriteLine("6.Statistics");
                Console.WriteLine("7.Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Add Bus
                        AddBus();
                        break;
                    case "2":
                        // Add Driver
                        AddDriver();
                        break;
                    case "3":
                        // Create Trip
                        CreateTrip();
                        break;
                    case "4":
                        // Show All Trips
                        ShowTrip();
                        break;
                    case "5":
                        // Search trip by city
                        SearchTrip();
                        break;
                    case "6":
                        // Statistics
                        ShowStatistics();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                static void AddBus()
                {
                    Console.Write("Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Seats: ");
                    int seats = int.Parse(Console.ReadLine());

                    buses.Add(new Bus { Id = BusId++, Model = model, Seats = seats });
                    Console.WriteLine("Bus added.");

                }
                static void AddDriver()
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Experience: ");
                    int exp = int.Parse(Console.ReadLine());
                    drivers.Add(new Driver { Id = DriverId++, Name = name, Experience = exp });
                    Console.WriteLine("Driver added.");
                }
                static void CreateTrip()
                {
                    if (buses.Count == 0 || drivers.Count == 0)
                    {
                        Console.WriteLine("Add buses and drivers first!");
                        return;
                    }
                    Console.WriteLine("\nChoose bus:");
                    foreach (var b in buses) b.Show();
                    int busIdInput = int.Parse(Console.ReadLine());
                    Bus bus = buses.First(b => b.Id == busIdInput);
                    Console.WriteLine("\nChoose driver:");
                    foreach (var d in drivers) d.Show();
                    int driverIdInput = int.Parse(Console.ReadLine());
                    Driver driver = drivers.First(d => d.Id == driverIdInput);
                    Console.Write("From City: ");
                    string fromCity = Console.ReadLine();
                    Console.Write("To City: ");
                    string toCity = Console.ReadLine();
                    Console.Write("Date (yyyy-MM-dd HH:mm): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    trips.Add(new Trip(bus, driver, fromCity, toCity, date, price));
                    Console.WriteLine("Trip created.");
                }
                static void ShowTrip()
                {
                    foreach (var t in trips)
                    {
                        t.Show();
                        Console.WriteLine();
                    }
                }
                static void SearchTrip()
                {
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine().ToLower();

                    var result = trips.Where(t => t.ToCity.ToLower() == city).ToList();

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No trips found.");
                        return;
                    }

                    foreach (var t in result)
                        t.Show();
                }
                static void ShowStatistics()
                {
                    Console.WriteLine($"Total Buses: {buses.Count}");
                    Console.WriteLine($"Total Drivers: {drivers.Count}");
                    Console.WriteLine($"Total Trips: {trips.Count}");
                    if (trips.Count == 0) return;

                    Console.WriteLine($"Max price: {trips.Max(t => t.Price)}");
                    Console.WriteLine($"Min price: {trips.Min(t => t.Price)}");
                    Console.WriteLine($"Average price: {trips.Average(t => t.Price):0.00}");


                }
            }
        }
    }
}
