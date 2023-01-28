using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indica o tipo de tributação
    /// </summary>
    public enum EnumInvestmentsFundTaxation
    {
        /// <summary>
        /// Curto prazo.
        /// </summary>
        [Description("Curto prazo")]
        CURTO_PRAZO = 1,
        
        /// <summary>
        /// Longo prazo.
        /// </summary>
        [Description("Longo prazo")]
        LONGO_PRAZO = 2,

        /// <summary>
        /// Variável.
        /// </summary>
        [Description("Variável")]
        VARIAVEL = 3,
    }
}
