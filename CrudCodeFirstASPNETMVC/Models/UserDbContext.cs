using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudCodeFirstASPNETMVC.Models
{
    public class UserDbContext :DbContext
    {
        public DbSet<Movies> MoviesDB { get; set; }
        public DbSet<Contacts> ContactsDB { get; set; }
        public DbSet<MoviePeopleMap> MoviePeopleMapDB { get; set; }
        public DbSet<Professions> ProfessionsDB { get; set; }
    }
}