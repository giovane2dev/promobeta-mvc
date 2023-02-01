using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("CompanyUnits")]
    public class CompanyUnits
    {
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [Required(ErrorMessage = "Informe a data de registro da unidade!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de registro")]
        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "Informe o código da unidade!")]
        [MaxLength(10, ErrorMessage = "Quantidade máxima excede 10 caracteres!")]
        [Display(Name = "Código")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Informe o nome da unidade!")]
        [MaxLength(150, ErrorMessage = "Quantidade máxima excede 150 caracteres!")]
        [Display(Name = "Unidade")]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Quantidade máxima excede 250 caracteres!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [MaxLength(50, ErrorMessage = "Quantidade máxima excede 50 caracteres!")]
        [Display(Name = "Latitude")]
        public string Latitude { get; set; }

        [MaxLength(50, ErrorMessage = "Quantidade máxima excede 50 caracteres!")]
        [Display(Name = "Longitude")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "Informe o endereço da unidade!")]
        [MaxLength(250, ErrorMessage = "Quantidade máxima excede 250 caracteres!")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Informe o número do endereço!")]
        [MaxLength(5, ErrorMessage = "Quantidade máxima excede 5 caracteres!")]
        [Display(Name = "Número")]
        public string AddressNumber { get; set; }

        [MaxLength(250, ErrorMessage = "Quantidade máxima excede 250 caracteres!")]
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "Informe o CEP do endereço!")]
        [MaxLength(8, ErrorMessage = "Quantidade máxima excede 8 caracteres!")]
        [Display(Name = "CEP")]
        public string ZipCode { get; set; }

        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }

        [Required(ErrorMessage = "Informe o número do celular!")]
        [MaxLength(11, ErrorMessage = "Quantidade máxima excede 11 caracteres!")]
        [Display(Name = "Telefone (celular)")]
        public string CellphoneNumber { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima excede 10 caracteres!")]
        [Display(Name = "Telefone (outro)")]
        public string TelephoneNumber { get; set; }

        [Required]
        public int UnitStatusId { get; set; }
        public virtual UnitStatus UnitStatus { get; set; }

        public virtual ICollection<UnitPromotions> UnitPromotions { get; set; }

        public string CustomDate
        {
            get
            {
                string day = RegistrationDate.Day.ToString().PadLeft(2, '0');
                string month = RegistrationDate.Month.ToString().PadLeft(2, '0');
                string year = RegistrationDate.Year.ToString();

                string date = String.Format("{0} {1} {2}", day, month, year);

                return date;
            }
        }

        public string ShortDate
        {
            get
            {
                return RegistrationDate.ToShortDateString();
            }
        }

        public string FullComplement
        {
            get
            {
                return !String.IsNullOrEmpty(Complement) ? Complement : "Sem complemento";
            }
        }

        public string FullAddress
        {
            get
            {

                string address = String.Format("{0}, {1}, {2}, {3}", Address, AddressNumber, FullComplement, City.Name);

                return address;
            }
        }

        public string LongDescription
        {
            get
            {
                return Description ?? "Descrição não definida!";
            }
        }
    }
}