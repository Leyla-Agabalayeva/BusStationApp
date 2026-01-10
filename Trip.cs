using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationApp
{
    internal class Trip
    {
        public Bus Bus { get; set; }
        public Driver Driver { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public DateTime Date{ get; set; }
        public double Price { get; set; }
        public Trip(Bus bus, Driver driver, string fromCity, string toCity, DateTime date, double price)
        {
            Bus = bus;
            Driver = driver;
            FromCity = fromCity;
            ToCity = toCity;
            Date = date;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"{FromCity} → {ToCity} | {Date} | {Price} AZN | " +
                $"Bus: {Bus.Model}, Driver: {Driver.Name}");
            Bus.Show();
            Driver.Show();
        }

    }
}
