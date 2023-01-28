using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Informar o critério de carência para a cobertura
    /// </summary>
    public enum EnumGracePeriodUnit
    {
        /// <summary>
        /// Dias.
        /// </summary>
        [Description("Dias")]
        DIAS = 1,

        /// <summary>
        /// Meses.
        /// </summary>
        [Description("Meses")]
        MESES = 2,

        /// <summary>
        /// Não se aplica.
        /// </summary>
        [Description("Não se aplica")]
        NAO_APLICA = 3,
    }
}
