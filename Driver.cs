using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationApp
{
    class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
    


        public void Show()
        {
            Console.WriteLine($"{Id}. {Name} - Experience: {Experience} years.");
        }
    }
}
