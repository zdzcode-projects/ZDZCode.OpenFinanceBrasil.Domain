using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Detalhamento da franquia em reais diferentes para cada cobertura que exista alguma especificidade. Caso a seguradora não tenha essa diferenciação, não retornará nada no campo.
    /// </summary>
    public class InsurancePensionCoverageDifferentiatedDeductible
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode Currency { get; set; }
    }
}
