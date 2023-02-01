using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("Company")]

    public class Company
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data de adesão")]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [Display(Name = "Nome Fantasia")]
        public string TradingName { get; set; }

        [Required]
        [Display(Name = "Razão Social")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "CNPJ")]
        public string RegistrationNumber { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefone (celular)")]
        public string CellphoneNumber { get; set; }

        [Display(Name = "Telefone (outro)")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Número")]
        public string AddressNumber { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required]
        [Display(Name = "CEP")]
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        
        [Display(Name = "Situação")]
        public bool Active { get; set; }

        public virtual ICollection<CompanyUnits> CompanyUnits { get; set; }
    }
}