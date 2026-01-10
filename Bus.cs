using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationApp
{
    internal class Bus
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        
     

        public void Show()
        {
            Console.WriteLine($"{Id}. {Model} - Seats: {Seats}");
        }

    }
}
