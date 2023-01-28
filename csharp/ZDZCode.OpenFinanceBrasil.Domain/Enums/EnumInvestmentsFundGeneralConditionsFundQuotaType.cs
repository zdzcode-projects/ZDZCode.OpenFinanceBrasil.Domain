  using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Referente a incidência de tributos sobre o produto de investimento
    /// </summary>
    public enum EnumInvestmentsFundGeneralConditionsFundQuotaType
    {
        /// <summary>
        /// Cota de abertura.
        /// </summary>
        [Description("Cota de abertura")]
        COTA_ABERTURA = 1,

        /// <summary>
        /// Cota de fechamento.
        /// </summary>
        [Description("Cota de fechamento")]
        COTA_FECHAMENTO = 2,
    }
}
