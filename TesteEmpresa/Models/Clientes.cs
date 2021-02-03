

using Bogus.DataSets;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace TesteEmpresa.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string Razao_Social { get; set; }
        [StringLength(14, ErrorMessage = "Deve ser menor que 14 caracteres.")]
        public string CNPJ { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_Fundacao { get; set; }

        [Column(TypeName = "decimal(18, 2)"), DataType(DataType.Currency) ]
        
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Capital { get; set; }

        public string Quarentena { get; set; }
        
        public string Status_Cliente { get; set; }
        
        public string Classificacao { get; set; }

    }

}
