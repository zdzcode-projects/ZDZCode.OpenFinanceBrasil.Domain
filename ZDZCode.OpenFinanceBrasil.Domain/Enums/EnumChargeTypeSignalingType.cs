using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sinalização em campo exclusivo se o pacote de Assistência é gratuita ou contratada/paga. 
    /// </summary>
    public enum EnumChargeTypeSignalingType
    {
        /// <summary>
        /// Gratuita
        /// </summary>
        [Description("Gratuita")]
        GRATUITA = 1,

        /// <summary>
        /// Pago
        /// </summary>
        [Description("Pago")]
        PAGO = 2,

    }
}
