using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class OverdraftLimitsBalance
    {
        /// <summary>
        /// Tipo de saldo informado: (vide Enum) - Valor utilizado do limite do cheque especial - Saldo a descoberto em conta de depósito à vista(relativo ao excesso do limite de cheque especial ou ao adiantamento a depositante)
        /// </summary>
        [Required]
        public EnumOverdraftLimitType Type { get; set; }

        /// <summary>
        /// Valor do saldo. Expressa em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public int Amount { get; set; }
    }
}
