using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MinimumRate
    {
        /// <summary>
        /// Percentual mínimo cobrado (taxa efetiva) no mês de referência, para o Empréstimo contratado
        /// </summary>
        [Required]
        public string minimumRate { get; set; }
    }
}
