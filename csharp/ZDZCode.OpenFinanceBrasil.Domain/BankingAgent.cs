using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgent // Vazio no site.
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public Identification Identification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<BankingAgentLocation> Locations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<BankingAgentsService> Services { get; set; }
    }
}
