using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes às informações de câmbio
    /// </summary>
    public class ExchangeVetValue
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Determina se o Banco está comprando ou vendendo a moeda estrangeira nas operações spot, que se liquidam em até dois dias(não aplica-se a operações futuras. (Vide Enum)
        /// - Compra
        /// - Venda
        /// </summary>
        [Required]
        public EnumExchangeTransactionType TransactionType { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode ForeignCurrency { get; set; }

        /// <summary>
        /// A classificação da forma de operação, conforme a circular BCB nº 3690 de 16/12/2013. (Vide Enum)
        /// ESPECIE
        /// CARTAO_PRE_PAGO
        /// TELETRANSMISSAO_SWIFT
        /// </summary>
        [Required]
        public EnumExchangeDeliveryForeignCurrency DeliveryForeignCurrency { get; set; }

        /// <summary>
        /// A classificação conforme a circular BCB nº 4015.
        /// </summary>
        [Required]
        public EnumExchangeRangeTransactionCategory RangeTransactionCategory { get; set; }

        /// <summary>
        /// A considerar os domínios abaixo:
        /// 1. Pessoa Natural
        /// 2. Pessoa Jurídica
        /// 3. Ambas(Pessoa Natural e Jurídica)
        /// </summary>
        public EnumTargetAudience TargetAudience { get; set; }

        /// <summary>
        /// Distribuição por frequência.
        /// </summary>
        [Required]
        public VetValueFrequencyDistribution VetAmount { get; set; }
    }
}
