using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de encargo pactuado no contrato.
    /// </summary>
    public enum EnumContractFinanceChargeType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        JUROS_REMUNERATORIOS_POR_ATRASO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MULTA_ATRASO_PAGAMENTO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        JUROS_MORA_ATRASO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IOF_CONTRATACAO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IOF_POR_ATRASO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_ENCARGO = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 7,
    }
}
