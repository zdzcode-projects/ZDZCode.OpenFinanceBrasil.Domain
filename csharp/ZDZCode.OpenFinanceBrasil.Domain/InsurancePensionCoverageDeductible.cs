using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem de franquia em reais para cada combinação de modalidade/cobertura do produto.
    /// </summary>
    public class InsurancePensionCoverageDeductible
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        ///	Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode Currency { get; set; }
    }
}
