using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A considerar os domínios abaixo: Pessoa Natural, Pessoa Jurídica e Ambas(Pessoa Natural e Jurídica)
    /// </summary>
    public enum EnumTargetAudience
    {
        /// <summary>
        /// Pessoa Natural.
        /// </summary>
        [Description("Pessoa Natural")]
        PESSOA_NATURAL = 1,

        /// <summary>
        /// Pessoa Jurídica.
        /// </summary>
        [Description("Pessoa Jurídica")]
        PESSOA_JURIDICA = 2,

        /// <summary>
        /// Ambas (Pessoa Natural e Jurídica).
        /// </summary>
        [Description("Ambas")]
        PESSOA_NATURAL_JURIDICA = 3,
    }
}
