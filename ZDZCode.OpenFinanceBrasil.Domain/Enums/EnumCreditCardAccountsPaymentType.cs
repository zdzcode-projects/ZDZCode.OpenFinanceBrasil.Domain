using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz os tipos de pagamento. Preenchimento obrigatório se selecionado tipo de transação PAGAMENTO.
    /// </summary>
    public enum EnumCreditCardAccountsPaymentType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        A_VISTA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        A_PRAZO = 2,
    }
}
