using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountOverdraftLimitsData
    {
        /// <summary>
        /// Valor do limite contratado do cheque especial.
        /// </summary>
        [Required]
        public double OverdraftContractedLimit { get; set; }

        /// <summary>
        /// Moeda referente ao valor do limite contratado do cheque especial, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string OverdraftContractedLimitCurrency { get; set; }

        /// <summary>
        /// Valor utilizado total do limite do cheque especial e o adiantamento a depositante.
        /// </summary>
        [Required]
        public double OverdraftUsedLimit { get; set; }

        /// <summary>
        /// Moeda referente ao valor utilizado total do limite do cheque especial e o adiantamento a depositante, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string OverdraftUsedLimitCurrency { get; set; }

        /// <summary>
        /// Valor de operação contratada em caráter emergencial para cobertura de saldo devedor em conta de depósitos à vista e de excesso sobre o limite pactuado de cheque especial.
        /// </summary>
        [Required]
        public double UnarrangedOverdraftAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor de operação contratada em caráter emergencial para cobertura de saldo devedor em conta de depósitos à vista e de excesso sobre o limite pactuado de cheque especial, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string UnarrangedOverdraftAmountCurrency { get; set; }
    }
}
