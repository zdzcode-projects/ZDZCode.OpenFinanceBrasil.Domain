using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem de abrangência geográfica do produto para fins de cada cobertura
    /// </summary>
    public enum EnumCoverageItemGeographicScopeType
    {
        /// <summary>
        /// Nacional.
        /// </summary>
        [Description("Nacional")]
        NACIONAL = 1,

        /// <summary>
        /// Regional.
        /// </summary>
        [Description("Regional")]
        REGIONAL = 2,

        /// <summary>
        /// Internacional.
        /// </summary>
        [Description("Internacional")]
        INTERNACIONAL = 3,

        /// <summary>
        /// Apenas outros países.
        /// </summary>
        [Description("Apenas outros países")]
        OUTROS_PAISES = 4,
    }
}
