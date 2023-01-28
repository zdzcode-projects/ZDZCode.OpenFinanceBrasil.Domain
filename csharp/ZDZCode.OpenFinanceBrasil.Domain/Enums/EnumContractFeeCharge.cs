using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Forma de cobrança relativa a tarifa pactuada no contrato.
    /// </summary>
    public enum EnumContractFeeCharge
    {
        /// <summary>
        /// Mínimo.
        /// </summary>
        [Description("Mínimo")]
        MINIMO = 1,

        /// <summary>
        /// Máximo.
        /// </summary>
        [Description("Máximo")]
        MAXIMO = 2,

        /// <summary>
        /// Fixo.
        /// </summary>
        [Description("Fixo")]
        FIXO = 3,

        /// <summary>
        /// Percentual.
        /// </summary>
        [Description("Percentual")]
        PERCENTUAL = 4,
    }
}
