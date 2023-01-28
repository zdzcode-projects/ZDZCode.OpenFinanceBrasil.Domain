using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseCreditCardAccountsList
    {
        /// <summary>
        /// [Lista que traz os valores relativos aos saldos do Limite de crédito total da conta de pagamento pós-paga]
        /// </summary>
        [Required]
        public List<CreditCardAccountsTransaction> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
