using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz as formas de efetivação do pagamento realizado
    /// </summary>
    public enum EnumCreditCardAccountsPaymentMode
    {
        /// <summary>
        /// Débito em conta corrente.
        /// </summary>
        [Description("Débito em conta corrente")]
        DEBITO_CONTA_CORRENTE = 1,

        /// <summary>
        /// Boleto bancário.
        /// </summary>
        [Description("Boleto bancário")]
        BOLETO_BANCARIO = 2,

        /// <summary>
        /// Averbação em folha.
        /// </summary>
        [Description("Averbação em folha")]
        AVERBACAO_FOLHA = 3,

        /// <summary>
        /// PIX.
        /// </summary>
        [Description("PIX")]
        PIX = 4,
    }
}
