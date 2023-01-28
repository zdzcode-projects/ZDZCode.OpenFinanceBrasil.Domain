using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreatePixPayment
    {
        /// <summary>
        /// Objeto contendo dados do pagamento e do recebedor (creditor).
        /// </summary>
        [Required]
        public CreatePixPaymentData Data { get; set; }
    }
}
