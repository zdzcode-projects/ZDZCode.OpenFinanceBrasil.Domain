using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Traz a frequência ou período da renda informada.
    /// </summary>
    public enum EnumInformedIncomeFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIARIA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEMANAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        QUINZENAL = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MENSAL = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BIMESTRAL = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRIMESTRAL = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEMESTRAL = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ANUAL = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_FREQUENCIA_RENDA_INFORMADA = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 10,
    }
}
