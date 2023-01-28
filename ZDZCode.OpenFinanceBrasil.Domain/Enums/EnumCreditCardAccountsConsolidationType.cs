using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indicador que permite informar se o valor do limite é consolidado ou individual.
    /// </summary>
    public enum EnumCreditCardAccountsConsolidationType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONSOLIDADO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INDIVIDUAL = 2,
    }
}
