using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de renda ou pensão, caso modalidade de pagamento de indenização seja sob a forma de renda
    /// </summary>
    public enum EnumPersonalInsuranceIndemnityPaymentIncome
    {
        /// <summary>
        /// Certa.
        /// </summary>
        [Description("Certa")]
        CERTA = 1,

        /// <summary>
        /// Temporária.
        /// </summary>
        [Description("Temporária")]
        TEMPORARIA = 2,

        /// <summary>
        /// Temporária reversível.
        /// </summary>
        [Description("Temporária reversível")]
        TEMPORARIA_REVERSIVEL = 3,

        /// <summary>
        /// Temporário com mínimo garantido.
        /// </summary>
        [Description("Temporário com mínimo garantido")]
        TEMPORARIO_MINIMO_GARANTIDO = 4,

        /// <summary>
        /// Temporária reversível com mínimo garantido.
        /// </summary>
        [Description("Temporária reversível com mínimo garantido")]
        TEMPORARIA_REVERSIVEL_MINIMO_GARANTIDO = 5,

        /// <summary>
        /// Vitalícia.
        /// </summary>
        [Description("Vitalícia")]
        VITALICIA = 6,

        /// <summary>
        /// Vitalícia reversível.
        /// </summary>
        [Description("Vitalícia reversível")]
        VITALICIA_REVERSIVEL = 7,

        /// <summary>
        /// Vitalícia com o mínimo garantido.
        /// </summary>
        [Description("Vitalícia com o mínimo garantido")]
        VITALICIA_MINIMO_GARANTIDO = 8,

        /// <summary>
        /// Vitalícia reversível como mínimo garantido.
        /// </summary>
        [Description("Vitalícia reversível como mínimo garantido")]
        VITALICIA_REVERSIVEL_MINIMO_GARANTIDO = 9,
    }
}
