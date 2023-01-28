using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Este campo define o tipo de pagamento que será iniciado após a autorização do consentimento.
    /// </summary>
    public enum EnumPaymentType
    {
        /// <summary>
        /// PIX
        /// </summary>
        [Description("PIX")]
        PIX = 1,   
    }
}
