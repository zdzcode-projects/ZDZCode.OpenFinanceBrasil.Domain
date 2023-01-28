using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ContractBase
    {
        /// <summary>
        ///
        /// </summary>
        public AutomotiveInsuranceDeterminedValue DeterminedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        public AutomotiveInsuranceMarketValuePercentage MarketValuePercentage { get; set; }
    }
}
