using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("UnitStatus")]
    public class UnitStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Name { get; set; }
        
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        public virtual ICollection<CompanyUnits> CompanyUnits { get; set; }
    }
}