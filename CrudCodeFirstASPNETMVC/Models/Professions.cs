using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudCodeFirstASPNETMVC.Models
{
    public class Professions
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}