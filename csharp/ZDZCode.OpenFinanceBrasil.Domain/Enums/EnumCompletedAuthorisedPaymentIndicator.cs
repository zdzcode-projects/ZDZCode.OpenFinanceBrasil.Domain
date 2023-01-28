using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indicador da transação: - Transação efetivada - Lançamento futuro
    /// </summary>
    public enum EnumCompletedAuthorisedPaymentIndicator
    {
        /// <summary>
        /// Transação efetivada.
        /// </summary>
        [Description("Transação efetivada")]
        TRANSACAO_EFETIVADA = 1,

        /// <summary>
        /// Lançamento futuro.
        /// </summary>
        [Description("Lançamento futuro")]
        LANCAMENTO_FUTURO = 2,
    }
}
