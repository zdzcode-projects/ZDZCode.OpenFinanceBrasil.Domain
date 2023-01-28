using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A considerar os seguintes domínios abaixo
    /// </summary>
    public enum EnumHomePropertyBuildType
    {
        /// <summary>
        /// Alvenaria.
        /// </summary>
        [Description("Alvenaria")]
        ALVENARIA = 1,

        /// <summary>
        /// Madeira.
        /// </summary>
        [Description("Madeira")]
        MADEIRA = 2,

        /// <summary>
        /// Mista (Alvenaria e Madeira)
        /// </summary>
        [Description("Mista (Alvenaria e Madeira)")]
        MISTA = 3,
    }
}
