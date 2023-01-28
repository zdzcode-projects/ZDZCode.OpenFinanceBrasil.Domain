using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz outros tipos de crédito contratados no cartão. [Restrição] Preenchimento obrigatório se o tipo transação selecionado for 'OPERACOES_CREDITO_CONTRATADAS_CARTAO'.
    /// </summary>
    public enum EnumCreditCardAccountsOtherCreditType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_ROTATIVO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PARCELAMENTO_FATURA = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMPRESTIMO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 4,
    }
}
