using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz os tipos dos valores relativos aos pagamentos da fatura da conta de pagamento pós-paga.
    /// </summary>
    public enum EnumCreditCardAccountsBillingValueType
    {
        /// <summary>
        /// Valor de pagamento da fatura com parcelamento.
        /// </summary>
        [Description("Valor de pagamento da fatura com parcelamento")]
        VALOR_PAGAMENTO_FATURA_PARCELADO = 1,

        /// <summary>
        /// Valor pagamento da fatura realizado.
        /// </summary>
        [Description("Valor pagamento da fatura realizado")]
        VALOR_PAGAMENTO_FATURA_REALIZADO = 2,

        /// <summary>
        /// Outro Valor pago na fatura.
        /// </summary>
        [Description("Outro Valor pago na fatura")]
        OUTRO_VALOR_PAGO_FATURA = 3,
    }
}
