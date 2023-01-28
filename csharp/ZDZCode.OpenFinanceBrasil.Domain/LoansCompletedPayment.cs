using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansCompletedPayment
    {
        /// <summary>
        /// Traz as datas de vencimento do pagamento do contrato da modalidade de crédito consultada, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string PaymentDate { get; set; }

        /// <summary>
        /// Traz o valor do pagamento do contrato da modalidade de crédito consultada. Expresso em valor monetário com 2 casas decimais.
        /// </summary>
        [Required]
        public string DueAmount { get; set; }
    }
}
