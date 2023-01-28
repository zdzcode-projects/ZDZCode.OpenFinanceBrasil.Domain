using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalCreditCardFeesServiceName
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUIDADE_CARTAO_BASICO_NACIONAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUIDADE_CARTAO_BASICO_INTERNACIONAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_BRASIL = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_EXTERIOR = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AVALIACAO_EMERGENCIAL_CREDITO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FORNECIMENTO_SEGUNDA_VIA_FUNCAO_CREDITO = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PAGAMENTO_CONTAS_UTILIZANDO_FUNCAO_CREDITO = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SMS = 8,
    }
}
