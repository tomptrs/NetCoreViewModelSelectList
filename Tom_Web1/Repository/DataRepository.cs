using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tom_Web1.Models;

namespace Tom_Web1.Repository
{
    public class DataRepository
    {
        private List<Gebruiker> gebruikers;
        private List<Project> projects;

        public DataRepository()
        {
            MakeGebruikers();
            MakeProjects();
        }

        public GebruikersPerProjectViewModel GetGebruikersPerProject(int gebruikersId)
        {
            Gebruiker gebruiker = gebruikers.Where(g=> g.Id == gebruikersId).Single();
            List<Project> p = GetProjects();
            GebruikersPerProjectViewModel vm = new GebruikersPerProjectViewModel();
            /*
             * listMoviesVM.Ratings = 
        new SelectList(_context.Ratings.OrderBy(r => r.Name),
                        "RatingID", "Name");

             */
            vm.Id = gebruikersId;
            vm.AllProjects = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(p, "Id", "Name");
            vm.gebruiker = gebruiker;
            return vm;

        }

        public List<Gebruiker> Gebruikers()
        {
            return gebruikers;
        }
        public List<Project> GetProjects()
        {
            return projects;
        }

        private void MakeProjects()
        {
            projects = new List<Project>();
            projects.Add(new Project() { Id = 1, Name = "Project 1", });
            projects.Add(new Project() { Id = 2, Name = "Project 2" });
        }
        private void MakeGebruikers()
        {
            gebruikers = new List<Gebruiker>();
            gebruikers.Add(new Gebruiker() { Id = 1, FirstName = "Tom", LastName = "Peeters", ProjectId=1 });
            gebruikers.Add(new Gebruiker() { Id = 2, FirstName = "Hannes", LastName = "Peeters",ProjectId=1 });
            gebruikers.Add(new Gebruiker() { Id = 3, FirstName = "Arno", LastName = "Peeters", ProjectId = 2 });
            gebruikers.Add(new Gebruiker() { Id = 4, FirstName = "Mieke", LastName = "Vandeperre", ProjectId =2 });

        }
    }
}
