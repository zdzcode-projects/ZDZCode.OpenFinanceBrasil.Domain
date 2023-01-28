using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Novas ou usada. A considerar os domínios abaixo
    /// </summary>
    public enum EnumAutomotivePartsCondition
    {
        /// <summary>
        /// Novas.
        /// </summary>
        [Description("Novas")]
        NOVAS = 1,

        /// <summary>
        /// Usadas.
        /// </summary>
        [Description("Usadas")]
        USADAS = 2,


        /// <summary>
        /// Ambas.
        /// </summary>
        [Description("Ambas")]
        AMBAS = 3,
    }
}
