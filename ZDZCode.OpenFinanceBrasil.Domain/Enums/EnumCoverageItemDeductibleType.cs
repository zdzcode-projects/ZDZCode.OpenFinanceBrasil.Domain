using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem de tipo de franquia para cada tipo de cobertura do produto
    /// </summary>
    public enum EnumCoverageItemDeductibleType
    {
        /// <summary>
        /// Normal.
        /// </summary>
        [Description("Normal")]
        NORMAL = 1,

        /// <summary>
        /// Reduzida.
        /// </summary>
        [Description("Reduzida")]
        REDUZIDA = 2,

        /// <summary>
        /// Isenta.
        /// </summary>
        [Description("Isenta")]
        ISENTA = 3,

        /// <summary>
        /// Majorada.
        /// </summary>
        [Description("Majorada")]
        MAJORADA = 4,

        /// <summary>
        /// Flexível.
        /// </summary>
        [Description("Flexível")]
        FLEXIVEL = 5,
    }
}
