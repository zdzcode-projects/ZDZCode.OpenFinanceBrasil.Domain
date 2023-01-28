using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardAccountsBillsPayment
    {
        /// <summary>
        /// Traz os tipos dos valores relativos aos pagamentos da fatura da conta de pagamento pós-paga: (Vide Enum)
        /// - Valor de pagamento da fatura com parcelamento
        /// - Valor pagamento da fatura realizado
        /// - Outro Valor pago na fatura
        /// </summary>
        [Required]
        public EnumCreditCardAccountsBillingValueType ValueType { get; set; }

        /// <summary>
        /// Data efetiva de quando o Pagamento da fatura foi realizado.
        /// </summary>
        [Required]
        public string PaymentDate { get; set; }

        /// <summary>
        /// Traz as formas de efetivação do pagamento realizado: (Vide Enum)
        /// - Débito em conta corrente
        /// - Boleto bancário
        /// - Averbação em folha
        /// - PIX
        /// </summary>
        [Required]
        public EnumCreditCardAccountsPaymentMode PaymentMode { get; set; }

        /// <summary>
        /// Valor pagamento segundo o valueType. Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor de pagamento da fatura, segundo modelo ISO-4217. p.ex. 'BRL' Todos os valores informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }
    }
}
