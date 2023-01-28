using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class OverParcel
    {
        /// <summary>
        /// Lista das tarifas que foram pagas fora da parcela, só para pagamento avulso.
        /// </summary>
        [Required]
        public List<LoansFeeOverParcel> fees { get; set; }

        /// <summary>
        /// Lista dos encargos que foram pagos fora da parcela.
        /// </summary>
        [Required]
        public List<LoansChargeOverParcel> charges { get; set; }
    }
}
