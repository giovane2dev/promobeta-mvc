using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Promobeta.Models
{
    [Table("UnitPromotions")]
    public class UnitPromotions
    {
        public int Id { get; set;  }

        [Required]
        [Display(Name = "Unidade")]
        public int CompanyUnitsId { get; set; }
        public virtual CompanyUnits CompanyUnits { get; set; }

        [Required(ErrorMessage = "Informe a data de início da promoção!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de início")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Informe a data de término da promoção!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de término")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Informe o nome da promoção!")]
        [MaxLength(150, ErrorMessage = "Quantidade máxima excede 150 caracteres!")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Quantidade máxima excede 250 caracteres!")]
        [Display(Name = "Descrição (opcional)")]
        public string Description { get; set; }

        [Display(Name = "Situação (Ativa)")]

        public bool Active { get; set; }

        public string ShortStartDate
        {
            get
            {
                return StartDate.ToShortDateString();
            }
        }

        public string ShortEndDate
        {
            get
            {
                return EndDate.ToShortDateString();
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