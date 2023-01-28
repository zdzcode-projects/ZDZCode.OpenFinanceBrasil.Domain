using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Intervalo de tempo regular previsto entre os sorteios.
    /// </summary>
    public enum EnumContributionAmountPeriodicity
    {
        /// <summary>
        /// Único 
        /// </summary>
        [Description("Único ")]
        UNICO = 1,

        /// <summary>
        /// Diário
        /// </summary>
        [Description("Diário")]
        DIARIO = 2,

        /// <summary>
        /// Semanal
        /// </summary>
        [Description("Semanal")]
        SEMANAL = 3,

        /// <summary>
        /// Quinzenal
        /// </summary>
        [Description("Quinzenal")]
        QUINZENAL = 4,

        /// <summary>
        /// Mensal
        /// </summary>
        [Description("Mensal")]
        MENSAL = 5,

        /// <summary>
        /// Bimestral
        /// </summary>
        [Description("Bimestral")]
        BIMESTRAL = 6,

        /// <summary>
        /// Trimestral
        /// </summary>
        [Description("Trimestral")]
        TRIMESTRAL = 7,

        /// <summary>
        /// Quadrimestral.
        /// </summary>
        [Description("Quadrimestral")]
        QUADRIMESTRAL = 8,

        /// <summary>
        /// Semestral
        /// </summary>
        [Description("Semestral")]
        SEMESTRAL = 9,

        /// <summary>
        /// Anual.
        /// </summary>
        [Description("Anual")]
        ANUAL = 10,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS = 11,      
    }
}
