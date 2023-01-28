using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de cobrança para a tarifa pactuada no contrato.
    /// </summary>
    public enum EnumContractFeeChargeType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        UNICA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        POR_PARCELA = 2,
    }
}
