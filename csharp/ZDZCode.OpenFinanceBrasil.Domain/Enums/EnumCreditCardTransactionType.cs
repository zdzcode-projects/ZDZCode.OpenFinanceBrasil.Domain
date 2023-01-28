using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz os tipos de Transação.
    /// </summary>
    public enum EnumCreditCardTransactionType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PAGAMENTO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TARIFA = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OPERACOES_CREDITO_CONTRATADAS_CARTAO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ESTORNO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CASHBACK = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 6,
    }
}
