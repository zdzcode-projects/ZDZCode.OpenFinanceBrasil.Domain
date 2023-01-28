using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Periodicidade de pagamento do prêmio
    /// </summary>
    public enum EnumPersonalInsurancePremiumPaymentFrequency
    {
        /// <summary>
        /// Diária.
        /// </summary>
        [Description("Diária")]
        DIARIA = 1,

        /// <summary>
        /// Mensal.
        /// </summary>
        [Description("Mensal")]
        MENSAL = 2,

        /// <summary>
        /// Única.
        /// </summary>
        [Description("Única")]
        UNICA = 3,

        /// <summary>
        /// Anual.
        /// </summary>
        [Description("Anual")]
        ANUAL = 4,

        /// <summary>
        /// Trimestral.
        /// </summary>
        [Description("Trimestral")]
        TRIMESTRAL = 5,

        /// <summary>
        /// Semestral.
        /// </summary>
        [Description("Semestral")]
        SEMESTRAL = 6,

        /// <summary>
        /// Fracionado.
        /// </summary>
        [Description("Fracionado")]
        FRACIONADO = 7,

        /// <summary>
        /// Outra.
        /// </summary>
        [Description("Outra")]
        OUTRA = 8,
    }
}
