using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("State")]
    public class State
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sigla")]
        public string Initials { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}