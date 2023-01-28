using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Titular, pessoa natural ou juridica a quem se referem os dados de recebedor (creditor).
    /// </summary>
    public enum EnumPaymentPersonType
    {
        /// <summary>
        /// pessoa natural
        /// </summary>
        [Description("pessoa natural")]
        PESSOA_NATURAL = 1,
        /// <summary>
        /// pessoa juridica
        /// </summary>
        [Description("pessoa juridica")]
        PESSOA_JURIDICA = 2,
    }
}
