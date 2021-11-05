using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioServer.Models
{
    public class RadioStations
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string StationUrl { get; set; }
        public string IconUrl { get; set; }
    }
}
