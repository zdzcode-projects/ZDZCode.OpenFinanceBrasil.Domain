using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Distribuição por frequência.
    /// </summary>
    public class VetValueFrequencyDistribution
    {
        /// <summary>
        /// Nome do serviço
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Código de identificação do serviço.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Distribuição dos preços.
        /// </summary>
        [Required]
        public List<DistributionFrequencyPrice> Prices { get; set; }

        /// <summary>
        /// Valor mínimo.
        /// </summary>
        [Required]
        public string Minimum { get; set; }

        /// <summary>
        /// Valor máximo.
        /// </summary>
        [Required]
        public string Maximum { get; set; }
    }
}
