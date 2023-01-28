using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumCreditCardInterestRateCode
    {
        /// <summary>
        /// Saque a crédito.
        /// </summary>
        [Description("Saque a crédito")]
        SAQUE_CREDITO = 1,

        /// <summary>
        /// Pagamento de contas.
        /// </summary>
        [Description("Pagamento de contas")]
        PAGAMENTO_CONTA = 2,

        /// <summary>
        /// Outros.
        /// </summary>
        [Description("Outros")]
        OUTROS = 3,
    }
}
