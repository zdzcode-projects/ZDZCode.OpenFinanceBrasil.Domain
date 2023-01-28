using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conforme classificação ANBIMA, que segue a deliberação 77 da ANBIMA.
    /// </summary>
    public enum EnumInvestmentsFundProductAnbimaCategory
    {
        /// <summary>
        /// Renda Fixa.
        /// </summary>
        [Description("Renda Fixa")]
        RENDA_FIXA = 1,

        /// <summary>
        /// Ações.
        /// </summary>
        [Description("Ações")]
        ACOES = 2,

        /// <summary>
        /// Multimercado.
        /// </summary>
        [Description("Multimercado")]
        MULTIMERCADO = 3,

        /// <summary>
        /// Cambial.
        /// </summary>
        [Description("Cambial")]
        CAMBIAL = 4,
    }
}
