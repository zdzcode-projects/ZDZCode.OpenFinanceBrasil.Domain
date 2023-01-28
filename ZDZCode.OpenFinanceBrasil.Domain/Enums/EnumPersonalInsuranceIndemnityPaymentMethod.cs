using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Modalidade de pagamento da indenização, a considerar os domínios abaixo
    /// </summary>
    public enum EnumPersonalInsuranceIndemnityPaymentMethod
    {
        /// <summary>
        /// Único.
        /// </summary>
        [Description("Único")]
        UNICO = 1,

        /// <summary>
        /// Sob a forma de renda.
        /// </summary>
        [Description("Sob a forma de renda")]
        SOB_FORMA_RENDA = 2,
    }
}
