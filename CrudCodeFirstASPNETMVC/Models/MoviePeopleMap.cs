using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudCodeFirstASPNETMVC.Models
{
    public class MoviePeopleMap
    {
        public Movies Movies { get; set; }
        public Contacts Contacts { get; set; }
    }
}