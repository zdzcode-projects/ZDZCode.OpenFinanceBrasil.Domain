using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Índice utilizado na atualização da PMBaC
    /// </summary>
    public enum EnumPersonalUpdateIndex
    {
        /// <summary>
        /// IPCA (IBGE).
        /// </summary>
        [Description("IPCA (IBGE)")]
        IPCA = 1,

        /// <summary>
        /// IGP-M (FGV).
        /// </summary>
        [Description("IGP-M (FGV)")]
        IGP_M = 2,

        /// <summary>
        /// INPC (IBGE).
        /// </summary>
        [Description("INPC (IBGE)")]
        INPC = 3,
    }
}
