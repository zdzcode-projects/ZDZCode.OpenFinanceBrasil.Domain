using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Taxa disponibilizada (taxa online) pelas instituições no formato D+0/D+2 (valor U$500 operações câmbio pronto) separado por moeda dólar e euro compra e venda PF/PJ.
    /// </summary>
    public class OnlineRate
    {
        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode ForeignCurrency { get; set; }

        /// <summary>
        /// A classificação da forma de operação, conforme a circular BCB nº 3690 de 16/12/2013. (Vide Enum)
        /// 1.ESPECIE
        /// 2.CARTAO_PRE_PAGO
        /// 3.TELETRANSMISSAO_SWIFT
        /// </summary>
        [Required]
        public EnumExchangeDeliveryForeignCurrency DeliveryForeignCurrency { get; set; }

        /// <summary>
        /// Determina se o Banco está comprando ou vendendo a moeda estrangeira nas operações spot, que se liquidam em até dois dias(não aplica-se a operações futuras. (Vide Enum)
        /// - Compra
        /// - Venda
        /// </summary>
        [Required]
        public EnumExchangeTransactionType TransactionType { get; set; }

        /// <summary>
        /// A classificação do tipo de operação, conforme a circular BCB nº 3690 de 16/12/2013
        /// </summary>
        [Required]
        public EnumExchangeTransactionCategory TransactionCategory { get; set; }

        /// <summary>
        /// Público alvo (ou PF ou PJ).
        /// </summary>
        public EnumDistinctTargetAudience TargetAudience { get; set; }

        /// <summary>
        /// Valor da operação.
        /// </summary>
        [Required]
        public string Value { get; set; }
    }
}
