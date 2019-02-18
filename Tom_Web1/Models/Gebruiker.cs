using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tom_Web1.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public int ProjectId { get; set; }
    }
}
