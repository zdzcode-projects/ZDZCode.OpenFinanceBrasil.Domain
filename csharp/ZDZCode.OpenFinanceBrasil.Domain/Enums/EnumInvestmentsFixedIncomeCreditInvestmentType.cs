using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Especifica o tipo de ativo negociado
    /// </summary>
    public enum EnumInvestmentsFixedIncomeCreditInvestmentType
    {
        /// <summary>
        /// Debêntures.
        /// </summary>
        [Description("Debêntures")]
        DEBENTURES = 1,

        /// <summary>
        /// CRI.
        /// </summary>
        [Description("CRI")]
        CRI = 2,

        /// <summary>
        /// CRA.
        /// </summary>
        [Description("CRA")]
        CRA = 3,
    }
}
