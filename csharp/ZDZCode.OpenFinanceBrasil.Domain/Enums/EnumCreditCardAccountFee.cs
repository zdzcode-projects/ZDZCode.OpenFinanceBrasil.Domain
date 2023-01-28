using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumCreditCardAccountFee
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUIDADE = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CARTAO_BRASIL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CARTAO_EXTERIOR = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AVALIACAO_EMERGENCIAL_CREDITO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMISSAO_SEGUNDA_VIA = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TARIFA_PAGAMENTO_CONTAS = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SMS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRA = 8,

    }
}
