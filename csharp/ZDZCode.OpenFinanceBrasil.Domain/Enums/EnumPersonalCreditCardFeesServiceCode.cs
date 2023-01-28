using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalCreditCardFeesServiceCode
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUIDADE_NACIONAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUIDADE_INTERNACIONAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CARTAO_BRASIL = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SAQUE_CARTAO_EXTERIOR = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AVALIACAO_EMERGENCIAL_CREDITO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMISSAO_SEGUNDA_VIA = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TARIFA_PAGAMENTO_CONTAS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SMS = 8,
    }
}
