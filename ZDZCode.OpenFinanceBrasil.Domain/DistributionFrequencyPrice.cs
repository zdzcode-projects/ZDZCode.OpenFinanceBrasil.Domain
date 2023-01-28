using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class DistributionFrequencyPrice
    {
        /// <summary>
        /// Faixas de frequência
        /// </summary>
        [Required]
        public EnumInterval Interval { get; set; }

        /// <summary>
        /// Mediana.
        /// </summary>
        [Required]
        public string Value { get; set; }

        /// <summary>
        /// Percentual de clientes.
        /// </summary>
        [Required]
        public string CustomerRate { get; set; }
    }
}
