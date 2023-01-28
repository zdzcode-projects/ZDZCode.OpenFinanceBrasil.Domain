using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardAccountsBillsData
    {
        /// <summary>
        /// Informação que identifica a fatura.
        /// </summary>
        [Required]
        public string BillId { get; set; }

        /// <summary>
        /// Data de vencimento da Fatura, que aparece para pagamento pelo cliente.
        /// </summary>
        [Required]
        public string DueDate { get; set; }

        /// <summary>
        /// Valor total da fatura.
        /// </summary>
        [Required]
        public double BillTotalAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor de pagamento total da fatura, segundo modelo ISO-4217. p.ex. 'BRL' Todos os valores informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string BillTotalAmountCurrency { get; set; }

        /// <summary>
        /// Valor do pagamento minimo da fatura.
        /// </summary>
        [Required]
        public double BillMinimumAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor de pagamento minimo da fatura, segundo modelo ISO-4217. p.ex. 'BRL' Todos os valores informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string BillMinimumAmountCurrency { get; set; }

        /// <summary>
        /// Indica se a fatura permite parcelamento (true) ou não (false).
        /// </summary>
        [Required]
        public bool IsInstalment { get; set; }

        /// <summary>
        /// Lista dos encargos cobrados na fatura.
        /// </summary>
        [Required]
        public List<CreditCardAccountsBillsFinanceCharge> FinanceCharges { get; set; }

        /// <summary>
        /// Lista que traz os valores relativos aos pagamentos da Fatura da conta de pagamento pós-paga.
        /// </summary>
        [Required]
        public List<CreditCardAccountsBillsPayment> Payments { get; set; }
    }
}
