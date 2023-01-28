using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansBank
    {
        /// <summary>
        /// Conjunto de informações referentes à identificação da operação de crédito de empréstimo.
        /// </summary>
        [Required]
        public LoansWarranties warranties { get; set; }
    }
}
