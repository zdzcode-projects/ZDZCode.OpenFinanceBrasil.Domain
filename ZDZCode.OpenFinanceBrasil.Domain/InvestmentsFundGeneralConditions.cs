using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundGeneralConditions
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestimentFundMinimumAmount MinimumAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestmentsFundGeneralConditionsRedemption Redemption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public InvestmentsFundGeneralConditionsApplication Application { get; set; }

        /// <summary>
        /// Referente a incidência de tributos sobre o produto de investimento:
        /// 1. Cota de abertura
        /// 2. Cota de fechamento
        /// </summary>
        [Required]
        public EnumInvestmentsFundGeneralConditionsFundQuotaType FundQuotaType { get; set; }
    }
}
