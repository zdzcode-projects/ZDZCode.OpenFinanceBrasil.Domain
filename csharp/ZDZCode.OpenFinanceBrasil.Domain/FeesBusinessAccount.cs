using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class FeesBusinessAccount
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços.
        /// </summary>
        [Required]
        public List<BusinessAccountsService> Services { get; set; }
    }
}
