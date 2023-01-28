using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveInsuranceMarketValuePercentage
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Max { get; set; }
    }
}
