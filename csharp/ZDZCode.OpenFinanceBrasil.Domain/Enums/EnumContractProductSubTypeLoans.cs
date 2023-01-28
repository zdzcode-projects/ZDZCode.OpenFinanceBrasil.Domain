using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sub tipo da modalidades de crédito Empréstimos contratadas, conforme circular 4.015 e descrição do DOC3040 do SCR).
    /// </summary>
    public enum EnumContractProductSubTypeLoans
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        HOME_EQUITY = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CHEQUE_ESPECIAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONTA_GARANTIDA = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CAPITAL_GIRO_TETO_ROTATIVO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_PESSOAL_SEM_CONSIGNACAO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_PESSOAL_COM_CONSIGNACAO = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MICROCREDITO_PRODUTIVO_ORIENTADO = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CAPITAL_GIRO_PRAZO_VENCIMENTO_ATE_365_DIAS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CAPITAL_GIRO_PRAZO_VENCIMENTO_SUPERIOR_365_DIAS = 9,
    }
}
