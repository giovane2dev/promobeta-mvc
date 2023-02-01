using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("City")]
    public class City
    {
        public int Id { get; set; }

        [Required]
        public int StateId { get; set; }
        public virtual State State { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CompanyUnits> CompanyUnits { get; set; }
    }
}