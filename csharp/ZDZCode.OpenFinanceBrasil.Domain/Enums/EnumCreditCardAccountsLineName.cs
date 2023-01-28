using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumCreditCardAccountsLineName
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_A_VISTA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_PARCELADO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CREDITO_BRASIL = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CREDITO_EXTERIOR = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMPRESTIMO_CARTAO_CONSIGNADO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 6,
    }
}
