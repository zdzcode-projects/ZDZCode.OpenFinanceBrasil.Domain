using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz a denominação dos Encargos que incidem na fatura da conta de pagamento pós-paga.
    /// </summary>
    public enum EnumCreditCardAccountsFinanceChargeType
    {
        /// <summary>
        /// Juros remuneratórios por atraso no pagamento da fatura.
        /// </summary>
        [Description("")]
        JUROS_REMUNERATORIOS_ATRASO_PAGAMENTO_FATURA = 1,

        /// <summary>
        /// Multa por atraso no pagamento da fatura.
        /// </summary>
        [Description("")]
        MULTA_ATRASO_PAGAMENTO_FATURA = 2,

        /// <summary>
        /// Juros de mora por atraso no pagamento da fatura.
        /// </summary>
        [Description("")]
        JUROS_MORA_ATRASO_PAGAMENTO_FATURA = 3,

        /// <summary>
        /// IOF.
        /// </summary>
        [Description("")]
        IOF = 4,

        /// <summary>
        /// Sem Encargo.
        /// </summary>
        [Description("")]
        SEM_ENCARGO = 5,

        /// <summary>
        /// Outros.
        /// </summary>
        [Description("")]
        OUTROS = 6,
    }
}
