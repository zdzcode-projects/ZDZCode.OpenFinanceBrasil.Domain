using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indicar a categoria do Produto
    /// </summary>
    public enum EnumInsurancePensionCategory
    {
        /// <summary>
        /// Tradicional
        /// </summary>
        [Description("Tradicional")]
        TRADICIONAL = 1,

        /// <summary>
        /// Microsseguro
        /// </summary>
        [Description("Microsseguro")]
        MICROSSEGURO = 2,
    }
}
