using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEmpresa.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Deve ser menor que 50 caracteres.")]
        public string Razao_Social { get; set; }
        [StringLength(14, ErrorMessage = "Deve ser menor que 14 caracteres.")]
        public string CNPJ { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy:0}", ApplyFormatInEditMode = true)]
        public DateTime Data_Fundacao { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Capital { get; set; }
        [StringLength(1)]
        public char Quarentena { get; set; }
        [StringLength(1)]
        public char Status_Cliente { get; set; }
        [StringLength(1)]
        public string Classificacao { get; set; }

    }
}
