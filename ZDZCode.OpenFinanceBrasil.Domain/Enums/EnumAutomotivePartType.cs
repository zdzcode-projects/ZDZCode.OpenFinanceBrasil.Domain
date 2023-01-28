using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Originais e Compatíveis. A considerar os domínios abaixo: 1. Originais 2. Compatíveis 3. Ambas
    /// </summary>
    public enum EnumAutomotivePartType
    {
        /// <summary>
        /// Originais.
        /// </summary>
        [Description("Originais")]
        ORIGINAIS = 1,

        /// <summary>
        /// Compatíveis.
        /// </summary>
        [Description("Compatíveis")]
        COMPATIVEIS = 2,

        /// <summary>
        /// Ambas.
        /// </summary>
        [Description("Ambas")]
        AMBAS = 3,
    }
}
