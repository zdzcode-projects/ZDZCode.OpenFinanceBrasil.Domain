using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tempos de uptime por endpoint.
    /// </summary>
    public class AccountFee
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços Prioritários
        /// </summary>
        [Required]
        public List<AccountPriorityService> PriorityServices { get; set; }

        /// <summary>
        /// Lista das Tarifas cobradas sobre outros Serviços, que não prioritários
        /// </summary>
        [Required]
        public List<AccountOtherService> OtherServices { get; set; }
    }
}
