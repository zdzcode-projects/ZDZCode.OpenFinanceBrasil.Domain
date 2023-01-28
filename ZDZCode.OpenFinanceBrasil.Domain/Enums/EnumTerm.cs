using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumTerm
    {
        /// <summary>
        /// Vitalícia.
        /// </summary>
        [Description("Vitalícia")]
        VITALICIA = 1,

        /// <summary>
        /// Temporária - prazo fixo.
        /// </summary>
        [Description("Temporária - prazo fixo")]
        TEMPORARIA_PRAZO_FIXO = 2,

        /// <summary>
        /// Temporária – intermitente.
        /// </summary>
        [Description("Temporária – intermitente")]
        TEMPORARIA_INTERMITENTE = 2,
    }
}
