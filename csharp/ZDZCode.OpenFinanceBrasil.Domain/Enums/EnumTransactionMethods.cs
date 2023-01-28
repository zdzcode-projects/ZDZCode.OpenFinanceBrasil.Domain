using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumTransactionMethods
    {
        /// <summary>
        /// Movimentação eletrônica.
        /// </summary>
        [Description("Movimentação eletrônica")]
        MOVIMENTACAO_ELETRONICA = 1,

        /// <summary>
        /// Movimentação com cheque.
        /// </summary>
        [Description("Movimentação com cheque")]
        MOVIMENTACAO_CHEQUE = 2,

        /// <summary>
        /// Movimentação com cartão.
        /// </summary>
        [Description("Movimentação com cartão")]
        MOVIMENTACAO_CARTAO = 3,

        /// <summary>
        /// Movimentação presencial.
        /// </summary>
        [Description("Movimentação presencial")]
        MOVIMENTACAO_PRESENCIAL = 4,
    }
}
