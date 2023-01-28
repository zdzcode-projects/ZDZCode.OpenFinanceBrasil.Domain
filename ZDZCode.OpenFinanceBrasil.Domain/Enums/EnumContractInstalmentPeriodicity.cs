using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    ///  "Informação relativa à periodicidade regular das parcelas. (Vide Enum) sem periodicidade regular, semanal, quinzenal, mensal, bimestral, trimestral, semestral, anual"
    /// </summary>
    public enum EnumContractInstalmentPeriodicity
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_PERIODICIDADE_REGULAR = 1,

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
        OUTROS = 9,
    }
}
