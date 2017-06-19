using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudCodeFirstASPNETMVC.Models
{
    public class Movies
    {
        #region Property
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        #endregion

        #region Method
        public void Save()
        {

        }
        #endregion
    }
}