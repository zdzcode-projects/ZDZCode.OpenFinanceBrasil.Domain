using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MaximumRate //confirmar com o Zids.
    {
        /// <summary>
        /// Percentual máximo cobrado (taxa efetiva) no mês de referência, para o Empréstimo contratado
        /// </summary>
        [Required]
        public string MaximumRates { get; set; } 

    }
}
