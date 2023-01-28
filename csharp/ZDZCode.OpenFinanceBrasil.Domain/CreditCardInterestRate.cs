using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardInterestRate
    {
        /// <summary>
        /// Lista de outras operações de crédito.
        /// </summary>
        [Required]
        public EnumCreditCardInterestRateCode Code { get; set; }

        /// <summary>
        /// Campo Texto para descrever outras operações de crédito marcadas como 'OUTROS'.
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
}
