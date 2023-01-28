using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// A considerar os seguintes domínios abaixo
    /// </summary>
    public enum EnumHomePropertyUsageType
    {
        /// <summary>
        /// Habitual.
        /// </summary>
        [Description("Habitual")]
        HABITUAL = 1,

        /// <summary>
        /// Veraneio.
        /// </summary>
        [Description("Veraneio")]
        VERANEIO = 2,

        /// <summary>
        /// Desocupado.
        /// </summary>
        [Description("Desocupado")]
        DESOCUPADO = 3,

        /// <summary>
        /// Casa/Escritório.
        /// </summary>
        [Description("Casa/Escritório")]
        CASA_ESCRITORIO = 4,

        /// <summary>
        /// Aluguel por temporada.
        /// </summary>
        [Description("Aluguel por temporada")]
        ALUGUEL_TEMPORADA = 5,
    }
}
