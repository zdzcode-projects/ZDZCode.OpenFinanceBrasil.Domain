using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFixedIncomeBankInvestmentConditions
    {
        /// <summary>
        /// Valor mínimo de aplicação no ativo.
        /// </summary>
        [Required]
        public string MinimumAmount { get; set; }

        /// <summary>
        /// Capacidade de conversão do título em dinheiro (resgate ou recompra).
        /// 1.diária
        /// 2.na data de vencimento
        /// 3.diária após prazo de carência
        /// </summary>
        [Required]
        public EnumInvestmentsFixedIncomeBankRedemptionTerm RedemptionTerm { get; set; }

        /// <summary>
        /// Prazo mínimo referente ao vencimento do título
        /// </summary>
        [Required]
        public int MinimumExpirationTerm { get; set; }

        /// <summary>
        /// Prazo máximo referente ao vencimento do título
        /// </summary>
        [Required]
        public int MaximumExpirationTerm { get; set; }

        /// <summary>
        /// Prazo mínimo da carência, ou seja, quando passa a ser possível resgatar o investimento
        /// </summary>
        [Required]
        public int MinimumGracePeriod { get; set; }

        /// <summary>
        /// Prazo máximo da carência, ou seja, quando passa a ser possível resgatar o investimento
        /// </summary>
        [Required]
        public int MaximumGracePeriod { get; set; }
    }
}
