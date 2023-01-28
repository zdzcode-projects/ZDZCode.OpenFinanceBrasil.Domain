using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentLocation
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public BankingAgentsPostalAddress PostalAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<BankingAgentsPhone> Phones { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public BankingAgentsAvailability Availability { get; set; }
    }
}
