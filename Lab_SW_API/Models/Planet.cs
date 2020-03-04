using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_SW_API.Models
{

    public class PlanetRootobject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public Planet[] results { get; set; }
    }

    public class Planet
    {
        public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        public string[] residents { get; set; }
        public string[] films { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }

}
