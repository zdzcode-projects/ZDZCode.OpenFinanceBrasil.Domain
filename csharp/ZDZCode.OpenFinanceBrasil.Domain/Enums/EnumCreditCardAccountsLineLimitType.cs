using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indicador do tipo de limite.
    /// </summary>
    public enum EnumCreditCardAccountsLineLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        LIMITE_CREDITO_TOTAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        LIMITE_CREDITO_MODALIDADE_OPERACAO = 2,
    }
}
