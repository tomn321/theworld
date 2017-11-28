using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class Trip
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }

        public ICollection<Stop>  Stops{ get; set; }
    }
}
