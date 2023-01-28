using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Forma de pagamento
    /// </summary>
    public enum EnumPremiumPaymentType
    {
        /// <summary>
        /// A vista.
        /// </summary>
        [Description("A vista")]
        A_VISTA = 1,

        /// <summary>
        /// Parcelado
        /// </summary>
        [Description("Parcelado")]
        PARCELADO = 2,

        /// <summary>
        /// Ambos
        /// </summary>
        [Description("Ambos")]
        AMBOS = 3,
    }
}
