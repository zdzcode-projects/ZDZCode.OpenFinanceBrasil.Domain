using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Base de cálculo
    /// </summary>
    public enum EnumContractCalculation //Confirmar com o Zids, nome dos enums
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VINTE_E_UM_POR252 = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRINTA_POR_360 = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRINTA_POR_365 = 3,
    }
}
