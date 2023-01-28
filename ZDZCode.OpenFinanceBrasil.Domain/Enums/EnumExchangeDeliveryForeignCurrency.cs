using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A classificação da forma de operação, conforme a circular BCB nº 3690 de 16/12/2013. (Vide Enum)
    /// </summary>
    public enum EnumExchangeDeliveryForeignCurrency
    {
        /// <summary>
        /// Telefone fixo.
        /// </summary>
        [Description("Telefone fixo")]
        ESPECIE = 1,
        
        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        CARTAO_PRE_PAGO = 2,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Telefone móvel")]
        TELETRANSMISSAO_SWIFT = 3,
    }
}
