using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Metodologia do campo para taxa de performance.
    /// </summary>
    public enum EnumInvestmentsFundFeesPerformanceFeeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        PASSIVO = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        ATIVO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        AJUSTE = 3,
    }
}
