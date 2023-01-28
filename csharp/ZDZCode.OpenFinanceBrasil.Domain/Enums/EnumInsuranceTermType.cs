using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumInsuranceTermType
    {
        /// <summary>
        /// anual
        /// </summary>
        [Description("anual")]
        ANUAL = 1,

        /// <summary>
        /// anual intermitente
        /// </summary>
        [Description("anual intermitente")]
        ANUAL_INTERMITENTE = 2,

        /// <summary>
        /// plurianual
        /// </summary>
        [Description("plurianual")]
        PLURIANUAL = 3,

        /// <summary>
        /// plurianual intermitente
        /// </summary>
        [Description("plurianual intermitente")]
        PLURIANUAL_INTERMITENTE = 4,

        /// <summary>
        /// semestral
        /// </summary>
        [Description("semestral")]
        SEMESTRAL = 5,

        /// <summary>
        /// semestral intermitente
        /// </summary>
        [Description("semestral intermitente")]
        SEMESTRAL_INTERMITENTE = 6,

        /// <summary>
        /// mensal
        /// </summary>
        [Description("mensal")]
        MENSAL = 7,

        /// <summary>
        /// mensal intermitente
        /// </summary>
        [Description("mensal intermitente")]
        MENSAL_INTERMITENTE = 8,

        /// <summary>
        /// diário
        /// </summary>
        [Description("diário")]
        DIARIO = 9,

        /// <summary>
        /// diário intermitente
        /// </summary>
        [Description("diário intermitente")]
        DIARIO_INTERMITENTE = 10,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 11,
    }
}
