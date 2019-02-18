using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tom_Web1.Models
{
    public class GebruikersPerProjectViewModel
    {
        public Gebruiker gebruiker { get; set; }
        public SelectList AllProjects { get; set; }
        public int Id { get; set; }
    }
}
