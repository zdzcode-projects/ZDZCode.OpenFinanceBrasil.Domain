using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações das Contas de: depósito à vista, poupança e de pagamento pré-paga
    /// </summary>
    public class AccountBalancesData
    {
        /// <summary>
        /// Saldo disponível para utilização imediata. No caso de conta de depósito a vista, sem considerar cheque especial e investimentos atrelados a conta. Admite saldo negativo. Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double AvailableAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor do saldo disponível, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string AvailableAmountCurrency { get; set; }

        /// <summary>
        /// Saldo bloqueado, não disponível para utilização imediata, por motivo de bloqueio apresentado para o cliente nos canais eletrônicos Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double BlockedAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor do saldo bloqueado, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string BlockedAmountCurrency { get; set; }

        /// <summary>
        /// Saldo disponível com aplicação automática - corresponde a soma do saldo disponível acrescido do valor obtido a partir da aplicação automática Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double AutomaticallyInvestedAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor do saldo disponível com aplicação automática, segundo modelo ISO-4217. p.ex. 'BRL'. Pode ser preenchido com “NA” caso a instituição não possua a informação.
        /// </summary>
        [Required]
        public string AutomaticallyInvestedAmountCurrency { get; set; }
    }
}
