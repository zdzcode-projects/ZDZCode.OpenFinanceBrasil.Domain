using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MaximumPrice
    {
        /// <summary>
        /// Valor máximo apurado para a tarifa de serviços sobre a base de clientes no mês de referência
        /// </summary>
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// Moeda referente ao valor mínimo da Tarifa, segundo modelo ISO-4217. p.ex.'BRL'
        /// </summary>
        [Required]
        public string Currency { get; set; }

    }
}
