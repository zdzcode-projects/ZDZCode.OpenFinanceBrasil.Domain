using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Período em dias corridos ou dias úteis do prazo de cotização.
    /// </summary>
    public enum EnumInvestmentsFundGeneralConditionsTermType
    {
        /// <summary>
        /// Dias corridos.
        /// </summary>
        [Description("Dias corridos")]
        DIAS_CORRIDOS = 1,
        
        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description("Dias úteis")]
        DIAS_UTEIS = 2,
    }
}
