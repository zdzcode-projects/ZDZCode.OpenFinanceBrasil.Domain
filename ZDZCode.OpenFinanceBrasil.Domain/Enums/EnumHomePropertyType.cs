using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Proposta conforme os domínios abaixo
    /// </summary>
    public enum EnumHomePropertyType
    {
        /// <summary>
        /// Casa.
        /// </summary>
        [Description("Casa")]
        CASA = 1,

        /// <summary>
        /// Apartamento.
        /// </summary>
        [Description("Apartamento")]
        APARTAMENTO = 2,
    }
}
